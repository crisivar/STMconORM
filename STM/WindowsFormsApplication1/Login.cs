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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btIngresar_Click(object sender, EventArgs e)
        {
            String login = tbLogin.Text;
            String contrasena = tbContrasena.Text;

            if (login == "doperativo" && contrasena == "doperativo")
            {
                MenuDOperativo MDOpe = new MenuDOperativo();
                MDOpe.Show();
            }

            if (login == "destacion" && contrasena == "destacion")
            {
                MenuDEstacion MDEst = new MenuDEstacion();
                MDEst.Show();
            }

            if (login == "conductor" && contrasena == "conductor")
            {
                MenuConductor MCon = new MenuConductor();
                MCon.Show();
            }

            if (login == "auxiliar" && contrasena == "auxiliar")
            {
                MenuAuxiliar MAux = new MenuAuxiliar();
                MAux.Show();
            }
        }

    }
}
