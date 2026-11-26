namespace MundoAnimal.Models
{
    public class Consulta
    {
        public int Id { get; set; }
        public int MascotaId { get; set; }
        public DateTime Fecha { get; set; }
        public string Motivo { get; set; }
        public string Diagnostico { get; set; }
        public int VeterinarioId { get; set; }
        public string Tratamiento { get; set; }
    }
}
