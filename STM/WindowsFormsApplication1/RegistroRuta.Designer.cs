namespace WindowsFormsApplication1
{
    partial class RegistroRuta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroRuta));
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.tbIDRuta = new System.Windows.Forms.TextBox();
            this.lbIDRuta = new System.Windows.Forms.Label();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btRegistrar = new System.Windows.Forms.Button();
            this.lbDescripcion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbFechaC = new System.Windows.Forms.Label();
            this.tbFechaC = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Location = new System.Drawing.Point(21, 148);
            this.tbDescripcion.Multiline = true;
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(395, 264);
            this.tbDescripcion.TabIndex = 31;
            // 
            // tbIDRuta
            // 
            this.tbIDRuta.Location = new System.Drawing.Point(187, 42);
            this.tbIDRuta.Name = "tbIDRuta";
            this.tbIDRuta.Size = new System.Drawing.Size(199, 20);
            this.tbIDRuta.TabIndex = 30;
            // 
            // lbIDRuta
            // 
            this.lbIDRuta.AutoSize = true;
            this.lbIDRuta.Location = new System.Drawing.Point(18, 49);
            this.lbIDRuta.Name = "lbIDRuta";
            this.lbIDRuta.Size = new System.Drawing.Size(50, 13);
            this.lbIDRuta.TabIndex = 29;
            this.lbIDRuta.Text = "I.D. Ruta";
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(247, 456);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 27;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btRegistrar
            // 
            this.btRegistrar.Location = new System.Drawing.Point(125, 456);
            this.btRegistrar.Name = "btRegistrar";
            this.btRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btRegistrar.TabIndex = 26;
            this.btRegistrar.Text = "Registrar";
            this.btRegistrar.UseVisualStyleBackColor = true;
            this.btRegistrar.Click += new System.EventHandler(this.btRegistrar_Click);
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.AutoSize = true;
            this.lbDescripcion.Location = new System.Drawing.Point(18, 119);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lbDescripcion.TabIndex = 24;
            this.lbDescripcion.Text = "Descripcion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 23;
            // 
            // lbFechaC
            // 
            this.lbFechaC.AutoSize = true;
            this.lbFechaC.Location = new System.Drawing.Point(18, 81);
            this.lbFechaC.Name = "lbFechaC";
            this.lbFechaC.Size = new System.Drawing.Size(163, 13);
            this.lbFechaC.TabIndex = 22;
            this.lbFechaC.Text = "Fecha Creacion (DD/MM/AAAA)\r\n";
            this.lbFechaC.Click += new System.EventHandler(this.lbFechaC_Click);
            // 
            // tbFechaC
            // 
            this.tbFechaC.Location = new System.Drawing.Point(187, 74);
            this.tbFechaC.Name = "tbFechaC";
            this.tbFechaC.Size = new System.Drawing.Size(199, 20);
            this.tbFechaC.TabIndex = 43;
            // 
            // RegistroRuta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 513);
            this.Controls.Add(this.tbFechaC);
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.tbIDRuta);
            this.Controls.Add(this.lbIDRuta);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btRegistrar);
            this.Controls.Add(this.lbDescripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbFechaC);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistroRuta";
            this.Text = "Registro Ruta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.TextBox tbIDRuta;
        private System.Windows.Forms.Label lbIDRuta;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btRegistrar;
        private System.Windows.Forms.Label lbDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbFechaC;
        private System.Windows.Forms.TextBox tbFechaC;
    }
}