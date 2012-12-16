namespace WindowsFormsApplication1
{
    partial class registrarBus
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbModelo = new System.Windows.Forms.Label();
            this.lbPlaca = new System.Windows.Forms.Label();
            this.btRegistrar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.fechaAd = new System.Windows.Forms.DateTimePicker();
            this.lbID = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbModelo = new System.Windows.Forms.TextBox();
            this.placa = new System.Windows.Forms.TextBox();
            this.lbTBus = new System.Windows.Forms.Label();
            this.lbColor = new System.Windows.Forms.Label();
            this.color = new System.Windows.Forms.TextBox();
            this.Fabricante = new System.Windows.Forms.Label();
            this.tipo = new System.Windows.Forms.ComboBox();
            this.fabri = new System.Windows.Forms.TextBox();
            this.lbCapacidad = new System.Windows.Forms.Label();
            this.capacidad = new System.Windows.Forms.ComboBox();
            this.lbTCombustible = new System.Windows.Forms.Label();
            this.combustible = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha Adquisicion\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // lbModelo
            // 
            this.lbModelo.AutoSize = true;
            this.lbModelo.Location = new System.Drawing.Point(19, 119);
            this.lbModelo.Name = "lbModelo";
            this.lbModelo.Size = new System.Drawing.Size(42, 13);
            this.lbModelo.TabIndex = 2;
            this.lbModelo.Text = "Modelo";
            // 
            // lbPlaca
            // 
            this.lbPlaca.AutoSize = true;
            this.lbPlaca.Location = new System.Drawing.Point(19, 162);
            this.lbPlaca.Name = "lbPlaca";
            this.lbPlaca.Size = new System.Drawing.Size(34, 13);
            this.lbPlaca.TabIndex = 3;
            this.lbPlaca.Text = "Placa";
            // 
            // btRegistrar
            // 
            this.btRegistrar.Location = new System.Drawing.Point(66, 403);
            this.btRegistrar.Name = "btRegistrar";
            this.btRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btRegistrar.TabIndex = 4;
            this.btRegistrar.Text = "Registrar";
            this.btRegistrar.UseVisualStyleBackColor = true;
            this.btRegistrar.Click += new System.EventHandler(this.btRegistrar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(188, 403);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 5;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            // 
            // fechaAd
            // 
            this.fechaAd.Location = new System.Drawing.Point(119, 74);
            this.fechaAd.Name = "fechaAd";
            this.fechaAd.Size = new System.Drawing.Size(200, 20);
            this.fechaAd.TabIndex = 6;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(19, 49);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(24, 13);
            this.lbID.TabIndex = 7;
            this.lbID.Text = "I.D.";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(119, 42);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(199, 20);
            this.tbID.TabIndex = 8;
            // 
            // tbModelo
            // 
            this.tbModelo.Location = new System.Drawing.Point(119, 111);
            this.tbModelo.Name = "tbModelo";
            this.tbModelo.Size = new System.Drawing.Size(199, 20);
            this.tbModelo.TabIndex = 9;
            // 
            // placa
            // 
            this.placa.Location = new System.Drawing.Point(119, 155);
            this.placa.Name = "placa";
            this.placa.Size = new System.Drawing.Size(199, 20);
            this.placa.TabIndex = 10;
            // 
            // lbTBus
            // 
            this.lbTBus.AutoSize = true;
            this.lbTBus.Location = new System.Drawing.Point(19, 198);
            this.lbTBus.Name = "lbTBus";
            this.lbTBus.Size = new System.Drawing.Size(64, 13);
            this.lbTBus.TabIndex = 11;
            this.lbTBus.Text = "Tipo de Bus";
            this.lbTBus.Click += new System.EventHandler(this.lbTBus_Click);
            // 
            // lbColor
            // 
            this.lbColor.AutoSize = true;
            this.lbColor.Location = new System.Drawing.Point(19, 235);
            this.lbColor.Name = "lbColor";
            this.lbColor.Size = new System.Drawing.Size(31, 13);
            this.lbColor.TabIndex = 13;
            this.lbColor.Text = "Color";
            // 
            // color
            // 
            this.color.Location = new System.Drawing.Point(119, 228);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(199, 20);
            this.color.TabIndex = 14;
            // 
            // Fabricante
            // 
            this.Fabricante.AutoSize = true;
            this.Fabricante.Location = new System.Drawing.Point(22, 271);
            this.Fabricante.Name = "Fabricante";
            this.Fabricante.Size = new System.Drawing.Size(57, 13);
            this.Fabricante.TabIndex = 15;
            this.Fabricante.Text = "Fabricante";
            // 
            // tipo
            // 
            this.tipo.FormattingEnabled = true;
            this.tipo.Items.AddRange(new object[] {
            "Expreso",
            "Troncal",
            "Pretroncal"});
            this.tipo.Location = new System.Drawing.Point(119, 190);
            this.tipo.Name = "tipo";
            this.tipo.Size = new System.Drawing.Size(199, 21);
            this.tipo.TabIndex = 16;
            // 
            // fabri
            // 
            this.fabri.Location = new System.Drawing.Point(119, 263);
            this.fabri.Name = "fabri";
            this.fabri.Size = new System.Drawing.Size(199, 20);
            this.fabri.TabIndex = 17;
            // 
            // lbCapacidad
            // 
            this.lbCapacidad.AutoSize = true;
            this.lbCapacidad.Location = new System.Drawing.Point(22, 312);
            this.lbCapacidad.Name = "lbCapacidad";
            this.lbCapacidad.Size = new System.Drawing.Size(58, 13);
            this.lbCapacidad.TabIndex = 18;
            this.lbCapacidad.Text = "Capacidad";
            // 
            // capacidad
            // 
            this.capacidad.FormattingEnabled = true;
            this.capacidad.Items.AddRange(new object[] {
            "100 Pasajeros",
            "150 Pasajeros",
            "180 Pasajeros"});
            this.capacidad.Location = new System.Drawing.Point(119, 304);
            this.capacidad.Name = "capacidad";
            this.capacidad.Size = new System.Drawing.Size(199, 21);
            this.capacidad.TabIndex = 19;
            // 
            // lbTCombustible
            // 
            this.lbTCombustible.AutoSize = true;
            this.lbTCombustible.Location = new System.Drawing.Point(22, 351);
            this.lbTCombustible.Name = "lbTCombustible";
            this.lbTCombustible.Size = new System.Drawing.Size(88, 13);
            this.lbTCombustible.TabIndex = 20;
            this.lbTCombustible.Text = "Tipo Combustible";
            // 
            // combustible
            // 
            this.combustible.FormattingEnabled = true;
            this.combustible.Items.AddRange(new object[] {
            "Gasolina",
            "Gas",
            "Biodiesel",
            "Híbrido"});
            this.combustible.Location = new System.Drawing.Point(119, 343);
            this.combustible.Name = "combustible";
            this.combustible.Size = new System.Drawing.Size(199, 21);
            this.combustible.TabIndex = 21;
            // 
            // registrarBus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 450);
            this.Controls.Add(this.combustible);
            this.Controls.Add(this.lbTCombustible);
            this.Controls.Add(this.capacidad);
            this.Controls.Add(this.lbCapacidad);
            this.Controls.Add(this.fabri);
            this.Controls.Add(this.tipo);
            this.Controls.Add(this.Fabricante);
            this.Controls.Add(this.color);
            this.Controls.Add(this.lbColor);
            this.Controls.Add(this.lbTBus);
            this.Controls.Add(this.placa);
            this.Controls.Add(this.tbModelo);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.fechaAd);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btRegistrar);
            this.Controls.Add(this.lbPlaca);
            this.Controls.Add(this.lbModelo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "registrarBus";
            this.Text = "Registrar Bus";
            this.Load += new System.EventHandler(this.registrarBus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbModelo;
        private System.Windows.Forms.Label lbPlaca;
        private System.Windows.Forms.Button btRegistrar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.DateTimePicker fechaAd;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbModelo;
        private System.Windows.Forms.TextBox placa;
        private System.Windows.Forms.Label lbTBus;
        private System.Windows.Forms.Label lbColor;
        private System.Windows.Forms.TextBox color;
        private System.Windows.Forms.Label Fabricante;
        private System.Windows.Forms.ComboBox tipo;
        private System.Windows.Forms.TextBox fabri;
        private System.Windows.Forms.Label lbCapacidad;
        private System.Windows.Forms.ComboBox capacidad;
        private System.Windows.Forms.Label lbTCombustible;
        private System.Windows.Forms.ComboBox combustible;
    }
}