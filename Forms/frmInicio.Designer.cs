namespace MundoAnimal.Forms
{
    partial class frmInicio
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            lblFecha = new Label();
            tlpTarjetas = new TableLayoutPanel();
            pnlMascotas = new Panel();
            pnlMascotasInterior = new Panel();
            lblMascotas = new Label();
            lblTituloMascotas = new Label();
            pnlDuenos = new Panel();
            pnlDuenosInterior = new Panel();
            lblDuenos = new Label();
            lblTituloDuenos = new Label();
            pnlConsultasHoy = new Panel();
            pnlConsultasHoyInterior = new Panel();
            lblConsultasHoy = new Label();
            lblTituloConsultasHoy = new Label();
            pnlVacunasProximas = new Panel();
            pnlVacunasProximasInterior = new Panel();
            lblVacunasProximas = new Label();
            lblTituloVacunasProximas = new Label();
            tlpTablas = new TableLayoutPanel();
            pnlConsultasRecientes = new Panel();
            pnlConsultasRecientesInterior = new Panel();
            pnlCuerpoConsultasRecientes = new Panel();
            dgvConsultasRecientes = new DataGridView();
            colConsultasRecientesFecha = new DataGridViewTextBoxColumn();
            colConsultasRecientesMascota = new DataGridViewTextBoxColumn();
            colConsultasRecientesDueno = new DataGridViewTextBoxColumn();
            colConsultasRecientesMotivo = new DataGridViewTextBoxColumn();
            lblTituloConsultasRecientes = new Label();
            pnlProximasVacunas = new Panel();
            pnlProximasVacunasInterior = new Panel();
            pnlCuerpoProximasVacunas = new Panel();
            dgvProximasVacunas = new DataGridView();
            colProximasVacunasFecha = new DataGridViewTextBoxColumn();
            colProximasVacunasMascota = new DataGridViewTextBoxColumn();
            colProximasVacunasVacuna = new DataGridViewTextBoxColumn();
            lblTituloProximasVacunas = new Label();
            pnlRecordatorio = new Panel();
            pnlRecordatorioInterior = new Panel();
            lblRecordatorioEtiqueta = new Label();
            lblRecordatorio = new Label();
            pnlLateral = new Panel();
            flpMenu = new FlowLayoutPanel();
            btnInicio = new Button();
            btnDuenos = new Button();
            btnMascotas = new Button();
            btnConsultas = new Button();
            btnVacunas = new Button();
            btnReportes = new Button();
            btnUsuarios = new Button();
            pnlInferior = new Panel();
            btnCerrarSesion = new Button();
            pnlMarca = new Panel();
            lblClinica = new Label();
            lblClinicaSub = new Label();
            pnlLinea = new Panel();
            tlpTarjetas.SuspendLayout();
            pnlMascotas.SuspendLayout();
            pnlMascotasInterior.SuspendLayout();
            pnlDuenos.SuspendLayout();
            pnlDuenosInterior.SuspendLayout();
            pnlConsultasHoy.SuspendLayout();
            pnlConsultasHoyInterior.SuspendLayout();
            pnlVacunasProximas.SuspendLayout();
            pnlVacunasProximasInterior.SuspendLayout();
            tlpTablas.SuspendLayout();
            pnlConsultasRecientes.SuspendLayout();
            pnlConsultasRecientesInterior.SuspendLayout();
            pnlCuerpoConsultasRecientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConsultasRecientes).BeginInit();
            pnlProximasVacunas.SuspendLayout();
            pnlProximasVacunasInterior.SuspendLayout();
            pnlCuerpoProximasVacunas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProximasVacunas).BeginInit();
            pnlRecordatorio.SuspendLayout();
            pnlRecordatorioInterior.SuspendLayout();
            pnlLateral.SuspendLayout();
            flpMenu.SuspendLayout();
            pnlInferior.SuspendLayout();
            pnlMarca.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(0, 77, 43);
            lblTitulo.Location = new Point(363, 17);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(164, 70);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Inicio";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 12F);
            lblSubtitulo.ForeColor = Color.FromArgb(20, 37, 28);
            lblSubtitulo.Location = new Point(366, 103);
            lblSubtitulo.Margin = new Padding(4, 0, 4, 0);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(326, 32);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Resumen general del sistema";
            // 
            // lblFecha
            // 
            lblFecha.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblFecha.BackColor = Color.FromArgb(201, 242, 211);
            lblFecha.Font = new Font("Segoe UI", 11F);
            lblFecha.ForeColor = Color.FromArgb(0, 77, 43);
            lblFecha.Location = new Point(1266, 23);
            lblFecha.Margin = new Padding(4, 0, 4, 0);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(529, 70);
            lblFecha.TabIndex = 2;
            lblFecha.Text = "Fecha:";
            lblFecha.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tlpTarjetas
            // 
            tlpTarjetas.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tlpTarjetas.ColumnCount = 4;
            tlpTarjetas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpTarjetas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpTarjetas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpTarjetas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpTarjetas.Controls.Add(pnlMascotas, 0, 0);
            tlpTarjetas.Controls.Add(pnlDuenos, 1, 0);
            tlpTarjetas.Controls.Add(pnlConsultasHoy, 2, 0);
            tlpTarjetas.Controls.Add(pnlVacunasProximas, 3, 0);
            tlpTarjetas.Location = new Point(363, 173);
            tlpTarjetas.Margin = new Padding(4, 5, 4, 5);
            tlpTarjetas.Name = "tlpTarjetas";
            tlpTarjetas.RowCount = 1;
            tlpTarjetas.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpTarjetas.Size = new Size(1431, 207);
            tlpTarjetas.TabIndex = 3;
            // 
            // pnlMascotas
            // 
            pnlMascotas.BackColor = Color.FromArgb(0, 140, 69);
            pnlMascotas.Controls.Add(pnlMascotasInterior);
            pnlMascotas.Dock = DockStyle.Fill;
            pnlMascotas.Location = new Point(0, 0);
            pnlMascotas.Margin = new Padding(0, 0, 20, 0);
            pnlMascotas.Name = "pnlMascotas";
            pnlMascotas.Padding = new Padding(1, 2, 1, 2);
            pnlMascotas.Size = new Size(337, 207);
            pnlMascotas.TabIndex = 0;
            // 
            // pnlMascotasInterior
            // 
            pnlMascotasInterior.BackColor = Color.White;
            pnlMascotasInterior.Controls.Add(lblMascotas);
            pnlMascotasInterior.Controls.Add(lblTituloMascotas);
            pnlMascotasInterior.Dock = DockStyle.Fill;
            pnlMascotasInterior.Location = new Point(1, 2);
            pnlMascotasInterior.Margin = new Padding(4, 5, 4, 5);
            pnlMascotasInterior.Name = "pnlMascotasInterior";
            pnlMascotasInterior.Size = new Size(335, 203);
            pnlMascotasInterior.TabIndex = 0;
            // 
            // lblMascotas
            // 
            lblMascotas.Dock = DockStyle.Fill;
            lblMascotas.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            lblMascotas.ForeColor = Color.FromArgb(20, 37, 28);
            lblMascotas.Location = new Point(0, 63);
            lblMascotas.Margin = new Padding(4, 0, 4, 0);
            lblMascotas.Name = "lblMascotas";
            lblMascotas.Size = new Size(335, 140);
            lblMascotas.TabIndex = 0;
            lblMascotas.Text = "0";
            lblMascotas.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTituloMascotas
            // 
            lblTituloMascotas.BackColor = Color.FromArgb(201, 242, 211);
            lblTituloMascotas.Dock = DockStyle.Top;
            lblTituloMascotas.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblTituloMascotas.ForeColor = Color.FromArgb(0, 77, 43);
            lblTituloMascotas.Location = new Point(0, 0);
            lblTituloMascotas.Margin = new Padding(4, 0, 4, 0);
            lblTituloMascotas.Name = "lblTituloMascotas";
            lblTituloMascotas.Padding = new Padding(17, 0, 0, 0);
            lblTituloMascotas.Size = new Size(335, 63);
            lblTituloMascotas.TabIndex = 1;
            lblTituloMascotas.Text = "Mascotas Registradas";
            lblTituloMascotas.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlDuenos
            // 
            pnlDuenos.BackColor = Color.FromArgb(0, 140, 69);
            pnlDuenos.Controls.Add(pnlDuenosInterior);
            pnlDuenos.Dock = DockStyle.Fill;
            pnlDuenos.Location = new Point(357, 0);
            pnlDuenos.Margin = new Padding(0, 0, 20, 0);
            pnlDuenos.Name = "pnlDuenos";
            pnlDuenos.Padding = new Padding(1, 2, 1, 2);
            pnlDuenos.Size = new Size(337, 207);
            pnlDuenos.TabIndex = 1;
            // 
            // pnlDuenosInterior
            // 
            pnlDuenosInterior.BackColor = Color.White;
            pnlDuenosInterior.Controls.Add(lblDuenos);
            pnlDuenosInterior.Controls.Add(lblTituloDuenos);
            pnlDuenosInterior.Dock = DockStyle.Fill;
            pnlDuenosInterior.Location = new Point(1, 2);
            pnlDuenosInterior.Margin = new Padding(4, 5, 4, 5);
            pnlDuenosInterior.Name = "pnlDuenosInterior";
            pnlDuenosInterior.Size = new Size(335, 203);
            pnlDuenosInterior.TabIndex = 0;
            // 
            // lblDuenos
            // 
            lblDuenos.Dock = DockStyle.Fill;
            lblDuenos.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            lblDuenos.ForeColor = Color.FromArgb(20, 37, 28);
            lblDuenos.Location = new Point(0, 63);
            lblDuenos.Margin = new Padding(4, 0, 4, 0);
            lblDuenos.Name = "lblDuenos";
            lblDuenos.Size = new Size(335, 140);
            lblDuenos.TabIndex = 0;
            lblDuenos.Text = "0";
            lblDuenos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTituloDuenos
            // 
            lblTituloDuenos.BackColor = Color.FromArgb(201, 242, 211);
            lblTituloDuenos.Dock = DockStyle.Top;
            lblTituloDuenos.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblTituloDuenos.ForeColor = Color.FromArgb(0, 77, 43);
            lblTituloDuenos.Location = new Point(0, 0);
            lblTituloDuenos.Margin = new Padding(4, 0, 4, 0);
            lblTituloDuenos.Name = "lblTituloDuenos";
            lblTituloDuenos.Padding = new Padding(17, 0, 0, 0);
            lblTituloDuenos.Size = new Size(335, 63);
            lblTituloDuenos.TabIndex = 1;
            lblTituloDuenos.Text = "Dueños Registrados";
            lblTituloDuenos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlConsultasHoy
            // 
            pnlConsultasHoy.BackColor = Color.FromArgb(0, 140, 69);
            pnlConsultasHoy.Controls.Add(pnlConsultasHoyInterior);
            pnlConsultasHoy.Dock = DockStyle.Fill;
            pnlConsultasHoy.Location = new Point(714, 0);
            pnlConsultasHoy.Margin = new Padding(0, 0, 20, 0);
            pnlConsultasHoy.Name = "pnlConsultasHoy";
            pnlConsultasHoy.Padding = new Padding(1, 2, 1, 2);
            pnlConsultasHoy.Size = new Size(337, 207);
            pnlConsultasHoy.TabIndex = 2;
            // 
            // pnlConsultasHoyInterior
            // 
            pnlConsultasHoyInterior.BackColor = Color.White;
            pnlConsultasHoyInterior.Controls.Add(lblConsultasHoy);
            pnlConsultasHoyInterior.Controls.Add(lblTituloConsultasHoy);
            pnlConsultasHoyInterior.Dock = DockStyle.Fill;
            pnlConsultasHoyInterior.Location = new Point(1, 2);
            pnlConsultasHoyInterior.Margin = new Padding(4, 5, 4, 5);
            pnlConsultasHoyInterior.Name = "pnlConsultasHoyInterior";
            pnlConsultasHoyInterior.Size = new Size(335, 203);
            pnlConsultasHoyInterior.TabIndex = 0;
            // 
            // lblConsultasHoy
            // 
            lblConsultasHoy.Dock = DockStyle.Fill;
            lblConsultasHoy.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            lblConsultasHoy.ForeColor = Color.FromArgb(20, 37, 28);
            lblConsultasHoy.Location = new Point(0, 63);
            lblConsultasHoy.Margin = new Padding(4, 0, 4, 0);
            lblConsultasHoy.Name = "lblConsultasHoy";
            lblConsultasHoy.Size = new Size(335, 140);
            lblConsultasHoy.TabIndex = 0;
            lblConsultasHoy.Text = "0";
            lblConsultasHoy.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTituloConsultasHoy
            // 
            lblTituloConsultasHoy.BackColor = Color.FromArgb(201, 242, 211);
            lblTituloConsultasHoy.Dock = DockStyle.Top;
            lblTituloConsultasHoy.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblTituloConsultasHoy.ForeColor = Color.FromArgb(0, 77, 43);
            lblTituloConsultasHoy.Location = new Point(0, 0);
            lblTituloConsultasHoy.Margin = new Padding(4, 0, 4, 0);
            lblTituloConsultasHoy.Name = "lblTituloConsultasHoy";
            lblTituloConsultasHoy.Padding = new Padding(17, 0, 0, 0);
            lblTituloConsultasHoy.Size = new Size(335, 63);
            lblTituloConsultasHoy.TabIndex = 1;
            lblTituloConsultasHoy.Text = "Consultas (Hoy)";
            lblTituloConsultasHoy.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlVacunasProximas
            // 
            pnlVacunasProximas.BackColor = Color.FromArgb(0, 140, 69);
            pnlVacunasProximas.Controls.Add(pnlVacunasProximasInterior);
            pnlVacunasProximas.Dock = DockStyle.Fill;
            pnlVacunasProximas.Location = new Point(1071, 0);
            pnlVacunasProximas.Margin = new Padding(0);
            pnlVacunasProximas.Name = "pnlVacunasProximas";
            pnlVacunasProximas.Padding = new Padding(1, 2, 1, 2);
            pnlVacunasProximas.Size = new Size(360, 207);
            pnlVacunasProximas.TabIndex = 3;
            // 
            // pnlVacunasProximasInterior
            // 
            pnlVacunasProximasInterior.BackColor = Color.White;
            pnlVacunasProximasInterior.Controls.Add(lblVacunasProximas);
            pnlVacunasProximasInterior.Controls.Add(lblTituloVacunasProximas);
            pnlVacunasProximasInterior.Dock = DockStyle.Fill;
            pnlVacunasProximasInterior.Location = new Point(1, 2);
            pnlVacunasProximasInterior.Margin = new Padding(4, 5, 4, 5);
            pnlVacunasProximasInterior.Name = "pnlVacunasProximasInterior";
            pnlVacunasProximasInterior.Size = new Size(358, 203);
            pnlVacunasProximasInterior.TabIndex = 0;
            // 
            // lblVacunasProximas
            // 
            lblVacunasProximas.Dock = DockStyle.Fill;
            lblVacunasProximas.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            lblVacunasProximas.ForeColor = Color.FromArgb(20, 37, 28);
            lblVacunasProximas.Location = new Point(0, 63);
            lblVacunasProximas.Margin = new Padding(4, 0, 4, 0);
            lblVacunasProximas.Name = "lblVacunasProximas";
            lblVacunasProximas.Size = new Size(358, 140);
            lblVacunasProximas.TabIndex = 0;
            lblVacunasProximas.Text = "0";
            lblVacunasProximas.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTituloVacunasProximas
            // 
            lblTituloVacunasProximas.BackColor = Color.FromArgb(201, 242, 211);
            lblTituloVacunasProximas.Dock = DockStyle.Top;
            lblTituloVacunasProximas.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblTituloVacunasProximas.ForeColor = Color.FromArgb(0, 77, 43);
            lblTituloVacunasProximas.Location = new Point(0, 0);
            lblTituloVacunasProximas.Margin = new Padding(4, 0, 4, 0);
            lblTituloVacunasProximas.Name = "lblTituloVacunasProximas";
            lblTituloVacunasProximas.Padding = new Padding(17, 0, 0, 0);
            lblTituloVacunasProximas.Size = new Size(358, 63);
            lblTituloVacunasProximas.TabIndex = 1;
            lblTituloVacunasProximas.Text = "Vacunas Próximas";
            lblTituloVacunasProximas.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tlpTablas
            // 
            tlpTablas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tlpTablas.ColumnCount = 2;
            tlpTablas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpTablas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpTablas.Controls.Add(pnlConsultasRecientes, 0, 0);
            tlpTablas.Controls.Add(pnlProximasVacunas, 1, 0);
            tlpTablas.Location = new Point(363, 403);
            tlpTablas.Margin = new Padding(4, 5, 4, 5);
            tlpTablas.Name = "tlpTablas";
            tlpTablas.RowCount = 1;
            tlpTablas.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpTablas.Size = new Size(1431, 643);
            tlpTablas.TabIndex = 4;
            // 
            // pnlConsultasRecientes
            // 
            pnlConsultasRecientes.BackColor = Color.FromArgb(0, 140, 69);
            pnlConsultasRecientes.Controls.Add(pnlConsultasRecientesInterior);
            pnlConsultasRecientes.Dock = DockStyle.Fill;
            pnlConsultasRecientes.Location = new Point(0, 0);
            pnlConsultasRecientes.Margin = new Padding(0, 0, 10, 0);
            pnlConsultasRecientes.Name = "pnlConsultasRecientes";
            pnlConsultasRecientes.Padding = new Padding(1, 2, 1, 2);
            pnlConsultasRecientes.Size = new Size(705, 643);
            pnlConsultasRecientes.TabIndex = 0;
            // 
            // pnlConsultasRecientesInterior
            // 
            pnlConsultasRecientesInterior.BackColor = Color.White;
            pnlConsultasRecientesInterior.Controls.Add(pnlCuerpoConsultasRecientes);
            pnlConsultasRecientesInterior.Controls.Add(lblTituloConsultasRecientes);
            pnlConsultasRecientesInterior.Dock = DockStyle.Fill;
            pnlConsultasRecientesInterior.Location = new Point(1, 2);
            pnlConsultasRecientesInterior.Margin = new Padding(4, 5, 4, 5);
            pnlConsultasRecientesInterior.Name = "pnlConsultasRecientesInterior";
            pnlConsultasRecientesInterior.Size = new Size(703, 639);
            pnlConsultasRecientesInterior.TabIndex = 0;
            // 
            // pnlCuerpoConsultasRecientes
            // 
            pnlCuerpoConsultasRecientes.BackColor = Color.White;
            pnlCuerpoConsultasRecientes.Controls.Add(dgvConsultasRecientes);
            pnlCuerpoConsultasRecientes.Dock = DockStyle.Fill;
            pnlCuerpoConsultasRecientes.Location = new Point(0, 63);
            pnlCuerpoConsultasRecientes.Margin = new Padding(4, 5, 4, 5);
            pnlCuerpoConsultasRecientes.Name = "pnlCuerpoConsultasRecientes";
            pnlCuerpoConsultasRecientes.Padding = new Padding(14, 17, 14, 17);
            pnlCuerpoConsultasRecientes.Size = new Size(703, 576);
            pnlCuerpoConsultasRecientes.TabIndex = 0;
            // 
            // dgvConsultasRecientes
            // 
            dgvConsultasRecientes.AllowUserToAddRows = false;
            dgvConsultasRecientes.AllowUserToDeleteRows = false;
            dgvConsultasRecientes.AllowUserToResizeRows = false;
            dgvConsultasRecientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvConsultasRecientes.BackgroundColor = Color.White;
            dgvConsultasRecientes.BorderStyle = BorderStyle.None;
            dgvConsultasRecientes.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvConsultasRecientes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(201, 242, 211);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(20, 37, 28);
            dataGridViewCellStyle1.Padding = new Padding(6, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(201, 242, 211);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(20, 37, 28);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvConsultasRecientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvConsultasRecientes.ColumnHeadersHeight = 38;
            dgvConsultasRecientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvConsultasRecientes.Columns.AddRange(new DataGridViewColumn[] { colConsultasRecientesFecha, colConsultasRecientesMascota, colConsultasRecientesDueno, colConsultasRecientesMotivo });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(20, 37, 28);
            dataGridViewCellStyle2.Padding = new Padding(6, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(201, 242, 211);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(20, 37, 28);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvConsultasRecientes.DefaultCellStyle = dataGridViewCellStyle2;
            dgvConsultasRecientes.Dock = DockStyle.Fill;
            dgvConsultasRecientes.EnableHeadersVisualStyles = false;
            dgvConsultasRecientes.GridColor = Color.FromArgb(217, 224, 228);
            dgvConsultasRecientes.Location = new Point(14, 17);
            dgvConsultasRecientes.Margin = new Padding(4, 5, 4, 5);
            dgvConsultasRecientes.MultiSelect = false;
            dgvConsultasRecientes.Name = "dgvConsultasRecientes";
            dgvConsultasRecientes.ReadOnly = true;
            dgvConsultasRecientes.RowHeadersVisible = false;
            dgvConsultasRecientes.RowHeadersWidth = 62;
            dgvConsultasRecientes.RowTemplate.Height = 34;
            dgvConsultasRecientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvConsultasRecientes.Size = new Size(675, 542);
            dgvConsultasRecientes.TabIndex = 0;
            dgvConsultasRecientes.CellContentClick += dgvConsultasRecientes_CellContentClick;
            // 
            // colConsultasRecientesFecha
            // 
            colConsultasRecientesFecha.HeaderText = "Fecha";
            colConsultasRecientesFecha.MinimumWidth = 8;
            colConsultasRecientesFecha.Name = "colConsultasRecientesFecha";
            colConsultasRecientesFecha.ReadOnly = true;
            // 
            // colConsultasRecientesMascota
            // 
            colConsultasRecientesMascota.HeaderText = "Mascota";
            colConsultasRecientesMascota.MinimumWidth = 8;
            colConsultasRecientesMascota.Name = "colConsultasRecientesMascota";
            colConsultasRecientesMascota.ReadOnly = true;
            // 
            // colConsultasRecientesDueno
            // 
            colConsultasRecientesDueno.HeaderText = "Dueño";
            colConsultasRecientesDueno.MinimumWidth = 8;
            colConsultasRecientesDueno.Name = "colConsultasRecientesDueno";
            colConsultasRecientesDueno.ReadOnly = true;
            // 
            // colConsultasRecientesMotivo
            // 
            colConsultasRecientesMotivo.HeaderText = "Motivo";
            colConsultasRecientesMotivo.MinimumWidth = 8;
            colConsultasRecientesMotivo.Name = "colConsultasRecientesMotivo";
            colConsultasRecientesMotivo.ReadOnly = true;
            // 
            // lblTituloConsultasRecientes
            // 
            lblTituloConsultasRecientes.BackColor = Color.FromArgb(0, 77, 43);
            lblTituloConsultasRecientes.Dock = DockStyle.Top;
            lblTituloConsultasRecientes.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblTituloConsultasRecientes.ForeColor = Color.White;
            lblTituloConsultasRecientes.Location = new Point(0, 0);
            lblTituloConsultasRecientes.Margin = new Padding(4, 0, 4, 0);
            lblTituloConsultasRecientes.Name = "lblTituloConsultasRecientes";
            lblTituloConsultasRecientes.Padding = new Padding(17, 0, 0, 0);
            lblTituloConsultasRecientes.Size = new Size(703, 63);
            lblTituloConsultasRecientes.TabIndex = 1;
            lblTituloConsultasRecientes.Text = "Consultas Recientes (Últimos 7 días)";
            lblTituloConsultasRecientes.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlProximasVacunas
            // 
            pnlProximasVacunas.BackColor = Color.FromArgb(0, 140, 69);
            pnlProximasVacunas.Controls.Add(pnlProximasVacunasInterior);
            pnlProximasVacunas.Dock = DockStyle.Fill;
            pnlProximasVacunas.Location = new Point(725, 0);
            pnlProximasVacunas.Margin = new Padding(10, 0, 0, 0);
            pnlProximasVacunas.Name = "pnlProximasVacunas";
            pnlProximasVacunas.Padding = new Padding(1, 2, 1, 2);
            pnlProximasVacunas.Size = new Size(706, 643);
            pnlProximasVacunas.TabIndex = 1;
            // 
            // pnlProximasVacunasInterior
            // 
            pnlProximasVacunasInterior.BackColor = Color.White;
            pnlProximasVacunasInterior.Controls.Add(pnlCuerpoProximasVacunas);
            pnlProximasVacunasInterior.Controls.Add(lblTituloProximasVacunas);
            pnlProximasVacunasInterior.Dock = DockStyle.Fill;
            pnlProximasVacunasInterior.Location = new Point(1, 2);
            pnlProximasVacunasInterior.Margin = new Padding(4, 5, 4, 5);
            pnlProximasVacunasInterior.Name = "pnlProximasVacunasInterior";
            pnlProximasVacunasInterior.Size = new Size(704, 639);
            pnlProximasVacunasInterior.TabIndex = 0;
            // 
            // pnlCuerpoProximasVacunas
            // 
            pnlCuerpoProximasVacunas.BackColor = Color.White;
            pnlCuerpoProximasVacunas.Controls.Add(dgvProximasVacunas);
            pnlCuerpoProximasVacunas.Dock = DockStyle.Fill;
            pnlCuerpoProximasVacunas.Location = new Point(0, 63);
            pnlCuerpoProximasVacunas.Margin = new Padding(4, 5, 4, 5);
            pnlCuerpoProximasVacunas.Name = "pnlCuerpoProximasVacunas";
            pnlCuerpoProximasVacunas.Padding = new Padding(14, 17, 14, 17);
            pnlCuerpoProximasVacunas.Size = new Size(704, 576);
            pnlCuerpoProximasVacunas.TabIndex = 0;
            // 
            // dgvProximasVacunas
            // 
            dgvProximasVacunas.AllowUserToAddRows = false;
            dgvProximasVacunas.AllowUserToDeleteRows = false;
            dgvProximasVacunas.AllowUserToResizeRows = false;
            dgvProximasVacunas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProximasVacunas.BackgroundColor = Color.White;
            dgvProximasVacunas.BorderStyle = BorderStyle.None;
            dgvProximasVacunas.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvProximasVacunas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(201, 242, 211);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(20, 37, 28);
            dataGridViewCellStyle3.Padding = new Padding(6, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(201, 242, 211);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(20, 37, 28);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvProximasVacunas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvProximasVacunas.ColumnHeadersHeight = 38;
            dgvProximasVacunas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvProximasVacunas.Columns.AddRange(new DataGridViewColumn[] { colProximasVacunasFecha, colProximasVacunasMascota, colProximasVacunasVacuna });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10.5F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(20, 37, 28);
            dataGridViewCellStyle4.Padding = new Padding(6, 0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(201, 242, 211);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(20, 37, 28);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvProximasVacunas.DefaultCellStyle = dataGridViewCellStyle4;
            dgvProximasVacunas.Dock = DockStyle.Fill;
            dgvProximasVacunas.EnableHeadersVisualStyles = false;
            dgvProximasVacunas.GridColor = Color.FromArgb(217, 224, 228);
            dgvProximasVacunas.Location = new Point(14, 17);
            dgvProximasVacunas.Margin = new Padding(4, 5, 4, 5);
            dgvProximasVacunas.MultiSelect = false;
            dgvProximasVacunas.Name = "dgvProximasVacunas";
            dgvProximasVacunas.ReadOnly = true;
            dgvProximasVacunas.RowHeadersVisible = false;
            dgvProximasVacunas.RowHeadersWidth = 62;
            dgvProximasVacunas.RowTemplate.Height = 34;
            dgvProximasVacunas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProximasVacunas.Size = new Size(676, 542);
            dgvProximasVacunas.TabIndex = 0;
            // 
            // colProximasVacunasFecha
            // 
            colProximasVacunasFecha.HeaderText = "Fecha";
            colProximasVacunasFecha.MinimumWidth = 8;
            colProximasVacunasFecha.Name = "colProximasVacunasFecha";
            colProximasVacunasFecha.ReadOnly = true;
            // 
            // colProximasVacunasMascota
            // 
            colProximasVacunasMascota.HeaderText = "Mascota";
            colProximasVacunasMascota.MinimumWidth = 8;
            colProximasVacunasMascota.Name = "colProximasVacunasMascota";
            colProximasVacunasMascota.ReadOnly = true;
            // 
            // colProximasVacunasVacuna
            // 
            colProximasVacunasVacuna.HeaderText = "Vacuna";
            colProximasVacunasVacuna.MinimumWidth = 8;
            colProximasVacunasVacuna.Name = "colProximasVacunasVacuna";
            colProximasVacunasVacuna.ReadOnly = true;
            // 
            // lblTituloProximasVacunas
            // 
            lblTituloProximasVacunas.BackColor = Color.FromArgb(0, 77, 43);
            lblTituloProximasVacunas.Dock = DockStyle.Top;
            lblTituloProximasVacunas.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblTituloProximasVacunas.ForeColor = Color.White;
            lblTituloProximasVacunas.Location = new Point(0, 0);
            lblTituloProximasVacunas.Margin = new Padding(4, 0, 4, 0);
            lblTituloProximasVacunas.Name = "lblTituloProximasVacunas";
            lblTituloProximasVacunas.Padding = new Padding(17, 0, 0, 0);
            lblTituloProximasVacunas.Size = new Size(704, 63);
            lblTituloProximasVacunas.TabIndex = 1;
            lblTituloProximasVacunas.Text = "Próximas Vacunas";
            lblTituloProximasVacunas.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlRecordatorio
            // 
            pnlRecordatorio.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlRecordatorio.BackColor = Color.FromArgb(0, 140, 69);
            pnlRecordatorio.Controls.Add(pnlRecordatorioInterior);
            pnlRecordatorio.Location = new Point(363, 1070);
            pnlRecordatorio.Margin = new Padding(4, 5, 4, 5);
            pnlRecordatorio.Name = "pnlRecordatorio";
            pnlRecordatorio.Padding = new Padding(1, 2, 1, 2);
            pnlRecordatorio.Size = new Size(1431, 130);
            pnlRecordatorio.TabIndex = 5;
            // 
            // pnlRecordatorioInterior
            // 
            pnlRecordatorioInterior.BackColor = Color.FromArgb(201, 242, 211);
            pnlRecordatorioInterior.Controls.Add(lblRecordatorioEtiqueta);
            pnlRecordatorioInterior.Controls.Add(lblRecordatorio);
            pnlRecordatorioInterior.Dock = DockStyle.Fill;
            pnlRecordatorioInterior.Location = new Point(1, 2);
            pnlRecordatorioInterior.Margin = new Padding(4, 5, 4, 5);
            pnlRecordatorioInterior.Name = "pnlRecordatorioInterior";
            pnlRecordatorioInterior.Size = new Size(1429, 126);
            pnlRecordatorioInterior.TabIndex = 0;
            // 
            // lblRecordatorioEtiqueta
            // 
            lblRecordatorioEtiqueta.BackColor = Color.FromArgb(0, 77, 43);
            lblRecordatorioEtiqueta.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblRecordatorioEtiqueta.ForeColor = Color.White;
            lblRecordatorioEtiqueta.Location = new Point(20, 23);
            lblRecordatorioEtiqueta.Margin = new Padding(4, 0, 4, 0);
            lblRecordatorioEtiqueta.Name = "lblRecordatorioEtiqueta";
            lblRecordatorioEtiqueta.Size = new Size(243, 80);
            lblRecordatorioEtiqueta.TabIndex = 0;
            lblRecordatorioEtiqueta.Text = "Recordatorio:";
            lblRecordatorioEtiqueta.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRecordatorio
            // 
            lblRecordatorio.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblRecordatorio.Font = new Font("Segoe UI", 13F);
            lblRecordatorio.ForeColor = Color.FromArgb(20, 37, 28);
            lblRecordatorio.Location = new Point(286, 23);
            lblRecordatorio.Margin = new Padding(4, 0, 4, 0);
            lblRecordatorio.Name = "lblRecordatorio";
            lblRecordatorio.Size = new Size(1114, 80);
            lblRecordatorio.TabIndex = 1;
            lblRecordatorio.Text = "Hay 0 vacunas programadas en los próximos días.";
            lblRecordatorio.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlLateral
            // 
            pnlLateral.BackColor = Color.FromArgb(0, 77, 43);
            pnlLateral.Controls.Add(flpMenu);
            pnlLateral.Controls.Add(pnlInferior);
            pnlLateral.Controls.Add(pnlMarca);
            pnlLateral.Dock = DockStyle.Left;
            pnlLateral.Location = new Point(0, 0);
            pnlLateral.Margin = new Padding(4, 5, 4, 5);
            pnlLateral.Name = "pnlLateral";
            pnlLateral.Size = new Size(329, 1233);
            pnlLateral.TabIndex = 6;
            // 
            // flpMenu
            // 
            flpMenu.Controls.Add(btnInicio);
            flpMenu.Controls.Add(btnDuenos);
            flpMenu.Controls.Add(btnMascotas);
            flpMenu.Controls.Add(btnConsultas);
            flpMenu.Controls.Add(btnVacunas);
            flpMenu.Controls.Add(btnReportes);
            flpMenu.Controls.Add(btnUsuarios);
            flpMenu.Dock = DockStyle.Fill;
            flpMenu.FlowDirection = FlowDirection.TopDown;
            flpMenu.Location = new Point(0, 207);
            flpMenu.Margin = new Padding(4, 5, 4, 5);
            flpMenu.Name = "flpMenu";
            flpMenu.Padding = new Padding(17, 23, 17, 0);
            flpMenu.Size = new Size(329, 886);
            flpMenu.TabIndex = 0;
            flpMenu.WrapContents = false;
            flpMenu.Paint += flpMenu_Paint;
            // 
            // btnInicio
            // 
            btnInicio.BackColor = Color.FromArgb(0, 176, 80);
            btnInicio.Cursor = Cursors.Hand;
            btnInicio.FlatAppearance.BorderSize = 0;
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnInicio.ForeColor = Color.White;
            btnInicio.Location = new Point(17, 23);
            btnInicio.Margin = new Padding(0, 0, 0, 13);
            btnInicio.Name = "btnInicio";
            btnInicio.Padding = new Padding(20, 0, 0, 0);
            btnInicio.Size = new Size(294, 83);
            btnInicio.TabIndex = 0;
            btnInicio.Text = "Inicio";
            btnInicio.TextAlign = ContentAlignment.MiddleLeft;
            btnInicio.UseVisualStyleBackColor = false;
            // 
            // btnDuenos
            // 
            btnDuenos.BackColor = Color.FromArgb(10, 92, 55);
            btnDuenos.Cursor = Cursors.Hand;
            btnDuenos.FlatAppearance.BorderSize = 0;
            btnDuenos.FlatStyle = FlatStyle.Flat;
            btnDuenos.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDuenos.ForeColor = Color.White;
            btnDuenos.Location = new Point(17, 119);
            btnDuenos.Margin = new Padding(0, 0, 0, 13);
            btnDuenos.Name = "btnDuenos";
            btnDuenos.Padding = new Padding(20, 0, 0, 0);
            btnDuenos.Size = new Size(294, 83);
            btnDuenos.TabIndex = 1;
            btnDuenos.Text = "Dueños";
            btnDuenos.TextAlign = ContentAlignment.MiddleLeft;
            btnDuenos.UseVisualStyleBackColor = false;
            btnDuenos.Click += Menu_Click;
            // 
            // btnMascotas
            // 
            btnMascotas.BackColor = Color.FromArgb(10, 92, 55);
            btnMascotas.Cursor = Cursors.Hand;
            btnMascotas.FlatAppearance.BorderSize = 0;
            btnMascotas.FlatStyle = FlatStyle.Flat;
            btnMascotas.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnMascotas.ForeColor = Color.White;
            btnMascotas.Location = new Point(17, 215);
            btnMascotas.Margin = new Padding(0, 0, 0, 13);
            btnMascotas.Name = "btnMascotas";
            btnMascotas.Padding = new Padding(20, 0, 0, 0);
            btnMascotas.Size = new Size(294, 83);
            btnMascotas.TabIndex = 2;
            btnMascotas.Text = "Mascotas";
            btnMascotas.TextAlign = ContentAlignment.MiddleLeft;
            btnMascotas.UseVisualStyleBackColor = false;
            btnMascotas.Click += Menu_Click;
            // 
            // btnConsultas
            // 
            btnConsultas.BackColor = Color.FromArgb(10, 92, 55);
            btnConsultas.Cursor = Cursors.Hand;
            btnConsultas.FlatAppearance.BorderSize = 0;
            btnConsultas.FlatStyle = FlatStyle.Flat;
            btnConsultas.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnConsultas.ForeColor = Color.White;
            btnConsultas.Location = new Point(17, 311);
            btnConsultas.Margin = new Padding(0, 0, 0, 13);
            btnConsultas.Name = "btnConsultas";
            btnConsultas.Padding = new Padding(20, 0, 0, 0);
            btnConsultas.Size = new Size(294, 83);
            btnConsultas.TabIndex = 3;
            btnConsultas.Text = "Consultas";
            btnConsultas.TextAlign = ContentAlignment.MiddleLeft;
            btnConsultas.UseVisualStyleBackColor = false;
            btnConsultas.Click += Menu_Click;
            // 
            // btnVacunas
            // 
            btnVacunas.BackColor = Color.FromArgb(10, 92, 55);
            btnVacunas.Cursor = Cursors.Hand;
            btnVacunas.FlatAppearance.BorderSize = 0;
            btnVacunas.FlatStyle = FlatStyle.Flat;
            btnVacunas.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnVacunas.ForeColor = Color.White;
            btnVacunas.Location = new Point(17, 407);
            btnVacunas.Margin = new Padding(0, 0, 0, 13);
            btnVacunas.Name = "btnVacunas";
            btnVacunas.Padding = new Padding(20, 0, 0, 0);
            btnVacunas.Size = new Size(294, 83);
            btnVacunas.TabIndex = 4;
            btnVacunas.Text = "Vacunas";
            btnVacunas.TextAlign = ContentAlignment.MiddleLeft;
            btnVacunas.UseVisualStyleBackColor = false;
            btnVacunas.Click += Menu_Click;
            // 
            // btnReportes
            // 
            btnReportes.BackColor = Color.FromArgb(10, 92, 55);
            btnReportes.Cursor = Cursors.Hand;
            btnReportes.FlatAppearance.BorderSize = 0;
            btnReportes.FlatStyle = FlatStyle.Flat;
            btnReportes.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnReportes.ForeColor = Color.White;
            btnReportes.Location = new Point(17, 503);
            btnReportes.Margin = new Padding(0, 0, 0, 13);
            btnReportes.Name = "btnReportes";
            btnReportes.Padding = new Padding(20, 0, 0, 0);
            btnReportes.Size = new Size(294, 83);
            btnReportes.TabIndex = 5;
            btnReportes.Text = "Reportes";
            btnReportes.TextAlign = ContentAlignment.MiddleLeft;
            btnReportes.UseVisualStyleBackColor = false;
            btnReportes.Click += Menu_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.BackColor = Color.FromArgb(10, 92, 55);
            btnUsuarios.Cursor = Cursors.Hand;
            btnUsuarios.FlatAppearance.BorderSize = 0;
            btnUsuarios.FlatStyle = FlatStyle.Flat;
            btnUsuarios.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnUsuarios.ForeColor = Color.White;
            btnUsuarios.Location = new Point(17, 599);
            btnUsuarios.Margin = new Padding(0, 0, 0, 13);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Padding = new Padding(20, 0, 0, 0);
            btnUsuarios.Size = new Size(294, 83);
            btnUsuarios.TabIndex = 6;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.TextAlign = ContentAlignment.MiddleLeft;
            btnUsuarios.UseVisualStyleBackColor = false;
            btnUsuarios.Visible = false;
            btnUsuarios.Click += Menu_Click;
            // 
            // pnlInferior
            // 
            pnlInferior.BackColor = Color.FromArgb(0, 77, 43);
            pnlInferior.Controls.Add(btnCerrarSesion);
            pnlInferior.Dock = DockStyle.Bottom;
            pnlInferior.Location = new Point(0, 1093);
            pnlInferior.Margin = new Padding(4, 5, 4, 5);
            pnlInferior.Name = "pnlInferior";
            pnlInferior.Padding = new Padding(17, 23, 17, 27);
            pnlInferior.Size = new Size(329, 140);
            pnlInferior.TabIndex = 1;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.FromArgb(10, 92, 55);
            btnCerrarSesion.Cursor = Cursors.Hand;
            btnCerrarSesion.Dock = DockStyle.Fill;
            btnCerrarSesion.FlatAppearance.BorderColor = Color.FromArgb(46, 138, 94);
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCerrarSesion.ForeColor = Color.White;
            btnCerrarSesion.Location = new Point(17, 23);
            btnCerrarSesion.Margin = new Padding(4, 5, 4, 5);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(295, 90);
            btnCerrarSesion.TabIndex = 0;
            btnCerrarSesion.Text = "Cerrar Sesión";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // pnlMarca
            // 
            pnlMarca.BackColor = Color.FromArgb(0, 77, 43);
            pnlMarca.Controls.Add(lblClinica);
            pnlMarca.Controls.Add(lblClinicaSub);
            pnlMarca.Controls.Add(pnlLinea);
            pnlMarca.Dock = DockStyle.Top;
            pnlMarca.Location = new Point(0, 0);
            pnlMarca.Margin = new Padding(4, 5, 4, 5);
            pnlMarca.Name = "pnlMarca";
            pnlMarca.Size = new Size(329, 207);
            pnlMarca.TabIndex = 2;
            // 
            // lblClinica
            // 
            lblClinica.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            lblClinica.ForeColor = Color.White;
            lblClinica.Location = new Point(0, 37);
            lblClinica.Margin = new Padding(4, 0, 4, 0);
            lblClinica.Name = "lblClinica";
            lblClinica.Size = new Size(329, 77);
            lblClinica.TabIndex = 0;
            lblClinica.Text = "Mundo Animal";
            lblClinica.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblClinicaSub
            // 
            lblClinicaSub.Font = new Font("Segoe UI", 11F);
            lblClinicaSub.ForeColor = Color.White;
            lblClinicaSub.Location = new Point(0, 113);
            lblClinicaSub.Margin = new Padding(4, 0, 4, 0);
            lblClinicaSub.Name = "lblClinicaSub";
            lblClinicaSub.Size = new Size(329, 47);
            lblClinicaSub.TabIndex = 1;
            lblClinicaSub.Text = "Clínica Veterinaria";
            lblClinicaSub.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlLinea
            // 
            pnlLinea.BackColor = Color.White;
            pnlLinea.Location = new Point(51, 177);
            pnlLinea.Margin = new Padding(4, 5, 4, 5);
            pnlLinea.Name = "pnlLinea";
            pnlLinea.Size = new Size(226, 3);
            pnlLinea.TabIndex = 2;
            // 
            // frmInicio
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1829, 1233);
            Controls.Add(lblTitulo);
            Controls.Add(lblSubtitulo);
            Controls.Add(lblFecha);
            Controls.Add(tlpTarjetas);
            Controls.Add(tlpTablas);
            Controls.Add(pnlRecordatorio);
            Controls.Add(pnlLateral);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmInicio";
            Text = "Inicio";
            Load += frmInicio_Load;
            tlpTarjetas.ResumeLayout(false);
            pnlMascotas.ResumeLayout(false);
            pnlMascotasInterior.ResumeLayout(false);
            pnlDuenos.ResumeLayout(false);
            pnlDuenosInterior.ResumeLayout(false);
            pnlConsultasHoy.ResumeLayout(false);
            pnlConsultasHoyInterior.ResumeLayout(false);
            pnlVacunasProximas.ResumeLayout(false);
            pnlVacunasProximasInterior.ResumeLayout(false);
            tlpTablas.ResumeLayout(false);
            pnlConsultasRecientes.ResumeLayout(false);
            pnlConsultasRecientesInterior.ResumeLayout(false);
            pnlCuerpoConsultasRecientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvConsultasRecientes).EndInit();
            pnlProximasVacunas.ResumeLayout(false);
            pnlProximasVacunasInterior.ResumeLayout(false);
            pnlCuerpoProximasVacunas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProximasVacunas).EndInit();
            pnlRecordatorio.ResumeLayout(false);
            pnlRecordatorioInterior.ResumeLayout(false);
            pnlLateral.ResumeLayout(false);
            flpMenu.ResumeLayout(false);
            pnlInferior.ResumeLayout(false);
            pnlMarca.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TableLayoutPanel tlpTarjetas;
        private System.Windows.Forms.Panel pnlMascotas;
        private System.Windows.Forms.Panel pnlMascotasInterior;
        private System.Windows.Forms.Label lblMascotas;
        private System.Windows.Forms.Label lblTituloMascotas;
        private System.Windows.Forms.Panel pnlDuenos;
        private System.Windows.Forms.Panel pnlDuenosInterior;
        private System.Windows.Forms.Label lblDuenos;
        private System.Windows.Forms.Label lblTituloDuenos;
        private System.Windows.Forms.Panel pnlConsultasHoy;
        private System.Windows.Forms.Panel pnlConsultasHoyInterior;
        private System.Windows.Forms.Label lblConsultasHoy;
        private System.Windows.Forms.Label lblTituloConsultasHoy;
        private System.Windows.Forms.Panel pnlVacunasProximas;
        private System.Windows.Forms.Panel pnlVacunasProximasInterior;
        private System.Windows.Forms.Label lblVacunasProximas;
        private System.Windows.Forms.Label lblTituloVacunasProximas;
        private System.Windows.Forms.TableLayoutPanel tlpTablas;
        private System.Windows.Forms.Panel pnlConsultasRecientes;
        private System.Windows.Forms.Panel pnlConsultasRecientesInterior;
        private System.Windows.Forms.Panel pnlCuerpoConsultasRecientes;
        private System.Windows.Forms.DataGridView dgvConsultasRecientes;
        private System.Windows.Forms.Label lblTituloConsultasRecientes;
        private System.Windows.Forms.Panel pnlProximasVacunas;
        private System.Windows.Forms.Panel pnlProximasVacunasInterior;
        private System.Windows.Forms.Panel pnlCuerpoProximasVacunas;
        private System.Windows.Forms.DataGridView dgvProximasVacunas;
        private System.Windows.Forms.Label lblTituloProximasVacunas;
        private System.Windows.Forms.Panel pnlRecordatorio;
        private System.Windows.Forms.Panel pnlRecordatorioInterior;
        private System.Windows.Forms.Label lblRecordatorioEtiqueta;
        private System.Windows.Forms.Label lblRecordatorio;
        private System.Windows.Forms.Panel pnlLateral;
        private System.Windows.Forms.FlowLayoutPanel flpMenu;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnDuenos;
        private System.Windows.Forms.Button btnMascotas;
        private System.Windows.Forms.Button btnConsultas;
        private System.Windows.Forms.Button btnVacunas;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Panel pnlInferior;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Panel pnlMarca;
        private System.Windows.Forms.Label lblClinica;
        private System.Windows.Forms.Label lblClinicaSub;
        private System.Windows.Forms.Panel pnlLinea;
        private System.Windows.Forms.DataGridViewTextBoxColumn colConsultasRecientesFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colConsultasRecientesMascota;
        private System.Windows.Forms.DataGridViewTextBoxColumn colConsultasRecientesDueno;
        private System.Windows.Forms.DataGridViewTextBoxColumn colConsultasRecientesMotivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProximasVacunasFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProximasVacunasMascota;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProximasVacunasVacuna;
    }
}
