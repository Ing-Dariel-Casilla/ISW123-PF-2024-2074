
using System;

namespace MundoAnimal.Models
{
    public class DatoVeterinarioException : Exception
    {
        public DatoVeterinarioException(string mensaje)
            : base(mensaje)
        {
        }
    }
}
