
using System;
using System.Threading.Tasks;

namespace MundoAnimal
{
    public class ProcesoAsincrono
    {
        public async Task EjecutarAsync(
            IProgress<int> progreso)
        {
            for (int i = 1; i <= 100; i++)
            {
                await Task.Delay(50);

                progreso?.Report(i);
            }
        }
    }
}
