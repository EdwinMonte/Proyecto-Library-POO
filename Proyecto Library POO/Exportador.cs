using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using Newtonsoft.Json;
using OfficeOpenXml;
using Proyecto_Library_POO;
using ClosedXML.Excel;



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

    public static void ExportarAExcel(string rutaArchivo, Libro[] libros)
    {
        using (var workbook = new XLWorkbook())
        {
            var worksheet = workbook.Worksheets.Add("Libros");

            worksheet.Cell(1, 1).Value = "Título";
            worksheet.Cell(1, 2).Value = "Autor";
            worksheet.Cell(1, 3).Value = "Páginas";
            worksheet.Cell(1, 4).Value = "Precio";
            worksheet.Cell(1, 5).Value = "Sucursal";

            for (int i = 0; i < libros.Length; i++)
            {
                worksheet.Cell(i + 2, 1).Value = libros[i].Titulo;
                worksheet.Cell(i + 2, 2).Value = libros[i].Autor;
                worksheet.Cell(i + 2, 3).Value = libros[i].Paginas;
                worksheet.Cell(i + 2, 4).Value = libros[i].Precio;
                worksheet.Cell(i + 2, 5).Value = libros[i].Sucursal;
            }

            workbook.SaveAs(rutaArchivo);
        }

        // Abre el archivo Excel
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

