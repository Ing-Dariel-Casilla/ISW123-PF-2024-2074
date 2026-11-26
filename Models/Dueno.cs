namespace MundoAnimal.Models
{
    public class Dueno
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }
        public DateTime FechaRegistro { get; set; }

        // Así se muestra el dueño dentro de un ComboBox
        public override string ToString()
        {
            return Nombre + " " + Apellido;
        }
    }
}
