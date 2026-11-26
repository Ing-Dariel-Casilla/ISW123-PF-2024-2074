using MundoAnimal.Data;
using MundoAnimal.Models;
using MundoAnimal.Services;
using MundoAnimal.UI;

namespace MundoAnimal.Forms
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        // Vuelve a la pantalla de Inicio (donde está el menú)
        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal principal = (frmPrincipal)this.Parent.FindForm();
            principal.AbrirModulo("Inicio");
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            // Esta pantalla es solo para el administrador
            if (Sesion.EsAdministrador() == false)
            {
                Mensajes.Aviso("Solo un administrador puede gestionar usuarios.");
                pnlDatos.Enabled = false;
                pnlLista.Enabled = false;
                return;
            }

            txtClave.PlaceholderText = "Vacía = no cambiarla";
            cmbEstado.SelectedIndex = 0;   // Activo
            CargarLista();
        }

        private void CargarLista()
        {
            dgvLista.Rows.Clear();
            List<Usuario> lista = RepositorioUsuarios.Listar(txtBuscar.Text.Trim());
            foreach (Usuario u in lista)
            {
                string estado = "Inactivo";
                if (u.Activo)
                {
                    estado = "Activo";
                }
                dgvLista.Rows.Add(u.Id, u.Nombre, u.Apellido, u.NombreUsuario, u.Rol, estado);
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
            Usuario u = RepositorioUsuarios.Buscar(id);
            if (u == null)
            {
                return;
            }

            txtId.Text = u.Id.ToString();
            txtNombre.Text = u.Nombre;
            txtApellido.Text = u.Apellido;
            txtUsuario.Text = u.NombreUsuario;
            txtClave.Clear();   // la contraseña nunca se muestra
            cmbRol.Text = u.Rol;
            if (u.Activo)
            {
                cmbEstado.Text = "Activo";
            }
            else
            {
                cmbEstado.Text = "Inactivo";
            }
        }

        private Usuario LeerFormulario()
        {
            Usuario u = new Usuario();
            if (txtId.Text != "")
            {
                u.Id = int.Parse(txtId.Text);
            }
            u.Nombre = txtNombre.Text.Trim();
            u.Apellido = txtApellido.Text.Trim();
            u.NombreUsuario = txtUsuario.Text.Trim();
            u.Rol = cmbRol.Text;
            u.Activo = (cmbEstado.Text != "Inactivo");
            return u;
        }

        private void LimpiarCampos()
        {
            txtId.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtUsuario.Clear();
            txtClave.Clear();
            cmbRol.SelectedIndex = -1;
            cmbEstado.SelectedIndex = 0;   // Activo por defecto
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

        // Guardar agrega un usuario nuevo (se pueden agregar todos los que se quiera)
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                Mensajes.Aviso("Este usuario ya está registrado. Use Editar para modificarlo o Nuevo para crear otro.");
                return;
            }

            Usuario u = LeerFormulario();
            string error = Validador.ValidarUsuario(u, txtClave.Text, true);
            if (error != "")
            {
                Mensajes.Aviso(error);
                return;
            }
            if (RepositorioUsuarios.NombreUsuarioRepetido(u.NombreUsuario, 0))
            {
                Mensajes.Aviso("Ya existe un usuario con ese nombre de usuario.");
                return;
            }

            RepositorioUsuarios.Agregar(u, txtClave.Text);
            CargarLista();
            LimpiarCampos();
            Mensajes.Info("Usuario creado correctamente.");
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                Mensajes.Aviso("Seleccione un usuario de la lista para editarlo.");
                return;
            }

            Usuario u = LeerFormulario();
            string error = Validador.ValidarUsuario(u, txtClave.Text, false);
            if (error != "")
            {
                Mensajes.Aviso(error);
                return;
            }
            if (RepositorioUsuarios.NombreUsuarioRepetido(u.NombreUsuario, u.Id))
            {
                Mensajes.Aviso("Ya existe otro usuario con ese nombre de usuario.");
                return;
            }

            Usuario actual = RepositorioUsuarios.Buscar(u.Id);
            if (actual == null)
            {
                Mensajes.Aviso("El usuario ya no existe.");
                return;
            }

            // Siempre debe quedar al menos un administrador activo
            bool eraAdminActivo = (actual.Rol == "Administrador" && actual.Activo);
            bool seguiraAdminActivo = (u.Rol == "Administrador" && u.Activo);
            if (eraAdminActivo && seguiraAdminActivo == false)
            {
                if (u.Id == Sesion.Actual.Id)
                {
                    Mensajes.Aviso("No puede quitarse a sí mismo el rol de administrador ni desactivar su propio usuario.");
                    return;
                }
                if (RepositorioUsuarios.ContarAdministradoresActivos(u.Id) == 0)
                {
                    Mensajes.Aviso("Debe existir al menos un administrador activo.");
                    return;
                }
            }

            RepositorioUsuarios.Actualizar(u, txtClave.Text);
            CargarLista();
            LimpiarCampos();
            Mensajes.Info("Usuario actualizado correctamente.");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                Mensajes.Aviso("Seleccione un usuario de la lista para eliminarlo.");
                return;
            }

            int id = int.Parse(txtId.Text);
            if (id == Sesion.Actual.Id)
            {
                Mensajes.Aviso("No puede eliminar su propio usuario.");
                return;
            }
            if (Mensajes.Confirmar("¿Eliminar al usuario " + txtUsuario.Text + "?") == false)
            {
                return;
            }

            Usuario actual = RepositorioUsuarios.Buscar(id);
            if (actual != null && actual.Rol == "Administrador" && actual.Activo)
            {
                if (RepositorioUsuarios.ContarAdministradoresActivos(id) == 0)
                {
                    Mensajes.Aviso("Debe existir al menos un administrador activo.");
                    return;
                }
            }

            string errorEliminar = RepositorioUsuarios.Eliminar(id);
            if (errorEliminar != "")
            {
                Mensajes.Aviso(errorEliminar);
                return;
            }

            CargarLista();
            LimpiarCampos();
            Mensajes.Info("Usuario eliminado.");
        }
    }
}
