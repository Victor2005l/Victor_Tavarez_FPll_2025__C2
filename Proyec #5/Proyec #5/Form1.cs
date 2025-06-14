namespace Proyec__5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int total = 0;

            if (chkMonitor.Checked == true)
                total = total + 250;

            if (chkTeclado.Checked == true)
                total = total + 15;

            if (chkMouse.Checked == true)
                total = total + 20;

            MessageBox.Show("El total es " + total.ToString()));        }


        }
    }
