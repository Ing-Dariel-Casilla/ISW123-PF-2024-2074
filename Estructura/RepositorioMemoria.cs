
using System;
using System.Collections.Generic;
using System.Linq;

namespace MundoAnimal.Models
{
    public class RepositorioMemoria<T>
    {
        private readonly List<T> elementos = new List<T>();

        public void Agregar(T elemento)
        {
            elementos.Add(elemento);
        }

        public List<T> ObtenerTodos()
        {
            return new List<T>(elementos);
        }

        public List<T> Filtrar(Func<T, bool> condicion)
        {
            return elementos.Where(condicion).ToList();
        }

        public int Cantidad()
        {
            return elementos.Count;
        }
    }
}
