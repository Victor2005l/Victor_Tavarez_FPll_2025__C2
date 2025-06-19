namespace Video__10
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
            textMensaje = new TextBox();
            btnEnvio = new Button();
            SuspendLayout();
            // 
            // textMensaje
            // 
            textMensaje.Location = new Point(108, 77);
            textMensaje.Name = "textMensaje";
            textMensaje.Size = new Size(125, 27);
            textMensaje.TabIndex = 0;
            // 
            // btnEnvio
            // 
            btnEnvio.Location = new Point(297, 75);
            btnEnvio.Name = "btnEnvio";
            btnEnvio.Size = new Size(94, 29);
            btnEnvio.TabIndex = 1;
            btnEnvio.Text = "Envio 1";
            btnEnvio.UseVisualStyleBackColor = true;
            btnEnvio.Click += btnEnvio_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(489, 450);
            Controls.Add(btnEnvio);
            Controls.Add(textMensaje);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textMensaje;
        private Button btnEnvio;
    }
}
