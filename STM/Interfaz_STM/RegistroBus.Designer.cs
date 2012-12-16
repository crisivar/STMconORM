namespace Interfaz_STM
{
    partial class RegistroBus
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
            this.btCancelar = new System.Windows.Forms.Button();
            this.btRegistrar = new System.Windows.Forms.Button();
            this.ComboBox2 = new System.Windows.Forms.ComboBox();
            this.ComboBox1 = new System.Windows.Forms.ComboBox();
            this.tbFabricante = new System.Windows.Forms.TextBox();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.tbPlaca = new System.Windows.Forms.TextBox();
            this.tbModelo = new System.Windows.Forms.TextBox();
            this.lbTCombustible = new System.Windows.Forms.Label();
            this.lbCapacidad = new System.Windows.Forms.Label();
            this.lbFabricante = new System.Windows.Forms.Label();
            this.lbColor = new System.Windows.Forms.Label();
            this.lbPlaca = new System.Windows.Forms.Label();
            this.lbModelo = new System.Windows.Forms.Label();
            this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbFAdquisicion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(208, 373);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(98, 25);
            this.btCancelar.TabIndex = 34;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            // 
            // btRegistrar
            // 
            this.btRegistrar.Location = new System.Drawing.Point(76, 372);
            this.btRegistrar.Name = "btRegistrar";
            this.btRegistrar.Size = new System.Drawing.Size(99, 26);
            this.btRegistrar.TabIndex = 33;
            this.btRegistrar.Text = "Registrar";
            this.btRegistrar.UseVisualStyleBackColor = true;
            // 
            // ComboBox2
            // 
            this.ComboBox2.FormattingEnabled = true;
            this.ComboBox2.Items.AddRange(new object[] {
            "Gasolina",
            "Gas",
            "Diesel",
            "Hibrido"});
            this.ComboBox2.Location = new System.Drawing.Point(141, 306);
            this.ComboBox2.Name = "ComboBox2";
            this.ComboBox2.Size = new System.Drawing.Size(199, 21);
            this.ComboBox2.TabIndex = 32;
            // 
            // ComboBox1
            // 
            this.ComboBox1.FormattingEnabled = true;
            this.ComboBox1.Items.AddRange(new object[] {
            "40 Pasajeros",
            "60 Pasajeros",
            "80 Pasajeros",
            "120 Pasajeros"});
            this.ComboBox1.Location = new System.Drawing.Point(140, 262);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(199, 21);
            this.ComboBox1.TabIndex = 31;
            // 
            // tbFabricante
            // 
            this.tbFabricante.Location = new System.Drawing.Point(141, 226);
            this.tbFabricante.Name = "tbFabricante";
            this.tbFabricante.Size = new System.Drawing.Size(199, 20);
            this.tbFabricante.TabIndex = 30;
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(140, 183);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(199, 20);
            this.TextBox1.TabIndex = 29;
            // 
            // tbPlaca
            // 
            this.tbPlaca.Location = new System.Drawing.Point(140, 137);
            this.tbPlaca.Name = "tbPlaca";
            this.tbPlaca.Size = new System.Drawing.Size(200, 20);
            this.tbPlaca.TabIndex = 28;
            // 
            // tbModelo
            // 
            this.tbModelo.Location = new System.Drawing.Point(140, 100);
            this.tbModelo.Name = "tbModelo";
            this.tbModelo.Size = new System.Drawing.Size(200, 20);
            this.tbModelo.TabIndex = 27;
            // 
            // lbTCombustible
            // 
            this.lbTCombustible.AutoSize = true;
            this.lbTCombustible.Location = new System.Drawing.Point(26, 306);
            this.lbTCombustible.Name = "lbTCombustible";
            this.lbTCombustible.Size = new System.Drawing.Size(103, 13);
            this.lbTCombustible.TabIndex = 26;
            this.lbTCombustible.Text = "Tipo de Combustible";
            // 
            // lbCapacidad
            // 
            this.lbCapacidad.AutoSize = true;
            this.lbCapacidad.Location = new System.Drawing.Point(26, 271);
            this.lbCapacidad.Name = "lbCapacidad";
            this.lbCapacidad.Size = new System.Drawing.Size(58, 13);
            this.lbCapacidad.TabIndex = 25;
            this.lbCapacidad.Text = "Capacidad";
            // 
            // lbFabricante
            // 
            this.lbFabricante.AutoSize = true;
            this.lbFabricante.Location = new System.Drawing.Point(29, 233);
            this.lbFabricante.Name = "lbFabricante";
            this.lbFabricante.Size = new System.Drawing.Size(57, 13);
            this.lbFabricante.TabIndex = 24;
            this.lbFabricante.Text = "Fabricante";
            // 
            // lbColor
            // 
            this.lbColor.AutoSize = true;
            this.lbColor.Location = new System.Drawing.Point(29, 190);
            this.lbColor.Name = "lbColor";
            this.lbColor.Size = new System.Drawing.Size(31, 13);
            this.lbColor.TabIndex = 23;
            this.lbColor.Text = "Color";
            // 
            // lbPlaca
            // 
            this.lbPlaca.AutoSize = true;
            this.lbPlaca.Location = new System.Drawing.Point(26, 144);
            this.lbPlaca.Name = "lbPlaca";
            this.lbPlaca.Size = new System.Drawing.Size(34, 13);
            this.lbPlaca.TabIndex = 22;
            this.lbPlaca.Text = "Placa";
            // 
            // lbModelo
            // 
            this.lbModelo.AutoSize = true;
            this.lbModelo.Location = new System.Drawing.Point(26, 107);
            this.lbModelo.Name = "lbModelo";
            this.lbModelo.Size = new System.Drawing.Size(42, 13);
            this.lbModelo.TabIndex = 21;
            this.lbModelo.Text = "Modelo";
            // 
            // DateTimePicker1
            // 
            this.DateTimePicker1.Location = new System.Drawing.Point(140, 53);
            this.DateTimePicker1.Name = "DateTimePicker1";
            this.DateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.DateTimePicker1.TabIndex = 20;
            // 
            // lbFAdquisicion
            // 
            this.lbFAdquisicion.AutoSize = true;
            this.lbFAdquisicion.Location = new System.Drawing.Point(21, 60);
            this.lbFAdquisicion.Name = "lbFAdquisicion";
            this.lbFAdquisicion.Size = new System.Drawing.Size(108, 13);
            this.lbFAdquisicion.TabIndex = 19;
            this.lbFAdquisicion.Text = "Fecha de adquisición";
            // 
            // RegistroBus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 437);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btRegistrar);
            this.Controls.Add(this.ComboBox2);
            this.Controls.Add(this.ComboBox1);
            this.Controls.Add(this.tbFabricante);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.tbPlaca);
            this.Controls.Add(this.tbModelo);
            this.Controls.Add(this.lbTCombustible);
            this.Controls.Add(this.lbCapacidad);
            this.Controls.Add(this.lbFabricante);
            this.Controls.Add(this.lbColor);
            this.Controls.Add(this.lbPlaca);
            this.Controls.Add(this.lbModelo);
            this.Controls.Add(this.DateTimePicker1);
            this.Controls.Add(this.lbFAdquisicion);
            this.Name = "RegistroBus";
            this.Text = "Registro Bus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btCancelar;
        internal System.Windows.Forms.Button btRegistrar;
        internal System.Windows.Forms.ComboBox ComboBox2;
        internal System.Windows.Forms.ComboBox ComboBox1;
        internal System.Windows.Forms.TextBox tbFabricante;
        internal System.Windows.Forms.TextBox TextBox1;
        internal System.Windows.Forms.TextBox tbPlaca;
        internal System.Windows.Forms.TextBox tbModelo;
        internal System.Windows.Forms.Label lbTCombustible;
        internal System.Windows.Forms.Label lbCapacidad;
        internal System.Windows.Forms.Label lbFabricante;
        internal System.Windows.Forms.Label lbColor;
        internal System.Windows.Forms.Label lbPlaca;
        internal System.Windows.Forms.Label lbModelo;
        internal System.Windows.Forms.DateTimePicker DateTimePicker1;
        internal System.Windows.Forms.Label lbFAdquisicion;
    }
}