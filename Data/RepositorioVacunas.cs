
using Microsoft.Data.SqlClient;
using MundoAnimal.ConexionSQL;
using MundoAnimal.Models;
using System;
using System.Collections.Generic;

namespace MundoAnimal.Data
{
    public static class RepositorioVacunas
    {
        public static List<Vacuna> Catalogo()
        {
            List<Vacuna> lista = new List<Vacuna>();

            using (SqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                conexion.Open();

                string sql = @"
                    SELECT Id, Nombre
                    FROM dbo.CatalogoVacunas
                    ORDER BY Nombre;";

                using (SqlCommand comando = new SqlCommand(sql, conexion))
                using (SqlDataReader lector = comando.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        lista.Add(new Vacuna
                        {
                            Id = lector.GetInt32(lector.GetOrdinal("Id")),
                            Nombre = lector.GetString(lector.GetOrdinal("Nombre"))
                        });
                    }
                }
            }

            return lista;
        }
    public static void AgregarAlCatalogo(string nombre, string descripcion)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("Escribe el nombre de la vacuna.");

            using (SqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                conexion.Open();

                string sql = @"
            INSERT INTO dbo.CatalogoVacunas (Nombre, Descripcion)
            VALUES (@Nombre, @Descripcion);";

                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue("@Nombre", nombre.Trim());
                    comando.Parameters.AddWithValue(
                        "@Descripcion",
                        string.IsNullOrWhiteSpace(descripcion)
                            ? (object)DBNull.Value
                            : descripcion.Trim());

                    comando.ExecuteNonQuery();
                }
            }
        }
        public static string NombreVacuna(int vacunaId)
        {
            using (SqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                conexion.Open();

                string sql = @"
                    SELECT Nombre
                    FROM dbo.CatalogoVacunas
                    WHERE Id = @Id;";

                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue("@Id", vacunaId);
                    object resultado = comando.ExecuteScalar();

                    return resultado == null || resultado == DBNull.Value
                        ? ""
                        : Convert.ToString(resultado);
                }
            }
        }

        public static List<RegistroVacuna> Todos()
        {
            List<RegistroVacuna> lista = new List<RegistroVacuna>();

            using (SqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                conexion.Open();

                string sql = @"
                    SELECT Id, MascotaId, VacunaId, Lote,
                           FechaAplicacion, ProximaDosis, Observacion
                    FROM dbo.Vacunas
                    ORDER BY FechaAplicacion DESC, Id DESC;";

                using (SqlCommand comando = new SqlCommand(sql, conexion))
                using (SqlDataReader lector = comando.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        lista.Add(LeerRegistro(lector));
                    }
                }
            }

            return lista;
        }

        public static List<RegistroVacuna> Listar(string filtro)
        {
            List<RegistroVacuna> resultado = new List<RegistroVacuna>();

            foreach (RegistroVacuna registro in Todos())
            {
                Mascota mascota =
                    RepositorioMascotas.Buscar(registro.MascotaId);

                string nombreMascota =
                    mascota == null ? "" : mascota.Nombre;

                if (Buscador.Coincide(nombreMascota, filtro) ||
                    Buscador.Coincide(
                        NombreVacuna(registro.VacunaId), filtro))
                {
                    resultado.Add(registro);
                }
            }

            return resultado;
        }

        public static RegistroVacuna Buscar(int id)
        {
            using (SqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                conexion.Open();

                string sql = @"
                    SELECT Id, MascotaId, VacunaId, Lote,
                           FechaAplicacion, ProximaDosis, Observacion
                    FROM dbo.Vacunas
                    WHERE Id = @Id;";

                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue("@Id", id);

                    using (SqlDataReader lector = comando.ExecuteReader())
                    {
                        if (lector.Read())
                            return LeerRegistro(lector);
                    }
                }
            }

            return null;
        }

        public static bool MascotaTieneVacunas(int mascotaId)
        {
            using (SqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                conexion.Open();

                string sql = @"
                    SELECT COUNT(1)
                    FROM dbo.Vacunas
                    WHERE MascotaId = @MascotaId;";

                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue("@MascotaId", mascotaId);

                    return Convert.ToInt32(comando.ExecuteScalar()) > 0;
                }
            }
        }

        public static List<RegistroVacuna> ProximasDosis(int dias)
        {
            List<RegistroVacuna> resultado = new List<RegistroVacuna>();

            DateTime hoy = DateTime.Today;
            DateTime limite = hoy.AddDays(dias);

            foreach (RegistroVacuna registro in Todos())
            {
                if (!registro.TieneProximaDosis)
                    continue;

                if (registro.ProximaDosis.Date < hoy ||
                    registro.ProximaDosis.Date > limite)
                    continue;

                bool aplicadaNuevamente = false;

                foreach (RegistroVacuna otra in Todos())
                {
                    if (otra.MascotaId == registro.MascotaId &&
                        otra.VacunaId == registro.VacunaId &&
                        otra.FechaAplicacion > registro.FechaAplicacion)
                    {
                        aplicadaNuevamente = true;
                        break;
                    }
                }

                if (!aplicadaNuevamente)
                    resultado.Add(registro);
            }

            return resultado;
        }

        public static void Agregar(RegistroVacuna registro)
        {
            using (SqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                conexion.Open();

                string sql = @"
                    INSERT INTO dbo.Vacunas
                        (MascotaId, VacunaId, Lote,
                         FechaAplicacion, ProximaDosis, Observacion)
                    VALUES
                        (@MascotaId, @VacunaId, @Lote,
                         @FechaAplicacion, @ProximaDosis, @Observacion);

                    SELECT CAST(SCOPE_IDENTITY() AS int);";

                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    AgregarParametros(comando, registro);

                    registro.Id = Convert.ToInt32(
                        comando.ExecuteScalar());
                }
            }
        }

        public static bool Actualizar(RegistroVacuna nuevo)
        {
            using (SqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                conexion.Open();

                string sql = @"
                    UPDATE dbo.Vacunas
                    SET MascotaId = @MascotaId,
                        VacunaId = @VacunaId,
                        Lote = @Lote,
                        FechaAplicacion = @FechaAplicacion,
                        ProximaDosis = @ProximaDosis,
                        Observacion = @Observacion
                    WHERE Id = @Id;";

                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    AgregarParametros(comando, nuevo);
                    comando.Parameters.AddWithValue("@Id", nuevo.Id);

                    return comando.ExecuteNonQuery() > 0;
                }
            }
        }

        public static void Eliminar(int id)
        {
            using (SqlConnection conexion = ConexionBD.ObtenerConexion())
            {
                conexion.Open();

                string sql = "DELETE FROM dbo.Vacunas WHERE Id = @Id;";

                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue("@Id", id);
                    comando.ExecuteNonQuery();
                }
            }
        }

        private static RegistroVacuna LeerRegistro(SqlDataReader lector)
        {
            int indiceProxima = lector.GetOrdinal("ProximaDosis");
            int indiceLote = lector.GetOrdinal("Lote");
            int indiceObservacion = lector.GetOrdinal("Observacion");

            return new RegistroVacuna
            {
                Id = lector.GetInt32(lector.GetOrdinal("Id")),
                MascotaId = lector.GetInt32(lector.GetOrdinal("MascotaId")),
                VacunaId = lector.GetInt32(lector.GetOrdinal("VacunaId")),
                Lote = lector.IsDBNull(indiceLote)
                    ? ""
                    : lector.GetString(indiceLote),
                FechaAplicacion = lector.GetDateTime(
                    lector.GetOrdinal("FechaAplicacion")),
                TieneProximaDosis = !lector.IsDBNull(indiceProxima),
                ProximaDosis = lector.IsDBNull(indiceProxima)
                    ? DateTime.MinValue
                    : lector.GetDateTime(indiceProxima),
                Observacion = lector.IsDBNull(indiceObservacion)
                    ? ""
                    : lector.GetString(indiceObservacion)
            };
        }

        private static void AgregarParametros(
            SqlCommand comando, RegistroVacuna registro)
        {
            comando.Parameters.AddWithValue(
                "@MascotaId", registro.MascotaId);

            comando.Parameters.AddWithValue(
                "@VacunaId", registro.VacunaId);

            comando.Parameters.AddWithValue(
                "@Lote",
                string.IsNullOrWhiteSpace(registro.Lote)
                    ? (object)DBNull.Value
                    : registro.Lote);

            comando.Parameters.AddWithValue(
                "@FechaAplicacion", registro.FechaAplicacion.Date);

            comando.Parameters.AddWithValue(
                "@ProximaDosis",
                registro.TieneProximaDosis
                    ? (object)registro.ProximaDosis.Date
                    : DBNull.Value);

            comando.Parameters.AddWithValue(
                "@Observacion",
                string.IsNullOrWhiteSpace(registro.Observacion)
                    ? (object)DBNull.Value
                    : registro.Observacion);
        }
    }
}
