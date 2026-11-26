using MundoAnimal.Data;

namespace MundoAnimal.Models
{
    public class Mascota
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Especie { get; set; }
        public string Raza { get; set; }
        public int Edad { get; set; }
        public string Sexo { get; set; }
        public int DuenoId { get; set; }
        public DateTime FechaRegistro { get; set; }

        // Así se muestra la mascota dentro de un ComboBox: Nombre (Dueño)
        public override string ToString()
        {
            Dueno dueno = RepositorioDuenos.Buscar(DuenoId);
            if (dueno == null)
            {
                return Nombre;
            }
            return Nombre + " (" + dueno.Nombre + " " + dueno.Apellido + ")";
        }
    }
}
