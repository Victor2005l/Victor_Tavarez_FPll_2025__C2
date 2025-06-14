namespace Video__7
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtA = new TextBox();
            txtB = new TextBox();
            btnCalcular = new Button();
            gboxOperaciones = new GroupBox();
            rbDividir = new RadioButton();
            rbMulti = new RadioButton();
            rbResta = new RadioButton();
            rbSuma = new RadioButton();
            lblResultado = new Label();
            gboxOperaciones.SuspendLayout();
            SuspendLayout();
            // 
            // txtA
            // 
            txtA.Location = new Point(67, 70);
            txtA.Name = "txtA";
            txtA.Size = new Size(125, 27);
            txtA.TabIndex = 0;
            txtA.Text = "0";
            txtA.TextAlign = HorizontalAlignment.Right;
            // 
            // txtB
            // 
            txtB.Location = new Point(67, 124);
            txtB.Name = "txtB";
            txtB.Size = new Size(125, 27);
            txtB.TabIndex = 1;
            txtB.Text = "0";
            txtB.TextAlign = HorizontalAlignment.Right;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(221, 70);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(126, 62);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // gboxOperaciones
            // 
            gboxOperaciones.Controls.Add(rbDividir);
            gboxOperaciones.Controls.Add(rbMulti);
            gboxOperaciones.Controls.Add(rbResta);
            gboxOperaciones.Controls.Add(rbSuma);
            gboxOperaciones.Location = new Point(67, 240);
            gboxOperaciones.Name = "gboxOperaciones";
            gboxOperaciones.Size = new Size(112, 144);
            gboxOperaciones.TabIndex = 4;
            gboxOperaciones.TabStop = false;
            gboxOperaciones.Text = "Operaciones";
            // 
            // rbDividir
            // 
            rbDividir.AutoSize = true;
            rbDividir.Location = new Point(8, 102);
            rbDividir.Name = "rbDividir";
            rbDividir.Size = new Size(74, 24);
            rbDividir.TabIndex = 5;
            rbDividir.TabStop = true;
            rbDividir.Text = "Dividir";
            rbDividir.UseVisualStyleBackColor = true;
            // 
            // rbMulti
            // 
            rbMulti.AutoSize = true;
            rbMulti.Location = new Point(8, 81);
            rbMulti.Name = "rbMulti";
            rbMulti.Size = new Size(96, 24);
            rbMulti.TabIndex = 5;
            rbMulti.TabStop = true;
            rbMulti.Text = "multiplica";
            rbMulti.UseVisualStyleBackColor = true;
            // 
            // rbResta
            // 
            rbResta.AutoSize = true;
            rbResta.Location = new Point(8, 61);
            rbResta.Name = "rbResta";
            rbResta.Size = new Size(66, 24);
            rbResta.TabIndex = 5;
            rbResta.TabStop = true;
            rbResta.Text = "Resta";
            rbResta.UseVisualStyleBackColor = true;
            rbResta.CheckedChanged += rbResta_CheckedChanged;
            // 
            // rbSuma
            // 
            rbSuma.AutoSize = true;
            rbSuma.Checked = true;
            rbSuma.Location = new Point(8, 40);
            rbSuma.Name = "rbSuma";
            rbSuma.Size = new Size(67, 24);
            rbSuma.TabIndex = 5;
            rbSuma.TabStop = true;
            rbSuma.Text = "Suma";
            rbSuma.UseVisualStyleBackColor = true;
            rbSuma.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(75, 167);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(50, 20);
            lblResultado.TabIndex = 5;
            lblResultado.Text = "label1";
            lblResultado.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(662, 450);
            Controls.Add(lblResultado);
            Controls.Add(gboxOperaciones);
            Controls.Add(btnCalcular);
            Controls.Add(txtB);
            Controls.Add(txtA);
            Name = "Form1";
            Text = "Form1";
            gboxOperaciones.ResumeLayout(false);
            gboxOperaciones.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtA;
        private TextBox txtB;
        private Button btnCalcular;
        private GroupBox gboxOperaciones;
        private RadioButton rbSuma;
        private RadioButton rbResta;
        private RadioButton rbMulti;
        private RadioButton rbDividir;
        private Label lblResultado;
    }
}
