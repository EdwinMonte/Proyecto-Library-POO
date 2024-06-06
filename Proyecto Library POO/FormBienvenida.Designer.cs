namespace Proyecto_Library_POO
{
    partial class FormBienvenida
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtCorreo = new TextBox();
            txtNombre = new TextBox();
            lblCorreo = new Label();
            lblNombre = new Label();
            lblBienvenida = new Label();
            btnContinuar = new Button();
            SuspendLayout();
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(198, 198);
            txtCorreo.Multiline = true;
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(309, 34);
            txtCorreo.TabIndex = 11;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(198, 125);
            txtNombre.Multiline = true;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(309, 34);
            txtNombre.TabIndex = 10;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCorreo.Location = new Point(105, 204);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(64, 28);
            lblCorreo.TabIndex = 9;
            lblCorreo.Text = "Email";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(101, 131);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(68, 28);
            lblNombre.TabIndex = 8;
            lblNombre.Text = "Name";
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBienvenida.Location = new Point(313, 43);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(99, 28);
            lblBienvenida.TabIndex = 7;
            lblBienvenida.Text = "Welcome";
            // 
            // btnContinuar
            // 
            btnContinuar.BackColor = SystemColors.InactiveCaption;
            btnContinuar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnContinuar.Location = new Point(313, 263);
            btnContinuar.Name = "btnContinuar";
            btnContinuar.Size = new Size(145, 53);
            btnContinuar.TabIndex = 6;
            btnContinuar.Text = "Continue";
            btnContinuar.UseVisualStyleBackColor = false;
            btnContinuar.Click += btnContinuar_Click;
            // 
            // FormBienvenida
            // 
            AcceptButton = btnContinuar;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtCorreo);
            Controls.Add(txtNombre);
            Controls.Add(lblCorreo);
            Controls.Add(lblNombre);
            Controls.Add(lblBienvenida);
            Controls.Add(btnContinuar);
            Name = "FormBienvenida";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCorreo;
        private TextBox txtNombre;
        private Label lblCorreo;
        private Label lblNombre;
        private Label lblBienvenida;
        private Button btnContinuar;
    }
}