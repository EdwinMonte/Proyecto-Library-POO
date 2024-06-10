using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;

namespace Proyecto_Library_POO
{
    internal static class Program
    {
        public static void ExportarAExcel(Biblioteca biblioteca, string rutaArchivo)
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Libros");

                worksheet.Cell("A1").Value = "Título";
                worksheet.Cell("B1").Value = "Autor";
                worksheet.Cell("C1").Value = "Páginas";

                int row = 2;
                foreach (Libro libro in biblioteca.ObtenerLibros())
                {
                    worksheet.Cell($"A{row}").Value = libro.Titulo;
                    worksheet.Cell($"B{row}").Value = libro.Autor;
                    worksheet.Cell($"C{row}").Value = libro.Paginas;
                    row++;
                }

                workbook.SaveAs(rutaArchivo);
            }
        }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                // Suponiendo que obtuviste el nombre y correo del usuario en FormBienvenida
                string nombreUsuario = "Nombre del Usuario";
                string correoUsuario = "correo@ejemplo.com";

               
                

                FormBienvenida bienvenidaForm = new FormBienvenida();
                if (bienvenidaForm.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new Form1());
                }
            }
        }
    }
}