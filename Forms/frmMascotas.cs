using MundoAnimal.Data;
using MundoAnimal.Models;
using MundoAnimal.Services;
using MundoAnimal.UI;

namespace MundoAnimal.Forms
{
    public partial class frmMascotas : Form
    {
        public frmMascotas()
        {
            InitializeComponent();
        }

        // Vuelve a la pantalla de Inicio (donde está el menú)
        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal principal = (frmPrincipal)this.Parent.FindForm();
            principal.AbrirModulo("Inicio");
        }

        private void frmMascotas_Load(object sender, EventArgs e)
        {
            // El dueño se escoge de la lista de dueños registrados
            foreach (Dueno d in RepositorioDuenos.Todos())
            {
                cmbDueno.Items.Add(d);
            }
            CargarLista();
        }

        private void CargarLista()
        {
            dgvLista.Rows.Clear();
            List<Mascota> lista = RepositorioMascotas.Listar(txtBuscar.Text.Trim());
            foreach (Mascota m in lista)
            {
                dgvLista.Rows.Add(m.Id, m.Nombre, m.Especie, m.Raza, m.Edad, m.Sexo, RepositorioMascotas.NombreDueno(m.DuenoId));
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
            Mascota m = RepositorioMascotas.Buscar(id);
            if (m == null)
            {
                return;
            }

            txtId.Text = m.Id.ToString();
            txtNombre.Text = m.Nombre;
            cmbEspecie.Text = m.Especie;
            txtRaza.Text = m.Raza;
            numEdad.Value = m.Edad;
            cmbSexo.Text = m.Sexo;

            // Selecciona en la lista al dueño de la mascota
            cmbDueno.SelectedIndex = -1;
            for (int i = 0; i < cmbDueno.Items.Count; i++)
            {
                Dueno d = (Dueno)cmbDueno.Items[i];
                if (d.Id == m.DuenoId)
                {
                    cmbDueno.SelectedIndex = i;
                }
            }
        }

        private Mascota LeerFormulario()
        {
            Mascota m = new Mascota();
            if (txtId.Text != "")
            {
                m.Id = int.Parse(txtId.Text);
            }
            m.Nombre = txtNombre.Text.Trim();
            m.Especie = cmbEspecie.Text;
            m.Raza = txtRaza.Text.Trim();
            m.Edad = (int)numEdad.Value;
            m.Sexo = cmbSexo.Text;

            Dueno dueno = cmbDueno.SelectedItem as Dueno;
            if (dueno != null)
            {
                m.DuenoId = dueno.Id;
            }
            return m;
        }

        private void LimpiarCampos()
        {
            txtId.Clear();
            txtNombre.Clear();
            cmbEspecie.SelectedIndex = -1;
            txtRaza.Clear();
            numEdad.Value = 0;
            cmbSexo.SelectedIndex = -1;
            cmbDueno.SelectedIndex = -1;
            dgvLista.ClearSelection();
            txtNombre.Focus();
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
                Mensajes.Aviso("Esta mascota ya está registrada. Use Editar para modificarla o Nuevo para registrar otra.");
                return;
            }

            Mascota m = LeerFormulario();
            string error = Validador.ValidarMascota(m);
            if (error != "")
            {
                Mensajes.Aviso(error);
                return;
            }
            if (RepositorioMascotas.NombreRepetido(m.Nombre, m.DuenoId, 0))
            {
                Mensajes.Aviso("Ese dueño ya tiene una mascota con ese nombre.");
                return;
            }

            RepositorioMascotas.Agregar(m);
            CargarLista();
            LimpiarCampos();
            Mensajes.Info("Mascota registrada correctamente.");
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                Mensajes.Aviso("Seleccione una mascota de la lista para editarla.");
                return;
            }

            Mascota m = LeerFormulario();
            string error = Validador.ValidarMascota(m);
            if (error != "")
            {
                Mensajes.Aviso(error);
                return;
            }
            if (RepositorioMascotas.NombreRepetido(m.Nombre, m.DuenoId, m.Id))
            {
                Mensajes.Aviso("Ese dueño ya tiene otra mascota con ese nombre.");
                return;
            }

            bool seActualizo = RepositorioMascotas.Actualizar(m);
            if (seActualizo == false)
            {
                Mensajes.Aviso("La mascota ya no existe.");
                return;
            }

            CargarLista();
            LimpiarCampos();
            Mensajes.Info("Mascota actualizada correctamente.");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                Mensajes.Aviso("Seleccione una mascota de la lista para eliminarla.");
                return;
            }
            if (Mensajes.Confirmar("¿Eliminar a la mascota " + txtNombre.Text + "?") == false)
            {
                return;
            }

            string error = RepositorioMascotas.Eliminar(int.Parse(txtId.Text));
            if (error != "")
            {
                Mensajes.Aviso(error);
                return;
            }

            CargarLista();
            LimpiarCampos();
            Mensajes.Info("Mascota eliminada.");
        }
    }
}
