namespace MundoAnimal.Models
{
    // Tipo de vacuna del catálogo (Antirrábica, Séxtuple, etc.)
    public class Vacuna
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
