
using System;
using MundoAnimal.Models;

namespace MundoAnimal
{
    public static class PruebaEventoVeterinario
    {
        public static void Ejecutar()
        {
            NotificadorVeterinario notificador =
                new NotificadorVeterinario();

            SuscriptoresVeterinarios suscriptores =
                new SuscriptoresVeterinarios();

            suscriptores.Suscribir(notificador);

            notificador.RegistrarCambio(
                "Se registró una consulta veterinaria.");
        }
    }
}
