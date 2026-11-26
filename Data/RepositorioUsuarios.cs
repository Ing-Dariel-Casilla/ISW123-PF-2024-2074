using MundoAnimal.Models;
using MundoAnimal.Services;

namespace MundoAnimal.Data
{
    public static class RepositorioUsuarios
    {
        // Usuario con el que se entra la primera vez (los datos no se guardan al cerrar el programa)
        public const string UsuarioInicial = "admin";
        public const string ClaveInicial = "admin1234";

        private static List<Usuario> usuarios = new List<Usuario>();
        private static int proximoId = 1;

        // Se llama una vez al iniciar el programa
        public static void CrearUsuarioInicial()
        {
            Usuario u = new Usuario();
            u.Nombre = "Administrador";
            u.Apellido = "Inicial";
            u.NombreUsuario = UsuarioInicial;
            u.Rol = "Administrador";
            u.Activo = true;
            Agregar(u, ClaveInicial);
        }

        public static List<Usuario> Todos()
        {
            return usuarios;
        }

        public static List<Usuario> Listar(string filtro)
        {
            List<Usuario> resultado = new List<Usuario>();
            foreach (Usuario u in usuarios)
            {
                if (Buscador.Coincide(u.Nombre, filtro) || Buscador.Coincide(u.Apellido, filtro) || Buscador.Coincide(u.NombreUsuario, filtro) || Buscador.Coincide(u.Rol, filtro))
                {
                    resultado.Add(u);
                }
            }
            return resultado;
        }

        public static List<Usuario> Veterinarios()
        {
            List<Usuario> resultado = new List<Usuario>();
            foreach (Usuario u in usuarios)
            {
                if (u.Rol == "Veterinario")
                {
                    resultado.Add(u);
                }
            }
            return resultado;
        }

        public static Usuario Buscar(int id)
        {
            foreach (Usuario u in usuarios)
            {
                if (u.Id == id)
                {
                    return u;
                }
            }
            return null;
        }

        public static Usuario BuscarPorNombre(string nombreUsuario)
        {
            foreach (Usuario u in usuarios)
            {
                if (u.NombreUsuario.ToLower() == nombreUsuario.ToLower())
                {
                    return u;
                }
            }
            return null;
        }

        // Comprueba la contraseña comparando hashes
        public static bool ClaveCorrecta(Usuario u, string clave)
        {
            string hash = Seguridad.CrearHash(clave, u.Sal);
            return hash == u.ClaveHash;
        }

        public static bool NombreUsuarioRepetido(string nombreUsuario, int idActual)
        {
            foreach (Usuario u in usuarios)
            {
                if (u.Id != idActual && u.NombreUsuario.ToLower() == nombreUsuario.ToLower())
                {
                    return true;
                }
            }
            return false;
        }

        public static int ContarAdministradoresActivos(int idExcluido)
        {
            int total = 0;
            foreach (Usuario u in usuarios)
            {
                if (u.Id != idExcluido && u.Rol == "Administrador" && u.Activo)
                {
                    total++;
                }
            }
            return total;
        }

        public static void Agregar(Usuario u, string clave)
        {
            u.Id = proximoId;
            proximoId++;
            u.Sal = Seguridad.CrearSal();
            u.ClaveHash = Seguridad.CrearHash(clave, u.Sal);
            usuarios.Add(u);
        }

        // Si claveNueva está vacía, la contraseña no cambia
        public static bool Actualizar(Usuario nuevo, string claveNueva)
        {
            Usuario actual = Buscar(nuevo.Id);
            if (actual == null)
            {
                return false;
            }
            actual.Nombre = nuevo.Nombre;
            actual.Apellido = nuevo.Apellido;
            actual.NombreUsuario = nuevo.NombreUsuario;
            actual.Rol = nuevo.Rol;
            actual.Activo = nuevo.Activo;

            if (claveNueva != "")
            {
                actual.Sal = Seguridad.CrearSal();
                actual.ClaveHash = Seguridad.CrearHash(claveNueva, actual.Sal);
            }
            return true;
        }

        public static string Eliminar(int id)
        {
            if (RepositorioConsultas.VeterinarioTieneConsultas(id))
            {
                return "No se puede eliminar: el usuario tiene consultas registradas. Póngalo en estado Inactivo en su lugar.";
            }
            Usuario u = Buscar(id);
            if (u != null)
            {
                usuarios.Remove(u);
            }
            return "";
        }
    }
}
