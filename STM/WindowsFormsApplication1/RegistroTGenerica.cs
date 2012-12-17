using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ORM_STM.Controladores;

namespace WindowsFormsApplication1
{
    public partial class RegistroTGenerica : Form
    {
        ControladorEstacion esta = new ControladorEstacion();
        ControladorTarjetas tarj = new ControladorTarjetas();
        public RegistroTGenerica()
        {
            InitializeComponent();
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bRegistrar_Click(object sender, EventArgs e)
        {
            int ide = int.Parse(tBIDTarjeta.Text);
            int est = int.Parse(tBIDEstacion.Text);

            Boolean exist = esta.comprobarEstacion(est);
            if (exist == false)
            {
                MessageBox.Show("El id de la estacion qque esta usando no se encuentra registrado por favor prueve con otro", null);
                tBIDEstacion.Clear();
            }
            else {
                tarj.AñadirTarjeta(ide,est);
                MessageBox.Show("el registro fue exitoso", null);
                this.Close();
            }
        }
    }
}
