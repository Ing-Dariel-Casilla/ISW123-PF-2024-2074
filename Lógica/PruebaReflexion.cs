
using System;
using MundoAnimal.Models;

namespace MundoAnimal
{
    public static class PruebaReflexion
    {
        public static string Ejecutar()
        {
            return LectorAtributos
                .ObtenerDescripcion<ResumenConsulta>();
        }
    }
}
