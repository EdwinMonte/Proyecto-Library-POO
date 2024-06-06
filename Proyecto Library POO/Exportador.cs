using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using Newtonsoft.Json;
using OfficeOpenXml;
using Proyecto_Library_POO;

public static class Exportador
{
    public static void ExportarADocx(Biblioteca biblioteca, string filePath)
    {
        using (WordprocessingDocument wordDocument = WordprocessingDocument.Create(filePath, DocumentFormat.OpenXml.WordprocessingDocumentType.Document))
        {
            MainDocumentPart mainPart = wordDocument.AddMainDocumentPart();
            mainPart.Document = new Document();
            Body body = new Body();

            foreach (Libro libro in biblioteca.ObtenerLibros())
            {
                Paragraph paragraph = new Paragraph();
                Run run = new Run();
                run.Append(new Text($"{libro.Titulo}, {libro.Autor}, {libro.Paginas} páginas, {libro.Precio:C}, Sucursal: {libro.Sucursal}"));
                paragraph.Append(run);
                body.Append(paragraph);
            }

            mainPart.Document.Append(body);
            mainPart.Document.Save();
        }

        // Abre el archivo DOCX
        Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });
    }

    public static void ExportarAExcel(string rutaArchivo, List<Libro> libros)
    {
        ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        using (ExcelPackage package = new ExcelPackage())
        {
            ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Libros");

            // Crear encabezados de columnas
            worksheet.Cells[1, 1].Value = "Título";
            worksheet.Cells[1, 2].Value = "Autor";
            worksheet.Cells[1, 3].Value = "Páginas";
            worksheet.Cells[1, 4].Value = "Precio";
            worksheet.Cells[1, 5].Value = "Sucursal";

            // Añadir los datos de los libros
            int row = 2;
            foreach (var libro in libros)
            {
                worksheet.Cells[row, 1].Value = libro.Titulo;
                worksheet.Cells[row, 2].Value = libro.Autor;
                worksheet.Cells[row, 3].Value = libro.Paginas;
                worksheet.Cells[row, 4].Value = libro.Precio.ToString("C", CultureInfo.CurrentCulture);
                worksheet.Cells[row, 5].Value = libro.Sucursal;
                row++;
            }

            // Guardar el archivo
            FileInfo fileInfo = new FileInfo(rutaArchivo);
            package.SaveAs(fileInfo);
        }

        // Abrir el archivo automáticamente
        Process.Start(new ProcessStartInfo(rutaArchivo) { UseShellExecute = true });
    }


    public static void ExportarAJson(Biblioteca biblioteca, string filePath)
    {
        string json = JsonConvert.SerializeObject(biblioteca.ObtenerLibros(), Formatting.Indented);
        File.WriteAllText(filePath, json);

        // Abre el archivo JSON
        Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });
    }
}
