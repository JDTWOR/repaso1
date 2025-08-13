using repaso1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace repaso1
{
    public partial class GenerosCRUD : Form
    {
        public GenerosCRUD()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void btnGenero_Click(object sender, EventArgs e)
        {
            using (var db = new MiContexto())
            {
                var gene = new Genero
                {
                    Nombre = txtNombre.Text
                };
                db.Generos.Add(gene);
                db.SaveChanges();
                CargarDatos();
            }
        }

        public void CargarDatos()
        {
            using (var db = new MiContexto())
            {
                dataGridView1.DataSource = db.Generos.ToList();
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Form1 principal = new Form1();
            principal.Show();
            this.Hide();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            using (var db = new MiContexto())
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["GeneroId"].Value);
                var genero = db.Generos.Find(id);
                db.Generos.Remove(genero);
                db.SaveChanges();
                CargarDatos();
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            using (var db = new MiContexto())
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["GeneroId"].Value);
                var genero = db.Generos.Find(id);
                genero.Nombre = txtNombre.Text;
                db.SaveChanges();
                CargarDatos();
            }
        }
    }
}
