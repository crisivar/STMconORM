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
    public partial class registrarBus : Form
    {
        public registrarBus()
        {
            InitializeComponent();
        }

        private void registrarBus_Load(object sender, EventArgs e)
        {

        }

        private void lbTBus_Click(object sender, EventArgs e)
        {

        }

        private void btRegistrar_Click(object sender, EventArgs e)
        {
            String iden = tbID.Text;
            String fecha = fechaAd.Text;
            String model = tbModelo.Text;
            String plac = placa.Text;
            String tip = tipo.SelectedText;
            String col = color.Text;
            String fab = fabri.Text;
            String capa = capacidad.Text;
            String com = combustible.SelectedText;
        }
    }
}
