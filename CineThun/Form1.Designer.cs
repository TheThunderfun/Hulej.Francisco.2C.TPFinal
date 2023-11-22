namespace CineThun
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Cliente = new Button();
            label1 = new Label();
            Bienvenida = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // Cliente
            // 
            Cliente.Location = new Point(228, 259);
            Cliente.Name = "Cliente";
            Cliente.Size = new Size(99, 56);
            Cliente.TabIndex = 0;
            Cliente.Text = "Cliente";
            Cliente.UseVisualStyleBackColor = true;
            Cliente.Click += Cliente_Click;
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            // 
            // Bienvenida
            // 
            Bienvenida.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            Bienvenida.Location = new Point(218, 125);
            Bienvenida.Name = "Bienvenida";
            Bienvenida.Size = new Size(392, 49);
            Bienvenida.TabIndex = 0;
            Bienvenida.Text = "¡Bienvenido a CineThun!";
            // 
            // button1
            // 
            button1.Location = new Point(426, 259);
            button1.Name = "button1";
            button1.Size = new Size(99, 56);
            button1.TabIndex = 1;
            button1.Text = "Personal Cine";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(Bienvenida);
            Controls.Add(label1);
            Controls.Add(Cliente);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button Cliente;
        private Label label1;
        private Label Bienvenida;
        private Button button1;
    }
}