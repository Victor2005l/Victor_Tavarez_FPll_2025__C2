namespace Video__9
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
            btnAbrir = new Button();
            SuspendLayout();
            // 
            // btnAbrir
            // 
            btnAbrir.Location = new Point(397, 108);
            btnAbrir.Name = "btnAbrir";
            btnAbrir.Size = new Size(94, 29);
            btnAbrir.TabIndex = 0;
            btnAbrir.Text = "Abrir";
            btnAbrir.UseVisualStyleBackColor = true;         
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(516, 450);
            Controls.Add(btnAbrir);
            Name = "Form1";
            Text = "Forma 1";
            Load += Form1_Load;
            MouseDoubleClick += Form1_MouseDoubleClick;
            ResumeLayout(false);
        }

        #endregion

        private Button btnAbrir;
    }
}
