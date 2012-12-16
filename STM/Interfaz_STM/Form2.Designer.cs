namespace Interfaz_STM
{
    partial class Form2
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
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbTelefono = new System.Windows.Forms.Label();
            this.lbDireccion = new System.Windows.Forms.Label();
            this.lbEstadoC = new System.Windows.Forms.Label();
            this.lbTipoID = new System.Windows.Forms.Label();
            this.lbIdentificacion = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(15, 264);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(32, 13);
            this.lbEmail.TabIndex = 13;
            this.lbEmail.Text = "Email";
            // 
            // lbTelefono
            // 
            this.lbTelefono.AutoSize = true;
            this.lbTelefono.Location = new System.Drawing.Point(12, 230);
            this.lbTelefono.Name = "lbTelefono";
            this.lbTelefono.Size = new System.Drawing.Size(49, 13);
            this.lbTelefono.TabIndex = 12;
            this.lbTelefono.Text = "Teléfono";
            // 
            // lbDireccion
            // 
            this.lbDireccion.AutoSize = true;
            this.lbDireccion.Location = new System.Drawing.Point(12, 197);
            this.lbDireccion.Name = "lbDireccion";
            this.lbDireccion.Size = new System.Drawing.Size(52, 13);
            this.lbDireccion.TabIndex = 11;
            this.lbDireccion.Text = "Dirección";
            // 
            // lbEstadoC
            // 
            this.lbEstadoC.AutoSize = true;
            this.lbEstadoC.Location = new System.Drawing.Point(12, 165);
            this.lbEstadoC.Name = "lbEstadoC";
            this.lbEstadoC.Size = new System.Drawing.Size(62, 13);
            this.lbEstadoC.TabIndex = 10;
            this.lbEstadoC.Text = "Estado Civil";
            // 
            // lbTipoID
            // 
            this.lbTipoID.AutoSize = true;
            this.lbTipoID.Location = new System.Drawing.Point(12, 131);
            this.lbTipoID.Name = "lbTipoID";
            this.lbTipoID.Size = new System.Drawing.Size(48, 13);
            this.lbTipoID.TabIndex = 9;
            this.lbTipoID.Text = "Tipo I.D.";
            // 
            // lbIdentificacion
            // 
            this.lbIdentificacion.AutoSize = true;
            this.lbIdentificacion.Location = new System.Drawing.Point(12, 96);
            this.lbIdentificacion.Name = "lbIdentificacion";
            this.lbIdentificacion.Size = new System.Drawing.Size(70, 13);
            this.lbIdentificacion.TabIndex = 8;
            this.lbIdentificacion.Text = "Identificacion";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(9, 61);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(91, 13);
            this.lbNombre.TabIndex = 7;
            this.lbNombre.Text = "Nombre Completo";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 384);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbTelefono);
            this.Controls.Add(this.lbDireccion);
            this.Controls.Add(this.lbEstadoC);
            this.Controls.Add(this.lbTipoID);
            this.Controls.Add(this.lbIdentificacion);
            this.Controls.Add(this.lbNombre);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lbEmail;
        internal System.Windows.Forms.Label lbTelefono;
        internal System.Windows.Forms.Label lbDireccion;
        internal System.Windows.Forms.Label lbEstadoC;
        internal System.Windows.Forms.Label lbTipoID;
        internal System.Windows.Forms.Label lbIdentificacion;
        internal System.Windows.Forms.Label lbNombre;
    }
}