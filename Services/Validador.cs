using MundoAnimal.Models;

namespace MundoAnimal.Services
{
    // Cada método devuelve el mensaje de error, o "" si todo está bien
    public static class Validador
    {
        public static string ValidarDueno(Dueno d)
        {
            if (d.Nombre == "") return "Ingrese el nombre del dueño.";
            if (d.Apellido == "") return "Ingrese el apellido del dueño.";
            if (d.Telefono == "") return "Ingrese el teléfono del dueño.";
            if (!TelefonoValido(d.Telefono)) return "El teléfono no es válido (de 7 a 20 caracteres: números, +, -, paréntesis y espacios).";
            if (d.Correo != "" && !CorreoValido(d.Correo)) return "El correo no es válido. Ejemplo: nombre@correo.com";
            if (d.Nombre.Length > 60) return "El nombre no puede tener más de 60 caracteres.";
            if (d.Apellido.Length > 60) return "El apellido no puede tener más de 60 caracteres.";
            if (d.Direccion.Length > 200) return "La dirección no puede tener más de 200 caracteres.";
            return "";
        }

        public static string ValidarMascota(Mascota m)
        {
            if (m.Nombre == "") return "Ingrese el nombre de la mascota.";
            if (m.Especie == "") return "Seleccione la especie.";
            if (m.Sexo == "") return "Seleccione el sexo.";
            if (m.DuenoId == 0) return "Seleccione el dueño. Si no hay dueños en la lista, regístrelos primero en el módulo Dueños.";
            if (m.Edad < 0 || m.Edad > 40) return "La edad debe estar entre 0 y 40 años.";
            if (m.Nombre.Length > 60) return "El nombre no puede tener más de 60 caracteres.";
            if (m.Raza.Length > 60) return "La raza no puede tener más de 60 caracteres.";
            return "";
        }

        public static string ValidarConsulta(Consulta c)
        {
            if (c.MascotaId == 0) return "Seleccione la mascota. Si no hay mascotas en la lista, regístrelas primero en el módulo Mascotas.";
            if (c.VeterinarioId == 0) return "Seleccione el veterinario. Debe existir un usuario con rol Veterinario (módulo Usuarios).";
            if (c.Motivo == "") return "Ingrese el motivo de la consulta.";
            if (c.Fecha.Date > DateTime.Today) return "La fecha de la consulta no puede ser futura.";
            if (c.Motivo.Length > 150) return "El motivo no puede tener más de 150 caracteres.";
            return "";
        }

        public static string ValidarRegistroVacuna(RegistroVacuna r)
        {
            if (r.MascotaId == 0) return "Seleccione la mascota. Si no hay mascotas en la lista, regístrelas primero en el módulo Mascotas.";
            if (r.VacunaId == 0) return "Seleccione la vacuna.";
            if (r.FechaAplicacion.Date > DateTime.Today) return "La fecha de aplicación no puede ser futura: solo se registran vacunas ya aplicadas.";
            if (r.TieneProximaDosis && r.ProximaDosis.Date <= r.FechaAplicacion.Date)
                return "La próxima dosis debe ser posterior a la fecha de aplicación (o desmarque la casilla si no hay próxima dosis).";
            if (r.Lote.Length > 40) return "El lote no puede tener más de 40 caracteres.";
            if (r.Observacion.Length > 300) return "La observación no puede tener más de 300 caracteres.";
            return "";
        }

        // Al crear un usuario la contraseña es obligatoria. Al editar, si está vacía no se cambia.
        public static string ValidarUsuario(Usuario u, string clave, bool esNuevo)
        {
            if (u.Nombre == "") return "Ingrese el nombre.";
            if (u.Apellido == "") return "Ingrese el apellido.";
            if (u.NombreUsuario == "") return "Ingrese el nombre de usuario.";
            if (!UsuarioValido(u.NombreUsuario)) return "El usuario debe tener de 3 a 40 caracteres: solo letras, números, punto o guion bajo.";
            if (u.Rol == "") return "Seleccione el rol.";
            if (esNuevo && clave == "") return "Ingrese la contraseña.";
            if (clave != "" && clave.Length < 8) return "La contraseña debe tener al menos 8 caracteres.";
            if (u.Nombre.Length > 60) return "El nombre no puede tener más de 60 caracteres.";
            if (u.Apellido.Length > 60) return "El apellido no puede tener más de 60 caracteres.";
            return "";
        }

        private static bool TelefonoValido(string telefono)
        {
            if (telefono.Length < 7 || telefono.Length > 20)
            {
                return false;
            }
            foreach (char c in telefono)
            {
                if (!char.IsDigit(c) && c != '+' && c != '-' && c != '(' && c != ')' && c != ' ')
                {
                    return false;
                }
            }
            return true;
        }

        private static bool CorreoValido(string correo)
        {
            int arroba = correo.IndexOf('@');
            if (arroba <= 0) return false;                         // debe haber algo antes de la @
            if (correo.IndexOf('@', arroba + 1) >= 0) return false; // solo una @
            if (correo.IndexOf(' ') >= 0) return false;             // sin espacios
            int punto = correo.LastIndexOf('.');
            if (punto < arroba + 2) return false;                   // debe haber un punto después de la @
            if (punto == correo.Length - 1) return false;           // no puede terminar en punto
            return true;
        }

        private static bool UsuarioValido(string usuario)
        {
            if (usuario.Length < 3 || usuario.Length > 40)
            {
                return false;
            }
            foreach (char c in usuario)
            {
                if (!char.IsLetterOrDigit(c) && c != '.' && c != '_')
                {
                    return false;
                }
            }
            return true;
        }
    }
}
