using MundoAnimal.Data;
using MundoAnimal.Models;
using MundoAnimal.Services;
using MundoAnimal.UI;

namespace MundoAnimal.Forms
{
    public partial class frmConsultas : Form
    {
        public frmConsultas()
        {
            InitializeComponent();
        }

        // Vuelve a la pantalla de Inicio (donde está el menú)
        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal principal = (frmPrincipal)this.Parent.FindForm();
            principal.AbrirModulo("Inicio");
        }

        private void frmConsultas_Load(object sender, EventArgs e)
        {
            // La mascota y el veterinario se escogen de los que ya existen
            foreach (Mascota m in RepositorioMascotas.Todas())
            {
                cmbMascota.Items.Add(m);
            }
            foreach (Usuario u in RepositorioUsuarios.Veterinarios())
            {
                cmbVeterinario.Items.Add(u);
            }
            CargarLista();
        }

        private void CargarLista()
        {
            dgvLista.Rows.Clear();
            List<Consulta> lista = RepositorioConsultas.Listar(txtBuscar.Text.Trim());
            foreach (Consulta c in lista)
            {
                dgvLista.Rows.Add(c.Id, c.Fecha.ToString("dd/MM/yyyy"), RepositorioConsultas.NombreMascota(c.MascotaId),
                                  c.Motivo, RepositorioConsultas.NombreVeterinario(c.VeterinarioId));
            }
            dgvLista.ClearSelection();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarLista();
        }

        private void dgvLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            int id = int.Parse(dgvLista.Rows[e.RowIndex].Cells[0].Value.ToString());
            Consulta c = RepositorioConsultas.Buscar(id);
            if (c == null)
            {
                return;
            }

            txtId.Text = c.Id.ToString();
            txtMotivo.Text = c.Motivo;
            txtDiagnostico.Text = c.Diagnostico;
            dtpFecha.Value = c.Fecha;
            txtTratamiento.Text = c.Tratamiento;

            cmbMascota.SelectedIndex = -1;
            for (int i = 0; i < cmbMascota.Items.Count; i++)
            {
                Mascota m = (Mascota)cmbMascota.Items[i];
                if (m.Id == c.MascotaId)
                {
                    cmbMascota.SelectedIndex = i;
                }
            }

            cmbVeterinario.SelectedIndex = -1;
            for (int i = 0; i < cmbVeterinario.Items.Count; i++)
            {
                Usuario u = (Usuario)cmbVeterinario.Items[i];
                if (u.Id == c.VeterinarioId)
                {
                    cmbVeterinario.SelectedIndex = i;
                }
            }
        }

        private Consulta LeerFormulario()
        {
            Consulta c = new Consulta();
            if (txtId.Text != "")
            {
                c.Id = int.Parse(txtId.Text);
            }

            Mascota mascota = cmbMascota.SelectedItem as Mascota;
            if (mascota != null)
            {
                c.MascotaId = mascota.Id;
            }

            Usuario veterinario = cmbVeterinario.SelectedItem as Usuario;
            if (veterinario != null)
            {
                c.VeterinarioId = veterinario.Id;
            }

            c.Fecha = dtpFecha.Value.Date;
            c.Motivo = txtMotivo.Text.Trim();
            c.Diagnostico = txtDiagnostico.Text.Trim();
            c.Tratamiento = txtTratamiento.Text.Trim();
            return c;
        }

        private void LimpiarCampos()
        {
            txtId.Clear();
            cmbMascota.SelectedIndex = -1;
            txtMotivo.Clear();
            txtDiagnostico.Clear();
            dtpFecha.Value = DateTime.Today;
            cmbVeterinario.SelectedIndex = -1;
            txtTratamiento.Clear();
            dgvLista.ClearSelection();
            cmbMascota.Focus();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                Mensajes.Aviso("Esta consulta ya está registrada. Use Editar para modificarla o Nuevo para registrar otra.");
                return;
            }

            Consulta c = LeerFormulario();
            string error = Validador.ValidarConsulta(c);
            if (error != "")
            {
                Mensajes.Aviso(error);
                return;
            }

            RepositorioConsultas.Agregar(c);
            CargarLista();
            LimpiarCampos();
            Mensajes.Info("Consulta registrada correctamente.");
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                Mensajes.Aviso("Seleccione una consulta de la lista para editarla.");
                return;
            }

            Consulta c = LeerFormulario();
            string error = Validador.ValidarConsulta(c);
            if (error != "")
            {
                Mensajes.Aviso(error);
                return;
            }

            bool seActualizo = RepositorioConsultas.Actualizar(c);
            if (seActualizo == false)
            {
                Mensajes.Aviso("La consulta ya no existe.");
                return;
            }

            CargarLista();
            LimpiarCampos();
            Mensajes.Info("Consulta actualizada correctamente.");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                Mensajes.Aviso("Seleccione una consulta de la lista para eliminarla.");
                return;
            }
            if (Mensajes.Confirmar("¿Eliminar esta consulta? Se perderán su diagnóstico y tratamiento.") == false)
            {
                return;
            }

            RepositorioConsultas.Eliminar(int.Parse(txtId.Text));
            CargarLista();
            LimpiarCampos();
            Mensajes.Info("Consulta eliminada.");
        }
    }
}
