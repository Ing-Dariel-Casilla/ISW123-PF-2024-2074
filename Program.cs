using MundoAnimal.Data;
using MundoAnimal.Forms;
using MundoAnimal.Services;

namespace MundoAnimal
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            // Prueba de reflexión
           // PruebaReflexion.Ejecutar();

            // el usuario inicial (admin) 
            RepositorioUsuarios.CrearUsuarioInicial();

            // Login -> ventana principal. Si el usuario cierra sesión, vuelve al login.
            while (true)
            {
                frmLogin login = new frmLogin();
                DialogResult resultado = login.ShowDialog();
                if (resultado != DialogResult.OK)
                {
                    break;
                }

                frmPrincipal principal = new frmPrincipal();
                Application.Run(principal);

                bool cerroSesion = principal.CerrarSesion;
                Sesion.Actual = null;
                if (cerroSesion == false)
                {
                    break;
                }
            }
        }
    }
}
