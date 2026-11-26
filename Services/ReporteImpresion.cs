using System.Drawing.Printing;

namespace MundoAnimal.Services
{
    // Dibuja el contenido de una tabla (DataGridView) para la vista previa o para guardarlo como PDF
    public class ReporteImpresion
    {
        private DataGridView tabla;
        private string titulo;
        private string rango;
        private int filaActual;

        public PrintDocument Documento;

        public ReporteImpresion(DataGridView tabla, string titulo, string rango)
        {
            this.tabla = tabla;
            this.titulo = titulo;
            this.rango = rango;

            Documento = new PrintDocument();
            Documento.DocumentName = titulo;
            Documento.BeginPrint += new PrintEventHandler(EmpezarImpresion);
            Documento.PrintPage += new PrintPageEventHandler(ImprimirPagina);
        }

        private void EmpezarImpresion(object sender, PrintEventArgs e)
        {
            filaActual = 0;
        }

        private void ImprimirPagina(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Font fuenteMarca = new Font("Segoe UI", 11, FontStyle.Bold);
            Font fuenteTitulo = new Font("Segoe UI", 18, FontStyle.Bold);
            Font fuenteTexto = new Font("Segoe UI", 10);
            Font fuenteEncabezado = new Font("Segoe UI", 10, FontStyle.Bold);
            SolidBrush verdeOscuro = new SolidBrush(Color.FromArgb(0, 77, 43));
            SolidBrush verdeClaro = new SolidBrush(Color.FromArgb(201, 242, 211));
            SolidBrush negro = new SolidBrush(Color.Black);

            int izquierda = e.MarginBounds.Left;
            int y = e.MarginBounds.Top;

            g.DrawString("Mundo Animal - Clínica Veterinaria", fuenteMarca, verdeOscuro, izquierda, y);
            y = y + 26;
            g.DrawString(titulo, fuenteTitulo, verdeOscuro, izquierda, y);
            y = y + 38;
            g.DrawString(rango, fuenteTexto, negro, izquierda, y);
            y = y + 34;

            int columnas = tabla.Columns.Count;
            int anchoColumna = e.MarginBounds.Width / columnas;
            int altoFila = 26;

            // Encabezados
            g.FillRectangle(verdeClaro, izquierda, y, e.MarginBounds.Width, altoFila);
            for (int i = 0; i < columnas; i++)
            {
                RectangleF celda = new RectangleF(izquierda + (i * anchoColumna) + 4, y + 4, anchoColumna - 8, altoFila);
                g.DrawString(tabla.Columns[i].HeaderText, fuenteEncabezado, negro, celda);
            }
            y = y + altoFila;

            // Filas
            while (filaActual < tabla.Rows.Count && y + altoFila < e.MarginBounds.Bottom)
            {
                for (int i = 0; i < columnas; i++)
                {
                    object valor = tabla.Rows[filaActual].Cells[i].Value;
                    string texto = "";
                    if (valor != null)
                    {
                        texto = valor.ToString();
                    }
                    RectangleF celda = new RectangleF(izquierda + (i * anchoColumna) + 4, y + 4, anchoColumna - 8, altoFila);
                    g.DrawString(texto, fuenteTexto, negro, celda);
                }
                y = y + altoFila;
                filaActual++;
            }

            if (filaActual < tabla.Rows.Count)
            {
                e.HasMorePages = true;    // faltan filas: se imprime otra página
            }
            else
            {
                e.HasMorePages = false;
            }
        }
    }
}
