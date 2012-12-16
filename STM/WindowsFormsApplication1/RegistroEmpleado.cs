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
    public partial class RegistroEmpleado : Form
    {
        ControladorEmpleado cEmp = new ControladorEmpleado();
        public RegistroEmpleado()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btRegistrar_Click(object sender, EventArgs e)
        {
            int id= int.Parse(tbIdentificacion.Text);
            String tipId= cbTipoID1.Text;
            String nom= tbNombre.Text;
            String civil= cbECivil.Text;
            String dir= tbDireccion.Text;
            String tel= tbTelefono.Text;
            String mail=tbEmail.Text;
            String car= cbCargo.Text;
            int sal = int.Parse(tbSalario.Text);

            cEmp.AñadirEmpleado(id,tipId,nom,mail,dir,tel,car,civil,sal);
            MessageBox.Show("el registro fue exitoso", null);
            this.Close();
        }
    }
}
