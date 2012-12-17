using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ORM_STM.Controladores;

namespace Interfaz_STM
{
    public partial class Login : Form
    {
        ControladorEmpleado emp = new ControladorEmpleado();
        String jefe = "jefe";
        String clave = "jefe";
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bEntrar_Click(object sender, EventArgs e)
        {
            String login= tBlogin.Text;
            String clav = textBox2.Text;

            int log=int.Parse(login);
            Boolean comprobar= emp.comprobarLoginContrasena(log,clav);
            if (comprobar == false)
            {
                MessageBox.Show("el login o el password  que esta usando no se encuentra registrado por favor prueve con otro", null);
                tBlogin.Clear();
                textBox2.Clear();
            }
            else {
                if (login == jefe && clav == clave)
                {

                }
            }
            
        }
    }
}
