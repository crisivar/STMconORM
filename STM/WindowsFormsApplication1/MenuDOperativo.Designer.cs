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
            this.menuRegistro = new System.Windows.Forms.ToolStripMenuItem();
            this.menuREmpleado = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRBus = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRRuta = new System.Windows.Forms.ToolStripMenuItem();
            this.menuREstacion = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarTurnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsulta = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCEmpleados = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCBuses = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCRutas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCEstaciones = new System.Windows.Forms.ToolStripMenuItem();
            this.turnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informacionCuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirCuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuRegistro,
            this.menuConsulta,
            this.perfilToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(623, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuRegistro
            // 
            this.menuRegistro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuREmpleado,
            this.menuRBus,
            this.menuRRuta,
            this.menuREstacion,
            this.registrarTurnoToolStripMenuItem});
            this.menuRegistro.Name = "menuRegistro";
            this.menuRegistro.Size = new System.Drawing.Size(62, 20);
            this.menuRegistro.Text = "Registro";
            // 
            // menuREmpleado
            // 
            this.menuREmpleado.Name = "menuREmpleado";
            this.menuREmpleado.Size = new System.Drawing.Size(176, 22);
            this.menuREmpleado.Text = "Registrar Empleado";
            this.menuREmpleado.Click += new System.EventHandler(this.registrarEmpleadosToolStripMenuItem_Click);
            // 
            // menuRBus
            // 
            this.menuRBus.Name = "menuRBus";
            this.menuRBus.Size = new System.Drawing.Size(176, 22);
            this.menuRBus.Text = "Registrar Bus";
            this.menuRBus.Click += new System.EventHandler(this.menuRBus_Click);
            // 
            // menuRRuta
            // 
            this.menuRRuta.Name = "menuRRuta";
            this.menuRRuta.Size = new System.Drawing.Size(176, 22);
            this.menuRRuta.Text = "Registrar Ruta";
            this.menuRRuta.Click += new System.EventHandler(this.menuRRuta_Click);
            // 
            // menuREstacion
            // 
            this.menuREstacion.Name = "menuREstacion";
            this.menuREstacion.Size = new System.Drawing.Size(176, 22);
            this.menuREstacion.Text = "Registrar Estacion";
            this.menuREstacion.Click += new System.EventHandler(this.menuREstacion_Click);
            // 
            // registrarTurnoToolStripMenuItem
            // 
            this.registrarTurnoToolStripMenuItem.Name = "registrarTurnoToolStripMenuItem";
            this.registrarTurnoToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.registrarTurnoToolStripMenuItem.Text = "Registrar Turno";
            this.registrarTurnoToolStripMenuItem.Click += new System.EventHandler(this.registrarTurnoToolStripMenuItem_Click);
            // 
            // menuConsulta
            // 
            this.menuConsulta.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCEmpleados,
            this.menuCBuses,
            this.menuCRutas,
            this.menuCEstaciones,
            this.turnosToolStripMenuItem});
            this.menuConsulta.Name = "menuConsulta";
            this.menuConsulta.Size = new System.Drawing.Size(66, 20);
            this.menuConsulta.Text = "Consulta";
            this.menuConsulta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.menuConsulta.Click += new System.EventHandler(this.verToolStripMenuItem_Click);
            // 
            // menuCEmpleados
            // 
            this.menuCEmpleados.Name = "menuCEmpleados";
            this.menuCEmpleados.Size = new System.Drawing.Size(132, 22);
            this.menuCEmpleados.Text = "Empleados";
            // 
            // menuCBuses
            // 
            this.menuCBuses.Name = "menuCBuses";
            this.menuCBuses.Size = new System.Drawing.Size(132, 22);
            this.menuCBuses.Text = "Buses";
            // 
            // menuCRutas
            // 
            this.menuCRutas.Name = "menuCRutas";
            this.menuCRutas.Size = new System.Drawing.Size(132, 22);
            this.menuCRutas.Text = "Rutas";
            this.menuCRutas.Click += new System.EventHandler(this.rutaToolStripMenuItem_Click);
            // 
            // menuCEstaciones
            // 
            this.menuCEstaciones.Name = "menuCEstaciones";
            this.menuCEstaciones.Size = new System.Drawing.Size(132, 22);
            this.menuCEstaciones.Text = "Estaciones";
            // 
            // turnosToolStripMenuItem
            // 
            this.turnosToolStripMenuItem.Name = "turnosToolStripMenuItem";
            this.turnosToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.turnosToolStripMenuItem.Text = "Turnos";
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
        private System.Windows.Forms.ToolStripMenuItem menuRegistro;
        private System.Windows.Forms.ToolStripMenuItem menuREmpleado;
        private System.Windows.Forms.ToolStripMenuItem menuRBus;
        private System.Windows.Forms.ToolStripMenuItem menuConsulta;
        private System.Windows.Forms.ToolStripMenuItem menuRRuta;
        private System.Windows.Forms.ToolStripMenuItem menuREstacion;
        private System.Windows.Forms.ToolStripMenuItem menuCEmpleados;
        private System.Windows.Forms.ToolStripMenuItem menuCBuses;
        private System.Windows.Forms.ToolStripMenuItem menuCRutas;
        private System.Windows.Forms.ToolStripMenuItem menuCEstaciones;
        private System.Windows.Forms.ToolStripMenuItem perfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informacionCuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirCuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarTurnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turnosToolStripMenuItem;
    }
}