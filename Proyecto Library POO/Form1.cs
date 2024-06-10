namespace Proyecto_Library_POO
{
    public partial class Form1 : Form
    {
       
        private Biblioteca biblioteca;

        public Form1()
        {
            InitializeComponent();
            biblioteca = new Biblioteca(100);
            ConfigurarListView();
            // Configurar columnas del ListView
            lstvLibros.View = View.Details;
            lstvLibros.Columns.Add("Título", 150);
            lstvLibros.Columns.Add("Autor", 150);
            lstvLibros.Columns.Add("Páginas", 70);
            lstvLibros.Columns.Add("Precio", 70);
            lstvLibros.Columns.Add("Sucursal", 100);

            
        }

       

        private void ConfigurarListView()
        {
            lstvLibros.MouseDoubleClick += lstvLibros_MouseDoubleClick;
        }

        private void btnaddbook_Click(object sender, EventArgs e)
        {
            string titulo = txtTitulo.Text;
            string autor = txtAutor.Text;
            string sucursal = txtSucursal.Text; // Nueva entrada para la sucursal
            if (int.TryParse(txtPaginas.Text, out int paginas) && decimal.TryParse(txtPrice.Text, out decimal precio))
            {
                Libro libro = new Libro(titulo, autor, paginas, precio, sucursal);
                biblioteca.AgregarLibro(libro);
                ActualizarListaLibros();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese datos válidos para páginas y precio.");
            }
        }

        private void ActualizarListaLibros()
        {
            lstvLibros.Items.Clear();
            foreach (var libro in biblioteca.ObtenerLibros())
            {
                ListViewItem item = new ListViewItem(new[] { libro.Titulo, libro.Autor, libro.Paginas.ToString(), libro.Precio.ToString("C"), libro.Sucursal });
                lstvLibros.Items.Add(item);
            }
        }

        private void LimpiarCampos()
        {
            txtTitulo.Clear();
            txtAutor.Clear();
            txtPaginas.Clear();
            txtPrice.Clear();
            txtSucursal.Clear(); // Limpiar también la sucursal
        }

        private void btnExportJSON_Click(object sender, EventArgs e)
        {
            if (lstvLibros.Items.Count == 0)
            {
                MessageBox.Show("No hay libros en la lista para exportar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos JSON (*.json)|*.json";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Biblioteca.ExportarAJson(biblioteca, saveFileDialog.FileName);
                MessageBox.Show("Biblioteca exportada exitosamente.");
                
            }
        }

        private void btnExportWord_Click(object sender, EventArgs e)
        {
            if (lstvLibros.Items.Count == 0)
            {
                MessageBox.Show("No hay libros en la lista para exportar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos Word (*.docx)|*.docx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Exportador.ExportarADocx(biblioteca, saveFileDialog.FileName);
                MessageBox.Show("Biblioteca exportada exitosamente a Word.");
                System.Diagnostics.Process.Start(saveFileDialog.FileName);
            }
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            if (lstvLibros.Items.Count == 0)
            {
                MessageBox.Show("No hay libros para exportar.");
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos Excel (*.xlsx)|*.xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Exportador.ExportarAExcel(saveFileDialog.FileName, biblioteca.ObtenerLibros());
                    MessageBox.Show("Datos exportados exitosamente a Excel.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al exportar a Excel: " + ex.Message);
                }
            }
        }

        private void btnChargingtxt_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    CargarDesdeTxt(openFileDialog.FileName);
                    MessageBox.Show("Biblioteca cargada exitosamente desde el archivo TXT.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cargar desde el archivo TXT: " + ex.Message);
            }
        }

        private void btnSavetxt_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    GuardarATxt(saveFileDialog.FileName);
                    MessageBox.Show("Biblioteca guardada exitosamente en el archivo TXT.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al guardar en el archivo TXT: " + ex.Message);
            }
        }

        private void CargarDesdeTxt(string rutaArchivo)
        {
            biblioteca = new Biblioteca(100); // Reiniciar la biblioteca
            string[] lineas = File.ReadAllLines(rutaArchivo);
            foreach (string linea in lineas)
            {
                string[] partes = linea.Split(';');
                if (partes.Length == 5)
                {
                    string titulo = partes[0];
                    string autor = partes[1];
                    string sucursal = partes[4];
                    if (int.TryParse(partes[2], out int paginas) && decimal.TryParse(partes[3], out decimal precio))
                    {
                        Libro libro = new Libro(titulo, autor, paginas, precio, sucursal);
                        try
                        {
                            biblioteca.AgregarLibro(libro);
                        }
                        catch (InvalidOperationException)
                        {
                            // Ignorar si no hay más espacio en la biblioteca
                            break;
                        }
                    }
                }
            }
            ActualizarListaLibros();
        }

        private void GuardarATxt(string rutaArchivo)
        {
            List<string> lineas = new List<string>();
            foreach (Libro libro in biblioteca.ObtenerLibros())
            {
                lineas.Add($"{libro.Titulo};{libro.Autor};{libro.Paginas};{libro.Precio};{libro.Sucursal}");
            }
            File.WriteAllLines(rutaArchivo, lineas);
        }

        private void btnEliminarLibro_Click(object sender, EventArgs e)
        {
            if (lstvLibros.SelectedItems.Count > 0)
            {
                string titulo = lstvLibros.SelectedItems[0].Text;
                Libro libroAEliminar = biblioteca.ObtenerLibros().FirstOrDefault(l => l.Titulo == titulo);
                if (libroAEliminar != null)
                {
                    biblioteca.EliminarLibro(libroAEliminar);
                    ActualizarListaLibros();
                    MessageBox.Show("Libro eliminado exitosamente.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un libro para eliminar.");
            }
        }

        private void lstvLibros_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lstvLibros.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lstvLibros.SelectedItems[0];
                string titulo = selectedItem.SubItems[0].Text;
                string autor = selectedItem.SubItems[1].Text;
                int paginas = int.Parse(selectedItem.SubItems[2].Text);
                decimal precio = decimal.Parse(selectedItem.SubItems[3].Text, System.Globalization.NumberStyles.Currency);
                string sucursal = selectedItem.SubItems[4].Text;

                // Hide Form1
                this.Hide();

                FormActionBook formAccion = new FormActionBook(titulo, autor, paginas, precio, sucursal);
                formAccion.ShowDialog();

                // Elimina el libro de la lista después de que el FormActionBook se cierre, asumiendo que se ha vendido o prestado
                biblioteca.EliminarLibro(new Libro(titulo, autor, paginas, precio, sucursal));

                // Show Form1 again
                this.Show();

                // Update the ListView
                ActualizarListaLibros();
            }
        }

       
    }
}

