using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Library_POO
{
    public partial class FormActionBook : Form
    {
        private Biblioteca biblioteca;
        private string titulo;
        private string autor;
        private int paginas;
        private decimal precio;
        private string sucursal;

        public Libro LibroSeleccionado { get; private set; }

        public FormActionBook(string titulo, string autor, int paginas, decimal precio, string sucursal)
        {
            InitializeComponent();
            lblTitle.Text = $"Título: {titulo}";
            lblPrice.Text = $"Precio: {precio:C}";
            lblSucursal.Text = $"Sucursal: {sucursal}"; // Asegúrate de tener un Label para la sucursal
            LibroSeleccionado = new Libro(titulo, autor, paginas, precio, sucursal);
        }

        private void btnToLend_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"El libro '{LibroSeleccionado.Titulo}' ha sido prestado.");
            this.Close();
        }

        private void btnPrice_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"El libro '{LibroSeleccionado.Titulo}' ha sido vendido.");
            this.Close();
        }
    }
}

