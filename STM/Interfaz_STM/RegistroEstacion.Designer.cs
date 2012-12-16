namespace Interfaz_STM
{
    partial class RegistroEstacion
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
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.tbNEstacion = new System.Windows.Forms.TextBox();
            this.lbDireccion = new System.Windows.Forms.Label();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btRegistrar = new System.Windows.Forms.Button();
            this.lbNombre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(143, 87);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(195, 20);
            this.tbDireccion.TabIndex = 29;
            // 
            // tbNEstacion
            // 
            this.tbNEstacion.Location = new System.Drawing.Point(143, 33);
            this.tbNEstacion.Name = "tbNEstacion";
            this.tbNEstacion.Size = new System.Drawing.Size(195, 20);
            this.tbNEstacion.TabIndex = 28;
            // 
            // lbDireccion
            // 
            this.lbDireccion.AutoSize = true;
            this.lbDireccion.Location = new System.Drawing.Point(28, 87);
            this.lbDireccion.Name = "lbDireccion";
            this.lbDireccion.Size = new System.Drawing.Size(52, 13);
            this.lbDireccion.TabIndex = 27;
            this.lbDireccion.Text = "Direccion";
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(195, 149);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(98, 25);
            this.btCancelar.TabIndex = 26;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            // 
            // btRegistrar
            // 
            this.btRegistrar.Location = new System.Drawing.Point(63, 148);
            this.btRegistrar.Name = "btRegistrar";
            this.btRegistrar.Size = new System.Drawing.Size(99, 26);
            this.btRegistrar.TabIndex = 25;
            this.btRegistrar.Text = "Registrar";
            this.btRegistrar.UseVisualStyleBackColor = true;
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(28, 40);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(88, 13);
            this.lbNombre.TabIndex = 24;
            this.lbNombre.Text = "Nombre Estacion";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 207);
            this.Controls.Add(this.tbDireccion);
            this.Controls.Add(this.tbNEstacion);
            this.Controls.Add(this.lbDireccion);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btRegistrar);
            this.Controls.Add(this.lbNombre);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox tbDireccion;
        internal System.Windows.Forms.TextBox tbNEstacion;
        internal System.Windows.Forms.Label lbDireccion;
        internal System.Windows.Forms.Button btCancelar;
        internal System.Windows.Forms.Button btRegistrar;
        internal System.Windows.Forms.Label lbNombre;
    }
}