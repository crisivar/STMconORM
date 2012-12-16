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
    public partial class RegistroEstacion : Form
    {
        ControladorEstacion cEstacion = new ControladorEstacion();
        
        public RegistroEstacion()
        {
            InitializeComponent();
        }

        private void btRegistrar_Click(object sender, EventArgs e)
        {

            int id = int.Parse(tbID.Text);

            String nombre = tbNombre.Text;
            String direccion = tbDireccion.Text;
            

            cEstacion.AñadirEstacion(id, nombre, direccion, true);

            MessageBox.Show("el registro fue exitoso", null);
            this.Close();
            
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
