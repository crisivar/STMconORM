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
            this.btCancelar = new System.Windows.Forms.Button();
            this.btRegistrar = new System.Windows.Forms.Button();
            this.tbTelefonoP = new System.Windows.Forms.TextBox();
            this.tbNombreP = new System.Windows.Forms.TextBox();
            this.tbSaldo = new System.Windows.Forms.TextBox();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.lbTelefonoP = new System.Windows.Forms.Label();
            this.lbNombreP = new System.Windows.Forms.Label();
            this.lbSaldo = new System.Windows.Forms.Label();
            this.lbCTarjeta = new System.Windows.Forms.Label();
            this.tbIDPasajero = new System.Windows.Forms.TextBox();
            this.lbIDPasajero = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(218, 298);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 55;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            // 
            // btRegistrar
            // 
            this.btRegistrar.Location = new System.Drawing.Point(96, 298);
            this.btRegistrar.Name = "btRegistrar";
            this.btRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btRegistrar.TabIndex = 54;
            this.btRegistrar.Text = "Registrar";
            this.btRegistrar.UseVisualStyleBackColor = true;
            // 
            // tbTelefonoP
            // 
            this.tbTelefonoP.Location = new System.Drawing.Point(150, 226);
            this.tbTelefonoP.Name = "tbTelefonoP";
            this.tbTelefonoP.Size = new System.Drawing.Size(195, 20);
            this.tbTelefonoP.TabIndex = 52;
            // 
            // tbNombreP
            // 
            this.tbNombreP.Location = new System.Drawing.Point(150, 180);
            this.tbNombreP.Name = "tbNombreP";
            this.tbNombreP.Size = new System.Drawing.Size(195, 20);
            this.tbNombreP.TabIndex = 51;
            // 
            // tbSaldo
            // 
            this.tbSaldo.Location = new System.Drawing.Point(150, 96);
            this.tbSaldo.Name = "tbSaldo";
            this.tbSaldo.Size = new System.Drawing.Size(195, 20);
            this.tbSaldo.TabIndex = 48;
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(150, 52);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(195, 20);
            this.tbCodigo.TabIndex = 47;
            // 
            // lbTelefonoP
            // 
            this.lbTelefonoP.AutoSize = true;
            this.lbTelefonoP.Location = new System.Drawing.Point(43, 233);
            this.lbTelefonoP.Name = "lbTelefonoP";
            this.lbTelefonoP.Size = new System.Drawing.Size(93, 13);
            this.lbTelefonoP.TabIndex = 45;
            this.lbTelefonoP.Text = "Telefono Pasajero";
            // 
            // lbNombreP
            // 
            this.lbNombreP.AutoSize = true;
            this.lbNombreP.Location = new System.Drawing.Point(43, 187);
            this.lbNombreP.Name = "lbNombreP";
            this.lbNombreP.Size = new System.Drawing.Size(88, 13);
            this.lbNombreP.TabIndex = 44;
            this.lbNombreP.Text = "Nombre Pasajero";
            // 
            // lbSaldo
            // 
            this.lbSaldo.AutoSize = true;
            this.lbSaldo.Location = new System.Drawing.Point(43, 103);
            this.lbSaldo.Name = "lbSaldo";
            this.lbSaldo.Size = new System.Drawing.Size(34, 13);
            this.lbSaldo.TabIndex = 42;
            this.lbSaldo.Text = "Saldo";
            // 
            // lbCTarjeta
            // 
            this.lbCTarjeta.AutoSize = true;
            this.lbCTarjeta.Location = new System.Drawing.Point(43, 59);
            this.lbCTarjeta.Name = "lbCTarjeta";
            this.lbCTarjeta.Size = new System.Drawing.Size(76, 13);
            this.lbCTarjeta.TabIndex = 40;
            this.lbCTarjeta.Text = "Código Tarjeta";
            // 
            // tbIDPasajero
            // 
            this.tbIDPasajero.Location = new System.Drawing.Point(150, 138);
            this.tbIDPasajero.Name = "tbIDPasajero";
            this.tbIDPasajero.Size = new System.Drawing.Size(195, 20);
            this.tbIDPasajero.TabIndex = 57;
            // 
            // lbIDPasajero
            // 
            this.lbIDPasajero.AutoSize = true;
            this.lbIDPasajero.Location = new System.Drawing.Point(43, 145);
            this.lbIDPasajero.Name = "lbIDPasajero";
            this.lbIDPasajero.Size = new System.Drawing.Size(68, 13);
            this.lbIDPasajero.TabIndex = 56;
            this.lbIDPasajero.Text = "I.D. Pasajero";
            // 
            // RegistroTPersonalizada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 353);
            this.Controls.Add(this.tbIDPasajero);
            this.Controls.Add(this.lbIDPasajero);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btRegistrar);
            this.Controls.Add(this.tbTelefonoP);
            this.Controls.Add(this.tbNombreP);
            this.Controls.Add(this.tbSaldo);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.lbTelefonoP);
            this.Controls.Add(this.lbNombreP);
            this.Controls.Add(this.lbSaldo);
            this.Controls.Add(this.lbCTarjeta);
            this.Name = "RegistroTPersonalizada";
            this.Text = "Registro Tarjeta Personalizada";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RegistroTPersonalizada_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btRegistrar;
        private System.Windows.Forms.TextBox tbTelefonoP;
        private System.Windows.Forms.TextBox tbNombreP;
        private System.Windows.Forms.TextBox tbSaldo;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.Label lbTelefonoP;
        private System.Windows.Forms.Label lbNombreP;
        private System.Windows.Forms.Label lbSaldo;
        private System.Windows.Forms.Label lbCTarjeta;
        private System.Windows.Forms.TextBox tbIDPasajero;
        private System.Windows.Forms.Label lbIDPasajero;
    }
}