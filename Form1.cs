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
    }
}
