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
            this.tbSaldo = new System.Windows.Forms.TextBox();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.lbSaldo = new System.Windows.Forms.Label();
            this.lbCTarjeta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(218, 156);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 55;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            // 
            // btRegistrar
            // 
            this.btRegistrar.Location = new System.Drawing.Point(96, 156);
            this.btRegistrar.Name = "btRegistrar";
            this.btRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btRegistrar.TabIndex = 54;
            this.btRegistrar.Text = "Registrar";
            this.btRegistrar.UseVisualStyleBackColor = true;
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
            // RegistroTPersonalizada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 212);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btRegistrar);
            this.Controls.Add(this.tbSaldo);
            this.Controls.Add(this.tbCodigo);
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
        private System.Windows.Forms.TextBox tbSaldo;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.Label lbSaldo;
        private System.Windows.Forms.Label lbCTarjeta;
    }
}