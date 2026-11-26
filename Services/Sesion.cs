using MundoAnimal.Models;

namespace MundoAnimal.Services
{
    // Guarda el usuario que inició sesión
    public static class Sesion
    {
        public static Usuario Actual;

        public static bool EsAdministrador()
        {
            if (Actual == null)
            {
                return false;
            }
            return Actual.Rol == "Administrador";
        }
    }
}
