using System.Drawing.Drawing2D;
using MundoAnimal.Data;
using MundoAnimal.Models;
using MundoAnimal.Services;
using MundoAnimal.UI;

namespace MundoAnimal.Forms
{
    public partial class frmLogin : Form
    {
        // Archivo donde se recuerda el nombre de usuario (nunca la contraseña)
        private string archivoUsuario = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "MundoAnimal", "usuario.txt");

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            // Centra "Mundo Animal" (son dos etiquetas de distinto color)
            int ancho = lblMundo.Width + lblAnimal.Width;
            lblMundo.Left = (pnlIzquierdo.Width - ancho) / 2;
            lblAnimal.Left = lblMundo.Right;

            // Si el usuario marcó "Recordarme" antes, se vuelve a escribir su nombre
            try
            {
                if (File.Exists(archivoUsuario))
                {
                    txtUsuario.Text = File.ReadAllText(archivoUsuario).Trim();
                    if (txtUsuario.Text != "")
                    {
                        chkRecordarme.Checked = true;
                    }
                }
            }
            catch
            {
                // si no se puede leer el archivo, no pasa nada
            }
        }

        // Dibuja la huella de la mascota
        private void pnlHuella_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            SolidBrush pincel = new SolidBrush(Color.White);
            e.Graphics.FillEllipse(pincel, 24, 46, 44, 38);
            e.Graphics.FillEllipse(pincel, 6, 34, 18, 22);
            e.Graphics.FillEllipse(pincel, 26, 12, 18, 24);
            e.Graphics.FillEllipse(pincel, 48, 12, 18, 24);
            e.Graphics.FillEllipse(pincel, 68, 34, 18, 22);
            pincel.Dispose();
        }

        private void chkMostrar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMostrar.Checked)
            {
                txtClave.UseSystemPasswordChar = false;   // se ve la contraseña
            }
            else
            {
                txtClave.UseSystemPasswordChar = true;    // se ocultan los caracteres
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Trim() == "")
            {
                Mensajes.Aviso("Ingrese el usuario.");
                txtUsuario.Focus();
                return;
            }
            if (txtClave.Text == "")
            {
                Mensajes.Aviso("Ingrese la contraseña.");
                txtClave.Focus();
                return;
            }

            Usuario usuario = RepositorioUsuarios.BuscarPorNombre(txtUsuario.Text.Trim());
            if (usuario == null || RepositorioUsuarios.ClaveCorrecta(usuario, txtClave.Text) == false)
            {
                Mensajes.Aviso("Usuario o contraseña incorrectos.");
                txtClave.Clear();
                txtClave.Focus();
                return;
            }
            if (usuario.Activo == false)
            {
                Mensajes.Aviso("El usuario está inactivo. Contacte al administrador.");
                return;
            }

            Sesion.Actual = usuario;
            GuardarUsuarioRecordado();
            DialogResult = DialogResult.OK;   // cierra el login y abre la ventana principal
        }

        private void GuardarUsuarioRecordado()
        {
            try
            {
                if (chkRecordarme.Checked)
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(archivoUsuario));
                    File.WriteAllText(archivoUsuario, txtUsuario.Text.Trim());
                }
                else if (File.Exists(archivoUsuario))
                {
                    File.Delete(archivoUsuario);
                }
            }
            catch
            {
                // si no se puede guardar, no pasa nada
            }
        }
    }
}
