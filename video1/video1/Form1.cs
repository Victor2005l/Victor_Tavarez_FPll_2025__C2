namespace video1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSaludo_Click(object sender, EventArgs e)
        {
            lblMensaje.Text = "hola a todos";
        }

        private void btnDespedida_Click(object sender, EventArgs e)
        {
            lblMensaje.Text = "adios!";
            this.Text = "Bye!";
        }

        private void btnDespedida_LocationChanged(object sender, EventArgs e)
        {
            lblMensaje.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblMensaje.Text = "";
        }
    }
}
