namespace CineThun
{
    partial class VistaCliente
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
            cmbPeliculas = new ComboBox();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDni = new TextBox();
            txtTarjeta = new TextBox();
            cmbCantEntradas = new ComboBox();
            cmbComboBox = new ComboBox();
            btnComprarEntardas = new Button();
            bttnEditarDatos = new Button();
            SuspendLayout();
            // 
            // cmbPeliculas
            // 
            cmbPeliculas.FormattingEnabled = true;
            cmbPeliculas.Location = new Point(318, 117);
            cmbPeliculas.Name = "cmbPeliculas";
            cmbPeliculas.Size = new Size(109, 23);
            cmbPeliculas.TabIndex = 0;
            cmbPeliculas.Text = "Peliculas";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(106, 184);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre";
            txtNombre.Size = new Size(109, 23);
            txtNombre.TabIndex = 2;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(106, 241);
            txtApellido.Name = "txtApellido";
            txtApellido.PlaceholderText = "Apellido";
            txtApellido.Size = new Size(109, 23);
            txtApellido.TabIndex = 3;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(318, 184);
            txtDni.Name = "txtDni";
            txtDni.PlaceholderText = "DNI";
            txtDni.ScrollBars = ScrollBars.Vertical;
            txtDni.Size = new Size(109, 23);
            txtDni.TabIndex = 4;
            // 
            // txtTarjeta
            // 
            txtTarjeta.Location = new Point(318, 241);
            txtTarjeta.Name = "txtTarjeta";
            txtTarjeta.PlaceholderText = "Tarjeta";
            txtTarjeta.Size = new Size(109, 23);
            txtTarjeta.TabIndex = 5;
            // 
            // cmbCantEntradas
            // 
            cmbCantEntradas.FormattingEnabled = true;
            cmbCantEntradas.Location = new Point(536, 184);
            cmbCantEntradas.Name = "cmbCantEntradas";
            cmbCantEntradas.Size = new Size(148, 23);
            cmbCantEntradas.TabIndex = 6;
            cmbCantEntradas.Text = "Cantidad de entradas";
            // 
            // cmbComboBox
            // 
            cmbComboBox.FormattingEnabled = true;
            cmbComboBox.Location = new Point(536, 241);
            cmbComboBox.Name = "cmbComboBox";
            cmbComboBox.Size = new Size(148, 23);
            cmbComboBox.TabIndex = 7;
            cmbComboBox.Text = "ComboBox";
            // 
            // btnComprarEntardas
            // 
            btnComprarEntardas.Location = new Point(218, 333);
            btnComprarEntardas.Name = "btnComprarEntardas";
            btnComprarEntardas.Size = new Size(99, 40);
            btnComprarEntardas.TabIndex = 8;
            btnComprarEntardas.Text = "Comprar Entrada";
            btnComprarEntardas.UseVisualStyleBackColor = true;
            btnComprarEntardas.Click += btnComprarEntardas_Click;
            // 
            // bttnEditarDatos
            // 
            bttnEditarDatos.Location = new Point(427, 333);
            bttnEditarDatos.Name = "bttnEditarDatos";
            bttnEditarDatos.Size = new Size(99, 40);
            bttnEditarDatos.TabIndex = 9;
            bttnEditarDatos.Text = "Editar datos";
            bttnEditarDatos.UseVisualStyleBackColor = true;
            // 
            // VistaCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bttnEditarDatos);
            Controls.Add(btnComprarEntardas);
            Controls.Add(cmbComboBox);
            Controls.Add(cmbCantEntradas);
            Controls.Add(txtTarjeta);
            Controls.Add(txtDni);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(cmbPeliculas);
            Name = "VistaCliente";
            Text = "VistaCliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbPeliculas;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDni;
        private TextBox txtTarjeta;
        private ComboBox cmbCantEntradas;
        private ComboBox cmbComboBox;
        private Button btnComprarEntardas;
        private Button bttnEditarDatos;
    }
}