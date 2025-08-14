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
    public partial class AutoresCRUD : Form
    {
        public AutoresCRUD()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            using (var db = new MiContexto())
            {
                var nuevo = new Autor
                {
                    Nombre = txtNombre.Text
                };

                db.Autores.Add(nuevo);
                db.SaveChanges();
                CargarDatos();
            }
        }

        public void CargarDatos()
        {
            using (var db = new MiContexto())
            {
                dataGridView1.DataSource = db.Autores.ToList();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            using (var db = new MiContexto())
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["AutorId"].Value);

                var viejo = db.Autores.Find(id);

                db.Autores.Remove(viejo);
                db.SaveChanges();
                CargarDatos();

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            using (var db = new MiContexto())
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["AutorId"].Value);

                var autoraeditar = db.Autores.Find(id);
                autoraeditar.Nombre = txtNombre.Text;
                db.SaveChanges();
                CargarDatos();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            txtNombre.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["Nombre"].Value);

        }
    }
}
