namespace WindowsFormsApplication1
{
    partial class RegistroTGenerica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroTGenerica));
            this.label1 = new System.Windows.Forms.Label();
            this.tBIDTarjeta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tBIDEstacion = new System.Windows.Forms.TextBox();
            this.bRegistrar = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID tarjeta";
            // 
            // tBIDTarjeta
            // 
            this.tBIDTarjeta.Location = new System.Drawing.Point(98, 12);
            this.tBIDTarjeta.Name = "tBIDTarjeta";
            this.tBIDTarjeta.Size = new System.Drawing.Size(194, 20);
            this.tBIDTarjeta.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Tag = "ID Etsacion";
            this.label2.Text = "ID Estacion";
            // 
            // tBIDEstacion
            // 
            this.tBIDEstacion.Location = new System.Drawing.Point(98, 41);
            this.tBIDEstacion.Name = "tBIDEstacion";
            this.tBIDEstacion.Size = new System.Drawing.Size(194, 20);
            this.tBIDEstacion.TabIndex = 3;
            // 
            // bRegistrar
            // 
            this.bRegistrar.Location = new System.Drawing.Point(53, 78);
            this.bRegistrar.Name = "bRegistrar";
            this.bRegistrar.Size = new System.Drawing.Size(75, 23);
            this.bRegistrar.TabIndex = 4;
            this.bRegistrar.Text = "Registrar";
            this.bRegistrar.UseVisualStyleBackColor = true;
            this.bRegistrar.Click += new System.EventHandler(this.bRegistrar_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(174, 78);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 5;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // RegistroTGenerica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 113);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bRegistrar);
            this.Controls.Add(this.tBIDEstacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tBIDTarjeta);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistroTGenerica";
            this.Text = "Registro Tarjeta Generica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBIDTarjeta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBIDEstacion;
        private System.Windows.Forms.Button bRegistrar;
        private System.Windows.Forms.Button bCancelar;
    }
}