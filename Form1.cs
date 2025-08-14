namespace repaso1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGeneros_Click(object sender, EventArgs e)
        {
            GenerosCRUD genero = new GenerosCRUD();
            genero.Show();
            this.Hide();
        }

        private void btnAutores_Click(object sender, EventArgs e)
        {
            AutoresCRUD aut = new AutoresCRUD();
            aut.Show();
            this.Hide();
        }

        private void btnLibros_Click(object sender, EventArgs e)
        {

            LibrosCRUD lib = new LibrosCRUD();
            lib.Show();
            this.Hide();
        }
    }
}
