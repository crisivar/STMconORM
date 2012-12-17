namespace WindowsFormsApplication1
{
    partial class RegistroTPersonalizada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroTPersonalizada));
            this.btCancelar = new System.Windows.Forms.Button();
            this.btRegistrar = new System.Windows.Forms.Button();
            this.tBIDCliente = new System.Windows.Forms.TextBox();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.lbSaldo = new System.Windows.Forms.Label();
            this.lbCTarjeta = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tBTelefono = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tBEstacion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(190, 154);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 55;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btRegistrar
            // 
            this.btRegistrar.Location = new System.Drawing.Point(65, 154);
            this.btRegistrar.Name = "btRegistrar";
            this.btRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btRegistrar.TabIndex = 54;
            this.btRegistrar.Text = "Registrar";
            this.btRegistrar.UseVisualStyleBackColor = true;
            this.btRegistrar.Click += new System.EventHandler(this.btRegistrar_Click);
            // 
            // tBIDCliente
            // 
            this.tBIDCliente.Location = new System.Drawing.Point(105, 35);
            this.tBIDCliente.Name = "tBIDCliente";
            this.tBIDCliente.Size = new System.Drawing.Size(223, 20);
            this.tBIDCliente.TabIndex = 48;
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(105, 9);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(223, 20);
            this.tbCodigo.TabIndex = 47;
            // 
            // lbSaldo
            // 
            this.lbSaldo.AutoSize = true;
            this.lbSaldo.Location = new System.Drawing.Point(12, 38);
            this.lbSaldo.Name = "lbSaldo";
            this.lbSaldo.Size = new System.Drawing.Size(52, 13);
            this.lbSaldo.TabIndex = 42;
            this.lbSaldo.Text = "ID cliente";
            // 
            // lbCTarjeta
            // 
            this.lbCTarjeta.AutoSize = true;
            this.lbCTarjeta.Location = new System.Drawing.Point(12, 12);
            this.lbCTarjeta.Name = "lbCTarjeta";
            this.lbCTarjeta.Size = new System.Drawing.Size(76, 13);
            this.lbCTarjeta.TabIndex = 40;
            this.lbCTarjeta.Text = "Código Tarjeta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 56;
            this.label1.Text = "Telefono";
            // 
            // tBTelefono
            // 
            this.tBTelefono.Location = new System.Drawing.Point(105, 61);
            this.tBTelefono.Name = "tBTelefono";
            this.tBTelefono.Size = new System.Drawing.Size(223, 20);
            this.tBTelefono.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 58;
            this.label2.Text = "Nombre";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(105, 87);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(223, 20);
            this.textBox1.TabIndex = 59;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 60;
            this.label3.Text = "ID Estacion";
            // 
            // tBEstacion
            // 
            this.tBEstacion.Location = new System.Drawing.Point(105, 113);
            this.tBEstacion.Name = "tBEstacion";
            this.tBEstacion.Size = new System.Drawing.Size(223, 20);
            this.tBEstacion.TabIndex = 61;
            // 
            // RegistroTPersonalizada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 189);
            this.Controls.Add(this.tBEstacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tBTelefono);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btRegistrar);
            this.Controls.Add(this.tBIDCliente);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.lbSaldo);
            this.Controls.Add(this.lbCTarjeta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistroTPersonalizada";
            this.Text = "Registro Tarjeta Personalizada";
            this.Load += new System.EventHandler(this.RegistroTPersonalizada_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btRegistrar;
        private System.Windows.Forms.TextBox tBIDCliente;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.Label lbSaldo;
        private System.Windows.Forms.Label lbCTarjeta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBTelefono;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBEstacion;
    }
}