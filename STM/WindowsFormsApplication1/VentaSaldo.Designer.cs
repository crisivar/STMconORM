namespace WindowsFormsApplication1
{
    partial class VentaSaldo
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
            this.lbIDTarjeta = new System.Windows.Forms.Label();
            this.lbSaldo = new System.Windows.Forms.Label();
            this.tbIDTarjeta = new System.Windows.Forms.TextBox();
            this.tbSaldo = new System.Windows.Forms.TextBox();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbIDTarjeta
            // 
            this.lbIDTarjeta.AutoSize = true;
            this.lbIDTarjeta.Location = new System.Drawing.Point(13, 42);
            this.lbIDTarjeta.Name = "lbIDTarjeta";
            this.lbIDTarjeta.Size = new System.Drawing.Size(60, 13);
            this.lbIDTarjeta.TabIndex = 0;
            this.lbIDTarjeta.Text = "I.D. Tarjeta";
            // 
            // lbSaldo
            // 
            this.lbSaldo.AutoSize = true;
            this.lbSaldo.Location = new System.Drawing.Point(16, 84);
            this.lbSaldo.Name = "lbSaldo";
            this.lbSaldo.Size = new System.Drawing.Size(34, 13);
            this.lbSaldo.TabIndex = 1;
            this.lbSaldo.Text = "Saldo";
            // 
            // tbIDTarjeta
            // 
            this.tbIDTarjeta.Location = new System.Drawing.Point(133, 42);
            this.tbIDTarjeta.Name = "tbIDTarjeta";
            this.tbIDTarjeta.Size = new System.Drawing.Size(139, 20);
            this.tbIDTarjeta.TabIndex = 2;
            // 
            // tbSaldo
            // 
            this.tbSaldo.Location = new System.Drawing.Point(133, 76);
            this.tbSaldo.Name = "tbSaldo";
            this.tbSaldo.Size = new System.Drawing.Size(139, 20);
            this.tbSaldo.TabIndex = 3;
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(178, 126);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 29;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(56, 126);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(75, 23);
            this.btAceptar.TabIndex = 28;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            // 
            // VentaSaldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 170);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.tbSaldo);
            this.Controls.Add(this.tbIDTarjeta);
            this.Controls.Add(this.lbSaldo);
            this.Controls.Add(this.lbIDTarjeta);
            this.Name = "VentaSaldo";
            this.Text = "Venta Saldo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbIDTarjeta;
        private System.Windows.Forms.Label lbSaldo;
        private System.Windows.Forms.TextBox tbIDTarjeta;
        private System.Windows.Forms.TextBox tbSaldo;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btAceptar;
    }
}