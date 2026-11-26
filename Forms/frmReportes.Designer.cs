namespace MundoAnimal.Forms
{
    partial class frmReportes
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
            this.pnlGenerar = new System.Windows.Forms.Panel();
            this.pnlGenerarInterior = new System.Windows.Forms.Panel();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.lblDesde = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.lblHasta = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.lblTituloGenerar = new System.Windows.Forms.Label();
            this.pnlOpciones = new System.Windows.Forms.Panel();
            this.pnlOpcionesInterior = new System.Windows.Forms.Panel();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnVistaPrevia = new System.Windows.Forms.Button();
            this.btnExportarPdf = new System.Windows.Forms.Button();
            this.btnExportarExcel = new System.Windows.Forms.Button();
            this.lblTituloOpciones = new System.Windows.Forms.Label();
            this.pnlResultados = new System.Windows.Forms.Panel();
            this.pnlResultadosInterior = new System.Windows.Forms.Panel();
            this.dgvReporte = new System.Windows.Forms.DataGridView();
            this.lblTituloResultados = new System.Windows.Forms.Label();
            this.colReporteID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReporteTipodeRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReporteDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReporteFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReporteCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte)).BeginInit();
            this.pnlGenerar.SuspendLayout();
            this.pnlGenerarInterior.SuspendLayout();
            this.pnlOpciones.SuspendLayout();
            this.pnlOpcionesInterior.SuspendLayout();
            this.pnlResultados.SuspendLayout();
            this.pnlResultadosInterior.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(0, 77, 43);
            this.lblTitulo.Location = new System.Drawing.Point(24, 10);
            this.lblTitulo.Text = "Reportes";
            this.lblTitulo.TabIndex = 0;
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(20, 37, 28);
            this.lblSubtitulo.Location = new System.Drawing.Point(26, 62);
            this.lblSubtitulo.Text = "Generación de reportes del sistema";
            this.lblSubtitulo.TabIndex = 1;
            // 
            // pnlGenerar
            // 
            this.pnlGenerar.Name = "pnlGenerar";
            this.pnlGenerar.BackColor = System.Drawing.Color.FromArgb(0, 140, 69);
            this.pnlGenerar.Location = new System.Drawing.Point(24, 100);
            this.pnlGenerar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left;
            this.pnlGenerar.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.pnlGenerar.Size = new System.Drawing.Size(396, 214);
            this.pnlGenerar.Controls.Add(this.pnlGenerarInterior);
            this.pnlGenerar.TabIndex = 2;
            // 
            // pnlGenerarInterior
            // 
            this.pnlGenerarInterior.Name = "pnlGenerarInterior";
            this.pnlGenerarInterior.BackColor = System.Drawing.Color.White;
            this.pnlGenerarInterior.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGenerarInterior.Size = new System.Drawing.Size(394, 212);
            this.pnlGenerarInterior.Controls.Add(this.lblTipo);
            this.pnlGenerarInterior.Controls.Add(this.cmbTipo);
            this.pnlGenerarInterior.Controls.Add(this.lblDesde);
            this.pnlGenerarInterior.Controls.Add(this.dtpDesde);
            this.pnlGenerarInterior.Controls.Add(this.lblHasta);
            this.pnlGenerarInterior.Controls.Add(this.dtpHasta);
            this.pnlGenerarInterior.Controls.Add(this.lblTituloGenerar);
            this.pnlGenerarInterior.TabIndex = 0;
            // 
            // lblTipo
            // 
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTipo.ForeColor = System.Drawing.Color.FromArgb(20, 37, 28);
            this.lblTipo.Location = new System.Drawing.Point(16, 62);
            this.lblTipo.Text = "Tipo de Reporte:";
            this.lblTipo.TabIndex = 0;
            // 
            // cmbTipo
            // 
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(146, 58);
            this.cmbTipo.Size = new System.Drawing.Size(228, 29);
            this.cmbTipo.Items.AddRange(new object[] { "Dueños", "Mascotas", "Consultas", "Vacunas" });
            this.cmbTipo.TabIndex = 1;
            // 
            // lblDesde
            // 
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.AutoSize = true;
            this.lblDesde.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDesde.ForeColor = System.Drawing.Color.FromArgb(20, 37, 28);
            this.lblDesde.Location = new System.Drawing.Point(16, 110);
            this.lblDesde.Text = "Fecha Desde:";
            this.lblDesde.TabIndex = 2;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.CustomFormat = "dd/MM/yyyy";
            this.dtpDesde.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDesde.Location = new System.Drawing.Point(146, 106);
            this.dtpDesde.Size = new System.Drawing.Size(228, 27);
            this.dtpDesde.TabIndex = 3;
            // 
            // lblHasta
            // 
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.AutoSize = true;
            this.lblHasta.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHasta.ForeColor = System.Drawing.Color.FromArgb(20, 37, 28);
            this.lblHasta.Location = new System.Drawing.Point(16, 158);
            this.lblHasta.Text = "Fecha Hasta:";
            this.lblHasta.TabIndex = 4;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.CustomFormat = "dd/MM/yyyy";
            this.dtpHasta.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHasta.Location = new System.Drawing.Point(146, 154);
            this.dtpHasta.Size = new System.Drawing.Size(228, 27);
            this.dtpHasta.TabIndex = 5;
            // 
            // lblTituloGenerar
            // 
            this.lblTituloGenerar.Name = "lblTituloGenerar";
            this.lblTituloGenerar.AutoSize = false;
            this.lblTituloGenerar.BackColor = System.Drawing.Color.FromArgb(201, 242, 211);
            this.lblTituloGenerar.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTituloGenerar.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTituloGenerar.ForeColor = System.Drawing.Color.FromArgb(0, 77, 43);
            this.lblTituloGenerar.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.lblTituloGenerar.Size = new System.Drawing.Size(394, 38);
            this.lblTituloGenerar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTituloGenerar.Text = "Generar Reporte";
            this.lblTituloGenerar.TabIndex = 6;
            // 
            // pnlOpciones
            // 
            this.pnlOpciones.Name = "pnlOpciones";
            this.pnlOpciones.BackColor = System.Drawing.Color.FromArgb(0, 140, 69);
            this.pnlOpciones.Location = new System.Drawing.Point(436, 100);
            this.pnlOpciones.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.pnlOpciones.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.pnlOpciones.Size = new System.Drawing.Size(590, 214);
            this.pnlOpciones.Controls.Add(this.pnlOpcionesInterior);
            this.pnlOpciones.TabIndex = 3;
            // 
            // pnlOpcionesInterior
            // 
            this.pnlOpcionesInterior.Name = "pnlOpcionesInterior";
            this.pnlOpcionesInterior.BackColor = System.Drawing.Color.White;
            this.pnlOpcionesInterior.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOpcionesInterior.Size = new System.Drawing.Size(588, 212);
            this.pnlOpcionesInterior.Controls.Add(this.btnGenerar);
            this.pnlOpcionesInterior.Controls.Add(this.btnVistaPrevia);
            this.pnlOpcionesInterior.Controls.Add(this.btnExportarPdf);
            this.pnlOpcionesInterior.Controls.Add(this.btnExportarExcel);
            this.pnlOpcionesInterior.Controls.Add(this.lblTituloOpciones);
            this.pnlOpcionesInterior.TabIndex = 0;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left;
            this.btnGenerar.BackColor = System.Drawing.Color.FromArgb(0, 77, 43);
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGenerar.ForeColor = System.Drawing.Color.White;
            this.btnGenerar.Location = new System.Drawing.Point(16, 58);
            this.btnGenerar.Size = new System.Drawing.Size(270, 62);
            this.btnGenerar.Text = "Generar Reporte";
            this.btnGenerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.FlatAppearance.BorderSize = 0;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            this.btnGenerar.TabIndex = 0;
            // 
            // btnVistaPrevia
            // 
            this.btnVistaPrevia.Name = "btnVistaPrevia";
            this.btnVistaPrevia.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.btnVistaPrevia.BackColor = System.Drawing.Color.FromArgb(0, 77, 43);
            this.btnVistaPrevia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVistaPrevia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVistaPrevia.ForeColor = System.Drawing.Color.White;
            this.btnVistaPrevia.Location = new System.Drawing.Point(302, 58);
            this.btnVistaPrevia.Size = new System.Drawing.Size(270, 62);
            this.btnVistaPrevia.Text = "Vista Previa";
            this.btnVistaPrevia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVistaPrevia.UseVisualStyleBackColor = false;
            this.btnVistaPrevia.FlatAppearance.BorderSize = 0;
            this.btnVistaPrevia.Click += new System.EventHandler(this.btnVistaPrevia_Click);
            this.btnVistaPrevia.TabIndex = 1;
            // 
            // btnExportarPdf
            // 
            this.btnExportarPdf.Name = "btnExportarPdf";
            this.btnExportarPdf.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left;
            this.btnExportarPdf.BackColor = System.Drawing.Color.FromArgb(0, 77, 43);
            this.btnExportarPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportarPdf.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExportarPdf.ForeColor = System.Drawing.Color.White;
            this.btnExportarPdf.Location = new System.Drawing.Point(16, 130);
            this.btnExportarPdf.Size = new System.Drawing.Size(270, 62);
            this.btnExportarPdf.Text = "Exportar PDF";
            this.btnExportarPdf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportarPdf.UseVisualStyleBackColor = false;
            this.btnExportarPdf.FlatAppearance.BorderSize = 0;
            this.btnExportarPdf.Click += new System.EventHandler(this.btnExportarPdf_Click);
            this.btnExportarPdf.TabIndex = 2;
            // 
            // btnExportarExcel
            // 
            this.btnExportarExcel.Name = "btnExportarExcel";
            this.btnExportarExcel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.btnExportarExcel.BackColor = System.Drawing.Color.FromArgb(0, 77, 43);
            this.btnExportarExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportarExcel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExportarExcel.ForeColor = System.Drawing.Color.White;
            this.btnExportarExcel.Location = new System.Drawing.Point(302, 130);
            this.btnExportarExcel.Size = new System.Drawing.Size(270, 62);
            this.btnExportarExcel.Text = "Exportar Excel";
            this.btnExportarExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportarExcel.UseVisualStyleBackColor = false;
            this.btnExportarExcel.FlatAppearance.BorderSize = 0;
            this.btnExportarExcel.Click += new System.EventHandler(this.btnExportarExcel_Click);
            this.btnExportarExcel.TabIndex = 3;
            // 
            // lblTituloOpciones
            // 
            this.lblTituloOpciones.Name = "lblTituloOpciones";
            this.lblTituloOpciones.AutoSize = false;
            this.lblTituloOpciones.BackColor = System.Drawing.Color.FromArgb(201, 242, 211);
            this.lblTituloOpciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTituloOpciones.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTituloOpciones.ForeColor = System.Drawing.Color.FromArgb(0, 77, 43);
            this.lblTituloOpciones.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.lblTituloOpciones.Size = new System.Drawing.Size(588, 38);
            this.lblTituloOpciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTituloOpciones.Text = "Opciones";
            this.lblTituloOpciones.TabIndex = 4;
            // 
            // pnlResultados
            // 
            this.pnlResultados.Name = "pnlResultados";
            this.pnlResultados.BackColor = System.Drawing.Color.FromArgb(0, 140, 69);
            this.pnlResultados.Location = new System.Drawing.Point(24, 330);
            this.pnlResultados.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.pnlResultados.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.pnlResultados.Size = new System.Drawing.Size(1002, 390);
            this.pnlResultados.Controls.Add(this.pnlResultadosInterior);
            this.pnlResultados.TabIndex = 4;
            // 
            // pnlResultadosInterior
            // 
            this.pnlResultadosInterior.Name = "pnlResultadosInterior";
            this.pnlResultadosInterior.BackColor = System.Drawing.Color.White;
            this.pnlResultadosInterior.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlResultadosInterior.Size = new System.Drawing.Size(1000, 388);
            this.pnlResultadosInterior.Controls.Add(this.dgvReporte);
            this.pnlResultadosInterior.Controls.Add(this.lblTituloResultados);
            this.pnlResultadosInterior.TabIndex = 0;
            // 
            // dgvReporte
            // 
            this.dgvReporte.Name = "dgvReporte";
            this.dgvReporte.AllowUserToAddRows = false;
            this.dgvReporte.AllowUserToDeleteRows = false;
            this.dgvReporte.AllowUserToResizeRows = false;
            this.dgvReporte.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.dgvReporte.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReporte.BackgroundColor = System.Drawing.Color.White;
            this.dgvReporte.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReporte.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvReporte.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvReporte.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReporte.ColumnHeadersHeight = 38;
            this.dgvReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvReporte.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReporte.EnableHeadersVisualStyles = false;
            this.dgvReporte.GridColor = System.Drawing.Color.FromArgb(217, 224, 228);
            this.dgvReporte.Location = new System.Drawing.Point(10, 48);
            this.dgvReporte.MultiSelect = false;
            this.dgvReporte.ReadOnly = true;
            this.dgvReporte.RowHeadersVisible = false;
            this.dgvReporte.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReporte.Size = new System.Drawing.Size(978, 330);
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
            this.dgvReporte.RowTemplate.Height = 34;
            this.dgvReporte.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.colReporteID, this.colReporteTipodeRegistro, this.colReporteDescripcion, this.colReporteFecha, this.colReporteCantidad });
            this.colReporteID.HeaderText = "ID";
            this.colReporteID.Name = "colReporteID";
            this.colReporteTipodeRegistro.HeaderText = "Tipo de Registro";
            this.colReporteTipodeRegistro.Name = "colReporteTipodeRegistro";
            this.colReporteDescripcion.HeaderText = "Descripción";
            this.colReporteDescripcion.Name = "colReporteDescripcion";
            this.colReporteFecha.HeaderText = "Fecha";
            this.colReporteFecha.Name = "colReporteFecha";
            this.colReporteCantidad.HeaderText = "Cantidad";
            this.colReporteCantidad.Name = "colReporteCantidad";
            this.dgvReporte.TabIndex = 0;
            // 
            // lblTituloResultados
            // 
            this.lblTituloResultados.Name = "lblTituloResultados";
            this.lblTituloResultados.AutoSize = false;
            this.lblTituloResultados.BackColor = System.Drawing.Color.FromArgb(0, 77, 43);
            this.lblTituloResultados.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTituloResultados.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTituloResultados.ForeColor = System.Drawing.Color.White;
            this.lblTituloResultados.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.lblTituloResultados.Size = new System.Drawing.Size(1000, 38);
            this.lblTituloResultados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTituloResultados.Text = "Resultados del Reporte";
            this.lblTituloResultados.TabIndex = 1;
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
            this.Text = "Reportes";
            this.Name = "frmReportes";
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.pnlGenerar);
            this.Controls.Add(this.pnlOpciones);
            this.Controls.Add(this.pnlResultados);
            this.Load += new System.EventHandler(this.frmReportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte)).EndInit();
            this.pnlGenerar.ResumeLayout(false);
            this.pnlGenerarInterior.ResumeLayout(false);
            this.pnlOpciones.ResumeLayout(false);
            this.pnlOpcionesInterior.ResumeLayout(false);
            this.pnlResultados.ResumeLayout(false);
            this.pnlResultadosInterior.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Panel pnlGenerar;
        private System.Windows.Forms.Panel pnlGenerarInterior;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Label lblTituloGenerar;
        private System.Windows.Forms.Panel pnlOpciones;
        private System.Windows.Forms.Panel pnlOpcionesInterior;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnVistaPrevia;
        private System.Windows.Forms.Button btnExportarPdf;
        private System.Windows.Forms.Button btnExportarExcel;
        private System.Windows.Forms.Label lblTituloOpciones;
        private System.Windows.Forms.Panel pnlResultados;
        private System.Windows.Forms.Panel pnlResultadosInterior;
        private System.Windows.Forms.DataGridView dgvReporte;
        private System.Windows.Forms.Label lblTituloResultados;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReporteID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReporteTipodeRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReporteDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReporteFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReporteCantidad;
    }
}
