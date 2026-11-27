
using System;
using System.Diagnostics;

namespace MundoAnimal.Models
{
    public class SuscriptoresVeterinarios
    {
        public void Suscribir(NotificadorVeterinario notificador)
        {
            notificador.CambioRegistrado += MostrarNotificacion;
            notificador.CambioRegistrado += RegistrarDepuracion;
        }

        private void MostrarNotificacion(
            object? sender,
            CambioVeterinarioEventArgs e)
        {
            System.Windows.Forms.MessageBox.Show(
                e.Mensaje,
                "Notificación veterinaria");
        }

        private void RegistrarDepuracion(
            object? sender,
            CambioVeterinarioEventArgs e)
        {
            Debug.WriteLine(
                $"Cambio registrado: {e.Mensaje} | Fecha: {e.Fecha}");
        }
    }
}
