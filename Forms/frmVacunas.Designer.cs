namespace MundoAnimal.Forms
{
    partial class frmVacunas
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
            this.lblMascota = new System.Windows.Forms.Label();
            this.cmbMascota = new System.Windows.Forms.ComboBox();
            this.lblVacuna = new System.Windows.Forms.Label();
            this.cmbVacuna = new System.Windows.Forms.ComboBox();
            this.lblLote = new System.Windows.Forms.Label();
            this.txtLote = new System.Windows.Forms.TextBox();
            this.lblAplicacion = new System.Windows.Forms.Label();
            this.dtpAplicacion = new System.Windows.Forms.DateTimePicker();
            this.lblProxima = new System.Windows.Forms.Label();
            this.dtpProxima = new System.Windows.Forms.DateTimePicker();
            this.lblObservacion = new System.Windows.Forms.Label();
            this.txtObservacion = new System.Windows.Forms.TextBox();
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
            this.colListaMascota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colListaVacuna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colListaFechaAplicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colListaProximaDosis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colListaLote = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.lblTitulo.Text = "Vacunas";
            this.lblTitulo.TabIndex = 0;
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(20, 37, 28);
            this.lblSubtitulo.Location = new System.Drawing.Point(26, 62);
            this.lblSubtitulo.Text = "Registro y control del plan de vacunación";
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
            this.pnlDatosInterior.Controls.Add(this.lblMascota);
            this.pnlDatosInterior.Controls.Add(this.cmbMascota);
            this.pnlDatosInterior.Controls.Add(this.lblVacuna);
            this.pnlDatosInterior.Controls.Add(this.cmbVacuna);
            this.pnlDatosInterior.Controls.Add(this.lblLote);
            this.pnlDatosInterior.Controls.Add(this.txtLote);
            this.pnlDatosInterior.Controls.Add(this.lblAplicacion);
            this.pnlDatosInterior.Controls.Add(this.dtpAplicacion);
            this.pnlDatosInterior.Controls.Add(this.lblProxima);
            this.pnlDatosInterior.Controls.Add(this.dtpProxima);
            this.pnlDatosInterior.Controls.Add(this.lblObservacion);
            this.pnlDatosInterior.Controls.Add(this.txtObservacion);
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
            // lblMascota
            // 
            this.lblMascota.Name = "lblMascota";
            this.lblMascota.AutoSize = true;
            this.lblMascota.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMascota.ForeColor = System.Drawing.Color.FromArgb(20, 37, 28);
            this.lblMascota.Location = new System.Drawing.Point(20, 100);
            this.lblMascota.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left;
            this.lblMascota.Text = "Mascota:";
            this.lblMascota.TabIndex = 2;
            // 
            // cmbMascota
            // 
            this.cmbMascota.Name = "cmbMascota";
            this.cmbMascota.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left;
            this.cmbMascota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMascota.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbMascota.FormattingEnabled = true;
            this.cmbMascota.Location = new System.Drawing.Point(140, 96);
            this.cmbMascota.Size = new System.Drawing.Size(340, 29);
            this.cmbMascota.TabIndex = 3;
            // 
            // lblVacuna
            // 
            this.lblVacuna.Name = "lblVacuna";
            this.lblVacuna.AutoSize = true;
            this.lblVacuna.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVacuna.ForeColor = System.Drawing.Color.FromArgb(20, 37, 28);
            this.lblVacuna.Location = new System.Drawing.Point(20, 146);
            this.lblVacuna.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left;
            this.lblVacuna.Text = "Vacuna:";
            this.lblVacuna.TabIndex = 4;
            // 
            // cmbVacuna
            // 
            this.cmbVacuna.Name = "cmbVacuna";
            this.cmbVacuna.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left;
            this.cmbVacuna.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVacuna.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbVacuna.FormattingEnabled = true;
            this.cmbVacuna.Location = new System.Drawing.Point(140, 142);
            this.cmbVacuna.Size = new System.Drawing.Size(340, 29);
            this.cmbVacuna.TabIndex = 5;
            // 
            // lblLote
            // 
            this.lblLote.Name = "lblLote";
            this.lblLote.AutoSize = true;
            this.lblLote.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLote.ForeColor = System.Drawing.Color.FromArgb(20, 37, 28);
            this.lblLote.Location = new System.Drawing.Point(20, 192);
            this.lblLote.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left;
            this.lblLote.Text = "Lote:";
            this.lblLote.TabIndex = 6;
            // 
            // txtLote
            // 
            this.txtLote.Name = "txtLote";
            this.txtLote.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left;
            this.txtLote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLote.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLote.Location = new System.Drawing.Point(140, 188);
            this.txtLote.Size = new System.Drawing.Size(340, 27);
            this.txtLote.TabIndex = 7;
            // 
            // lblAplicacion
            // 
            this.lblAplicacion.Name = "lblAplicacion";
            this.lblAplicacion.AutoSize = true;
            this.lblAplicacion.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAplicacion.ForeColor = System.Drawing.Color.FromArgb(20, 37, 28);
            this.lblAplicacion.Location = new System.Drawing.Point(510, 54);
            this.lblAplicacion.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.lblAplicacion.Text = "Fecha Aplicación:";
            this.lblAplicacion.TabIndex = 8;
            // 
            // dtpAplicacion
            // 
            this.dtpAplicacion.Name = "dtpAplicacion";
            this.dtpAplicacion.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.dtpAplicacion.CustomFormat = "dd/MM/yyyy";
            this.dtpAplicacion.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpAplicacion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAplicacion.Location = new System.Drawing.Point(640, 50);
            this.dtpAplicacion.Size = new System.Drawing.Size(340, 27);
            this.dtpAplicacion.TabIndex = 9;
            // 
            // lblProxima
            // 
            this.lblProxima.Name = "lblProxima";
            this.lblProxima.AutoSize = true;
            this.lblProxima.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProxima.ForeColor = System.Drawing.Color.FromArgb(20, 37, 28);
            this.lblProxima.Location = new System.Drawing.Point(510, 100);
            this.lblProxima.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.lblProxima.Text = "Próxima Dosis:";
            this.lblProxima.TabIndex = 10;
            // 
            // dtpProxima
            // 
            this.dtpProxima.Name = "dtpProxima";
            this.dtpProxima.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.dtpProxima.CustomFormat = "dd/MM/yyyy";
            this.dtpProxima.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpProxima.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpProxima.Location = new System.Drawing.Point(640, 96);
            this.dtpProxima.Size = new System.Drawing.Size(340, 27);
            this.dtpProxima.ShowCheckBox = true;
            this.dtpProxima.TabIndex = 11;
            // 
            // lblObservacion
            // 
            this.lblObservacion.Name = "lblObservacion";
            this.lblObservacion.AutoSize = true;
            this.lblObservacion.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblObservacion.ForeColor = System.Drawing.Color.FromArgb(20, 37, 28);
            this.lblObservacion.Location = new System.Drawing.Point(510, 146);
            this.lblObservacion.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.lblObservacion.Text = "Observación:";
            this.lblObservacion.TabIndex = 12;
            // 
            // txtObservacion
            // 
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.txtObservacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtObservacion.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtObservacion.Location = new System.Drawing.Point(640, 142);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservacion.Size = new System.Drawing.Size(340, 73);
            this.txtObservacion.TabIndex = 13;
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
            this.btnNuevo.TabIndex = 14;
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
            this.btnGuardar.TabIndex = 15;
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
            this.btnEditar.TabIndex = 16;
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
            this.btnEliminar.TabIndex = 17;
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
            this.btnLimpiar.TabIndex = 18;
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
            this.lblTituloDatos.Text = "Datos de la Vacuna";
            this.lblTituloDatos.TabIndex = 19;
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
            this.txtBuscar.PlaceholderText = "Buscar por mascota o vacuna...";
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
            this.dgvLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.colListaID, this.colListaMascota, this.colListaVacuna, this.colListaFechaAplicacion, this.colListaProximaDosis, this.colListaLote });
            this.colListaID.HeaderText = "ID";
            this.colListaID.Name = "colListaID";
            this.colListaMascota.HeaderText = "Mascota";
            this.colListaMascota.Name = "colListaMascota";
            this.colListaVacuna.HeaderText = "Vacuna";
            this.colListaVacuna.Name = "colListaVacuna";
            this.colListaFechaAplicacion.HeaderText = "Fecha Aplicación";
            this.colListaFechaAplicacion.Name = "colListaFechaAplicacion";
            this.colListaProximaDosis.HeaderText = "Próxima Dosis";
            this.colListaProximaDosis.Name = "colListaProximaDosis";
            this.colListaLote.HeaderText = "Lote";
            this.colListaLote.Name = "colListaLote";
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
            this.lblTituloLista.Text = "Lista de Vacunas";
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
            this.Text = "Vacunas";
            this.Name = "frmVacunas";
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.pnlDatos);
            this.Controls.Add(this.pnlLista);
            this.Load += new System.EventHandler(this.frmVacunas_Load);
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
        private System.Windows.Forms.Label lblMascota;
        private System.Windows.Forms.ComboBox cmbMascota;
        private System.Windows.Forms.Label lblVacuna;
        private System.Windows.Forms.ComboBox cmbVacuna;
        private System.Windows.Forms.Label lblLote;
        private System.Windows.Forms.TextBox txtLote;
        private System.Windows.Forms.Label lblAplicacion;
        private System.Windows.Forms.DateTimePicker dtpAplicacion;
        private System.Windows.Forms.Label lblProxima;
        private System.Windows.Forms.DateTimePicker dtpProxima;
        private System.Windows.Forms.Label lblObservacion;
        private System.Windows.Forms.TextBox txtObservacion;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colListaMascota;
        private System.Windows.Forms.DataGridViewTextBoxColumn colListaVacuna;
        private System.Windows.Forms.DataGridViewTextBoxColumn colListaFechaAplicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colListaProximaDosis;
        private System.Windows.Forms.DataGridViewTextBoxColumn colListaLote;
    }
}
