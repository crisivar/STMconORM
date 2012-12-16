namespace WindowsFormsApplication1
{
    partial class MenuDOperativo
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
            this.registroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarBusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarRutaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarEstacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroToolStripMenuItem,
            this.verToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(623, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registroToolStripMenuItem
            // 
            this.registroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarEmpleadosToolStripMenuItem,
            this.registrarBusToolStripMenuItem,
            this.registrarRutaToolStripMenuItem,
            this.registrarEstacionesToolStripMenuItem});
            this.registroToolStripMenuItem.Name = "registroToolStripMenuItem";
            this.registroToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.registroToolStripMenuItem.Text = "Registro";
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(36, 20);
            this.verToolStripMenuItem.Text = "Ver";
            // 
            // registrarEmpleadosToolStripMenuItem
            // 
            this.registrarEmpleadosToolStripMenuItem.Name = "registrarEmpleadosToolStripMenuItem";
            this.registrarEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.registrarEmpleadosToolStripMenuItem.Text = "Registrar Empleado";
            this.registrarEmpleadosToolStripMenuItem.Click += new System.EventHandler(this.registrarEmpleadosToolStripMenuItem_Click);
            // 
            // registrarBusToolStripMenuItem
            // 
            this.registrarBusToolStripMenuItem.Name = "registrarBusToolStripMenuItem";
            this.registrarBusToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.registrarBusToolStripMenuItem.Text = "Registrar Bus";
            // 
            // registrarRutaToolStripMenuItem
            // 
            this.registrarRutaToolStripMenuItem.Name = "registrarRutaToolStripMenuItem";
            this.registrarRutaToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.registrarRutaToolStripMenuItem.Text = "Registrar Ruta";
            // 
            // registrarEstacionesToolStripMenuItem
            // 
            this.registrarEstacionesToolStripMenuItem.Name = "registrarEstacionesToolStripMenuItem";
            this.registrarEstacionesToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.registrarEstacionesToolStripMenuItem.Text = "Registrar Estaciones";
            // 
            // MenuDOperativo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 490);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuDOperativo";
            this.Text = "Director Operativo";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarEmpleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarBusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarRutaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarEstacionesToolStripMenuItem;
    }
}