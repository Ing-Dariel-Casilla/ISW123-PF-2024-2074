

namespace MundoAnimal.Models
{
    public class EntidadConsulta : EntidadVeterinaria
    {
        public string Motivo { get; private set; }

        public EntidadConsulta(int id, string motivo)
            : base(id)
        {
            if (string.IsNullOrWhiteSpace(motivo))
                throw new System.ArgumentException(
                    "El motivo de la consulta es obligatorio.");

            Motivo = motivo.Trim();
        }

        public override string ObtenerDescripcion()
        {
            return $"Consulta veterinaria: {Motivo}";
        }
    }
}


