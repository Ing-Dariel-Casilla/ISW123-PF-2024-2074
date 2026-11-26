using MundoAnimal.Models;

namespace MundoAnimal.Data
{
    public static class RepositorioConsultas
    {
        private static List<Consulta> consultas = new List<Consulta>();
        private static int proximoId = 1;

        public static List<Consulta> Todas()
        {
            return consultas;
        }

        public static string NombreMascota(int mascotaId)
        {
            Mascota m = RepositorioMascotas.Buscar(mascotaId);
            if (m == null)
            {
                return "";
            }
            return m.Nombre;
        }

        public static string NombreVeterinario(int usuarioId)
        {
            Usuario u = RepositorioUsuarios.Buscar(usuarioId);
            if (u == null)
            {
                return "";
            }
            return u.Nombre + " " + u.Apellido;
        }

        public static List<Consulta> Listar(string filtro)
        {
            List<Consulta> resultado = new List<Consulta>();
            foreach (Consulta c in consultas)
            {
                if (Buscador.Coincide(NombreMascota(c.MascotaId), filtro) || Buscador.Coincide(c.Motivo, filtro) || Buscador.Coincide(NombreVeterinario(c.VeterinarioId), filtro))
                {
                    resultado.Add(c);
                }
            }
            return resultado;
        }

        public static Consulta Buscar(int id)
        {
            foreach (Consulta c in consultas)
            {
                if (c.Id == id)
                {
                    return c;
                }
            }
            return null;
        }

        public static bool MascotaTieneConsultas(int mascotaId)
        {
            foreach (Consulta c in consultas)
            {
                if (c.MascotaId == mascotaId)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool VeterinarioTieneConsultas(int usuarioId)
        {
            foreach (Consulta c in consultas)
            {
                if (c.VeterinarioId == usuarioId)
                {
                    return true;
                }
            }
            return false;
        }

        public static void Agregar(Consulta c)
        {
            c.Id = proximoId;
            proximoId++;
            consultas.Add(c);
        }

        public static bool Actualizar(Consulta nueva)
        {
            Consulta actual = Buscar(nueva.Id);
            if (actual == null)
            {
                return false;
            }
            actual.MascotaId = nueva.MascotaId;
            actual.Fecha = nueva.Fecha;
            actual.Motivo = nueva.Motivo;
            actual.Diagnostico = nueva.Diagnostico;
            actual.VeterinarioId = nueva.VeterinarioId;
            actual.Tratamiento = nueva.Tratamiento;
            return true;
        }

        public static void Eliminar(int id)
        {
            Consulta c = Buscar(id);
            if (c != null)
            {
                consultas.Remove(c);
            }
        }
    }
}
