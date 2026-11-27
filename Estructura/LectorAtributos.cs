
using System;
using System.Reflection;

namespace MundoAnimal.Models
{
    public static class LectorAtributos
    {
        public static string ObtenerDescripcion<T>()
        {
            Type tipo = typeof(T);

            EntidadVeterinariaAttribute atributo =
                tipo.GetCustomAttribute<EntidadVeterinariaAttribute>();

            if (atributo == null)
            {
                return "La clase no tiene un atributo veterinario.";
            }

            return atributo.Descripcion;
        }
    }
}
