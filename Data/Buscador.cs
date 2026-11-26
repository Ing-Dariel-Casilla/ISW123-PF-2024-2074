namespace MundoAnimal.Data
{
    public static class Buscador
    {
        // Devuelve true si el texto contiene lo que el usuario escribió (sin importar mayúsculas)
        public static bool Coincide(string texto, string filtro)
        {
            if (filtro == "")
            {
                return true;
            }
            if (texto == null)
            {
                return false;
            }
            return texto.ToLower().Contains(filtro.ToLower());
        }
    }
}
