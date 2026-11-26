using MundoAnimal.Data;
using MundoAnimal.Models;
using MundoAnimal.Services;
using MundoAnimal.UI;

namespace MundoAnimal.Forms
{
    public partial class frmVacunas : Form
    {
        public frmVacunas()
        {
            InitializeComponent();
        }

        // Vuelve a la pantalla de Inicio (donde está el menú)
        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal principal = (frmPrincipal)this.Parent.FindForm();
            principal.AbrirModulo("Inicio");
        }

        private void frmVacunas_Load(object sender, EventArgs e)
        {
            foreach (Mascota m in RepositorioMascotas.Todas())
            {
                cmbMascota.Items.Add(m);
            }
            foreach (Vacuna v in RepositorioVacunas.Catalogo())
            {
                cmbVacuna.Items.Add(v);
            }
            PonerFechasIniciales();
            CargarLista();
        }

        // Fechas que aparecen al empezar un registro nuevo (el usuario las puede cambiar)
        private void PonerFechasIniciales()
        {
            dtpAplicacion.Value = DateTime.Today;
            dtpProxima.Value = DateTime.Today.AddMonths(1);
            dtpProxima.Checked = true;
        }

        private void CargarLista()
        {
            dgvLista.Rows.Clear();
            List<RegistroVacuna> lista = RepositorioVacunas.Listar(txtBuscar.Text.Trim());
            foreach (RegistroVacuna r in lista)
            {
                string mascota = "";
                Mascota m = RepositorioMascotas.Buscar(r.MascotaId);
                if (m != null)
                {
                    mascota = m.Nombre;
                }

                string proxima = "";
                if (r.TieneProximaDosis)
                {
                    proxima = r.ProximaDosis.ToString("dd/MM/yyyy");
                }

                dgvLista.Rows.Add(r.Id, mascota, RepositorioVacunas.NombreVacuna(r.VacunaId),
                                  r.FechaAplicacion.ToString("dd/MM/yyyy"), proxima, r.Lote);
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
            RegistroVacuna r = RepositorioVacunas.Buscar(id);
            if (r == null)
            {
                return;
            }

            txtId.Text = r.Id.ToString();
            txtLote.Text = r.Lote;
            dtpAplicacion.Value = r.FechaAplicacion;
            if (r.TieneProximaDosis)
            {
                dtpProxima.Value = r.ProximaDosis;
                dtpProxima.Checked = true;
            }
            else
            {
                dtpProxima.Checked = false;
            }
            txtObservacion.Text = r.Observacion;

            cmbMascota.SelectedIndex = -1;
            for (int i = 0; i < cmbMascota.Items.Count; i++)
            {
                Mascota m = (Mascota)cmbMascota.Items[i];
                if (m.Id == r.MascotaId)
                {
                    cmbMascota.SelectedIndex = i;
                }
            }

            cmbVacuna.SelectedIndex = -1;
            for (int i = 0; i < cmbVacuna.Items.Count; i++)
            {
                Vacuna v = (Vacuna)cmbVacuna.Items[i];
                if (v.Id == r.VacunaId)
                {
                    cmbVacuna.SelectedIndex = i;
                }
            }
        }

        private RegistroVacuna LeerFormulario()
        {
            RegistroVacuna r = new RegistroVacuna();
            if (txtId.Text != "")
            {
                r.Id = int.Parse(txtId.Text);
            }

            Mascota mascota = cmbMascota.SelectedItem as Mascota;
            if (mascota != null)
            {
                r.MascotaId = mascota.Id;
            }

            Vacuna vacuna = cmbVacuna.SelectedItem as Vacuna;
            if (vacuna != null)
            {
                r.VacunaId = vacuna.Id;
            }

            r.Lote = txtLote.Text.Trim();
            r.FechaAplicacion = dtpAplicacion.Value.Date;
            r.TieneProximaDosis = dtpProxima.Checked;
            r.ProximaDosis = dtpProxima.Value.Date;
            r.Observacion = txtObservacion.Text.Trim();
            return r;
        }

        private void LimpiarCampos()
        {
            txtId.Clear();
            cmbMascota.SelectedIndex = -1;
            cmbVacuna.SelectedIndex = -1;
            txtLote.Clear();
            txtObservacion.Clear();
            PonerFechasIniciales();
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
                Mensajes.Aviso("Esta aplicación ya está registrada. Use Editar para modificarla o Nuevo para registrar otra.");
                return;
            }

            RegistroVacuna r = LeerFormulario();
            string error = Validador.ValidarRegistroVacuna(r);
            if (error != "")
            {
                Mensajes.Aviso(error);
                return;
            }

            RepositorioVacunas.Agregar(r);
            CargarLista();
            LimpiarCampos();
            Mensajes.Info("Vacuna registrada correctamente.");
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                Mensajes.Aviso("Seleccione un registro de la lista para editarlo.");
                return;
            }

            RegistroVacuna r = LeerFormulario();
            string error = Validador.ValidarRegistroVacuna(r);
            if (error != "")
            {
                Mensajes.Aviso(error);
                return;
            }

            bool seActualizo = RepositorioVacunas.Actualizar(r);
            if (seActualizo == false)
            {
                Mensajes.Aviso("El registro ya no existe.");
                return;
            }

            CargarLista();
            LimpiarCampos();
            Mensajes.Info("Registro de vacuna actualizado correctamente.");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                Mensajes.Aviso("Seleccione un registro de la lista para eliminarlo.");
                return;
            }
            if (Mensajes.Confirmar("¿Eliminar este registro de vacunación? Se quitará del historial de la mascota.") == false)
            {
                return;
            }

            RepositorioVacunas.Eliminar(int.Parse(txtId.Text));
            CargarLista();
            LimpiarCampos();
            Mensajes.Info("Registro de vacuna eliminado.");
        }
    }
}
