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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            btnVolver = new Button();
            pnlDatos = new Panel();
            pnlDatosInterior = new Panel();
            btnAgregarVacuna = new Button();
            lblId = new Label();
            txtId = new TextBox();
            lblMascota = new Label();
            cmbMascota = new ComboBox();
            lblVacuna = new Label();
            cmbVacuna = new ComboBox();
            lblLote = new Label();
            txtLote = new TextBox();
            lblAplicacion = new Label();
            dtpAplicacion = new DateTimePicker();
            lblProxima = new Label();
            dtpProxima = new DateTimePicker();
            lblObservacion = new Label();
            txtObservacion = new TextBox();
            btnNuevo = new Button();
            btnGuardar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            lblTituloDatos = new Label();
            pnlLista = new Panel();
            pnlListaInterior = new Panel();
            lblBuscar = new Label();
            txtBuscar = new TextBox();
            dgvLista = new DataGridView();
            colListaID = new DataGridViewTextBoxColumn();
            colListaMascota = new DataGridViewTextBoxColumn();
            colListaVacuna = new DataGridViewTextBoxColumn();
            colListaFechaAplicacion = new DataGridViewTextBoxColumn();
            colListaProximaDosis = new DataGridViewTextBoxColumn();
            colListaLote = new DataGridViewTextBoxColumn();
            lblTituloLista = new Label();
            pnlDatos.SuspendLayout();
            pnlDatosInterior.SuspendLayout();
            pnlLista.SuspendLayout();
            pnlListaInterior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLista).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(0, 77, 43);
            lblTitulo.Location = new Point(34, 17);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(227, 70);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Vacunas";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 12F);
            lblSubtitulo.ForeColor = Color.FromArgb(20, 37, 28);
            lblSubtitulo.Location = new Point(37, 103);
            lblSubtitulo.Margin = new Padding(4, 0, 4, 0);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(455, 32);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Registro y control del plan de vacunación";
            // 
            // btnVolver
            // 
            btnVolver.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnVolver.BackColor = Color.FromArgb(0, 77, 43);
            btnVolver.Cursor = Cursors.Hand;
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btnVolver.ForeColor = Color.White;
            btnVolver.Location = new Point(1223, 37);
            btnVolver.Margin = new Padding(4, 5, 4, 5);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(243, 67);
            btnVolver.TabIndex = 9;
            btnVolver.Text = "Volver al Inicio";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // pnlDatos
            // 
            pnlDatos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlDatos.BackColor = Color.FromArgb(0, 140, 69);
            pnlDatos.Controls.Add(pnlDatosInterior);
            pnlDatos.Location = new Point(34, 167);
            pnlDatos.Margin = new Padding(4, 5, 4, 5);
            pnlDatos.Name = "pnlDatos";
            pnlDatos.Padding = new Padding(1, 2, 1, 2);
            pnlDatos.Size = new Size(1431, 483);
            pnlDatos.TabIndex = 2;
            // 
            // pnlDatosInterior
            // 
            pnlDatosInterior.BackColor = Color.White;
            pnlDatosInterior.Controls.Add(btnAgregarVacuna);
            pnlDatosInterior.Controls.Add(lblId);
            pnlDatosInterior.Controls.Add(txtId);
            pnlDatosInterior.Controls.Add(lblMascota);
            pnlDatosInterior.Controls.Add(cmbMascota);
            pnlDatosInterior.Controls.Add(lblVacuna);
            pnlDatosInterior.Controls.Add(cmbVacuna);
            pnlDatosInterior.Controls.Add(lblLote);
            pnlDatosInterior.Controls.Add(txtLote);
            pnlDatosInterior.Controls.Add(lblAplicacion);
            pnlDatosInterior.Controls.Add(dtpAplicacion);
            pnlDatosInterior.Controls.Add(lblProxima);
            pnlDatosInterior.Controls.Add(dtpProxima);
            pnlDatosInterior.Controls.Add(lblObservacion);
            pnlDatosInterior.Controls.Add(txtObservacion);
            pnlDatosInterior.Controls.Add(btnNuevo);
            pnlDatosInterior.Controls.Add(btnGuardar);
            pnlDatosInterior.Controls.Add(btnEditar);
            pnlDatosInterior.Controls.Add(btnEliminar);
            pnlDatosInterior.Controls.Add(btnLimpiar);
            pnlDatosInterior.Controls.Add(lblTituloDatos);
            pnlDatosInterior.Dock = DockStyle.Fill;
            pnlDatosInterior.Location = new Point(1, 2);
            pnlDatosInterior.Margin = new Padding(4, 5, 4, 5);
            pnlDatosInterior.Name = "pnlDatosInterior";
            pnlDatosInterior.Size = new Size(1429, 479);
            pnlDatosInterior.TabIndex = 0;
            pnlDatosInterior.Paint += pnlDatosInterior_Paint;
            // 
            // btnAgregarVacuna
            // 
            btnAgregarVacuna.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAgregarVacuna.BackColor = Color.FromArgb(0, 77, 43);
            btnAgregarVacuna.Cursor = Cursors.Hand;
            btnAgregarVacuna.FlatAppearance.BorderSize = 0;
            btnAgregarVacuna.FlatStyle = FlatStyle.Flat;
            btnAgregarVacuna.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btnAgregarVacuna.ForeColor = Color.White;
            btnAgregarVacuna.Location = new Point(29, 389);
            btnAgregarVacuna.Margin = new Padding(4, 5, 4, 5);
            btnAgregarVacuna.Name = "btnAgregarVacuna";
            btnAgregarVacuna.Size = new Size(208, 67);
            btnAgregarVacuna.TabIndex = 20;
            btnAgregarVacuna.Text = "Agregar Vacuna";
            btnAgregarVacuna.UseVisualStyleBackColor = false;
            btnAgregarVacuna.Click += btnAgregarVacuna_Click;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 10.5F);
            lblId.ForeColor = Color.FromArgb(20, 37, 28);
            lblId.Location = new Point(29, 90);
            lblId.Margin = new Padding(4, 0, 4, 0);
            lblId.Name = "lblId";
            lblId.Size = new Size(39, 30);
            lblId.TabIndex = 0;
            lblId.Text = "ID:";
            // 
            // txtId
            // 
            txtId.BackColor = Color.FromArgb(217, 224, 228);
            txtId.BorderStyle = BorderStyle.FixedSingle;
            txtId.Font = new Font("Segoe UI", 10.5F);
            txtId.Location = new Point(200, 83);
            txtId.Margin = new Padding(4, 5, 4, 5);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(171, 35);
            txtId.TabIndex = 1;
            txtId.TabStop = false;
            // 
            // lblMascota
            // 
            lblMascota.AutoSize = true;
            lblMascota.Font = new Font("Segoe UI", 10.5F);
            lblMascota.ForeColor = Color.FromArgb(20, 37, 28);
            lblMascota.Location = new Point(29, 167);
            lblMascota.Margin = new Padding(4, 0, 4, 0);
            lblMascota.Name = "lblMascota";
            lblMascota.Size = new Size(97, 30);
            lblMascota.TabIndex = 2;
            lblMascota.Text = "Mascota:";
            // 
            // cmbMascota
            // 
            cmbMascota.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMascota.Font = new Font("Segoe UI", 10.5F);
            cmbMascota.FormattingEnabled = true;
            cmbMascota.Location = new Point(200, 160);
            cmbMascota.Margin = new Padding(4, 5, 4, 5);
            cmbMascota.Name = "cmbMascota";
            cmbMascota.Size = new Size(484, 38);
            cmbMascota.TabIndex = 3;
            // 
            // lblVacuna
            // 
            lblVacuna.AutoSize = true;
            lblVacuna.Font = new Font("Segoe UI", 10.5F);
            lblVacuna.ForeColor = Color.FromArgb(20, 37, 28);
            lblVacuna.Location = new Point(29, 243);
            lblVacuna.Margin = new Padding(4, 0, 4, 0);
            lblVacuna.Name = "lblVacuna";
            lblVacuna.Size = new Size(85, 30);
            lblVacuna.TabIndex = 4;
            lblVacuna.Text = "Vacuna:";
            // 
            // cmbVacuna
            // 
            cmbVacuna.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVacuna.Font = new Font("Segoe UI", 10.5F);
            cmbVacuna.FormattingEnabled = true;
            cmbVacuna.Location = new Point(200, 237);
            cmbVacuna.Margin = new Padding(4, 5, 4, 5);
            cmbVacuna.Name = "cmbVacuna";
            cmbVacuna.Size = new Size(484, 38);
            cmbVacuna.TabIndex = 5;
            // 
            // lblLote
            // 
            lblLote.AutoSize = true;
            lblLote.Font = new Font("Segoe UI", 10.5F);
            lblLote.ForeColor = Color.FromArgb(20, 37, 28);
            lblLote.Location = new Point(29, 320);
            lblLote.Margin = new Padding(4, 0, 4, 0);
            lblLote.Name = "lblLote";
            lblLote.Size = new Size(58, 30);
            lblLote.TabIndex = 6;
            lblLote.Text = "Lote:";
            // 
            // txtLote
            // 
            txtLote.BorderStyle = BorderStyle.FixedSingle;
            txtLote.Font = new Font("Segoe UI", 10.5F);
            txtLote.Location = new Point(200, 313);
            txtLote.Margin = new Padding(4, 5, 4, 5);
            txtLote.Name = "txtLote";
            txtLote.Size = new Size(485, 35);
            txtLote.TabIndex = 7;
            // 
            // lblAplicacion
            // 
            lblAplicacion.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblAplicacion.AutoSize = true;
            lblAplicacion.Font = new Font("Segoe UI", 10.5F);
            lblAplicacion.ForeColor = Color.FromArgb(20, 37, 28);
            lblAplicacion.Location = new Point(729, 90);
            lblAplicacion.Margin = new Padding(4, 0, 4, 0);
            lblAplicacion.Name = "lblAplicacion";
            lblAplicacion.Size = new Size(174, 30);
            lblAplicacion.TabIndex = 8;
            lblAplicacion.Text = "Fecha Aplicación:";
            // 
            // dtpAplicacion
            // 
            dtpAplicacion.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dtpAplicacion.CustomFormat = "dd/MM/yyyy";
            dtpAplicacion.Font = new Font("Segoe UI", 10.5F);
            dtpAplicacion.Format = DateTimePickerFormat.Custom;
            dtpAplicacion.Location = new Point(914, 83);
            dtpAplicacion.Margin = new Padding(4, 5, 4, 5);
            dtpAplicacion.Name = "dtpAplicacion";
            dtpAplicacion.Size = new Size(484, 35);
            dtpAplicacion.TabIndex = 9;
            // 
            // lblProxima
            // 
            lblProxima.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblProxima.AutoSize = true;
            lblProxima.Font = new Font("Segoe UI", 10.5F);
            lblProxima.ForeColor = Color.FromArgb(20, 37, 28);
            lblProxima.Location = new Point(729, 167);
            lblProxima.Margin = new Padding(4, 0, 4, 0);
            lblProxima.Name = "lblProxima";
            lblProxima.Size = new Size(149, 30);
            lblProxima.TabIndex = 10;
            lblProxima.Text = "Próxima Dosis:";
            // 
            // dtpProxima
            // 
            dtpProxima.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dtpProxima.CustomFormat = "dd/MM/yyyy";
            dtpProxima.Font = new Font("Segoe UI", 10.5F);
            dtpProxima.Format = DateTimePickerFormat.Custom;
            dtpProxima.Location = new Point(914, 160);
            dtpProxima.Margin = new Padding(4, 5, 4, 5);
            dtpProxima.Name = "dtpProxima";
            dtpProxima.ShowCheckBox = true;
            dtpProxima.Size = new Size(484, 35);
            dtpProxima.TabIndex = 11;
            // 
            // lblObservacion
            // 
            lblObservacion.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblObservacion.AutoSize = true;
            lblObservacion.Font = new Font("Segoe UI", 10.5F);
            lblObservacion.ForeColor = Color.FromArgb(20, 37, 28);
            lblObservacion.Location = new Point(729, 243);
            lblObservacion.Margin = new Padding(4, 0, 4, 0);
            lblObservacion.Name = "lblObservacion";
            lblObservacion.Size = new Size(133, 30);
            lblObservacion.TabIndex = 12;
            lblObservacion.Text = "Observación:";
            // 
            // txtObservacion
            // 
            txtObservacion.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtObservacion.BorderStyle = BorderStyle.FixedSingle;
            txtObservacion.Font = new Font("Segoe UI", 10.5F);
            txtObservacion.Location = new Point(914, 237);
            txtObservacion.Margin = new Padding(4, 5, 4, 5);
            txtObservacion.Multiline = true;
            txtObservacion.Name = "txtObservacion";
            txtObservacion.ScrollBars = ScrollBars.Vertical;
            txtObservacion.Size = new Size(485, 120);
            txtObservacion.TabIndex = 13;
            // 
            // btnNuevo
            // 
            btnNuevo.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnNuevo.BackColor = Color.FromArgb(0, 77, 43);
            btnNuevo.Cursor = Cursors.Hand;
            btnNuevo.FlatAppearance.BorderSize = 0;
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btnNuevo.ForeColor = Color.White;
            btnNuevo.Location = new Point(594, 389);
            btnNuevo.Margin = new Padding(4, 5, 4, 5);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(157, 67);
            btnNuevo.TabIndex = 14;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGuardar.BackColor = Color.FromArgb(0, 140, 69);
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(760, 389);
            btnGuardar.Margin = new Padding(4, 5, 4, 5);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(157, 67);
            btnGuardar.TabIndex = 15;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEditar.BackColor = Color.FromArgb(0, 140, 69);
            btnEditar.Cursor = Cursors.Hand;
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(926, 389);
            btnEditar.Margin = new Padding(4, 5, 4, 5);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(157, 67);
            btnEditar.TabIndex = 16;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEliminar.BackColor = Color.FromArgb(0, 140, 69);
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(1091, 389);
            btnEliminar.Margin = new Padding(4, 5, 4, 5);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(157, 67);
            btnEliminar.TabIndex = 17;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnLimpiar.BackColor = Color.FromArgb(0, 140, 69);
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(1257, 389);
            btnLimpiar.Margin = new Padding(4, 5, 4, 5);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(157, 67);
            btnLimpiar.TabIndex = 18;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // lblTituloDatos
            // 
            lblTituloDatos.BackColor = Color.FromArgb(201, 242, 211);
            lblTituloDatos.Dock = DockStyle.Top;
            lblTituloDatos.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblTituloDatos.ForeColor = Color.FromArgb(0, 77, 43);
            lblTituloDatos.Location = new Point(0, 0);
            lblTituloDatos.Margin = new Padding(4, 0, 4, 0);
            lblTituloDatos.Name = "lblTituloDatos";
            lblTituloDatos.Padding = new Padding(17, 0, 0, 0);
            lblTituloDatos.Size = new Size(1429, 63);
            lblTituloDatos.TabIndex = 19;
            lblTituloDatos.Text = "Datos de la Vacuna";
            lblTituloDatos.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlLista
            // 
            pnlLista.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlLista.BackColor = Color.FromArgb(0, 140, 69);
            pnlLista.Controls.Add(pnlListaInterior);
            pnlLista.Location = new Point(34, 677);
            pnlLista.Margin = new Padding(4, 5, 4, 5);
            pnlLista.Name = "pnlLista";
            pnlLista.Padding = new Padding(1, 2, 1, 2);
            pnlLista.Size = new Size(1431, 523);
            pnlLista.TabIndex = 3;
            // 
            // pnlListaInterior
            // 
            pnlListaInterior.BackColor = Color.White;
            pnlListaInterior.Controls.Add(lblBuscar);
            pnlListaInterior.Controls.Add(txtBuscar);
            pnlListaInterior.Controls.Add(dgvLista);
            pnlListaInterior.Controls.Add(lblTituloLista);
            pnlListaInterior.Dock = DockStyle.Fill;
            pnlListaInterior.Location = new Point(1, 2);
            pnlListaInterior.Margin = new Padding(4, 5, 4, 5);
            pnlListaInterior.Name = "pnlListaInterior";
            pnlListaInterior.Size = new Size(1429, 519);
            pnlListaInterior.TabIndex = 0;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Font = new Font("Segoe UI", 10.5F);
            lblBuscar.ForeColor = Color.FromArgb(20, 37, 28);
            lblBuscar.Location = new Point(17, 88);
            lblBuscar.Margin = new Padding(4, 0, 4, 0);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(79, 30);
            lblBuscar.TabIndex = 0;
            lblBuscar.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            txtBuscar.BorderStyle = BorderStyle.FixedSingle;
            txtBuscar.Font = new Font("Segoe UI", 10.5F);
            txtBuscar.Location = new Point(114, 83);
            txtBuscar.Margin = new Padding(4, 5, 4, 5);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Buscar por mascota o vacuna...";
            txtBuscar.Size = new Size(685, 35);
            txtBuscar.TabIndex = 1;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // dgvLista
            // 
            dgvLista.AllowUserToAddRows = false;
            dgvLista.AllowUserToDeleteRows = false;
            dgvLista.AllowUserToResizeRows = false;
            dgvLista.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvLista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLista.BackgroundColor = Color.White;
            dgvLista.BorderStyle = BorderStyle.None;
            dgvLista.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvLista.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(201, 242, 211);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(20, 37, 28);
            dataGridViewCellStyle5.Padding = new Padding(6, 0, 0, 0);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(201, 242, 211);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(20, 37, 28);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvLista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvLista.ColumnHeadersHeight = 38;
            dgvLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvLista.Columns.AddRange(new DataGridViewColumn[] { colListaID, colListaMascota, colListaVacuna, colListaFechaAplicacion, colListaProximaDosis, colListaLote });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(20, 37, 28);
            dataGridViewCellStyle6.Padding = new Padding(6, 0, 0, 0);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(201, 242, 211);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(20, 37, 28);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvLista.DefaultCellStyle = dataGridViewCellStyle6;
            dgvLista.EnableHeadersVisualStyles = false;
            dgvLista.GridColor = Color.FromArgb(217, 224, 228);
            dgvLista.Location = new Point(14, 147);
            dgvLista.Margin = new Padding(4, 5, 4, 5);
            dgvLista.MultiSelect = false;
            dgvLista.Name = "dgvLista";
            dgvLista.ReadOnly = true;
            dgvLista.RowHeadersVisible = false;
            dgvLista.RowHeadersWidth = 62;
            dgvLista.RowTemplate.Height = 34;
            dgvLista.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLista.Size = new Size(1400, 356);
            dgvLista.TabIndex = 2;
            dgvLista.CellClick += dgvLista_CellClick;
            // 
            // colListaID
            // 
            colListaID.HeaderText = "ID";
            colListaID.MinimumWidth = 8;
            colListaID.Name = "colListaID";
            colListaID.ReadOnly = true;
            // 
            // colListaMascota
            // 
            colListaMascota.HeaderText = "Mascota";
            colListaMascota.MinimumWidth = 8;
            colListaMascota.Name = "colListaMascota";
            colListaMascota.ReadOnly = true;
            // 
            // colListaVacuna
            // 
            colListaVacuna.HeaderText = "Vacuna";
            colListaVacuna.MinimumWidth = 8;
            colListaVacuna.Name = "colListaVacuna";
            colListaVacuna.ReadOnly = true;
            // 
            // colListaFechaAplicacion
            // 
            colListaFechaAplicacion.HeaderText = "Fecha Aplicación";
            colListaFechaAplicacion.MinimumWidth = 8;
            colListaFechaAplicacion.Name = "colListaFechaAplicacion";
            colListaFechaAplicacion.ReadOnly = true;
            // 
            // colListaProximaDosis
            // 
            colListaProximaDosis.HeaderText = "Próxima Dosis";
            colListaProximaDosis.MinimumWidth = 8;
            colListaProximaDosis.Name = "colListaProximaDosis";
            colListaProximaDosis.ReadOnly = true;
            // 
            // colListaLote
            // 
            colListaLote.HeaderText = "Lote";
            colListaLote.MinimumWidth = 8;
            colListaLote.Name = "colListaLote";
            colListaLote.ReadOnly = true;
            // 
            // lblTituloLista
            // 
            lblTituloLista.BackColor = Color.FromArgb(0, 77, 43);
            lblTituloLista.Dock = DockStyle.Top;
            lblTituloLista.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblTituloLista.ForeColor = Color.White;
            lblTituloLista.Location = new Point(0, 0);
            lblTituloLista.Margin = new Padding(4, 0, 4, 0);
            lblTituloLista.Name = "lblTituloLista";
            lblTituloLista.Padding = new Padding(17, 0, 0, 0);
            lblTituloLista.Size = new Size(1429, 63);
            lblTituloLista.TabIndex = 3;
            lblTituloLista.Text = "Lista de Vacunas";
            lblTituloLista.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // frmVacunas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1500, 1233);
            Controls.Add(lblTitulo);
            Controls.Add(lblSubtitulo);
            Controls.Add(btnVolver);
            Controls.Add(pnlDatos);
            Controls.Add(pnlLista);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmVacunas";
            Text = "Vacunas";
            Load += frmVacunas_Load;
            pnlDatos.ResumeLayout(false);
            pnlDatosInterior.ResumeLayout(false);
            pnlDatosInterior.PerformLayout();
            pnlLista.ResumeLayout(false);
            pnlListaInterior.ResumeLayout(false);
            pnlListaInterior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLista).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private Button btnAgregarVacuna;
    }
}
