namespace MundoAnimal.Models
{
    // Una vacuna aplicada a una mascota
    public class RegistroVacuna
    {
        public int Id { get; set; }
        public int MascotaId { get; set; }
        public int VacunaId { get; set; }
        public string Lote { get; set; }
        public DateTime FechaAplicacion { get; set; }
        public bool TieneProximaDosis { get; set; }
        public DateTime ProximaDosis { get; set; }
        public string Observacion { get; set; }
    }
}
