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
    public partial class RegistroRuta : Form
    {

        ControladorRuta cRuta = new ControladorRuta();

        public RegistroRuta()
        {
            InitializeComponent();
        }

        private void btRegistrar_Click(object sender, EventArgs e)
        {

            int id = int.Parse(tbIDRuta.Text);
              
            
            String descripcion = tbDescripcion.Text;

            String fech = tbFechaC.Text;

            DateTime fechita = new DateTime();
            fechita = DateTime.ParseExact(fech, "d", null);

            cRuta.AñadirRuta(id, fechita, descripcion, true);

            MessageBox.Show("el registro fue exitoso", null);
            this.Close();

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbFechaC_Click(object sender, EventArgs e)
        {

        }
    }
}
