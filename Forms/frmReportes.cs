using System.Drawing.Printing;
using MundoAnimal.Data;
using MundoAnimal.Models;
using MundoAnimal.Services;
using MundoAnimal.UI;

namespace MundoAnimal.Forms
{
    public partial class frmReportes : Form
    {
        private string tituloReporte = "";
        private string rangoReporte = "";

        public frmReportes()
        {
            InitializeComponent();
        }

        // Vuelve a la pantalla de Inicio (donde está el menú)
        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal principal = (frmPrincipal)this.Parent.FindForm();
            principal.AbrirModulo("Inicio");
        }

        private void frmReportes_Load(object sender, EventArgs e)
        {
            // Por defecto: desde el primer día del mes hasta hoy
            dtpDesde.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtpHasta.Value = DateTime.Today;
        }

        // Cuenta cuántos registros del tipo elegido hay en un día
        private int ContarEnFecha(string tipo, DateTime dia)
        {
            int total = 0;

            if (tipo == "Dueños")
            {
                foreach (Dueno d in RepositorioDuenos.Todos())
                {
                    if (d.FechaRegistro.Date == dia.Date) total++;
                }
            }
            else if (tipo == "Mascotas")
            {
                foreach (Mascota m in RepositorioMascotas.Todas())
                {
                    if (m.FechaRegistro.Date == dia.Date) total++;
                }
            }
            else if (tipo == "Consultas")
            {
                foreach (Consulta c in RepositorioConsultas.Todas())
                {
                    if (c.Fecha.Date == dia.Date) total++;
                }
            }
            else if (tipo == "Vacunas")
            {
                foreach (RegistroVacuna r in RepositorioVacunas.Todos())
                {
                    if (r.FechaAplicacion.Date == dia.Date) total++;
                }
            }
            return total;
        }

        // Llena la tabla con un resumen por día. Devuelve false si falta algún dato.
        private bool GenerarReporte()
        {
            if (cmbTipo.Text == "")
            {
                Mensajes.Aviso("Seleccione el tipo de reporte.");
                return false;
            }

            DateTime desde = dtpDesde.Value.Date;
            DateTime hasta = dtpHasta.Value.Date;
            if (desde > hasta)
            {
                Mensajes.Aviso("La fecha Desde no puede ser posterior a la fecha Hasta.");
                return false;
            }

            string tipo = cmbTipo.Text;
            string descripcion = "";
            if (tipo == "Dueños") descripcion = "Dueños registrados";
            if (tipo == "Mascotas") descripcion = "Mascotas registradas";
            if (tipo == "Consultas") descripcion = "Consultas realizadas";
            if (tipo == "Vacunas") descripcion = "Vacunas aplicadas";

            dgvReporte.Rows.Clear();
            int numero = 0;
            int total = 0;

            // Se revisa día por día y se muestran solo los días que tienen registros
            DateTime dia = desde;
            while (dia <= hasta)
            {
                int cantidad = ContarEnFecha(tipo, dia);
                if (cantidad > 0)
                {
                    numero++;
                    total = total + cantidad;
                    dgvReporte.Rows.Add("R" + numero.ToString("000"), tipo, descripcion, dia.ToString("dd/MM/yyyy"), cantidad);
                }
                dia = dia.AddDays(1);
            }

            dgvReporte.Rows.Add("Total", tipo, "Total del período", "", total);
            dgvReporte.ClearSelection();

            tituloReporte = "Reporte de " + tipo;
            rangoReporte = "Período: " + desde.ToString("dd/MM/yyyy") + " al " + hasta.ToString("dd/MM/yyyy");
            return true;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (GenerarReporte() == false)
            {
                return;
            }
            if (dgvReporte.Rows.Count == 1)
            {
                Mensajes.Info("No hay registros de ese tipo en el período seleccionado.");
            }
        }

        private void btnVistaPrevia_Click(object sender, EventArgs e)
        {
            if (GenerarReporte() == false)
            {
                return;
            }

            try
            {
                ReporteImpresion reporte = new ReporteImpresion(dgvReporte, tituloReporte, rangoReporte);
                PrintPreviewDialog vista = new PrintPreviewDialog();
                vista.Document = reporte.Documento;
                vista.Width = 1000;
                vista.Height = 720;
                vista.ShowDialog();
            }
            catch (Exception ex)
            {
                Mensajes.Error("No se pudo mostrar la vista previa. Es posible que Windows no tenga impresoras instaladas.\n\n" + ex.Message);
            }
        }

        // Crea el PDF con la impresora virtual "Microsoft Print to PDF" que trae Windows
        private void btnExportarPdf_Click(object sender, EventArgs e)
        {
            if (GenerarReporte() == false)
            {
                return;
            }

            SaveFileDialog guardar = new SaveFileDialog();
            guardar.Filter = "Archivo PDF (*.pdf)|*.pdf";
            guardar.FileName = "Reporte_" + cmbTipo.Text + ".pdf";
            if (guardar.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            try
            {
                ReporteImpresion reporte = new ReporteImpresion(dgvReporte, tituloReporte, rangoReporte);
                reporte.Documento.PrinterSettings.PrinterName = "Microsoft Print to PDF";
                if (reporte.Documento.PrinterSettings.IsValid == false)
                {
                    Mensajes.Error("No se encontró la impresora \"Microsoft Print to PDF\" en este equipo.\nUse Vista Previa e imprima desde allí.");
                    return;
                }
                reporte.Documento.PrinterSettings.PrintToFile = true;
                reporte.Documento.PrinterSettings.PrintFileName = guardar.FileName;
                reporte.Documento.PrintController = new StandardPrintController();
                reporte.Documento.Print();
            }
            catch (Exception ex)
            {
                Mensajes.Error("No se pudo crear el PDF.\n\n" + ex.Message);
                return;
            }

            if (File.Exists(guardar.FileName))
            {
                Mensajes.Info("PDF generado:\n" + guardar.FileName);
            }
            else
            {
                Mensajes.Error("Windows no generó el archivo PDF. Use Vista Previa e imprima desde allí.");
            }
        }

        // Guarda un archivo .csv que Excel abre directamente
        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            if (GenerarReporte() == false)
            {
                return;
            }

            SaveFileDialog guardar = new SaveFileDialog();
            guardar.Filter = "Archivo para Excel (*.csv)|*.csv";
            guardar.FileName = "Reporte_" + cmbTipo.Text + ".csv";
            if (guardar.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            try
            {
                StreamWriter archivo = new StreamWriter(guardar.FileName, false, System.Text.Encoding.UTF8);

                // Encabezados
                string linea = "";
                for (int i = 0; i < dgvReporte.Columns.Count; i++)
                {
                    linea = linea + dgvReporte.Columns[i].HeaderText;
                    if (i < dgvReporte.Columns.Count - 1) linea = linea + ";";
                }
                archivo.WriteLine(linea);

                // Filas
                for (int fila = 0; fila < dgvReporte.Rows.Count; fila++)
                {
                    linea = "";
                    for (int i = 0; i < dgvReporte.Columns.Count; i++)
                    {
                        object valor = dgvReporte.Rows[fila].Cells[i].Value;
                        if (valor != null)
                        {
                            linea = linea + valor.ToString().Replace(";", ",");
                        }
                        if (i < dgvReporte.Columns.Count - 1) linea = linea + ";";
                    }
                    archivo.WriteLine(linea);
                }
                archivo.Close();
            }
            catch (Exception ex)
            {
                Mensajes.Error("No se pudo guardar el archivo.\n\n" + ex.Message);
                return;
            }

            Mensajes.Info("Archivo generado:\n" + guardar.FileName);
        }
    }
}
