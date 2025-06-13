namespace Segundo_proyec
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblNombre.Text = "";
        }

        private void btnSaludo_Click(object sender, EventArgs e)
        {
            lblNombre.Text = txtNombre.Text + " es el nombre, Hola!!!!!";
        }
    }
}
