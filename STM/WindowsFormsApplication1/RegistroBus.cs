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
    public partial class registrarBus : Form
    {
        ControladorBus cBus = new ControladorBus();

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
            int ident = int.Parse(iden); 
            String fecha = fechaAd.Text;
            DateTime fechita = new DateTime();
            fechita=DateTime.ParseExact(iden,"yyyy-MM-dd",null);
            String model = tbModelo.Text;
            String plac = placa.Text;
            String tip = tipo.SelectedText;
            String col = color.Text;
            String fab = fabri.Text;
            String capa = capacidad.Text;
            String com = combustible.SelectedText;

            cBus.AñadirBus(ident,fechita,model,plac,tip,col,fab,capa,com);

        }
    }
}
