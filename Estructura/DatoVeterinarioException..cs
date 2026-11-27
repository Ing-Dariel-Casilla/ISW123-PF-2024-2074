using System;

namespace MundoAnimal.Models
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class EntidadVeterinariaAttribute : Attribute
    {
        public string Descripcion { get; }

        public EntidadVeterinariaAttribute(string descripcion)
        {
            Descripcion = descripcion;
        }
    }
}
