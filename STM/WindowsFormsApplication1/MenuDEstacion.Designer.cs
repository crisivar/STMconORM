namespace WindowsFormsApplication1
{
    partial class MenuDEstacion
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuRegistro = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsulta = new System.Windows.Forms.ToolStripMenuItem();
            this.perfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informacionCuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirCuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarAuxiliaresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.auxiliaresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quejasYReclamosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.responderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuRegistro,
            this.menuConsulta,
            this.perfilToolStripMenuItem,
            this.quejasYReclamosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(528, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuRegistro
            // 
            this.menuRegistro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarAuxiliaresToolStripMenuItem});
            this.menuRegistro.Name = "menuRegistro";
            this.menuRegistro.Size = new System.Drawing.Size(62, 20);
            this.menuRegistro.Text = "Registro";
            // 
            // menuConsulta
            // 
            this.menuConsulta.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.auxiliaresToolStripMenuItem});
            this.menuConsulta.Name = "menuConsulta";
            this.menuConsulta.Size = new System.Drawing.Size(66, 20);
            this.menuConsulta.Text = "Consulta";
            this.menuConsulta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.menuConsulta.Click += new System.EventHandler(this.menuConsulta_Click);
            // 
            // perfilToolStripMenuItem
            // 
            this.perfilToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informacionCuentaToolStripMenuItem,
            this.salirCuentaToolStripMenuItem});
            this.perfilToolStripMenuItem.Name = "perfilToolStripMenuItem";
            this.perfilToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.perfilToolStripMenuItem.Text = "Perfil";
            // 
            // informacionCuentaToolStripMenuItem
            // 
            this.informacionCuentaToolStripMenuItem.Name = "informacionCuentaToolStripMenuItem";
            this.informacionCuentaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.informacionCuentaToolStripMenuItem.Text = "Informacion Cuenta";
            // 
            // salirCuentaToolStripMenuItem
            // 
            this.salirCuentaToolStripMenuItem.Name = "salirCuentaToolStripMenuItem";
            this.salirCuentaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirCuentaToolStripMenuItem.Text = "Salir Cuenta";
            // 
            // registrarAuxiliaresToolStripMenuItem
            // 
            this.registrarAuxiliaresToolStripMenuItem.Name = "registrarAuxiliaresToolStripMenuItem";
            this.registrarAuxiliaresToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.registrarAuxiliaresToolStripMenuItem.Text = "Registrar Auxiliar";
            // 
            // auxiliaresToolStripMenuItem
            // 
            this.auxiliaresToolStripMenuItem.Name = "auxiliaresToolStripMenuItem";
            this.auxiliaresToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.auxiliaresToolStripMenuItem.Text = "Auxiliares";
            // 
            // quejasYReclamosToolStripMenuItem
            // 
            this.quejasYReclamosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarToolStripMenuItem,
            this.responderToolStripMenuItem});
            this.quejasYReclamosToolStripMenuItem.Name = "quejasYReclamosToolStripMenuItem";
            this.quejasYReclamosToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.quejasYReclamosToolStripMenuItem.Text = "Quejas y Reclamos";
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.consultarToolStripMenuItem.Text = "Consultar";
            // 
            // responderToolStripMenuItem
            // 
            this.responderToolStripMenuItem.Name = "responderToolStripMenuItem";
            this.responderToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.responderToolStripMenuItem.Text = "Responder";
            // 
            // MenuDEstacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 447);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MenuDEstacion";
            this.Text = "Director de Estacion";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuRegistro;
        private System.Windows.Forms.ToolStripMenuItem menuConsulta;
        private System.Windows.Forms.ToolStripMenuItem perfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informacionCuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirCuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarAuxiliaresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem auxiliaresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quejasYReclamosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem responderToolStripMenuItem;
    }
}