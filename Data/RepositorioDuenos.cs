
using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using MundoAnimal.Models;
using MundoAnimal.ConexionSQL;

namespace MundoAnimal.Data
{
    public static class RepositorioDuenos
    {
        public static List<Dueno> Todos()
        {
            List<Dueno> duenos = new List<Dueno>();

            using SqlConnection conexion = ConexionBD.ObtenerConexion();
            string sql = @"SELECT Id, Nombre, Apellido, Telefono, Correo, Direccion
                           FROM dbo.Duenos ORDER BY Id DESC";

            using SqlCommand comando = new SqlCommand(sql, conexion);
            conexion.Open();

            using SqlDataReader lector = comando.ExecuteReader();

            while (lector.Read())
            {
                duenos.Add(LeerDueno(lector));
            }

            return duenos;
        }

        public static List<Dueno> Listar(string filtro)
        {
            List<Dueno> duenos = new List<Dueno>();

            using SqlConnection conexion = ConexionBD.ObtenerConexion();

            string sql = @"
                SELECT Id, Nombre, Apellido, Telefono, Correo, Direccion
                FROM dbo.Duenos
                WHERE Nombre LIKE @Filtro
                   OR Apellido LIKE @Filtro
                   OR Telefono LIKE @Filtro
                ORDER BY Id DESC";

            using SqlCommand comando = new SqlCommand(sql, conexion);
            comando.Parameters.AddWithValue(
                "@Filtro", "%" + (filtro ?? "") + "%");

            conexion.Open();

            using SqlDataReader lector = comando.ExecuteReader();

            while (lector.Read())
            {
                duenos.Add(LeerDueno(lector));
            }

            return duenos;
        }

        public static Dueno Buscar(int id)
        {
            using SqlConnection conexion = ConexionBD.ObtenerConexion();

            string sql = @"
                SELECT Id, Nombre, Apellido, Telefono, Correo, Direccion
                FROM dbo.Duenos
                WHERE Id = @Id";

            using SqlCommand comando = new SqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@Id", id);

            conexion.Open();

            using SqlDataReader lector = comando.ExecuteReader();

            if (lector.Read())
            {
                return LeerDueno(lector);
            }

            return null;
        }

        public static bool TelefonoRepetido(string telefono, int idActual)
        {
            using SqlConnection conexion = ConexionBD.ObtenerConexion();

            string sql = @"
                SELECT COUNT(*)
                FROM dbo.Duenos
                WHERE Telefono = @Telefono
                  AND Id <> @Id";

            using SqlCommand comando = new SqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@Telefono", telefono);
            comando.Parameters.AddWithValue("@Id", idActual);

            conexion.Open();

            return (int)comando.ExecuteScalar() > 0;
        }

        public static void Agregar(Dueno d)
        {
            using SqlConnection conexion = ConexionBD.ObtenerConexion();

            string sql = @"
                INSERT INTO dbo.Duenos
                    (Nombre, Apellido, Telefono, Correo, Direccion)
                VALUES
                    (@Nombre, @Apellido, @Telefono, @Correo, @Direccion);

                SELECT CAST(SCOPE_IDENTITY() AS int);";

            using SqlCommand comando = new SqlCommand(sql, conexion);
            AgregarParametros(comando, d);

            conexion.Open();

            d.Id = (int)comando.ExecuteScalar();
            d.FechaRegistro = DateTime.Today;
        }

        public static bool Actualizar(Dueno nuevo)
        {
            using SqlConnection conexion = ConexionBD.ObtenerConexion();

            string sql = @"
                UPDATE dbo.Duenos
                SET Nombre = @Nombre,
                    Apellido = @Apellido,
                    Telefono = @Telefono,
                    Correo = @Correo,
                    Direccion = @Direccion
                WHERE Id = @Id";

            using SqlCommand comando = new SqlCommand(sql, conexion);
            AgregarParametros(comando, nuevo);
            comando.Parameters.AddWithValue("@Id", nuevo.Id);

            conexion.Open();

            return comando.ExecuteNonQuery() > 0;
        }

        public static string Eliminar(int id)
        {
            using SqlConnection conexion = ConexionBD.ObtenerConexion();
            conexion.Open();

            // Evitar eliminar un dueño que tenga mascotas.
            string comprobar = @"
                SELECT COUNT(*)
                FROM dbo.Mascotas
                WHERE DuenoId = @Id";

            using (SqlCommand comando = new SqlCommand(comprobar, conexion))
            {
                comando.Parameters.AddWithValue("@Id", id);

                if ((int)comando.ExecuteScalar() > 0)
                {
                    return "No se puede eliminar: el dueño tiene mascotas registradas. Elimine o reasigne primero sus mascotas.";
                }
            }

            string sql = "DELETE FROM dbo.Duenos WHERE Id = @Id";

            using SqlCommand eliminar = new SqlCommand(sql, conexion);
            eliminar.Parameters.AddWithValue("@Id", id);

            eliminar.ExecuteNonQuery();

            return "";
        }

        private static Dueno LeerDueno(SqlDataReader lector)
        {
            return new Dueno
            {
                Id = Convert.ToInt32(lector["Id"]),
                Nombre = lector["Nombre"].ToString(),
                Apellido = lector["Apellido"].ToString(),
                Telefono = lector["Telefono"].ToString(),
                Correo = lector["Correo"] == DBNull.Value
                    ? ""
                    : lector["Correo"].ToString(),
                Direccion = lector["Direccion"] == DBNull.Value
                    ? ""
                    : lector["Direccion"].ToString()
            };
        }

        private static void AgregarParametros(SqlCommand comando, Dueno d)
        {
            comando.Parameters.AddWithValue("@Nombre", d.Nombre);
            comando.Parameters.AddWithValue("@Apellido", d.Apellido);
            comando.Parameters.AddWithValue("@Telefono", d.Telefono);
            comando.Parameters.AddWithValue(
                "@Correo", (object)d.Correo ?? DBNull.Value);
            comando.Parameters.AddWithValue(
                "@Direccion", (object)d.Direccion ?? DBNull.Value);
        }
    }
}
