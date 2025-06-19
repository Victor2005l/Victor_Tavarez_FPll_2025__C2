namespace Video__10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnvio_Click(object sender, EventArgs e)
        {
            // Creamos la instancia de la forma 2
            Form2 miForma2 = new Form2(textMensaje.Text);

            miForma2.Comentario = "nos vemos";

            // Mostramos la forma
            miForma2.ShowDialog();

        }
    }
}
