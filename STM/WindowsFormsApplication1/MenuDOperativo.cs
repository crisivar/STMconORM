using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class MenuDOperativo : Form
    {
        public MenuDOperativo()
        {
            InitializeComponent();
        }

        private void registrarEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroEmpleado RegEmp = new RegistroEmpleado();
            RegEmp.Show();

        }

        private void rutaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void verToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuRBus_Click(object sender, EventArgs e)
        {
            registrarBus RegBus = new registrarBus();
            RegBus.Show();
        }

        private void menuRRuta_Click(object sender, EventArgs e)
        {
            RegistroRuta RegRut = new RegistroRuta();
            RegRut.Show();

        }

        private void menuREstacion_Click(object sender, EventArgs e)
        {
            RegistroEstacion RegEst = new RegistroEstacion();
            RegEst.Show();
        }

        private void registrarTurnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroTurno RegTur = new RegistroTurno();
            RegTur.Show();
        }
    }
}
