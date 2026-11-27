
using System;
using System.Collections.Generic;

namespace MundoAnimal
{
    public static class PruebaFlujo
    {
        public static string ClasificarEspecie(string especie)
        {
            if (string.IsNullOrWhiteSpace(especie))
                return "Especie no especificada";

            return especie.Trim().ToLowerInvariant() switch
            {
                "perro" => "Canino",
                "gato" => "Felino",
                "ave" => "Ave",
                "conejo" => "Conejo",
                _ => "Otra especie"
            };
        }

        public static List<string> ObtenerEspeciesRegistradas()
        {
            List<string> especies = new List<string>
            {
                "Perro",
                "Gato",
                "Ave",
                "Conejo"
            };

            List<string> resultado = new List<string>();

            foreach (string especie in especies)
            {
                if (!string.IsNullOrWhiteSpace(especie))
                    resultado.Add(especie);
            }

            return resultado;
        }

        public static Dictionary<string, int> ContarEspecies()
        {
            Dictionary<string, int> cantidades =
                new Dictionary<string, int>
                {
                    { "Perro", 3 },
                    { "Gato", 2 },
                    { "Ave", 1 }
                };

            foreach (KeyValuePair<string, int> elemento in cantidades)
            {
                System.Diagnostics.Debug.WriteLine(
                    $"{elemento.Key}: {elemento.Value}");
            }

            return cantidades;
        }
    }
}
