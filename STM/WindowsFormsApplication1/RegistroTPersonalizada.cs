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
    public partial class RegistroTPersonalizada : Form
    {
        ControladorTarjetaPersonalizada Tper = new ControladorTarjetaPersonalizada();
        ControladorEstacion esta = new ControladorEstacion();
        public RegistroTPersonalizada()
        {
            InitializeComponent();
        }

        private void RegistroTPersonalizada_Load(object sender, EventArgs e)
        {

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btRegistrar_Click(object sender, EventArgs e)
        {
            int ide= int.Parse(tbCodigo.Text);
            int est= int.Parse(tBEstacion.Text);
            int idCli= int.Parse(tBIDCliente.Text);
            String tel= tBTelefono.Text;
            String nom = textBox1.Text;
            Boolean exist = esta.comprobarEstacion(est);
            if (exist == false)
            {
                MessageBox.Show("el id de la estacion que esta usando no se encuentra registrado por favor prueve con otro", null);
                tBEstacion.Clear();
            }
            else {
                Tper.AñadirTarjetaPersonalizada(ide,idCli,tel,nom,est);
                MessageBox.Show("el registro fue exitoso", null);
                this.Close();
            }
        }

    }
}
