
namespace MundoAnimal.Models
{
    public class EntidadMascota : EntidadVeterinaria
    {
        public string Nombre { get; private set; }

        public EntidadMascota(int id, string nombre)
            : base(id)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new System.ArgumentException(
                    "El nombre de la mascota es obligatorio.");

            Nombre = nombre.Trim();
        }

        public override string ObtenerDescripcion()
        {
            return $"Mascota: {Nombre}";
        }
    }
}
