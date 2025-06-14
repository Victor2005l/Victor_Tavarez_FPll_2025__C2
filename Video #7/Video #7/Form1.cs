namespace Video__7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double r = 0.0;
            double a = 0.0;
            double b = 0.0;

            a = Convert.ToDouble(txtA.Text);
            b = Convert.ToDouble(txtB.Text);

            if (rbSuma.Checked == true)
                r = a + b;

            if (rbResta.Checked == true)
                r = a - b;

            if (rbMulti.Checked == true)
                r = a * b;

            if (rbDividir.Checked ==)
                r = a / b;

            lblResultado.Text = r.ToString();



        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbResta_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            lblResultado.Text = rbDividir.ToString();
        }
    }
}
