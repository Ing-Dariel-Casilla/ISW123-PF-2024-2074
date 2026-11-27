using System;

namespace MundoAnimal.Estructura
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
    public sealed class EntidadVeterinariaAttribute : Attribute
    {
        public string Descripcion { get; }
        public EntidadVeterinariaAttribute(string descripcion) => Descripcion = descripcion;
    }

    [EntidadVeterinaria("Resumen de una consulta veterinaria")]
    public record ResumenConsulta(
        int ConsultaId,
        int MascotaId,
        DateTime Fecha,
        string Motivo,
        string Diagnostico
    );
}