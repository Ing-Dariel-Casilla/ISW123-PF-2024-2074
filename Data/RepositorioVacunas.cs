using MundoAnimal.Models;

namespace MundoAnimal.Data
{
    // Catálogo de tipos de vacuna y registro de las vacunas aplicadas
    public static class RepositorioVacunas
    {
        private static List<Vacuna> catalogo = CrearCatalogo();
        private static List<RegistroVacuna> registros = new List<RegistroVacuna>();
        private static int proximoId = 1;

        private static List<Vacuna> CrearCatalogo()
        {
            string[] nombres = { "Antirrábica", "Séxtuple", "Parvovirus", "Triple Felina", "Leucemia Felina" };
            List<Vacuna> lista = new List<Vacuna>();
            for (int i = 0; i < nombres.Length; i++)
            {
                Vacuna v = new Vacuna();
                v.Id = i + 1;
                v.Nombre = nombres[i];
                lista.Add(v);
            }
            return lista;
        }

        public static List<Vacuna> Catalogo()
        {
            return catalogo;
        }

        public static string NombreVacuna(int vacunaId)
        {
            foreach (Vacuna v in catalogo)
            {
                if (v.Id == vacunaId)
                {
                    return v.Nombre;
                }
            }
            return "";
        }

        public static List<RegistroVacuna> Todos()
        {
            return registros;
        }

        public static List<RegistroVacuna> Listar(string filtro)
        {
            List<RegistroVacuna> resultado = new List<RegistroVacuna>();
            foreach (RegistroVacuna r in registros)
            {
                string mascota = "";
                Mascota m = RepositorioMascotas.Buscar(r.MascotaId);
                if (m != null)
                {
                    mascota = m.Nombre;
                }
                if (Buscador.Coincide(mascota, filtro) || Buscador.Coincide(NombreVacuna(r.VacunaId), filtro))
                {
                    resultado.Add(r);
                }
            }
            return resultado;
        }

        public static RegistroVacuna Buscar(int id)
        {
            foreach (RegistroVacuna r in registros)
            {
                if (r.Id == id)
                {
                    return r;
                }
            }
            return null;
        }

        public static bool MascotaTieneVacunas(int mascotaId)
        {
            foreach (RegistroVacuna r in registros)
            {
                if (r.MascotaId == mascotaId)
                {
                    return true;
                }
            }
            return false;
        }

        // Vacunas cuya próxima dosis cae entre hoy y dentro de "dias" días.
        // Si esa vacuna ya se volvió a aplicar después a la mascota, la dosis ya no está pendiente.
        public static List<RegistroVacuna> ProximasDosis(int dias)
        {
            List<RegistroVacuna> resultado = new List<RegistroVacuna>();
            DateTime hoy = DateTime.Today;
            DateTime limite = hoy.AddDays(dias);

            foreach (RegistroVacuna r in registros)
            {
                if (!r.TieneProximaDosis)
                {
                    continue;
                }
                if (r.ProximaDosis.Date < hoy || r.ProximaDosis.Date > limite)
                {
                    continue;
                }

                bool yaSeAplicoOtraVez = false;
                foreach (RegistroVacuna otra in registros)
                {
                    if (otra.MascotaId == r.MascotaId && otra.VacunaId == r.VacunaId && otra.FechaAplicacion > r.FechaAplicacion)
                    {
                        yaSeAplicoOtraVez = true;
                    }
                }
                if (!yaSeAplicoOtraVez)
                {
                    resultado.Add(r);
                }
            }
            return resultado;
        }

        public static void Agregar(RegistroVacuna r)
        {
            r.Id = proximoId;
            proximoId++;
            registros.Add(r);
        }

        public static bool Actualizar(RegistroVacuna nuevo)
        {
            RegistroVacuna actual = Buscar(nuevo.Id);
            if (actual == null)
            {
                return false;
            }
            actual.MascotaId = nuevo.MascotaId;
            actual.VacunaId = nuevo.VacunaId;
            actual.Lote = nuevo.Lote;
            actual.FechaAplicacion = nuevo.FechaAplicacion;
            actual.TieneProximaDosis = nuevo.TieneProximaDosis;
            actual.ProximaDosis = nuevo.ProximaDosis;
            actual.Observacion = nuevo.Observacion;
            return true;
        }

        public static void Eliminar(int id)
        {
            RegistroVacuna r = Buscar(id);
            if (r != null)
            {
                registros.Remove(r);
            }
        }
    }
}
