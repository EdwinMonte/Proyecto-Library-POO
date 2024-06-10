namespace Proyecto_Library_POO
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtPrice = new TextBox();
            lblPrecio = new Label();
            btnEliminarLibro = new Button();
            lblPages = new Label();
            lblAuthor = new Label();
            lbltitle = new Label();
            lstvLibros = new ListView();
            btnSavetxt = new Button();
            btnChargingtxt = new Button();
            btnExportExcel = new Button();
            btnExportWord = new Button();
            btnExportJSON = new Button();
            btnaddbook = new Button();
            txtPaginas = new TextBox();
            txtAutor = new TextBox();
            txtTitulo = new TextBox();
            lblSucursal = new Label();
            txtSucursal = new TextBox();
            SuspendLayout();
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(169, 224);
            txtPrice.Multiline = true;
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(137, 34);
            txtPrice.TabIndex = 47;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrecio.Location = new Point(96, 233);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(54, 25);
            lblPrecio.TabIndex = 46;
            lblPrecio.Text = "Price";
            // 
            // btnEliminarLibro
            // 
            btnEliminarLibro.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminarLibro.Location = new Point(1201, 30);
            btnEliminarLibro.Name = "btnEliminarLibro";
            btnEliminarLibro.Size = new Size(131, 42);
            btnEliminarLibro.TabIndex = 45;
            btnEliminarLibro.Text = "Delete book";
            btnEliminarLibro.UseVisualStyleBackColor = true;
            btnEliminarLibro.Click += btnEliminarLibro_Click;
            // 
            // lblPages
            // 
            lblPages.AutoSize = true;
            lblPages.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPages.Location = new Point(88, 173);
            lblPages.Name = "lblPages";
            lblPages.Size = new Size(62, 25);
            lblPages.TabIndex = 44;
            lblPages.Text = "Pages";
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAuthor.Location = new Point(85, 120);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(72, 25);
            lblAuthor.TabIndex = 43;
            lblAuthor.Text = "Author";
            // 
            // lbltitle
            // 
            lbltitle.AutoSize = true;
            lbltitle.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbltitle.Location = new Point(88, 68);
            lbltitle.Name = "lbltitle";
            lbltitle.Size = new Size(50, 25);
            lbltitle.TabIndex = 41;
            lbltitle.Text = "Title";
            // 
            // lstvLibros
            // 
            lstvLibros.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstvLibros.Location = new Point(344, 27);
            lstvLibros.Name = "lstvLibros";
            lstvLibros.Size = new Size(851, 632);
            lstvLibros.TabIndex = 42;
            lstvLibros.UseCompatibleStateImageBehavior = false;
            lstvLibros.View = View.Details;
            // 
            // btnSavetxt
            // 
            btnSavetxt.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSavetxt.Location = new Point(85, 426);
            btnSavetxt.Name = "btnSavetxt";
            btnSavetxt.Size = new Size(125, 38);
            btnSavetxt.TabIndex = 40;
            btnSavetxt.Text = "Save txt";
            btnSavetxt.UseVisualStyleBackColor = true;
            btnSavetxt.Click += btnSavetxt_Click;
            // 
            // btnChargingtxt
            // 
            btnChargingtxt.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChargingtxt.Location = new Point(85, 470);
            btnChargingtxt.Name = "btnChargingtxt";
            btnChargingtxt.Size = new Size(125, 42);
            btnChargingtxt.TabIndex = 39;
            btnChargingtxt.Text = "Charging txt";
            btnChargingtxt.UseVisualStyleBackColor = true;
            btnChargingtxt.Click += btnChargingtxt_Click;
            // 
            // btnExportExcel
            // 
            btnExportExcel.BackColor = Color.Lime;
            btnExportExcel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExportExcel.Location = new Point(216, 426);
            btnExportExcel.Name = "btnExportExcel";
            btnExportExcel.Size = new Size(122, 38);
            btnExportExcel.TabIndex = 38;
            btnExportExcel.Text = "Export Excel";
            btnExportExcel.UseVisualStyleBackColor = false;
            btnExportExcel.Click += btnExportExcel_Click;
            // 
            // btnExportWord
            // 
            btnExportWord.BackColor = SystemColors.Highlight;
            btnExportWord.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExportWord.Location = new Point(85, 518);
            btnExportWord.Name = "btnExportWord";
            btnExportWord.Size = new Size(122, 44);
            btnExportWord.TabIndex = 37;
            btnExportWord.Text = "Export Word";
            btnExportWord.UseVisualStyleBackColor = false;
            btnExportWord.Click += btnExportWord_Click;
            // 
            // btnExportJSON
            // 
            btnExportJSON.BackColor = SystemColors.GrayText;
            btnExportJSON.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExportJSON.Location = new Point(216, 470);
            btnExportJSON.Name = "btnExportJSON";
            btnExportJSON.Size = new Size(122, 42);
            btnExportJSON.TabIndex = 36;
            btnExportJSON.Text = "Export JSON";
            btnExportJSON.UseVisualStyleBackColor = false;
            btnExportJSON.Click += btnExportJSON_Click;
            // 
            // btnaddbook
            // 
            btnaddbook.BackColor = Color.FromArgb(128, 255, 128);
            btnaddbook.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnaddbook.ForeColor = Color.Black;
            btnaddbook.Location = new Point(88, 345);
            btnaddbook.Name = "btnaddbook";
            btnaddbook.Size = new Size(219, 34);
            btnaddbook.TabIndex = 35;
            btnaddbook.Text = "Add book";
            btnaddbook.UseVisualStyleBackColor = false;
            btnaddbook.Click += btnaddbook_Click;
            // 
            // txtPaginas
            // 
            txtPaginas.Location = new Point(169, 164);
            txtPaginas.Multiline = true;
            txtPaginas.Name = "txtPaginas";
            txtPaginas.Size = new Size(137, 37);
            txtPaginas.TabIndex = 34;
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(169, 112);
            txtAutor.Multiline = true;
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(137, 36);
            txtAutor.TabIndex = 33;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(155, 59);
            txtTitulo.Multiline = true;
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(151, 34);
            txtTitulo.TabIndex = 32;
            // 
            // lblSucursal
            // 
            lblSucursal.AutoSize = true;
            lblSucursal.Location = new Point(75, 292);
            lblSucursal.Name = "lblSucursal";
            lblSucursal.Size = new Size(63, 20);
            lblSucursal.TabIndex = 48;
            lblSucursal.Text = "Sucursal";
            // 
            // txtSucursal
            // 
            txtSucursal.Location = new Point(163, 278);
            txtSucursal.Multiline = true;
            txtSucursal.Name = "txtSucursal";
            txtSucursal.Size = new Size(125, 34);
            txtSucursal.TabIndex = 49;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1417, 686);
            Controls.Add(txtSucursal);
            Controls.Add(lblSucursal);
            Controls.Add(txtPrice);
            Controls.Add(lblPrecio);
            Controls.Add(btnEliminarLibro);
            Controls.Add(lblPages);
            Controls.Add(lblAuthor);
            Controls.Add(lbltitle);
            Controls.Add(lstvLibros);
            Controls.Add(btnSavetxt);
            Controls.Add(btnChargingtxt);
            Controls.Add(btnExportExcel);
            Controls.Add(btnExportWord);
            Controls.Add(btnExportJSON);
            Controls.Add(btnaddbook);
            Controls.Add(txtPaginas);
            Controls.Add(txtAutor);
            Controls.Add(txtTitulo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPrice;
        private Label lblPrecio;
        private Button btnEliminarLibro;
        private Label lblPages;
        private Label lblAuthor;
        private Label lbltitle;
        private ListView lstvLibros;
        private Button btnSavetxt;
        private Button btnChargingtxt;
        private Button btnExportExcel;
        private Button btnExportWord;
        private Button btnExportJSON;
        private Button btnaddbook;
        private TextBox txtPaginas;
        private TextBox txtAutor;
        private TextBox txtTitulo;
        private Label lblSucursal;
        private TextBox txtSucursal;
    }
}
