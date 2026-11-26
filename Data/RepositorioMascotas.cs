using MundoAnimal.Models;

namespace MundoAnimal.Data
{
    public static class RepositorioMascotas
    {
        private static List<Mascota> mascotas = new List<Mascota>();
        private static int proximoId = 1;

        public static List<Mascota> Todas()
        {
            return mascotas;
        }

        // Nombre completo del dueño de una mascota
        public static string NombreDueno(int duenoId)
        {
            Dueno d = RepositorioDuenos.Buscar(duenoId);
            if (d == null)
            {
                return "";
            }
            return d.Nombre + " " + d.Apellido;
        }

        public static List<Mascota> Listar(string filtro)
        {
            List<Mascota> resultado = new List<Mascota>();
            foreach (Mascota m in mascotas)
            {
                if (Buscador.Coincide(m.Nombre, filtro) || Buscador.Coincide(m.Especie, filtro) || Buscador.Coincide(NombreDueno(m.DuenoId), filtro))
                {
                    resultado.Add(m);
                }
            }
            return resultado;
        }

        public static Mascota Buscar(int id)
        {
            foreach (Mascota m in mascotas)
            {
                if (m.Id == id)
                {
                    return m;
                }
            }
            return null;
        }

        public static bool DuenoTieneMascotas(int duenoId)
        {
            foreach (Mascota m in mascotas)
            {
                if (m.DuenoId == duenoId)
                {
                    return true;
                }
            }
            return false;
        }

        // Devuelve true si ese dueño ya tiene otra mascota con el mismo nombre
        public static bool NombreRepetido(string nombre, int duenoId, int idActual)
        {
            foreach (Mascota m in mascotas)
            {
                if (m.Id != idActual && m.DuenoId == duenoId && m.Nombre.ToLower() == nombre.ToLower())
                {
                    return true;
                }
            }
            return false;
        }

        public static void Agregar(Mascota m)
        {
            m.Id = proximoId;
            proximoId++;
            m.FechaRegistro = DateTime.Today;
            mascotas.Add(m);
        }

        public static bool Actualizar(Mascota nueva)
        {
            Mascota actual = Buscar(nueva.Id);
            if (actual == null)
            {
                return false;
            }
            actual.Nombre = nueva.Nombre;
            actual.Especie = nueva.Especie;
            actual.Raza = nueva.Raza;
            actual.Edad = nueva.Edad;
            actual.Sexo = nueva.Sexo;
            actual.DuenoId = nueva.DuenoId;
            return true;
        }

        public static string Eliminar(int id)
        {
            if (RepositorioConsultas.MascotaTieneConsultas(id) || RepositorioVacunas.MascotaTieneVacunas(id))
            {
                return "No se puede eliminar: la mascota tiene consultas o vacunas registradas (historial clínico).";
            }
            Mascota m = Buscar(id);
            if (m != null)
            {
                mascotas.Remove(m);
            }
            return "";
        }
    }
}
