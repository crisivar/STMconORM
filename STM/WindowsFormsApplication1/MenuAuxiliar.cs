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
    public partial class MenuAuxiliar : Form
    {
        public MenuAuxiliar()
        {
            InitializeComponent();
        }

        private void registrarTarjetaPersonalizadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroTPersonalizada RegTPer = new RegistroTPersonalizada();
            RegTPer.Show();
        }

        private void recargaTarjetaGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroTGenerica RegTGen = new RegistroTGenerica();
            RegTGen.Show();
        }

        private void registrarQuejasYReclamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroSolicitud RegSol = new RegistroSolicitud();
            RegSol.Show();
        }

        private void informacionCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }


    }
}
