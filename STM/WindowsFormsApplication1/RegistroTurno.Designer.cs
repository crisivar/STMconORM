namespace WindowsFormsApplication1
{
    partial class RegistroTurno
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
            this.lbIDBus = new System.Windows.Forms.Label();
            this.lbRuta = new System.Windows.Forms.Label();
            this.lbEmpleado = new System.Windows.Forms.Label();
            this.lbHComienzo = new System.Windows.Forms.Label();
            this.lbHFin = new System.Windows.Forms.Label();
            this.tbIDBus = new System.Windows.Forms.TextBox();
            this.tbIDRuta = new System.Windows.Forms.TextBox();
            this.tbHComienzo = new System.Windows.Forms.TextBox();
            this.tbIDEmpleado = new System.Windows.Forms.TextBox();
            this.tbHFin = new System.Windows.Forms.TextBox();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btRegistrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbIDBus
            // 
            this.lbIDBus.AutoSize = true;
            this.lbIDBus.Location = new System.Drawing.Point(13, 37);
            this.lbIDBus.Name = "lbIDBus";
            this.lbIDBus.Size = new System.Drawing.Size(45, 13);
            this.lbIDBus.TabIndex = 0;
            this.lbIDBus.Text = "I.D. Bus";
            // 
            // lbRuta
            // 
            this.lbRuta.AutoSize = true;
            this.lbRuta.Location = new System.Drawing.Point(13, 81);
            this.lbRuta.Name = "lbRuta";
            this.lbRuta.Size = new System.Drawing.Size(50, 13);
            this.lbRuta.TabIndex = 1;
            this.lbRuta.Text = "I.D. Ruta";
            // 
            // lbEmpleado
            // 
            this.lbEmpleado.AutoSize = true;
            this.lbEmpleado.Location = new System.Drawing.Point(12, 121);
            this.lbEmpleado.Name = "lbEmpleado";
            this.lbEmpleado.Size = new System.Drawing.Size(74, 13);
            this.lbEmpleado.TabIndex = 2;
            this.lbEmpleado.Text = "I.D. Empleado";
            // 
            // lbHComienzo
            // 
            this.lbHComienzo.AutoSize = true;
            this.lbHComienzo.Location = new System.Drawing.Point(13, 161);
            this.lbHComienzo.Name = "lbHComienzo";
            this.lbHComienzo.Size = new System.Drawing.Size(37, 13);
            this.lbHComienzo.TabIndex = 3;
            this.lbHComienzo.Text = "Fecha";
            // 
            // lbHFin
            // 
            this.lbHFin.AutoSize = true;
            this.lbHFin.Location = new System.Drawing.Point(16, 200);
            this.lbHFin.Name = "lbHFin";
            this.lbHFin.Size = new System.Drawing.Size(41, 13);
            this.lbHFin.TabIndex = 4;
            this.lbHFin.Text = "Horario";
            // 
            // tbIDBus
            // 
            this.tbIDBus.Location = new System.Drawing.Point(154, 29);
            this.tbIDBus.Name = "tbIDBus";
            this.tbIDBus.Size = new System.Drawing.Size(158, 20);
            this.tbIDBus.TabIndex = 5;
            // 
            // tbIDRuta
            // 
            this.tbIDRuta.Location = new System.Drawing.Point(154, 73);
            this.tbIDRuta.Name = "tbIDRuta";
            this.tbIDRuta.Size = new System.Drawing.Size(158, 20);
            this.tbIDRuta.TabIndex = 6;
            // 
            // tbHComienzo
            // 
            this.tbHComienzo.Location = new System.Drawing.Point(154, 153);
            this.tbHComienzo.Name = "tbHComienzo";
            this.tbHComienzo.Size = new System.Drawing.Size(158, 20);
            this.tbHComienzo.TabIndex = 7;
            // 
            // tbIDEmpleado
            // 
            this.tbIDEmpleado.Location = new System.Drawing.Point(154, 113);
            this.tbIDEmpleado.Name = "tbIDEmpleado";
            this.tbIDEmpleado.Size = new System.Drawing.Size(158, 20);
            this.tbIDEmpleado.TabIndex = 8;
            // 
            // tbHFin
            // 
            this.tbHFin.Location = new System.Drawing.Point(154, 192);
            this.tbHFin.Name = "tbHFin";
            this.tbHFin.Size = new System.Drawing.Size(158, 20);
            this.tbHFin.TabIndex = 9;
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(183, 247);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 41;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btRegistrar
            // 
            this.btRegistrar.Location = new System.Drawing.Point(61, 247);
            this.btRegistrar.Name = "btRegistrar";
            this.btRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btRegistrar.TabIndex = 40;
            this.btRegistrar.Text = "Registrar";
            this.btRegistrar.UseVisualStyleBackColor = true;
            this.btRegistrar.Click += new System.EventHandler(this.btRegistrar_Click);
            // 
            // RegistroTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 306);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btRegistrar);
            this.Controls.Add(this.tbHFin);
            this.Controls.Add(this.tbIDEmpleado);
            this.Controls.Add(this.tbHComienzo);
            this.Controls.Add(this.tbIDRuta);
            this.Controls.Add(this.tbIDBus);
            this.Controls.Add(this.lbHFin);
            this.Controls.Add(this.lbHComienzo);
            this.Controls.Add(this.lbEmpleado);
            this.Controls.Add(this.lbRuta);
            this.Controls.Add(this.lbIDBus);
            this.Name = "RegistroTurno";
            this.Text = "Registro Turno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbIDBus;
        private System.Windows.Forms.Label lbRuta;
        private System.Windows.Forms.Label lbEmpleado;
        private System.Windows.Forms.Label lbHComienzo;
        private System.Windows.Forms.Label lbHFin;
        private System.Windows.Forms.TextBox tbIDBus;
        private System.Windows.Forms.TextBox tbIDRuta;
        private System.Windows.Forms.TextBox tbHComienzo;
        private System.Windows.Forms.TextBox tbIDEmpleado;
        private System.Windows.Forms.TextBox tbHFin;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btRegistrar;
    }
}