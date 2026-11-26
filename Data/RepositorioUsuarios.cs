
using Microsoft.Data.SqlClient;
using MundoAnimal.Models;
using MundoAnimal.Services;
using MundoAnimal.ConexionSQL;
using System;
using System.Collections.Generic;

namespace MundoAnimal.Data
{
    public static class RepositorioUsuarios
    {
        public const string UsuarioInicial = "admin";
        public const string ClaveInicial = "admin1234";

        public static void CrearUsuarioInicial()
        {
            if (BuscarPorNombre(UsuarioInicial) != null)
                return;

            Usuario u = new Usuario
            {
                Nombre = "Administrador",
                Apellido = "Inicial",
                NombreUsuario = UsuarioInicial,
                Rol = "Administrador",
                Activo = true
            };

            Agregar(u, ClaveInicial);
        }

        public static List<Usuario> Todos()
        {
            List<Usuario> lista = new List<Usuario>();

            using (SqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                conexion.Open();

                string sql = @"
                    SELECT Id, Nombre, Apellido, NombreUsuario,
                           ClaveHash, Sal, Rol, Estado
                    FROM dbo.Usuarios
                    ORDER BY Id;";

                using (SqlCommand comando = new SqlCommand(sql, conexion))
                using (SqlDataReader lector = comando.ExecuteReader())
                {
                    while (lector.Read())
                        lista.Add(LeerUsuario(lector));
                }
            }

            return lista;
        }

        public static List<Usuario> Listar(string filtro)
        {
            List<Usuario> resultado = new List<Usuario>();

            foreach (Usuario u in Todos())
            {
                if (Buscador.Coincide(u.Nombre, filtro) ||
                    Buscador.Coincide(u.Apellido, filtro) ||
                    Buscador.Coincide(u.NombreUsuario, filtro) ||
                    Buscador.Coincide(u.Rol, filtro))
                {
                    resultado.Add(u);
                }
            }

            return resultado;
        }

        public static List<Usuario> Veterinarios()
        {
            List<Usuario> resultado = new List<Usuario>();

            foreach (Usuario u in Todos())
            {
                if (u.Rol == "Veterinario" && u.Activo)
                    resultado.Add(u);
            }

            return resultado;
        }

        public static Usuario Buscar(int id)
        {
            using (SqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                conexion.Open();

                string sql = @"
                    SELECT Id, Nombre, Apellido, NombreUsuario,
                           ClaveHash, Sal, Rol, Estado
                    FROM dbo.Usuarios
                    WHERE Id = @Id;";

                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue("@Id", id);

                    using (SqlDataReader lector = comando.ExecuteReader())
                    {
                        if (lector.Read())
                            return LeerUsuario(lector);
                    }
                }
            }

            return null;
        }

        public static Usuario BuscarPorNombre(string nombreUsuario)
        {
            if (string.IsNullOrWhiteSpace(nombreUsuario))
                return null;

            using (SqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                conexion.Open();

                string sql = @"
                    SELECT Id, Nombre, Apellido, NombreUsuario,
                           ClaveHash, Sal, Rol, Estado
                    FROM dbo.Usuarios
                    WHERE NombreUsuario = @NombreUsuario;";

                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue(
                        "@NombreUsuario", nombreUsuario.Trim());

                    using (SqlDataReader lector = comando.ExecuteReader())
                    {
                        if (lector.Read())
                            return LeerUsuario(lector);
                    }
                }
            }

            return null;
        }

        public static bool ClaveCorrecta(Usuario u, string clave)
        {
            if (u == null || clave == null)
                return false;

            string hash = Seguridad.CrearHash(clave, u.Sal);
            return string.Equals(
                hash, u.ClaveHash, StringComparison.Ordinal);
        }

        public static bool NombreUsuarioRepetido(
            string nombreUsuario, int idActual)
        {
            foreach (Usuario u in Todos())
            {
                if (u.Id != idActual &&
                    string.Equals(
                        u.NombreUsuario,
                        nombreUsuario,
                        StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }

            return false;
        }

        public static int ContarAdministradoresActivos(int idExcluido)
        {
            int total = 0;

            foreach (Usuario u in Todos())
            {
                if (u.Id != idExcluido &&
                    u.Rol == "Administrador" &&
                    u.Activo)
                {
                    total++;
                }
            }

            return total;
        }

        public static void Agregar(Usuario u, string clave)
        {
            if (u == null)
                throw new ArgumentNullException(nameof(u));

            if (string.IsNullOrWhiteSpace(clave))
                throw new ArgumentException(
                    "La contraseña no puede estar vacía.", nameof(clave));

            u.Sal = Seguridad.CrearSal();
            u.ClaveHash = Seguridad.CrearHash(clave, u.Sal);

            using (SqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                conexion.Open();

                string sql = @"
                    INSERT INTO dbo.Usuarios
                        (Nombre, Apellido, NombreUsuario,
                         ClaveHash, Sal, Rol, Estado)
                    VALUES
                        (@Nombre, @Apellido, @NombreUsuario,
                         @ClaveHash, @Sal, @Rol, @Estado);

                    SELECT CAST(SCOPE_IDENTITY() AS int);";

                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    AgregarParametrosUsuario(comando, u);

                    u.Id = Convert.ToInt32(comando.ExecuteScalar());
                }
            }
        }

        public static bool Actualizar(Usuario nuevo, string claveNueva)
        {
            if (nuevo == null)
                return false;

            Usuario actual = Buscar(nuevo.Id);

            if (actual == null)
                return false;

            bool cambiarClave = !string.IsNullOrEmpty(claveNueva);

            string sal = cambiarClave
                ? Seguridad.CrearSal()
                : actual.Sal;

            string hash = cambiarClave
                ? Seguridad.CrearHash(claveNueva, sal)
                : actual.ClaveHash;

            using (SqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                conexion.Open();

                string sql = @"
                    UPDATE dbo.Usuarios
                    SET Nombre = @Nombre,
                        Apellido = @Apellido,
                        NombreUsuario = @NombreUsuario,
                        Rol = @Rol,
                        Estado = @Estado,
                        ClaveHash = @ClaveHash,
                        Sal = @Sal
                    WHERE Id = @Id;";

                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    AgregarParametrosUsuario(comando, nuevo);

                    comando.Parameters.AddWithValue("@Id", nuevo.Id);
                    comando.Parameters["@ClaveHash"].Value = hash;
                    comando.Parameters["@Sal"].Value = sal;

                    return comando.ExecuteNonQuery() > 0;
                }
            }
        }

        public static string Eliminar(int id)
        {
            if (RepositorioConsultas.VeterinarioTieneConsultas(id))
            {
                return "No se puede eliminar: el usuario tiene consultas registradas. Póngalo en estado Inactivo en su lugar.";
            }

            using (SqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                conexion.Open();

                string sql = "DELETE FROM dbo.Usuarios WHERE Id = @Id;";

                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue("@Id", id);
                    comando.ExecuteNonQuery();
                }
            }

            return "";
        }

        private static Usuario LeerUsuario(SqlDataReader lector)
        {
            string estado = lector["Estado"].ToString();

            return new Usuario
            {
                Id = Convert.ToInt32(lector["Id"]),
                Nombre = lector["Nombre"].ToString(),
                Apellido = lector["Apellido"].ToString(),
                NombreUsuario = lector["NombreUsuario"].ToString(),
                ClaveHash = lector["ClaveHash"].ToString(),
                Sal = lector["Sal"].ToString(),
                Rol = lector["Rol"].ToString(),
                Activo = string.Equals(
                    estado, "Activo", StringComparison.OrdinalIgnoreCase)
                    || string.Equals(
                    estado, "1", StringComparison.OrdinalIgnoreCase)
                    || string.Equals(
                    estado, "True", StringComparison.OrdinalIgnoreCase)
            };
        }

        private static void AgregarParametrosUsuario(
            SqlCommand comando, Usuario u)
        {
            comando.Parameters.AddWithValue("@Nombre", u.Nombre);
            comando.Parameters.AddWithValue("@Apellido", u.Apellido);
            comando.Parameters.AddWithValue(
                "@NombreUsuario", u.NombreUsuario);
            comando.Parameters.AddWithValue("@ClaveHash", u.ClaveHash);
            comando.Parameters.AddWithValue("@Sal", u.Sal);
            comando.Parameters.AddWithValue("@Rol", u.Rol);
            comando.Parameters.AddWithValue(
                "@Estado", u.Activo ? "Activo" : "Inactivo");
        }
    }
}
