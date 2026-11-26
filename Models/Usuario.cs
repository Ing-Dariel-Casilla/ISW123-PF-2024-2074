namespace MundoAnimal.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NombreUsuario { get; set; }
        public string ClaveHash { get; set; }   // la contraseña nunca se guarda tal cual
        public string Sal { get; set; }
        public string Rol { get; set; }
        public bool Activo { get; set; }

        // Así se muestra el usuario (veterinario) dentro de un ComboBox
        public override string ToString()
        {
            if (Activo)
            {
                return Nombre + " " + Apellido;
            }
            return Nombre + " " + Apellido + " (inactivo)";
        }
    }
}
