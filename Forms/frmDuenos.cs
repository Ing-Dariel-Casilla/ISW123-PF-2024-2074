using MundoAnimal.Data;
using MundoAnimal.Models;
using MundoAnimal.Services;
using MundoAnimal.UI;

namespace MundoAnimal.Forms
{
    public partial class frmDuenos : Form
    {
        public frmDuenos()
        {
            InitializeComponent();
        }

        // Vuelve a la pantalla de Inicio (donde está el menú)
        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal principal = (frmPrincipal)this.Parent.FindForm();
            principal.AbrirModulo("Inicio");
        }

        private void frmDuenos_Load(object sender, EventArgs e)
        {
            CargarLista();
        }

        // Llena la tabla con los dueños (aplicando lo que se escribió en el buscador)
        private void CargarLista()
        {
            dgvLista.Rows.Clear();
            List<Dueno> lista = RepositorioDuenos.Listar(txtBuscar.Text.Trim());
            foreach (Dueno d in lista)
            {
                dgvLista.Rows.Add(d.Id, d.Nombre, d.Apellido, d.Telefono, d.Correo, d.Direccion);
            }
            dgvLista.ClearSelection();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarLista();
        }

        // Al hacer clic en una fila, sus datos pasan al formulario
        private void dgvLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            int id = int.Parse(dgvLista.Rows[e.RowIndex].Cells[0].Value.ToString());
            Dueno d = RepositorioDuenos.Buscar(id);
            if (d == null)
            {
                return;
            }

            txtId.Text = d.Id.ToString();
            txtNombre.Text = d.Nombre;
            txtApellido.Text = d.Apellido;
            txtTelefono.Text = d.Telefono;
            txtCorreo.Text = d.Correo;
            txtDireccion.Text = d.Direccion;
        }

        // Crea un objeto Dueno con lo que hay escrito en los campos
        private Dueno LeerFormulario()
        {
            Dueno d = new Dueno();
            if (txtId.Text != "")
            {
                d.Id = int.Parse(txtId.Text);
            }
            d.Nombre = txtNombre.Text.Trim();
            d.Apellido = txtApellido.Text.Trim();
            d.Telefono = txtTelefono.Text.Trim();
            d.Correo = txtCorreo.Text.Trim();
            d.Direccion = txtDireccion.Text.Trim();
            return d;
        }

        private void LimpiarCampos()
        {
            txtId.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtDireccion.Clear();
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
                Mensajes.Aviso("Este dueño ya está registrado. Use Editar para modificarlo o Nuevo para registrar otro.");
                return;
            }

            Dueno d = LeerFormulario();
            string error = Validador.ValidarDueno(d);
            if (error != "")
            {
                Mensajes.Aviso(error);
                return;
            }
            if (RepositorioDuenos.TelefonoRepetido(d.Telefono, 0))
            {
                Mensajes.Aviso("Ya existe un dueño registrado con ese teléfono.");
                return;
            }

            RepositorioDuenos.Agregar(d);
            CargarLista();
            LimpiarCampos();
            Mensajes.Info("Dueño registrado correctamente.");
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                Mensajes.Aviso("Seleccione un dueño de la lista para editarlo.");
                return;
            }

            Dueno d = LeerFormulario();
            string error = Validador.ValidarDueno(d);
            if (error != "")
            {
                Mensajes.Aviso(error);
                return;
            }
            if (RepositorioDuenos.TelefonoRepetido(d.Telefono, d.Id))
            {
                Mensajes.Aviso("Ya existe otro dueño registrado con ese teléfono.");
                return;
            }

            bool seActualizo = RepositorioDuenos.Actualizar(d);
            if (seActualizo == false)
            {
                Mensajes.Aviso("El dueño ya no existe.");
                return;
            }

            CargarLista();
            LimpiarCampos();
            Mensajes.Info("Dueño actualizado correctamente.");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                Mensajes.Aviso("Seleccione un dueño de la lista para eliminarlo.");
                return;
            }
            if (Mensajes.Confirmar("¿Eliminar al dueño " + txtNombre.Text + " " + txtApellido.Text + "?") == false)
            {
                return;
            }

            string error = RepositorioDuenos.Eliminar(int.Parse(txtId.Text));
            if (error != "")
            {
                Mensajes.Aviso(error);
                return;
            }

            CargarLista();
            LimpiarCampos();
            Mensajes.Info("Dueño eliminado.");
        }
    }
}
