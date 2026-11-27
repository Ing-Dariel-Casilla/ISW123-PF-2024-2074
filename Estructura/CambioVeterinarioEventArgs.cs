
using System;

namespace MundoAnimal.Models
{
    public class CambioVeterinarioEventArgs : EventArgs
    {
        public string Mensaje { get; }

        public DateTime Fecha { get; }

        public CambioVeterinarioEventArgs(string mensaje)
        {
            if (string.IsNullOrWhiteSpace(mensaje))
            {
                throw new ArgumentException(
                    "El mensaje del cambio es obligatorio.");
            }

            Mensaje = mensaje;
            Fecha = DateTime.Now;
        }
    }
}
