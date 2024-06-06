namespace Proyecto_Library_POO
{
    partial class FormActionBook
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
            btnToLend = new Button();
            btnPrice = new Button();
            lblPrice = new Label();
            lblTitle = new Label();
            lblSucursal = new Label();
            SuspendLayout();
            // 
            // btnToLend
            // 
            btnToLend.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnToLend.Location = new Point(58, 315);
            btnToLend.Name = "btnToLend";
            btnToLend.Size = new Size(129, 42);
            btnToLend.TabIndex = 7;
            btnToLend.Text = "To Lend";
            btnToLend.UseVisualStyleBackColor = true;
            btnToLend.Click += btnToLend_Click;
            // 
            // btnPrice
            // 
            btnPrice.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPrice.Location = new Point(58, 251);
            btnPrice.Name = "btnPrice";
            btnPrice.Size = new Size(129, 38);
            btnPrice.TabIndex = 6;
            btnPrice.Text = "To Buy";
            btnPrice.UseVisualStyleBackColor = true;
            btnPrice.Click += btnPrice_Click;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrice.Location = new Point(103, 123);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(64, 21);
            lblPrice.TabIndex = 5;
            lblPrice.Text = "label2";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(103, 55);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(64, 21);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "label1";
            // 
            // lblSucursal
            // 
            lblSucursal.AutoSize = true;
            lblSucursal.Location = new Point(111, 184);
            lblSucursal.Name = "lblSucursal";
            lblSucursal.Size = new Size(50, 20);
            lblSucursal.TabIndex = 8;
            lblSucursal.Text = "label1";
            // 
            // FormActionBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblSucursal);
            Controls.Add(btnToLend);
            Controls.Add(btnPrice);
            Controls.Add(lblPrice);
            Controls.Add(lblTitle);
            Name = "FormActionBook";
            Text = "FormActionBook";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnToLend;
        private Button btnPrice;
        private Label lblPrice;
        private Label lblTitle;
        private Label lblSucursal;
    }
}