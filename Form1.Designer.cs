namespace repaso1
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
            btnLibros = new Button();
            btnAutores = new Button();
            btnGeneros = new Button();
            SuspendLayout();
            // 
            // btnLibros
            // 
            btnLibros.Location = new Point(124, 143);
            btnLibros.Margin = new Padding(3, 2, 3, 2);
            btnLibros.Name = "btnLibros";
            btnLibros.Size = new Size(82, 22);
            btnLibros.TabIndex = 0;
            btnLibros.Text = "Libros";
            btnLibros.UseVisualStyleBackColor = true;
            btnLibros.Click += btnLibros_Click;
            // 
            // btnAutores
            // 
            btnAutores.Location = new Point(280, 143);
            btnAutores.Margin = new Padding(3, 2, 3, 2);
            btnAutores.Name = "btnAutores";
            btnAutores.Size = new Size(82, 22);
            btnAutores.TabIndex = 1;
            btnAutores.Text = "Autores";
            btnAutores.UseVisualStyleBackColor = true;
            btnAutores.Click += btnAutores_Click;
            // 
            // btnGeneros
            // 
            btnGeneros.Location = new Point(432, 143);
            btnGeneros.Margin = new Padding(3, 2, 3, 2);
            btnGeneros.Name = "btnGeneros";
            btnGeneros.Size = new Size(82, 22);
            btnGeneros.TabIndex = 2;
            btnGeneros.Text = "Generos";
            btnGeneros.UseVisualStyleBackColor = true;
            btnGeneros.Click += btnGeneros_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(btnGeneros);
            Controls.Add(btnAutores);
            Controls.Add(btnLibros);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnLibros;
        private Button btnAutores;
        private Button btnGeneros;
    }
}
