using System.Security.Cryptography;
using System.Text;

namespace MundoAnimal.Services
{
    // La contraseña se guarda como hash (SHA256) mezclado con una sal distinta para cada usuario
    public static class Seguridad
    {
        public static string CrearSal()
        {
            return Guid.NewGuid().ToString();
        }

        public static string CrearHash(string clave, string sal)
        {
            SHA256 sha = SHA256.Create();
            byte[] datos = Encoding.UTF8.GetBytes(sal + clave);
            byte[] hash = sha.ComputeHash(datos);
            return Convert.ToBase64String(hash);
        }
    }
}
