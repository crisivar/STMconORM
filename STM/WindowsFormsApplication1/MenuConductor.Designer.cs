namespace WindowsFormsApplication1
{
    partial class MenuConductor
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
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarTurnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarRutaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarPerfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirCuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultasToolStripMenuItem,
            this.perfilToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarTurnoToolStripMenuItem,
            this.consultarRutaToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // consultarTurnoToolStripMenuItem
            // 
            this.consultarTurnoToolStripMenuItem.Name = "consultarTurnoToolStripMenuItem";
            this.consultarTurnoToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.consultarTurnoToolStripMenuItem.Text = "Consultar Turno";
            // 
            // consultarRutaToolStripMenuItem
            // 
            this.consultarRutaToolStripMenuItem.Name = "consultarRutaToolStripMenuItem";
            this.consultarRutaToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.consultarRutaToolStripMenuItem.Text = "Consultar Ruta";
            // 
            // perfilToolStripMenuItem
            // 
            this.perfilToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarPerfilToolStripMenuItem,
            this.salirCuentaToolStripMenuItem});
            this.perfilToolStripMenuItem.Name = "perfilToolStripMenuItem";
            this.perfilToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.perfilToolStripMenuItem.Text = "Perfil";
            // 
            // consultarPerfilToolStripMenuItem
            // 
            this.consultarPerfilToolStripMenuItem.Name = "consultarPerfilToolStripMenuItem";
            this.consultarPerfilToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consultarPerfilToolStripMenuItem.Text = "Informacion Cuenta";
            this.consultarPerfilToolStripMenuItem.Click += new System.EventHandler(this.consultarPerfilToolStripMenuItem_Click);
            // 
            // salirCuentaToolStripMenuItem
            // 
            this.salirCuentaToolStripMenuItem.Name = "salirCuentaToolStripMenuItem";
            this.salirCuentaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirCuentaToolStripMenuItem.Text = "Salir Cuenta";
            // 
            // MenuConductor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 438);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuConductor";
            this.Text = "Conductor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarTurnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarRutaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarPerfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirCuentaToolStripMenuItem;
    }
}