using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loteria
{
    public partial class Form1 : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // Cerrar la aplicación
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Minimizar la ventana
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            // No se necesita lógica aquí por ahora
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point diff = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(diff));
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // BOTÓN PLAY

            // Validar número a jugar
            if (!int.TryParse(NumeroAJugar.Text, out int numeroJugado) || numeroJugado < 1 || numeroJugado > 100)
            {
                MessageBox.Show("Por favor ingresa un número del 1 al 100.", "Número inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar monto a apostar
            if (!decimal.TryParse(MontoAJugar.Text, out decimal montoApostado) || montoApostado <= 0)
            {
                MessageBox.Show("El monto a jugar debe ser mayor a 0.", "Monto inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Generar números aleatorios
            Random rnd = new Random();
            int n1 = rnd.Next(1, 101);
            int n2 = rnd.Next(1, 101);
            int n3 = rnd.Next(1, 101);

            // Mostrar números
            Numero1.Text = n1.ToString();
            Numero2.Text = n2.ToString();
            Numero3.Text = n3.ToString();

            // Calcular monto ganado
            decimal montoGanado = 0;
            if (numeroJugado == n1) montoGanado += montoApostado * 1000;
            if (numeroJugado == n2) montoGanado += montoApostado * 100;
            if (numeroJugado == n3) montoGanado += montoApostado * 10;

            // Mostrar resultado
            MontoGanado.Text = montoGanado.ToString("0.00");
        }

        private void Numero3_TextChanged(object sender, EventArgs e)
        {
            // No se requiere lógica aquí por ahora
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // No se requiere lógica aquí por ahora
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // No se requiere lógica aquí por ahora
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // No se requiere lógica aquí por ahora
        }
    }
}
