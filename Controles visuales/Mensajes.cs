namespace MundoAnimal.UI
{
    // Cuadros de mensaje que se usan en todos los formularios
    public static class Mensajes
    {
        public static void Info(string mensaje)
        {
            MessageBox.Show(mensaje, "Mundo Animal", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void Aviso(string mensaje)
        {
            MessageBox.Show(mensaje, "Mundo Animal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void Error(string mensaje)
        {
            MessageBox.Show(mensaje, "Mundo Animal", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static bool Confirmar(string pregunta)
        {
            DialogResult respuesta = MessageBox.Show(pregunta, "Mundo Animal", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return respuesta == DialogResult.Yes;
        }
    }
}
