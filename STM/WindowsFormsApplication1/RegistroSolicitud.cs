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
    public partial class RegistroSolicitud : Form
    {
        ControladorEstacion esta = new ControladorEstacion();
        ControladorTarjetaPersonalizada tper = new ControladorTarjetaPersonalizada();
        ControladorReclamos rec = new ControladorReclamos();
        ControladorTarjetas tar = new ControladorTarjetas();
        public RegistroSolicitud()
        {
            InitializeComponent();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btRegistrar_Click(object sender, EventArgs e)
        {
            int ide=int.Parse(tbID.Text);
            int tarj= int.Parse(tBTarjeta.Text);
            int est= int.Parse(tBEstacion.Text);
            String tip= tbTipo.Text;
            String desc = tbDescripcion.Text;

            Boolean tarjet1 = tper.comprobarTarjetaPersonalizada(tarj);
            Boolean tarjet2 = tar.comprobarTarjeta(tarj);
            Boolean exisEst = esta.comprobarEstacion(est);

            if (exisEst == false)
            {
                MessageBox.Show("el id de la estacion que esta usando no se encuentra registrado por favor prueve con otro", null);
                tBEstacion.Clear();
            }
            else {
                if (tarjet1 == false) {
                    if (tarjet2 == false)
                    {
                        MessageBox.Show("el id de la tarjeta que esta usando no se encuentra registrado por favor prueve con otro", null);
                        tBTarjeta.Clear();
                    }
                    else {
                        rec.AñadirReclamo(ide,tarj,est,tip,desc);
                        MessageBox.Show("el registro fue exitoso", null);
                        this.Close();
                    }
                }
            }
        }       
    }
}
