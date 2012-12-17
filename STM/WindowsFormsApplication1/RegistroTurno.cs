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
    
    public partial class RegistroTurno : Form
    {
        ControladorEmpleado emple = new ControladorEmpleado();
        ControladorBus buss = new ControladorBus();
        ControladorRuta ruta = new ControladorRuta();
        ControladorProgramacion pro = new ControladorProgramacion();

        public RegistroTurno()
        {
            InitializeComponent();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btRegistrar_Click(object sender, EventArgs e)
        {
            int bus = int.Parse(tbIDBus.Text);
            int rut= int.Parse(tbIDRuta.Text);
            int emp = int.Parse(tbIDEmpleado.Text);
            DateTime fechita = DateTime.ParseExact(tbHComienzo.Text,"d",null);
            String hor = tbHFin.Text;

            Boolean existe1 = emple.comprobarEmpleado(emp);
            Boolean existe2 = buss.comprobarBus(bus);
            Boolean existe3 = ruta.comprobarRuta(rut);

            if (existe1 == false)
            {
                MessageBox.Show("el id del empleado que esta utilizando no esta registrado intente con otro", null);
                tbIDEmpleado.Clear();
            }
            else {
                if (existe2 == false)
                {
                    MessageBox.Show("El id del bus que esta empleando no esta registrado intente con otro", null);
                    tbIDBus.Clear();
                }
                else {
                    if (existe3 == false)
                    {
                        MessageBox.Show("El id de la ruta que esta empleando no esta registrado intente con otro", null);
                        tbIDRuta.Clear();
                    }
                    else {
                        pro.AñadirProgramacion(bus,rut,emp,fechita,hor);
                        MessageBox.Show("el registro fue exitoso", null);
                        this.Close();
                    }
                }
            }
        }
    }
}
