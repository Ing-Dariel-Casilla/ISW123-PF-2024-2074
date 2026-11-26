
using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using MundoAnimal.Models;
using MundoAnimal.ConexionSQL;

namespace MundoAnimal.Data
{
    public static class RepositorioMascotas
    {


        public static List<Mascota> Todas()
        {
            List<Mascota> mascotas = new List<Mascota>();

            string sql = @"
    SELECT Id, Nombre, Especie, Raza, Edad, Sexo, DuenoId
    FROM dbo.Mascotas
    ORDER BY Id DESC";

            using SqlConnection conexion = ConexionBD.ObtenerConexion();
            using SqlCommand comando = new SqlCommand(sql, conexion);

            conexion.Open();

            using SqlDataReader lector = comando.ExecuteReader();

            while (lector.Read())
            {
                mascotas.Add(LeerMascota(lector));
            }

            return mascotas;
        }



        public static string NombreDueno(int duenoId)
        {
            Dueno d = RepositorioDuenos.Buscar(duenoId);

            if (d == null)
                return "";

            return d.Nombre + " " + d.Apellido;
        }

        
public static List<Mascota> Listar(string filtro)
{
    List<Mascota> mascotas = new List<Mascota>();

            string sql = @"
    SELECT M.Id, M.Nombre, M.Especie, M.Raza,
           M.Edad, M.Sexo, M.DuenoId
    FROM dbo.Mascotas M
    INNER JOIN dbo.Duenos D ON D.Id = M.DuenoId
    WHERE M.Nombre LIKE @Filtro
       OR M.Especie LIKE @Filtro
       OR ISNULL(M.Raza, '') LIKE @Filtro
       OR D.Nombre LIKE @Filtro
       OR D.Apellido LIKE @Filtro
    ORDER BY M.Id DESC";

            using SqlConnection conexion = ConexionBD.ObtenerConexion();
    using SqlCommand comando = new SqlCommand(sql, conexion);

    comando.Parameters.AddWithValue(
        "@Filtro", "%" + (filtro ?? "") + "%");

    conexion.Open();

    using SqlDataReader lector = comando.ExecuteReader();

    while (lector.Read())
    {
        mascotas.Add(LeerMascota(lector));
    }

    return mascotas;
}


        public static Mascota Buscar(int id)
        {
            string sql = @"
                SELECT Id, Nombre, Especie, Raza, Edad, Sexo, DuenoId
                FROM dbo.Mascotas
                WHERE Id = @Id";

            using SqlConnection conexion = ConexionBD.ObtenerConexion();
            using SqlCommand comando = new SqlCommand(sql, conexion);

            comando.Parameters.AddWithValue("@Id", id);

            conexion.Open();

            using SqlDataReader lector = comando.ExecuteReader();

            if (lector.Read())
                return LeerMascota(lector);

            return null;
        }

        public static bool DuenoTieneMascotas(int duenoId)
        {
            string sql = @"
                SELECT COUNT(*)
                FROM dbo.Mascotas
                WHERE DuenoId = @DuenoId";

            using SqlConnection conexion = ConexionBD.ObtenerConexion();
            using SqlCommand comando = new SqlCommand(sql, conexion);

            comando.Parameters.AddWithValue("@DuenoId", duenoId);

            conexion.Open();

            return Convert.ToInt32(comando.ExecuteScalar()) > 0;
        }

        public static bool NombreRepetido(
            string nombre, int duenoId, int idActual)
        {
            string sql = @"
                SELECT COUNT(*)
                FROM dbo.Mascotas
                WHERE LOWER(Nombre) = LOWER(@Nombre)
                  AND DuenoId = @DuenoId
                  AND Id <> @Id";

            using SqlConnection conexion = ConexionBD.ObtenerConexion();
            using SqlCommand comando = new SqlCommand(sql, conexion);

            comando.Parameters.AddWithValue("@Nombre", nombre);
            comando.Parameters.AddWithValue("@DuenoId", duenoId);
            comando.Parameters.AddWithValue("@Id", idActual);

            conexion.Open();

            return Convert.ToInt32(comando.ExecuteScalar()) > 0;
        }

        public static void Agregar(Mascota m)
        {
            string sql = @"
                INSERT INTO dbo.Mascotas
                    (Nombre, Especie, Raza, Edad, Sexo, DuenoId)
                VALUES
                    (@Nombre, @Especie, @Raza, @Edad, @Sexo, @DuenoId);

                SELECT CAST(SCOPE_IDENTITY() AS int);";

            using SqlConnection conexion = ConexionBD.ObtenerConexion();
            using SqlCommand comando = new SqlCommand(sql, conexion);

            AgregarParametros(comando, m);

            conexion.Open();

            m.Id = Convert.ToInt32(comando.ExecuteScalar());
            m.FechaRegistro = DateTime.Today;
        }

        public static bool Actualizar(Mascota nueva)
        {
            string sql = @"
                UPDATE dbo.Mascotas
                SET Nombre = @Nombre,
                    Especie = @Especie,
                    Raza = @Raza,
                    Edad = @Edad,
                    Sexo = @Sexo,
                    DuenoId = @DuenoId
                WHERE Id = @Id";

            using SqlConnection conexion = ConexionBD.ObtenerConexion();
            using SqlCommand comando = new SqlCommand(sql, conexion);

            AgregarParametros(comando, nueva);
            comando.Parameters.AddWithValue("@Id", nueva.Id);

            conexion.Open();

            return comando.ExecuteNonQuery() > 0;
        }

        public static string Eliminar(int id)
        {
            // Conservar las comprobaciones del historial clínico.
            if (RepositorioConsultas.MascotaTieneConsultas(id) ||
                RepositorioVacunas.MascotaTieneVacunas(id))
            {
                return "No se puede eliminar: la mascota tiene consultas o vacunas registradas (historial clínico).";
            }

            string sql = "DELETE FROM dbo.Mascotas WHERE Id = @Id";

            using SqlConnection conexion = ConexionBD.ObtenerConexion();
            using SqlCommand comando = new SqlCommand(sql, conexion);

            comando.Parameters.AddWithValue("@Id", id);

            conexion.Open();
            comando.ExecuteNonQuery();

            return "";
        }

        private static Mascota LeerMascota(SqlDataReader lector)
        {
            return new Mascota
            {
                Id = Convert.ToInt32(lector["Id"]),
                Nombre = Convert.ToString(lector["Nombre"]),
                Especie = Convert.ToString(lector["Especie"]),
                Raza = Convert.ToString(lector["Raza"]),
                Edad = Convert.ToInt32(lector["Edad"]),
                Sexo = Convert.ToString(lector["Sexo"]),
                DuenoId = Convert.ToInt32(lector["DuenoId"])
            };
        }

        private static void AgregarParametros(
            SqlCommand comando, Mascota m)
        {
            comando.Parameters.AddWithValue("@Nombre", m.Nombre);
            comando.Parameters.AddWithValue("@Especie", m.Especie);
            comando.Parameters.AddWithValue("@Raza", m.Raza);
            comando.Parameters.AddWithValue("@Edad", m.Edad);
            comando.Parameters.AddWithValue("@Sexo", m.Sexo);
            comando.Parameters.AddWithValue("@DuenoId", m.DuenoId);
        }
    }
}
