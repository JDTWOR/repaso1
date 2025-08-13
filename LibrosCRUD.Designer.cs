namespace repaso1
{
    partial class LibrosCRUD
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
            dataGridView1 = new DataGridView();
            txtTitulo = new TextBox();
            txtAutorId = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(296, 75);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(300, 188);
            dataGridView1.TabIndex = 0;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(81, 99);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.PlaceholderText = "titulo libro";
            txtTitulo.Size = new Size(125, 27);
            txtTitulo.TabIndex = 1;
            // 
            // txtAutorId
            // 
            txtAutorId.Location = new Point(81, 157);
            txtAutorId.Name = "txtAutorId";
            txtAutorId.PlaceholderText = "id autor";
            txtAutorId.Size = new Size(125, 27);
            txtAutorId.TabIndex = 2;
            // 
            // LibrosCRUD
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtAutorId);
            Controls.Add(txtTitulo);
            Controls.Add(dataGridView1);
            Name = "LibrosCRUD";
            Text = "LibrosCRUD";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtTitulo;
        private TextBox txtAutorId;
    }
}