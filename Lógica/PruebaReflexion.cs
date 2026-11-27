

using System;
using System.Windows.Forms;
using MundoAnimal.Estructura;
using MundoAnimal.Models;

namespace MundoAnimal
{
    public static class PruebaReflexion
    {
        public static void Ejecutar()
        {
            string resultado =
                LectorAtributos.ObtenerDescripcion<ResumenConsulta>();

            MessageBox.Show(
                resultado,
                "Prueba de reflexión",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
