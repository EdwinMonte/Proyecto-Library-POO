using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Library_POO
{
    public class Libro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int Paginas { get; set; }
        public decimal Precio { get; set; }
        public string Sucursal { get; set; } 

        public Libro(string titulo, string autor, int paginas, decimal precio, string sucursal)
        {
            Titulo = titulo;
            Autor = autor;
            Paginas = paginas;
            Precio = precio;
            Sucursal = sucursal;
        }
    }
}
