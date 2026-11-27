
using System;
using System.Collections.Generic;
using System.Linq;
using MundoAnimal.Models;

namespace MundoAnimal.Models
{
    public static class ExtensionesMascotas
    {
        public static bool TieneNombre(this Mascota mascota, string nombre)
        {
            if (mascota == null || string.IsNullOrWhiteSpace(nombre))
                return false;

            return mascota.Nombre != null &&
                   mascota.Nombre.Contains(
                       nombre,
                       StringComparison.OrdinalIgnoreCase);
        }

        public static List<Mascota> FiltrarPorEspecie(
            this IEnumerable<Mascota> mascotas,
            string especie)
        {
            if (mascotas == null)
                return new List<Mascota>();

            if (string.IsNullOrWhiteSpace(especie))
                return mascotas.ToList();

            return mascotas
                .Where(m => m != null &&
                    string.Equals(
                        m.Especie,
                        especie,
                        StringComparison.OrdinalIgnoreCase))
                .ToList();
        }
    }
}
