namespace WindowsFormsApplication1
{
    partial class RegistroPasajero
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
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.cbECivil = new System.Windows.Forms.ComboBox();
            this.cbTipoID1 = new System.Windows.Forms.ComboBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbIdentificacion = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbTelefono = new System.Windows.Forms.Label();
            this.lbDireccion = new System.Windows.Forms.Label();
            this.lbECivil = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbTipoID = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(201, 321);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 39;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            // 
            // btRegistrar
            // 
            this.btRegistrar.Location = new System.Drawing.Point(79, 321);
            this.btRegistrar.Name = "btRegistrar";
            this.btRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btRegistrar.TabIndex = 38;
            this.btRegistrar.Text = "Registrar";
            this.btRegistrar.UseVisualStyleBackColor = true;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(134, 261);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(195, 20);
            this.tbEmail.TabIndex = 35;
            // 
            // tbTelefono
            // 
            this.tbTelefono.Location = new System.Drawing.Point(134, 222);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(195, 20);
            this.tbTelefono.TabIndex = 34;
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(134, 180);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(195, 20);
            this.tbDireccion.TabIndex = 33;
            // 
            // cbECivil
            // 
            this.cbECivil.FormattingEnabled = true;
            this.cbECivil.Items.AddRange(new object[] {
            "Soltero",
            "Casado",
            "Viudo",
            "Divorciado",
            "Union Libre"});
            this.cbECivil.Location = new System.Drawing.Point(134, 134);
            this.cbECivil.Name = "cbECivil";
            this.cbECivil.Size = new System.Drawing.Size(195, 21);
            this.cbECivil.TabIndex = 32;
            // 
            // cbTipoID1
            // 
            this.cbTipoID1.FormattingEnabled = true;
            this.cbTipoID1.Items.AddRange(new object[] {
            "Cedula Ciudadanía",
            "Cedula Extranjería"});
            this.cbTipoID1.Location = new System.Drawing.Point(134, 60);
            this.cbTipoID1.Name = "cbTipoID1";
            this.cbTipoID1.Size = new System.Drawing.Size(195, 21);
            this.cbTipoID1.TabIndex = 31;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(134, 100);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(195, 20);
            this.tbNombre.TabIndex = 30;
            // 
            // tbIdentificacion
            // 
            this.tbIdentificacion.Location = new System.Drawing.Point(134, 24);
            this.tbIdentificacion.Name = "tbIdentificacion";
            this.tbIdentificacion.Size = new System.Drawing.Size(195, 20);
            this.tbIdentificacion.TabIndex = 29;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(27, 268);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(32, 13);
            this.lbEmail.TabIndex = 26;
            this.lbEmail.Text = "Email";
            // 
            // lbTelefono
            // 
            this.lbTelefono.AutoSize = true;
            this.lbTelefono.Location = new System.Drawing.Point(27, 230);
            this.lbTelefono.Name = "lbTelefono";
            this.lbTelefono.Size = new System.Drawing.Size(49, 13);
            this.lbTelefono.TabIndex = 25;
            this.lbTelefono.Text = "Telefono";
            // 
            // lbDireccion
            // 
            this.lbDireccion.AutoSize = true;
            this.lbDireccion.Location = new System.Drawing.Point(27, 188);
            this.lbDireccion.Name = "lbDireccion";
            this.lbDireccion.Size = new System.Drawing.Size(52, 13);
            this.lbDireccion.TabIndex = 24;
            this.lbDireccion.Text = "Direccion";
            // 
            // lbECivil
            // 
            this.lbECivil.AutoSize = true;
            this.lbECivil.Location = new System.Drawing.Point(27, 142);
            this.lbECivil.Name = "lbECivil";
            this.lbECivil.Size = new System.Drawing.Size(62, 13);
            this.lbECivil.TabIndex = 23;
            this.lbECivil.Text = "Estado Civil";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(27, 100);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(44, 13);
            this.lbNombre.TabIndex = 22;
            this.lbNombre.Text = "Nombre";
            // 
            // lbTipoID
            // 
            this.lbTipoID.AutoSize = true;
            this.lbTipoID.Location = new System.Drawing.Point(27, 60);
            this.lbTipoID.Name = "lbTipoID";
            this.lbTipoID.Size = new System.Drawing.Size(48, 13);
            this.lbTipoID.TabIndex = 21;
            this.lbTipoID.Text = "Tipo I.D.";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(27, 24);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(70, 13);
            this.lbID.TabIndex = 20;
            this.lbID.Text = "Identificacion";
            // 
            // RegistroPasajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 371);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btRegistrar);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbTelefono);
            this.Controls.Add(this.tbDireccion);
            this.Controls.Add(this.cbECivil);
            this.Controls.Add(this.cbTipoID1);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.tbIdentificacion);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbTelefono);
            this.Controls.Add(this.lbDireccion);
            this.Controls.Add(this.lbECivil);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.lbTipoID);
            this.Controls.Add(this.lbID);
            this.Name = "RegistroPasajero";
            this.Text = "Registro Pasajero";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btRegistrar;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.ComboBox cbECivil;
        private System.Windows.Forms.ComboBox cbTipoID1;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbIdentificacion;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbTelefono;
        private System.Windows.Forms.Label lbDireccion;
        private System.Windows.Forms.Label lbECivil;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbTipoID;
        private System.Windows.Forms.Label lbID;
    }
}