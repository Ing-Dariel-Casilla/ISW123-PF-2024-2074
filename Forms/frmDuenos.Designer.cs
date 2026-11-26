namespace MundoAnimal.Forms
{
    partial class frmDuenos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.pnlDatos = new System.Windows.Forms.Panel();
            this.pnlDatosInterior = new System.Windows.Forms.Panel();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblTituloDatos = new System.Windows.Forms.Label();
            this.pnlLista = new System.Windows.Forms.Panel();
            this.pnlListaInterior = new System.Windows.Forms.Panel();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.lblTituloLista = new System.Windows.Forms.Label();
            this.colListaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colListaNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colListaApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colListaTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colListaCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colListaDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.pnlDatos.SuspendLayout();
            this.pnlDatosInterior.SuspendLayout();
            this.pnlLista.SuspendLayout();
            this.pnlListaInterior.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(0, 77, 43);
            this.lblTitulo.Location = new System.Drawing.Point(24, 10);
            this.lblTitulo.Text = "Dueños";
            this.lblTitulo.TabIndex = 0;
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(20, 37, 28);
            this.lblSubtitulo.Location = new System.Drawing.Point(26, 62);
            this.lblSubtitulo.Text = "Gestiona el registro de los propietarios de las mascotas";
            this.lblSubtitulo.TabIndex = 1;
            // 
            // pnlDatos
            // 
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.BackColor = System.Drawing.Color.FromArgb(0, 140, 69);
            this.pnlDatos.Location = new System.Drawing.Point(24, 100);
            this.pnlDatos.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.pnlDatos.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.pnlDatos.Size = new System.Drawing.Size(1002, 290);
            this.pnlDatos.Controls.Add(this.pnlDatosInterior);
            this.pnlDatos.TabIndex = 2;
            // 
            // pnlDatosInterior
            // 
            this.pnlDatosInterior.Name = "pnlDatosInterior";
            this.pnlDatosInterior.BackColor = System.Drawing.Color.White;
            this.pnlDatosInterior.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDatosInterior.Size = new System.Drawing.Size(1000, 288);
            this.pnlDatosInterior.Controls.Add(this.lblId);
            this.pnlDatosInterior.Controls.Add(this.txtId);
            this.pnlDatosInterior.Controls.Add(this.lblNombre);
            this.pnlDatosInterior.Controls.Add(this.txtNombre);
            this.pnlDatosInterior.Controls.Add(this.lblApellido);
            this.pnlDatosInterior.Controls.Add(this.txtApellido);
            this.pnlDatosInterior.Controls.Add(this.lblTelefono);
            this.pnlDatosInterior.Controls.Add(this.txtTelefono);
            this.pnlDatosInterior.Controls.Add(this.lblCorreo);
            this.pnlDatosInterior.Controls.Add(this.txtCorreo);
            this.pnlDatosInterior.Controls.Add(this.lblDireccion);
            this.pnlDatosInterior.Controls.Add(this.txtDireccion);
            this.pnlDatosInterior.Controls.Add(this.btnNuevo);
            this.pnlDatosInterior.Controls.Add(this.btnGuardar);
            this.pnlDatosInterior.Controls.Add(this.btnEditar);
            this.pnlDatosInterior.Controls.Add(this.btnEliminar);
            this.pnlDatosInterior.Controls.Add(this.btnLimpiar);
            this.pnlDatosInterior.Controls.Add(this.lblTituloDatos);
            this.pnlDatosInterior.TabIndex = 0;
            // 
            // lblId
            // 
            this.lblId.Name = "lblId";
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblId.ForeColor = System.Drawing.Color.FromArgb(20, 37, 28);
            this.lblId.Location = new System.Drawing.Point(20, 54);
            this.lblId.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left;
            this.lblId.Text = "ID:";
            this.lblId.TabIndex = 0;
            // 
            // txtId
            // 
            this.txtId.Name = "txtId";
            this.txtId.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left;
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtId.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtId.Location = new System.Drawing.Point(140, 50);
            this.txtId.Size = new System.Drawing.Size(120, 27);
            this.txtId.ReadOnly = true;
            this.txtId.BackColor = System.Drawing.Color.FromArgb(217, 224, 228);
            this.txtId.TabStop = false;
            this.txtId.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(20, 37, 28);
            this.lblNombre.Location = new System.Drawing.Point(20, 100);
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left;
            this.lblNombre.Text = "Nombre:";
            this.lblNombre.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombre.Location = new System.Drawing.Point(140, 96);
            this.txtNombre.Size = new System.Drawing.Size(340, 27);
            this.txtNombre.TabIndex = 3;
            // 
            // lblApellido
            // 
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblApellido.ForeColor = System.Drawing.Color.FromArgb(20, 37, 28);
            this.lblApellido.Location = new System.Drawing.Point(20, 146);
            this.lblApellido.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left;
            this.lblApellido.Text = "Apellido:";
            this.lblApellido.TabIndex = 4;
            // 
            // txtApellido
            // 
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left;
            this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApellido.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtApellido.Location = new System.Drawing.Point(140, 142);
            this.txtApellido.Size = new System.Drawing.Size(340, 27);
            this.txtApellido.TabIndex = 5;
            // 
            // lblTelefono
            // 
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTelefono.ForeColor = System.Drawing.Color.FromArgb(20, 37, 28);
            this.lblTelefono.Location = new System.Drawing.Point(20, 192);
            this.lblTelefono.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left;
            this.lblTelefono.Text = "Teléfono:";
            this.lblTelefono.TabIndex = 6;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left;
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefono.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTelefono.Location = new System.Drawing.Point(140, 188);
            this.txtTelefono.Size = new System.Drawing.Size(340, 27);
            this.txtTelefono.TabIndex = 7;
            // 
            // lblCorreo
            // 
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCorreo.ForeColor = System.Drawing.Color.FromArgb(20, 37, 28);
            this.lblCorreo.Location = new System.Drawing.Point(510, 54);
            this.lblCorreo.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.lblCorreo.Text = "Correo:";
            this.lblCorreo.TabIndex = 8;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCorreo.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCorreo.Location = new System.Drawing.Point(640, 50);
            this.txtCorreo.Size = new System.Drawing.Size(340, 27);
            this.txtCorreo.TabIndex = 9;
            // 
            // lblDireccion
            // 
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDireccion.ForeColor = System.Drawing.Color.FromArgb(20, 37, 28);
            this.lblDireccion.Location = new System.Drawing.Point(510, 100);
            this.lblDireccion.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.lblDireccion.Text = "Dirección:";
            this.lblDireccion.TabIndex = 10;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDireccion.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDireccion.Location = new System.Drawing.Point(640, 96);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDireccion.Size = new System.Drawing.Size(340, 73);
            this.txtDireccion.TabIndex = 11;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(0, 77, 43);
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Location = new System.Drawing.Point(416, 234);
            this.btnNuevo.Size = new System.Drawing.Size(110, 40);
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            this.btnNuevo.TabIndex = 12;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(0, 140, 69);
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(532, 234);
            this.btnGuardar.Size = new System.Drawing.Size(110, 40);
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            this.btnGuardar.TabIndex = 13;
            // 
            // btnEditar
            // 
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(0, 140, 69);
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(648, 234);
            this.btnEditar.Size = new System.Drawing.Size(110, 40);
            this.btnEditar.Text = "Editar";
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            this.btnEditar.TabIndex = 14;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(0, 140, 69);
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(764, 234);
            this.btnEliminar.Size = new System.Drawing.Size(110, 40);
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            this.btnEliminar.TabIndex = 15;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(0, 140, 69);
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(880, 234);
            this.btnLimpiar.Size = new System.Drawing.Size(110, 40);
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            this.btnLimpiar.TabIndex = 16;
            // 
            // lblTituloDatos
            // 
            this.lblTituloDatos.Name = "lblTituloDatos";
            this.lblTituloDatos.AutoSize = false;
            this.lblTituloDatos.BackColor = System.Drawing.Color.FromArgb(201, 242, 211);
            this.lblTituloDatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTituloDatos.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTituloDatos.ForeColor = System.Drawing.Color.FromArgb(0, 77, 43);
            this.lblTituloDatos.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.lblTituloDatos.Size = new System.Drawing.Size(1000, 38);
            this.lblTituloDatos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTituloDatos.Text = "Datos del Dueño";
            this.lblTituloDatos.TabIndex = 17;
            // 
            // pnlLista
            // 
            this.pnlLista.Name = "pnlLista";
            this.pnlLista.BackColor = System.Drawing.Color.FromArgb(0, 140, 69);
            this.pnlLista.Location = new System.Drawing.Point(24, 406);
            this.pnlLista.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.pnlLista.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.pnlLista.Size = new System.Drawing.Size(1002, 314);
            this.pnlLista.Controls.Add(this.pnlListaInterior);
            this.pnlLista.TabIndex = 3;
            // 
            // pnlListaInterior
            // 
            this.pnlListaInterior.Name = "pnlListaInterior";
            this.pnlListaInterior.BackColor = System.Drawing.Color.White;
            this.pnlListaInterior.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlListaInterior.Size = new System.Drawing.Size(1000, 312);
            this.pnlListaInterior.Controls.Add(this.lblBuscar);
            this.pnlListaInterior.Controls.Add(this.txtBuscar);
            this.pnlListaInterior.Controls.Add(this.dgvLista);
            this.pnlListaInterior.Controls.Add(this.lblTituloLista);
            this.pnlListaInterior.TabIndex = 0;
            // 
            // lblBuscar
            // 
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBuscar.ForeColor = System.Drawing.Color.FromArgb(20, 37, 28);
            this.lblBuscar.Location = new System.Drawing.Point(12, 53);
            this.lblBuscar.Text = "Buscar:";
            this.lblBuscar.TabIndex = 0;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left;
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBuscar.Location = new System.Drawing.Point(80, 50);
            this.txtBuscar.PlaceholderText = "Buscar por nombre, apellido o teléfono...";
            this.txtBuscar.Size = new System.Drawing.Size(480, 27);
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            this.txtBuscar.TabIndex = 1;
            // 
            // dgvLista
            // 
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.AllowUserToAddRows = false;
            this.dgvLista.AllowUserToDeleteRows = false;
            this.dgvLista.AllowUserToResizeRows = false;
            this.dgvLista.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.dgvLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLista.BackgroundColor = System.Drawing.Color.White;
            this.dgvLista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLista.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvLista.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvLista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLista.ColumnHeadersHeight = 38;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvLista.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLista.EnableHeadersVisualStyles = false;
            this.dgvLista.GridColor = System.Drawing.Color.FromArgb(217, 224, 228);
            this.dgvLista.Location = new System.Drawing.Point(10, 88);
            this.dgvLista.MultiSelect = false;
            this.dgvLista.ReadOnly = true;
            this.dgvLista.RowHeadersVisible = false;
            this.dgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLista.Size = new System.Drawing.Size(980, 214);
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(201, 242, 211);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(20, 37, 28);
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(201, 242, 211);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(20, 37, 28);
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(20, 37, 28);
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(201, 242, 211);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(20, 37, 28);
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLista.RowTemplate.Height = 34;
            this.dgvLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.colListaID, this.colListaNombre, this.colListaApellido, this.colListaTelefono, this.colListaCorreo, this.colListaDireccion });
            this.colListaID.HeaderText = "ID";
            this.colListaID.Name = "colListaID";
            this.colListaNombre.HeaderText = "Nombre";
            this.colListaNombre.Name = "colListaNombre";
            this.colListaApellido.HeaderText = "Apellido";
            this.colListaApellido.Name = "colListaApellido";
            this.colListaTelefono.HeaderText = "Teléfono";
            this.colListaTelefono.Name = "colListaTelefono";
            this.colListaCorreo.HeaderText = "Correo";
            this.colListaCorreo.Name = "colListaCorreo";
            this.colListaDireccion.HeaderText = "Dirección";
            this.colListaDireccion.Name = "colListaDireccion";
            this.dgvLista.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLista_CellClick);
            this.dgvLista.TabIndex = 2;
            // 
            // lblTituloLista
            // 
            this.lblTituloLista.Name = "lblTituloLista";
            this.lblTituloLista.AutoSize = false;
            this.lblTituloLista.BackColor = System.Drawing.Color.FromArgb(0, 77, 43);
            this.lblTituloLista.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTituloLista.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTituloLista.ForeColor = System.Drawing.Color.White;
            this.lblTituloLista.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.lblTituloLista.Size = new System.Drawing.Size(1000, 38);
            this.lblTituloLista.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTituloLista.Text = "Lista de Dueños";
            this.lblTituloLista.TabIndex = 3;
            // 
            // btnVolver
            // 
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(0, 77, 43);
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(856, 22);
            this.btnVolver.Size = new System.Drawing.Size(170, 40);
            this.btnVolver.Text = "Volver al Inicio";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            this.btnVolver.TabIndex = 9;
            // 
            // this
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1050, 740);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Text = "Dueños";
            this.Name = "frmDuenos";
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.pnlDatos);
            this.Controls.Add(this.pnlLista);
            this.Load += new System.EventHandler(this.frmDuenos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.pnlDatos.ResumeLayout(false);
            this.pnlDatosInterior.ResumeLayout(false);
            this.pnlLista.ResumeLayout(false);
            this.pnlListaInterior.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Panel pnlDatos;
        private System.Windows.Forms.Panel pnlDatosInterior;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblTituloDatos;
        private System.Windows.Forms.Panel pnlLista;
        private System.Windows.Forms.Panel pnlListaInterior;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.Label lblTituloLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn colListaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colListaNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colListaApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colListaTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn colListaCorreo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colListaDireccion;
    }
}
