namespace MundoAnimal.Forms
{
    partial class frmLogin
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlDerecho = new System.Windows.Forms.Panel();
            this.lblTituloLogin = new System.Windows.Forms.Label();
            this.lblSubtituloLogin = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.chkRecordarme = new System.Windows.Forms.CheckBox();
            this.chkMostrar = new System.Windows.Forms.CheckBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lblAviso = new System.Windows.Forms.Label();
            this.pnlIzquierdo = new System.Windows.Forms.Panel();
            this.pnlHuella = new System.Windows.Forms.Panel();
            this.lblMundo = new System.Windows.Forms.Label();
            this.lblAnimal = new System.Windows.Forms.Label();
            this.lblClinica = new System.Windows.Forms.Label();
            this.lblLema = new System.Windows.Forms.Label();
            this.pnlDerecho.SuspendLayout();
            this.pnlIzquierdo.SuspendLayout();
            this.pnlHuella.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDerecho
            // 
            this.pnlDerecho.Name = "pnlDerecho";
            this.pnlDerecho.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            this.pnlDerecho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDerecho.Size = new System.Drawing.Size(580, 620);
            this.pnlDerecho.Controls.Add(this.lblTituloLogin);
            this.pnlDerecho.Controls.Add(this.lblSubtituloLogin);
            this.pnlDerecho.Controls.Add(this.txtUsuario);
            this.pnlDerecho.Controls.Add(this.txtClave);
            this.pnlDerecho.Controls.Add(this.chkRecordarme);
            this.pnlDerecho.Controls.Add(this.chkMostrar);
            this.pnlDerecho.Controls.Add(this.btnIngresar);
            this.pnlDerecho.Controls.Add(this.lblAviso);
            this.pnlDerecho.TabIndex = 0;
            // 
            // lblTituloLogin
            // 
            this.lblTituloLogin.Name = "lblTituloLogin";
            this.lblTituloLogin.AutoSize = false;
            this.lblTituloLogin.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTituloLogin.ForeColor = System.Drawing.Color.FromArgb(0, 77, 43);
            this.lblTituloLogin.Location = new System.Drawing.Point(80, 110);
            this.lblTituloLogin.Size = new System.Drawing.Size(420, 52);
            this.lblTituloLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTituloLogin.Text = "Iniciar Sesión";
            this.lblTituloLogin.TabIndex = 0;
            // 
            // lblSubtituloLogin
            // 
            this.lblSubtituloLogin.Name = "lblSubtituloLogin";
            this.lblSubtituloLogin.AutoSize = false;
            this.lblSubtituloLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSubtituloLogin.ForeColor = System.Drawing.Color.FromArgb(91, 107, 99);
            this.lblSubtituloLogin.Location = new System.Drawing.Point(80, 168);
            this.lblSubtituloLogin.Size = new System.Drawing.Size(420, 28);
            this.lblSubtituloLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSubtituloLogin.Text = "Accede al sistema de gestión veterinaria";
            this.lblSubtituloLogin.TabIndex = 1;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUsuario.Location = new System.Drawing.Point(80, 236);
            this.txtUsuario.PlaceholderText = "Usuario";
            this.txtUsuario.Size = new System.Drawing.Size(420, 31);
            this.txtUsuario.TabIndex = 2;
            // 
            // txtClave
            // 
            this.txtClave.Name = "txtClave";
            this.txtClave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClave.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtClave.Location = new System.Drawing.Point(80, 288);
            this.txtClave.PlaceholderText = "Contraseña";
            this.txtClave.Size = new System.Drawing.Size(420, 31);
            this.txtClave.UseSystemPasswordChar = true;
            this.txtClave.TabIndex = 3;
            // 
            // chkRecordarme
            // 
            this.chkRecordarme.Name = "chkRecordarme";
            this.chkRecordarme.AutoSize = true;
            this.chkRecordarme.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkRecordarme.Location = new System.Drawing.Point(80, 346);
            this.chkRecordarme.Text = "Recordarme";
            this.chkRecordarme.UseVisualStyleBackColor = true;
            this.chkRecordarme.TabIndex = 4;
            // 
            // chkMostrar
            // 
            this.chkMostrar.Name = "chkMostrar";
            this.chkMostrar.AutoSize = true;
            this.chkMostrar.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkMostrar.Location = new System.Drawing.Point(350, 346);
            this.chkMostrar.Text = "Mostrar contraseña";
            this.chkMostrar.UseVisualStyleBackColor = true;
            this.chkMostrar.CheckedChanged += new System.EventHandler(this.chkMostrar_CheckedChanged);
            this.chkMostrar.TabIndex = 5;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(0, 77, 43);
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIngresar.ForeColor = System.Drawing.Color.White;
            this.btnIngresar.Location = new System.Drawing.Point(80, 396);
            this.btnIngresar.Size = new System.Drawing.Size(420, 52);
            this.btnIngresar.Text = "Iniciar Sesión";
            this.btnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.FlatAppearance.BorderSize = 0;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            this.btnIngresar.TabIndex = 6;
            // 
            // lblAviso
            // 
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.AutoSize = false;
            this.lblAviso.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblAviso.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAviso.ForeColor = System.Drawing.Color.FromArgb(122, 91, 0);
            this.lblAviso.Size = new System.Drawing.Size(580, 50);
            this.lblAviso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAviso.Text = "SIN BASE DE DATOS: los datos se pierden al cerrar el programa.\nUsuario inicial: admin     Contraseña: admin1234";
            this.lblAviso.TabIndex = 7;
            // 
            // pnlIzquierdo
            // 
            this.pnlIzquierdo.Name = "pnlIzquierdo";
            this.pnlIzquierdo.BackColor = System.Drawing.Color.FromArgb(0, 77, 43);
            this.pnlIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlIzquierdo.Size = new System.Drawing.Size(380, 620);
            this.pnlIzquierdo.Controls.Add(this.pnlHuella);
            this.pnlIzquierdo.Controls.Add(this.lblMundo);
            this.pnlIzquierdo.Controls.Add(this.lblAnimal);
            this.pnlIzquierdo.Controls.Add(this.lblClinica);
            this.pnlIzquierdo.Controls.Add(this.lblLema);
            this.pnlIzquierdo.TabIndex = 1;
            // 
            // pnlHuella
            // 
            this.pnlHuella.Name = "pnlHuella";
            this.pnlHuella.BackColor = System.Drawing.Color.FromArgb(0, 77, 43);
            this.pnlHuella.Location = new System.Drawing.Point(144, 150);
            this.pnlHuella.Size = new System.Drawing.Size(92, 92);
            this.pnlHuella.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlHuella_Paint);
            this.pnlHuella.TabIndex = 0;
            // 
            // lblMundo
            // 
            this.lblMundo.Name = "lblMundo";
            this.lblMundo.AutoSize = true;
            this.lblMundo.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMundo.ForeColor = System.Drawing.Color.White;
            this.lblMundo.Location = new System.Drawing.Point(62, 262);
            this.lblMundo.Text = "Mundo";
            this.lblMundo.TabIndex = 1;
            // 
            // lblAnimal
            // 
            this.lblAnimal.Name = "lblAnimal";
            this.lblAnimal.AutoSize = true;
            this.lblAnimal.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAnimal.ForeColor = System.Drawing.Color.FromArgb(61, 220, 151);
            this.lblAnimal.Location = new System.Drawing.Point(190, 262);
            this.lblAnimal.Text = " Animal";
            this.lblAnimal.TabIndex = 2;
            // 
            // lblClinica
            // 
            this.lblClinica.Name = "lblClinica";
            this.lblClinica.AutoSize = false;
            this.lblClinica.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblClinica.ForeColor = System.Drawing.Color.White;
            this.lblClinica.Location = new System.Drawing.Point(0, 322);
            this.lblClinica.Size = new System.Drawing.Size(380, 28);
            this.lblClinica.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblClinica.Text = "CLÍNICA VETERINARIA";
            this.lblClinica.TabIndex = 3;
            // 
            // lblLema
            // 
            this.lblLema.Name = "lblLema";
            this.lblLema.AutoSize = false;
            this.lblLema.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblLema.ForeColor = System.Drawing.Color.White;
            this.lblLema.Location = new System.Drawing.Point(60, 384);
            this.lblLema.Size = new System.Drawing.Size(260, 60);
            this.lblLema.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLema.Text = "Cuidamos la salud de tus mascotas";
            this.lblLema.TabIndex = 4;
            // 
            // this
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(960, 620);
            this.Text = "Mundo Animal - Clínica Veterinaria";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "frmLogin";
            this.AcceptButton = this.btnIngresar;
            this.Controls.Add(this.pnlDerecho);
            this.Controls.Add(this.pnlIzquierdo);
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.pnlDerecho.ResumeLayout(false);
            this.pnlIzquierdo.ResumeLayout(false);
            this.pnlHuella.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlDerecho;
        private System.Windows.Forms.Label lblTituloLogin;
        private System.Windows.Forms.Label lblSubtituloLogin;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.CheckBox chkRecordarme;
        private System.Windows.Forms.CheckBox chkMostrar;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label lblAviso;
        private System.Windows.Forms.Panel pnlIzquierdo;
        private System.Windows.Forms.Panel pnlHuella;
        private System.Windows.Forms.Label lblMundo;
        private System.Windows.Forms.Label lblAnimal;
        private System.Windows.Forms.Label lblClinica;
        private System.Windows.Forms.Label lblLema;
    }
}
