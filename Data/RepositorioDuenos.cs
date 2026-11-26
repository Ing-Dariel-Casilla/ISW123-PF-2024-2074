using MundoAnimal.Models;

namespace MundoAnimal.Data
{
    // Los dueños se guardan en una lista en memoria (se pierden al cerrar el programa)
    public static class RepositorioDuenos
    {
        private static List<Dueno> duenos = new List<Dueno>();
        private static int proximoId = 1;

        public static List<Dueno> Todos()
        {
            return duenos;
        }

        public static List<Dueno> Listar(string filtro)
        {
            List<Dueno> resultado = new List<Dueno>();
            foreach (Dueno d in duenos)
            {
                if (Buscador.Coincide(d.Nombre, filtro) || Buscador.Coincide(d.Apellido, filtro) || Buscador.Coincide(d.Telefono, filtro))
                {
                    resultado.Add(d);
                }
            }
            return resultado;
        }

        public static Dueno Buscar(int id)
        {
            foreach (Dueno d in duenos)
            {
                if (d.Id == id)
                {
                    return d;
                }
            }
            return null;
        }

        // Devuelve true si otro dueño (distinto al que tiene idActual) ya usa ese teléfono
        public static bool TelefonoRepetido(string telefono, int idActual)
        {
            foreach (Dueno d in duenos)
            {
                if (d.Id != idActual && d.Telefono == telefono)
                {
                    return true;
                }
            }
            return false;
        }

        public static void Agregar(Dueno d)
        {
            d.Id = proximoId;
            proximoId++;
            d.FechaRegistro = DateTime.Today;
            duenos.Add(d);
        }

        // Devuelve false si el dueño ya no existe
        public static bool Actualizar(Dueno nuevo)
        {
            Dueno actual = Buscar(nuevo.Id);
            if (actual == null)
            {
                return false;
            }
            actual.Nombre = nuevo.Nombre;
            actual.Apellido = nuevo.Apellido;
            actual.Telefono = nuevo.Telefono;
            actual.Correo = nuevo.Correo;
            actual.Direccion = nuevo.Direccion;
            return true;
        }

        // Devuelve el mensaje de error, o "" si se eliminó bien
        public static string Eliminar(int id)
        {
            if (RepositorioMascotas.DuenoTieneMascotas(id))
            {
                return "No se puede eliminar: el dueño tiene mascotas registradas. Elimine o reasigne primero sus mascotas.";
            }
            Dueno d = Buscar(id);
            if (d != null)
            {
                duenos.Remove(d);
            }
            return "";
        }
    }
}
