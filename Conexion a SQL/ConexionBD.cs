
using Microsoft.Data.SqlClient;

namespace MundoAnimal.ConexionSQL
{
    public static class ConexionBD
    {
        private static readonly string cadenaConexion =
            @"Server=localhost;Database=MundoAnimal;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";

        public static SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadenaConexion);
        }
    }
}
