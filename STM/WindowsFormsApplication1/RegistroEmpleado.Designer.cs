namespace WindowsFormsApplication1
{
    partial class RegistroEmpleado
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
            this.lbID = new System.Windows.Forms.Label();
            this.lbTipoID = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbECivil = new System.Windows.Forms.Label();
            this.lbDireccion = new System.Windows.Forms.Label();
            this.lbTelefono = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbCargo = new System.Windows.Forms.Label();
            this.lbSalario = new System.Windows.Forms.Label();
            this.tbIdentificacion = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.cbTipoID1 = new System.Windows.Forms.ComboBox();
            this.cbECivil = new System.Windows.Forms.ComboBox();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbSalario = new System.Windows.Forms.TextBox();
            this.cbCargo = new System.Windows.Forms.ComboBox();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btRegistrar = new System.Windows.Forms.Button();
            this.Es = new System.Windows.Forms.Label();
            this.estacion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tBPassw = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(16, 46);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(70, 13);
            this.lbID.TabIndex = 0;
            this.lbID.Text = "Identificacion";
            this.lbID.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbTipoID
            // 
            this.lbTipoID.AutoSize = true;
            this.lbTipoID.Location = new System.Drawing.Point(16, 82);
            this.lbTipoID.Name = "lbTipoID";
            this.lbTipoID.Size = new System.Drawing.Size(48, 13);
            this.lbTipoID.TabIndex = 1;
            this.lbTipoID.Text = "Tipo I.D.";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(16, 122);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(44, 13);
            this.lbNombre.TabIndex = 2;
            this.lbNombre.Text = "Nombre";
            // 
            // lbECivil
            // 
            this.lbECivil.AutoSize = true;
            this.lbECivil.Location = new System.Drawing.Point(16, 156);
            this.lbECivil.Name = "lbECivil";
            this.lbECivil.Size = new System.Drawing.Size(62, 13);
            this.lbECivil.TabIndex = 3;
            this.lbECivil.Text = "Estado Civil";
            // 
            // lbDireccion
            // 
            this.lbDireccion.AutoSize = true;
            this.lbDireccion.Location = new System.Drawing.Point(16, 193);
            this.lbDireccion.Name = "lbDireccion";
            this.lbDireccion.Size = new System.Drawing.Size(52, 13);
            this.lbDireccion.TabIndex = 4;
            this.lbDireccion.Text = "Direccion";
            // 
            // lbTelefono
            // 
            this.lbTelefono.AutoSize = true;
            this.lbTelefono.Location = new System.Drawing.Point(16, 230);
            this.lbTelefono.Name = "lbTelefono";
            this.lbTelefono.Size = new System.Drawing.Size(49, 13);
            this.lbTelefono.TabIndex = 5;
            this.lbTelefono.Text = "Telefono";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(16, 270);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(32, 13);
            this.lbEmail.TabIndex = 6;
            this.lbEmail.Text = "Email";
            // 
            // lbCargo
            // 
            this.lbCargo.AutoSize = true;
            this.lbCargo.Location = new System.Drawing.Point(16, 312);
            this.lbCargo.Name = "lbCargo";
            this.lbCargo.Size = new System.Drawing.Size(35, 13);
            this.lbCargo.TabIndex = 7;
            this.lbCargo.Text = "Cargo";
            // 
            // lbSalario
            // 
            this.lbSalario.AutoSize = true;
            this.lbSalario.Location = new System.Drawing.Point(16, 352);
            this.lbSalario.Name = "lbSalario";
            this.lbSalario.Size = new System.Drawing.Size(39, 13);
            this.lbSalario.TabIndex = 8;
            this.lbSalario.Text = "Salario";
            // 
            // tbIdentificacion
            // 
            this.tbIdentificacion.Location = new System.Drawing.Point(123, 43);
            this.tbIdentificacion.Name = "tbIdentificacion";
            this.tbIdentificacion.Size = new System.Drawing.Size(195, 20);
            this.tbIdentificacion.TabIndex = 9;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(123, 119);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(195, 20);
            this.tbNombre.TabIndex = 10;
            // 
            // cbTipoID1
            // 
            this.cbTipoID1.FormattingEnabled = true;
            this.cbTipoID1.Items.AddRange(new object[] {
            "Cedula Ciudadanía",
            "Cedula Extranjería"});
            this.cbTipoID1.Location = new System.Drawing.Point(123, 79);
            this.cbTipoID1.Name = "cbTipoID1";
            this.cbTipoID1.Size = new System.Drawing.Size(195, 21);
            this.cbTipoID1.TabIndex = 11;
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
            this.cbECivil.Location = new System.Drawing.Point(123, 153);
            this.cbECivil.Name = "cbECivil";
            this.cbECivil.Size = new System.Drawing.Size(195, 21);
            this.cbECivil.TabIndex = 12;
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(123, 190);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(195, 20);
            this.tbDireccion.TabIndex = 13;
            // 
            // tbTelefono
            // 
            this.tbTelefono.Location = new System.Drawing.Point(123, 227);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(195, 20);
            this.tbTelefono.TabIndex = 14;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(123, 267);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(195, 20);
            this.tbEmail.TabIndex = 15;
            // 
            // tbSalario
            // 
            this.tbSalario.Location = new System.Drawing.Point(123, 349);
            this.tbSalario.Name = "tbSalario";
            this.tbSalario.Size = new System.Drawing.Size(195, 20);
            this.tbSalario.TabIndex = 16;
            // 
            // cbCargo
            // 
            this.cbCargo.FormattingEnabled = true;
            this.cbCargo.Items.AddRange(new object[] {
            "Auxiliar",
            "Conductor",
            "Director Estacion",
            "Director Operativo"});
            this.cbCargo.Location = new System.Drawing.Point(123, 309);
            this.cbCargo.Name = "cbCargo";
            this.cbCargo.Size = new System.Drawing.Size(195, 21);
            this.cbCargo.TabIndex = 17;
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(185, 487);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 19;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btRegistrar
            // 
            this.btRegistrar.Location = new System.Drawing.Point(59, 487);
            this.btRegistrar.Name = "btRegistrar";
            this.btRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btRegistrar.TabIndex = 18;
            this.btRegistrar.Text = "Registrar";
            this.btRegistrar.UseVisualStyleBackColor = true;
            this.btRegistrar.Click += new System.EventHandler(this.btRegistrar_Click);
            // 
            // Es
            // 
            this.Es.AutoSize = true;
            this.Es.Location = new System.Drawing.Point(16, 392);
            this.Es.Name = "Es";
            this.Es.Size = new System.Drawing.Size(48, 13);
            this.Es.TabIndex = 20;
            this.Es.Text = "Estacion";
            // 
            // estacion
            // 
            this.estacion.Location = new System.Drawing.Point(123, 389);
            this.estacion.Name = "estacion";
            this.estacion.Size = new System.Drawing.Size(195, 20);
            this.estacion.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 430);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Password";
            // 
            // tBPassw
            // 
            this.tBPassw.Location = new System.Drawing.Point(123, 427);
            this.tBPassw.Name = "tBPassw";
            this.tBPassw.Size = new System.Drawing.Size(195, 20);
            this.tBPassw.TabIndex = 23;
            this.tBPassw.UseSystemPasswordChar = true;
            // 
            // RegistroEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 522);
            this.Controls.Add(this.tBPassw);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.estacion);
            this.Controls.Add(this.Es);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btRegistrar);
            this.Controls.Add(this.cbCargo);
            this.Controls.Add(this.tbSalario);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbTelefono);
            this.Controls.Add(this.tbDireccion);
            this.Controls.Add(this.cbECivil);
            this.Controls.Add(this.cbTipoID1);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.tbIdentificacion);
            this.Controls.Add(this.lbSalario);
            this.Controls.Add(this.lbCargo);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbTelefono);
            this.Controls.Add(this.lbDireccion);
            this.Controls.Add(this.lbECivil);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.lbTipoID);
            this.Controls.Add(this.lbID);
            this.Name = "RegistroEmpleado";
            this.Text = "Registro Empleado";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbTipoID;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbECivil;
        private System.Windows.Forms.Label lbDireccion;
        private System.Windows.Forms.Label lbTelefono;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbCargo;
        private System.Windows.Forms.Label lbSalario;
        private System.Windows.Forms.TextBox tbIdentificacion;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.ComboBox cbTipoID1;
        private System.Windows.Forms.ComboBox cbECivil;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbSalario;
        private System.Windows.Forms.ComboBox cbCargo;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btRegistrar;
        private System.Windows.Forms.Label Es;
        private System.Windows.Forms.TextBox estacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBPassw;
    }
}