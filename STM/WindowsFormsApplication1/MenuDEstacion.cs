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
    public partial class MenuDEstacion : Form
    {
        public MenuDEstacion()
        {
            InitializeComponent();
        }

        private void menuConsulta_Click(object sender, EventArgs e)
        {

        }

        private void registrarAuxiliaresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroEmpleado RegEmp = new RegistroEmpleado();
            RegEmp.Show();
        }
    }
}
