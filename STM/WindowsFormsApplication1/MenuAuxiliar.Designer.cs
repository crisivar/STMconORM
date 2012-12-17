namespace WindowsFormsApplication1
{
    partial class MenuAuxiliar
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
            this.tarjetasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarTarjetaPersonalizadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recargaTarjetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarQuejasYReclamosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consulltarTarjetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informacionCuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirCuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tarjetasToolStripMenuItem,
            this.consultaToolStripMenuItem,
            this.perfilToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(503, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tarjetasToolStripMenuItem
            // 
            this.tarjetasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarTarjetaPersonalizadaToolStripMenuItem,
            this.recargaTarjetaToolStripMenuItem,
            this.registrarQuejasYReclamosToolStripMenuItem});
            this.tarjetasToolStripMenuItem.Name = "tarjetasToolStripMenuItem";
            this.tarjetasToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.tarjetasToolStripMenuItem.Text = "Registro";
            // 
            // consultarTarjetaPersonalizadaToolStripMenuItem
            // 
            this.consultarTarjetaPersonalizadaToolStripMenuItem.Name = "consultarTarjetaPersonalizadaToolStripMenuItem";
            this.consultarTarjetaPersonalizadaToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.consultarTarjetaPersonalizadaToolStripMenuItem.Text = "Registrar Tarjeta Personalizada";
            // 
            // recargaTarjetaToolStripMenuItem
            // 
            this.recargaTarjetaToolStripMenuItem.Name = "recargaTarjetaToolStripMenuItem";
            this.recargaTarjetaToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.recargaTarjetaToolStripMenuItem.Text = "Registro Tarjeta Generica";
            // 
            // registrarQuejasYReclamosToolStripMenuItem
            // 
            this.registrarQuejasYReclamosToolStripMenuItem.Name = "registrarQuejasYReclamosToolStripMenuItem";
            this.registrarQuejasYReclamosToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.registrarQuejasYReclamosToolStripMenuItem.Text = "Registrar Quejas y Reclamos";
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consulltarTarjetaToolStripMenuItem,
            this.consultarToolStripMenuItem});
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.consultaToolStripMenuItem.Text = "Consulta";
            // 
            // consulltarTarjetaToolStripMenuItem
            // 
            this.consulltarTarjetaToolStripMenuItem.Name = "consulltarTarjetaToolStripMenuItem";
            this.consulltarTarjetaToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.consulltarTarjetaToolStripMenuItem.Text = "Consulltar Tarjeta";
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.consultarToolStripMenuItem.Text = "Consultar Quejas y Reclamos";
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
            // MenuAuxiliar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 424);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuAuxiliar";
            this.Text = "Auxiliar";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tarjetasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarTarjetaPersonalizadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recargaTarjetaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarQuejasYReclamosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consulltarTarjetaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informacionCuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirCuentaToolStripMenuItem;
    }
}