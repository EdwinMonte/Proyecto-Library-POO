using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using DocumentFormat.OpenXml.Wordprocessing;
using Text = DocumentFormat.OpenXml.Wordprocessing.Text;

namespace Proyecto_Library_POO
{
    public class Biblioteca
{
    private Libro[] libros;
    private int indice;

    public Biblioteca(int tamañoMaximo)
    {
        libros = new Libro[tamañoMaximo];
        indice = 0;
    }

    public Libro[] ObtenerLibros()
    {
        // Retorna solo los elementos llenos del arreglo
        return libros.Where(libro => libro != null).ToArray();
    }

    public void AgregarLibro(Libro libro)
    {
        if (indice < libros.Length)
        {
            libros[indice] = libro;
            indice++;
        }
        else
        {
            throw new InvalidOperationException("No hay espacio para más libros en la biblioteca.");
        }
    }

    public void EliminarLibro(Libro libro)
    {
        for (int i = 0; i < libros.Length; i++)
        {
            if (libros[i] != null && libros[i].Equals(libro))
            {
                libros[i] = null;
                // Compactar el arreglo
                for (int j = i; j < libros.Length - 1; j++)
                {
                    libros[j] = libros[j + 1];
                }
                libros[libros.Length - 1] = null;
                indice--;
                break;
            }
        }
    }

        public static void ExportarAJson(Biblioteca biblioteca, string rutaArchivo)
        {
            string json = JsonSerializer.Serialize(biblioteca.libros);
            File.WriteAllText(rutaArchivo, json);
        }

        
    }
}
