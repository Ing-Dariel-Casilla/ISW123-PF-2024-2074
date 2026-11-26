using MundoAnimal.Services;
using MundoAnimal.UI;

namespace MundoAnimal.Forms
{
    // Ventana que contiene a todas las pantallas. El menú verde está dentro de la pantalla Inicio.
    public partial class frmPrincipal : Form
    {
        private Form moduloActual;

        // Es true cuando el usuario pulsa "Cerrar Sesión" (y no la X de la ventana)
        public bool CerrarSesion = false;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            this.Text = "Mundo Animal – Clínica Veterinaria   |   " + Sesion.Actual.Nombre + " " + Sesion.Actual.Apellido + " (" + Sesion.Actual.Rol + ")";
            AbrirModulo("Inicio");
        }

        // Abre una pantalla por su nombre
        public void AbrirModulo(string nombre)
        {
            Form modulo = null;

            if (nombre == "Inicio") modulo = new frmInicio();
            if (nombre == "Dueños") modulo = new frmDuenos();
            if (nombre == "Mascotas") modulo = new frmMascotas();
            if (nombre == "Consultas") modulo = new frmConsultas();
            if (nombre == "Vacunas") modulo = new frmVacunas();
            if (nombre == "Reportes") modulo = new frmReportes();
            if (nombre == "Usuarios") modulo = new frmUsuarios();

            if (modulo != null)
            {
                MostrarModulo(modulo);
            }
        }

        // Muestra un formulario dentro del panel central (sin abrir otra ventana)
        private void MostrarModulo(Form modulo)
        {
            if (moduloActual != null)
            {
                panelCentral.Controls.Remove(moduloActual);
                moduloActual.Dispose();
            }

            moduloActual = modulo;
            modulo.TopLevel = false;
            modulo.FormBorderStyle = FormBorderStyle.None;
            modulo.Dock = DockStyle.Fill;
            panelCentral.Controls.Add(modulo);
            modulo.Show();
        }

        // La pantalla Inicio llama a este método desde su botón Cerrar Sesión
        public void PedirCerrarSesion()
        {
            if (Mensajes.Confirmar("¿Desea cerrar la sesión?"))
            {
                CerrarSesion = true;
                this.Close();
            }
        }
    }
}
