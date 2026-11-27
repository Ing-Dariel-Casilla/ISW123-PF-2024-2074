
using System;
using MundoAnimal.Estructura;
using MundoAnimal.Models;

namespace MundoAnimal
{
    public static class PruebaExcepciones
    {
        public static string ValidarNombreMascota(string nombre)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(nombre))
                {
                    throw new DatoVeterinarioException(
                        "El nombre de la mascota es obligatorio.");
                }

                return "Nombre válido: " + nombre.Trim();
            }
            catch (DatoVeterinarioException ex)
            {
                return "Error de validación: " + ex.Message;
            }
        }
    }
}
