using System.Globalization;
using MundoAnimal.Data;
using MundoAnimal.Models;
using MundoAnimal.Services;

namespace MundoAnimal.Forms
{
    public partial class frmInicio : Form
    {
        // Se consideran "próximas" las vacunas de los siguientes 30 días
        private int diasProximos = 30;

        public frmInicio()
        {
            InitializeComponent();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            // Solo el administrador ve el botón Usuarios
            btnUsuarios.Visible = Sesion.EsAdministrador();

            MostrarFecha();
            MostrarContadores();
            MostrarConsultasRecientes();
            MostrarProximasVacunas();
        }

        // Todos los botones del menú verde usan este mismo evento: abren la pantalla que dice su texto
        private void Menu_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            frmPrincipal principal = (frmPrincipal)this.Parent.FindForm();
            principal.AbrirModulo(boton.Text);
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            frmPrincipal principal = (frmPrincipal)this.Parent.FindForm();
            principal.PedirCerrarSesion();
        }

        private void MostrarFecha()
        {
            string fecha = DateTime.Now.ToString("dddd, d 'de' MMMM 'de' yyyy", new CultureInfo("es-DO"));
            fecha = fecha.Substring(0, 1).ToUpper() + fecha.Substring(1);   // primera letra en mayúscula
            lblFecha.Text = "Fecha: " + fecha;
        }

        private void MostrarContadores()
        {
            lblMascotas.Text = RepositorioMascotas.Todas().Count.ToString();
            lblDuenos.Text = RepositorioDuenos.Todos().Count.ToString();

            // Consultas de hoy
            int consultasHoy = 0;
            foreach (Consulta c in RepositorioConsultas.Todas())
            {
                if (c.Fecha.Date == DateTime.Today)
                {
                    consultasHoy++;
                }
            }
            lblConsultasHoy.Text = consultasHoy.ToString();

            // Vacunas próximas
            int proximas = RepositorioVacunas.ProximasDosis(diasProximos).Count;
            lblVacunasProximas.Text = proximas.ToString();

            if (proximas == 0)
            {
                lblRecordatorio.Text = "No hay vacunas programadas en los próximos " + diasProximos + " días.";
            }
            else
            {
                lblRecordatorio.Text = "Hay " + proximas + " vacuna(s) programada(s) en los próximos " + diasProximos + " días.";
            }
        }

        // Consultas de los últimos 7 días
        private void MostrarConsultasRecientes()
        {
            dgvConsultasRecientes.Rows.Clear();
            DateTime desde = DateTime.Today.AddDays(-7);

            foreach (Consulta c in RepositorioConsultas.Todas())
            {
                if (c.Fecha.Date >= desde && c.Fecha.Date <= DateTime.Today)
                {
                    string nombreMascota = "";
                    string nombreDueno = "";
                    Mascota m = RepositorioMascotas.Buscar(c.MascotaId);
                    if (m != null)
                    {
                        nombreMascota = m.Nombre;
                        nombreDueno = RepositorioMascotas.NombreDueno(m.DuenoId);
                    }
                    dgvConsultasRecientes.Rows.Add(c.Fecha.ToString("dd/MM/yyyy"), nombreMascota, nombreDueno, c.Motivo);
                }
            }
            dgvConsultasRecientes.ClearSelection();
        }

        private void MostrarProximasVacunas()
        {
            dgvProximasVacunas.Rows.Clear();

            foreach (RegistroVacuna r in RepositorioVacunas.ProximasDosis(diasProximos))
            {
                string nombreMascota = "";
                Mascota m = RepositorioMascotas.Buscar(r.MascotaId);
                if (m != null)
                {
                    nombreMascota = m.Nombre;
                }
                dgvProximasVacunas.Rows.Add(r.ProximaDosis.ToString("dd/MM/yyyy"), nombreMascota, RepositorioVacunas.NombreVacuna(r.VacunaId));
            }
            dgvProximasVacunas.ClearSelection();
        }

        private void flpMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvConsultasRecientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

       


private async void btnEjecutarProceso_Click(object sender, EventArgs e)
        {
            btnEjecutarProceso.Enabled = false;
            progressBarProceso.Value = 0;

            try
            {
                var progreso = new Progress<int>(porcentaje =>
                {
                    progressBarProceso.Value = porcentaje;
                });

                ProcesoAsincrono proceso = new ProcesoAsincrono();

                await proceso.EjecutarAsync(progreso);

                MessageBox.Show(
                    "Proceso completado correctamente.",
                    "MundoAnimal",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ocurrió un error: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                btnEjecutarProceso.Enabled = true;
            }
        }

    }
}

