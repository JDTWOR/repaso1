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
            btnLibros.Location = new Point(142, 191);
            btnLibros.Name = "btnLibros";
            btnLibros.Size = new Size(94, 29);
            btnLibros.TabIndex = 0;
            btnLibros.Text = "Libros";
            btnLibros.UseVisualStyleBackColor = true;
            // 
            // btnAutores
            // 
            btnAutores.Location = new Point(320, 191);
            btnAutores.Name = "btnAutores";
            btnAutores.Size = new Size(94, 29);
            btnAutores.TabIndex = 1;
            btnAutores.Text = "Autores";
            btnAutores.UseVisualStyleBackColor = true;
            // 
            // btnGeneros
            // 
            btnGeneros.Location = new Point(494, 191);
            btnGeneros.Name = "btnGeneros";
            btnGeneros.Size = new Size(94, 29);
            btnGeneros.TabIndex = 2;
            btnGeneros.Text = "Generos";
            btnGeneros.UseVisualStyleBackColor = true;
            btnGeneros.Click += btnGeneros_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGeneros);
            Controls.Add(btnAutores);
            Controls.Add(btnLibros);
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
