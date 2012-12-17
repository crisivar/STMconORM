namespace WindowsFormsApplication1
{
    partial class RegistroSolicitud
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
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.lbDescripcion = new System.Windows.Forms.Label();
            this.lbTipo = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.tbTipo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tBTarjeta = new System.Windows.Forms.TextBox();
            this.tBEstacion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(194, 304);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 39;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btRegistrar
            // 
            this.btRegistrar.Location = new System.Drawing.Point(65, 304);
            this.btRegistrar.Name = "btRegistrar";
            this.btRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btRegistrar.TabIndex = 38;
            this.btRegistrar.Text = "Registrar";
            this.btRegistrar.UseVisualStyleBackColor = true;
            this.btRegistrar.Click += new System.EventHandler(this.btRegistrar_Click);
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Location = new System.Drawing.Point(24, 145);
            this.tbDescripcion.Multiline = true;
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(299, 133);
            this.tbDescripcion.TabIndex = 30;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(135, 10);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(195, 20);
            this.tbID.TabIndex = 29;
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.AutoSize = true;
            this.lbDescripcion.Location = new System.Drawing.Point(21, 129);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lbDescripcion.TabIndex = 22;
            this.lbDescripcion.Text = "Descripcion";
            // 
            // lbTipo
            // 
            this.lbTipo.AutoSize = true;
            this.lbTipo.Location = new System.Drawing.Point(21, 42);
            this.lbTipo.Name = "lbTipo";
            this.lbTipo.Size = new System.Drawing.Size(31, 13);
            this.lbTipo.TabIndex = 21;
            this.lbTipo.Text = "Tipo ";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(21, 13);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(24, 13);
            this.lbID.TabIndex = 20;
            this.lbID.Text = "I.D.";
            // 
            // tbTipo
            // 
            this.tbTipo.Location = new System.Drawing.Point(135, 39);
            this.tbTipo.Name = "tbTipo";
            this.tbTipo.Size = new System.Drawing.Size(195, 20);
            this.tbTipo.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "ID tarjeta";
            // 
            // tBTarjeta
            // 
            this.tBTarjeta.Location = new System.Drawing.Point(135, 69);
            this.tBTarjeta.Name = "tBTarjeta";
            this.tBTarjeta.Size = new System.Drawing.Size(195, 20);
            this.tBTarjeta.TabIndex = 42;
            // 
            // tBEstacion
            // 
            this.tBEstacion.Location = new System.Drawing.Point(135, 98);
            this.tBEstacion.Name = "tBEstacion";
            this.tBEstacion.Size = new System.Drawing.Size(195, 20);
            this.tBEstacion.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "ID estacion";
            // 
            // RegistroSolicitud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 338);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tBEstacion);
            this.Controls.Add(this.tBTarjeta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTipo);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btRegistrar);
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.lbDescripcion);
            this.Controls.Add(this.lbTipo);
            this.Controls.Add(this.lbID);
            this.Name = "RegistroSolicitud";
            this.Text = "Registro Solicitud";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btRegistrar;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label lbDescripcion;
        private System.Windows.Forms.Label lbTipo;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.TextBox tbTipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBTarjeta;
        private System.Windows.Forms.TextBox tBEstacion;
        private System.Windows.Forms.Label label2;
    }
}