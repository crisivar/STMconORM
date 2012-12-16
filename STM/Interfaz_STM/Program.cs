using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ORM_STM.Controladores;

namespace Interfaz_STM
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            ControladorTarjeta contrB = new ControladorTarjeta();

           // contrB.AñadirBus(1111, new DateTime(2010, 1, 18), "asdsd", "asdasd", "asdasd", "asdasd", "adsgfdfg", "fghdgh", "dfhdgh", true);

            ControladorTarjeta contrEditar = new ControladorTarjeta();

            //aca hay un problema que detecta llave duplicada en la base de datos :S
            //contrEditar.EditarBus(new DateTime(2010, 1, 18), "ggggg", "gggggg", "gggggg", "asdasd", "adsgfdfg", "fghdgh", "dfhdgh", true);




            ControladorEstacion contrE = new ControladorEstacion();

            contrE.AñadirEstacion(12345, "Lido", "cra 39 con calle 5ta", true);

            ControladorEstacion contrEditarE = new ControladorEstacion();

            //aca hay un problema que detecta llave duplicada en la base de datos :S
            contrEditarE.EditarEstacion("asdasd", "asdasdaff", true);






        }
    }
}
