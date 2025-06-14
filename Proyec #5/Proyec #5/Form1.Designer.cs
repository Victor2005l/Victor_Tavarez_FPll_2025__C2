namespace Proyec__5
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
            chkMonitor = new CheckBox();
            chkTeclado = new CheckBox();
            chkMause = new CheckBox();
            lblMensaje = new Label();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // chkMonitor
            // 
            chkMonitor.AutoSize = true;
            chkMonitor.Location = new Point(74, 120);
            chkMonitor.Name = "chkMonitor";
            chkMonitor.Size = new Size(120, 24);
            chkMonitor.TabIndex = 0;
            chkMonitor.Text = "Monitor $250";
            chkMonitor.UseVisualStyleBackColor = true;
            // 
            // chkTeclado
            // 
            chkTeclado.AutoSize = true;
            chkTeclado.Location = new Point(74, 169);
            chkTeclado.Name = "chkTeclado";
            chkTeclado.Size = new Size(111, 24);
            chkTeclado.TabIndex = 1;
            chkTeclado.Text = "Teclado $15";
            chkTeclado.UseVisualStyleBackColor = true;          
            
            // 
            chkMause.AutoSize = true;
            chkMause.Location = new Point(74, 215);
            chkMause.Name = "chkMause";
            chkMause.Size = new Size(102, 24);
            chkMause.TabIndex = 2;
            chkMause.Text = "Mause $20";
            chkMause.UseVisualStyleBackColor = true;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(74, 267);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(50, 20);
            lblMensaje.TabIndex = 3;
            lblMensaje.Text = "label1";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(245, 120);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(94, 29);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCalcular);
            Controls.Add(lblMensaje);
            Controls.Add(chkMause);
            Controls.Add(chkTeclado);
            Controls.Add(chkMonitor);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chkMonitor;
        private CheckBox chkTeclado;
        private CheckBox chkMause;
        private Label lblMensaje;
        private Button btnCalcular;
    }
}
