
using System;

namespace MundoAnimal.Models
{
    public class NotificadorVeterinario
    {
        public event EventHandler<CambioVeterinarioEventArgs>
            CambioRegistrado;

        public void RegistrarCambio(string mensaje)
        {
            CambioVeterinarioEventArgs datos =
                new CambioVeterinarioEventArgs(mensaje);

            CambioRegistrado?.Invoke(this, datos);
        }
    }
}
