namespace MundoAnimal.Estructura
{
    public abstract class EntidadVeterinaria : IEntidadVeterinaria,
    System.IComparable<EntidadVeterinaria>
    {
        public int Id { get; protected set; }

        protected EntidadVeterinaria(int id)
        {
            if (id < 0)
                throw new System.ArgumentException(
                    "El ID no puede ser negativo.");

            Id = id;
        }

        public int ObtenerId()
        {
            return Id;
        }

        public abstract string ObtenerDescripcion();

        public int CompareTo(EntidadVeterinaria otra)
        {
            if (otra == null)
                return 1;

            return Id.CompareTo(otra.Id);
        }
    }
}
