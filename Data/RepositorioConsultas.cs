
using Microsoft.Data.SqlClient;
using MundoAnimal.ConexionSQL;
using MundoAnimal.Models;
using System;
using System.Collections.Generic;

namespace MundoAnimal.Data
{
    public static class RepositorioConsultas
    {
        public static List<Consulta> Todas()
        {
            List<Consulta> lista = new List<Consulta>();

            using (SqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                conexion.Open();

                string sql = @"
                    SELECT Id, MascotaId, Fecha, Motivo,
                           Diagnostico, VeterinarioId, Tratamiento
                    FROM dbo.Consultas
                    ORDER BY Fecha DESC, Id DESC;";

                using (SqlCommand comando = new SqlCommand(sql, conexion))
                using (SqlDataReader lector = comando.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        lista.Add(LeerConsulta(lector));
                    }
                }
            }

            return lista;
        }

        public static string NombreMascota(int mascotaId)
        {
            return RepositorioMascotas.NombreDueno(-1) == null
                ? ""
                : ObtenerNombreMascota(mascotaId);
        }

        private static string ObtenerNombreMascota(int mascotaId)
        {
            Mascota mascota = RepositorioMascotas.Buscar(mascotaId);
            return mascota == null ? "" : mascota.Nombre;
        }

        public static string NombreVeterinario(int usuarioId)
        {
            Usuario usuario = RepositorioUsuarios.Buscar(usuarioId);

            if (usuario == null)
                return "";

            return usuario.Nombre + " " + usuario.Apellido;
        }

        public static List<Consulta> Listar(string filtro)
        {
            List<Consulta> resultado = new List<Consulta>();

            foreach (Consulta consulta in Todas())
            {
                if (Buscador.Coincide(NombreMascota(consulta.MascotaId), filtro) ||
                    Buscador.Coincide(consulta.Motivo, filtro) ||
                    Buscador.Coincide(NombreVeterinario(consulta.VeterinarioId), filtro))
                {
                    resultado.Add(consulta);
                }
            }

            return resultado;
        }

        public static Consulta Buscar(int id)
        {
            using (SqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                conexion.Open();

                string sql = @"
                    SELECT Id, MascotaId, Fecha, Motivo,
                           Diagnostico, VeterinarioId, Tratamiento
                    FROM dbo.Consultas
                    WHERE Id = @Id;";

                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue("@Id", id);

                    using (SqlDataReader lector = comando.ExecuteReader())
                    {
                        if (lector.Read())
                            return LeerConsulta(lector);
                    }
                }
            }

            return null;
        }

        public static bool MascotaTieneConsultas(int mascotaId)
        {
            using (SqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                conexion.Open();

                string sql = @"
                    SELECT COUNT(1)
                    FROM dbo.Consultas
                    WHERE MascotaId = @MascotaId;";

                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue("@MascotaId", mascotaId);
                    return Convert.ToInt32(comando.ExecuteScalar()) > 0;
                }
            }
        }

        public static bool VeterinarioTieneConsultas(int usuarioId)
        {
            using (SqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                conexion.Open();

                string sql = @"
                    SELECT COUNT(1)
                    FROM dbo.Consultas
                    WHERE VeterinarioId = @VeterinarioId;";

                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue("@VeterinarioId", usuarioId);
                    return Convert.ToInt32(comando.ExecuteScalar()) > 0;
                }
            }
        }

        public static void Agregar(Consulta consulta)
        {
            using (SqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                conexion.Open();

                string sql = @"
                    INSERT INTO dbo.Consultas
                        (MascotaId, Fecha, Motivo, Diagnostico,
                         VeterinarioId, Tratamiento)
                    VALUES
                        (@MascotaId, @Fecha, @Motivo, @Diagnostico,
                         @VeterinarioId, @Tratamiento);

                    SELECT CAST(SCOPE_IDENTITY() AS int);";

                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    AgregarParametros(comando, consulta);
                    consulta.Id = Convert.ToInt32(comando.ExecuteScalar());
                }
            }
        }

        public static bool Actualizar(Consulta nueva)
        {
            using (SqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                conexion.Open();

                string sql = @"
                    UPDATE dbo.Consultas
                    SET MascotaId = @MascotaId,
                        Fecha = @Fecha,
                        Motivo = @Motivo,
                        Diagnostico = @Diagnostico,
                        VeterinarioId = @VeterinarioId,
                        Tratamiento = @Tratamiento
                    WHERE Id = @Id;";

                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    AgregarParametros(comando, nueva);
                    comando.Parameters.AddWithValue("@Id", nueva.Id);

                    return comando.ExecuteNonQuery() > 0;
                }
            }
        }

        public static void Eliminar(int id)
        {
            using (SqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                conexion.Open();

                string sql = "DELETE FROM dbo.Consultas WHERE Id = @Id;";

                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue("@Id", id);
                    comando.ExecuteNonQuery();
                }
            }
        }

        private static Consulta LeerConsulta(SqlDataReader lector)
        {
            return new Consulta
            {
                Id = lector.GetInt32(lector.GetOrdinal("Id")),
                MascotaId = lector.GetInt32(lector.GetOrdinal("MascotaId")),
                Fecha = lector.GetDateTime(lector.GetOrdinal("Fecha")),
                Motivo = lector.GetString(lector.GetOrdinal("Motivo")),
                Diagnostico = lector.IsDBNull(lector.GetOrdinal("Diagnostico"))
                    ? ""
                    : lector.GetString(lector.GetOrdinal("Diagnostico")),
                VeterinarioId = lector.GetInt32(lector.GetOrdinal("VeterinarioId")),
                Tratamiento = lector.IsDBNull(lector.GetOrdinal("Tratamiento"))
                    ? ""
                    : lector.GetString(lector.GetOrdinal("Tratamiento"))
            };
        }

        private static void AgregarParametros(
            SqlCommand comando, Consulta consulta)
        {
            comando.Parameters.AddWithValue("@MascotaId", consulta.MascotaId);
            comando.Parameters.AddWithValue("@Fecha", consulta.Fecha.Date);
            comando.Parameters.AddWithValue("@Motivo", consulta.Motivo);

            comando.Parameters.AddWithValue(
                "@Diagnostico",
                string.IsNullOrWhiteSpace(consulta.Diagnostico)
                    ? (object)DBNull.Value
                    : consulta.Diagnostico);

            comando.Parameters.AddWithValue(
                "@VeterinarioId", consulta.VeterinarioId);

            comando.Parameters.AddWithValue(
                "@Tratamiento",
                string.IsNullOrWhiteSpace(consulta.Tratamiento)
                    ? (object)DBNull.Value
                    : consulta.Tratamiento);
        }
    }
}
