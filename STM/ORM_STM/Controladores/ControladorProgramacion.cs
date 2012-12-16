using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ORM_STM.Controladores
{
    public class ControladorProgramacion
    {

        public void AñadirProgramacion(Bu bus, Ruta ruta, Empleado empleado, DateTime fecha, String horario)
        {

            using (EntitiesModel dbContext = new EntitiesModel())
            {

                Programacion programacion = new Programacion();
                programacion.Bu = bus;
                programacion.Rutum = ruta;
                programacion.Empleado = empleado;
                programacion.Fecha = fecha;
                programacion.Horario = horario;   
                
                dbContext.Add(programacion);
                dbContext.SaveChanges();

            }


        }

        public void EditarProgramacion(Bu bus, Ruta ruta, Empleado empleado, DateTime fecha, String horario)
        {

            using (EntitiesModel dbContext = new EntitiesModel())
            {

                //se supone que debemos hacer el update pidiendo el ID.....falta implementarlo

                Programacion programaParaEditar = dbContext.Programacions.First();

                
                programaParaEditar.Bu= bus;
                programaParaEditar.Rutum= ruta;
                programaParaEditar.Empleado= empleado;
                programaParaEditar.Fecha = fecha;
                programaParaEditar.Horario= horario;
                

                dbContext.SaveChanges();

            }

        }

        public void EliminarProgramacion()
        {

            using (EntitiesModel dbContext = new EntitiesModel())
            {

                Programacion programaParaBorrar = dbContext.Programacions.Last();
                dbContext.Delete(programaParaBorrar);
                dbContext.SaveChanges();

            }

        }

        public void ConsultaProgramacionFull() //toca parametrizarlo
        {

            using (EntitiesModel dbContext = new EntitiesModel())
            {
                IEnumerable<Programacion> bus = dbContext.Programacions.ToList();
            }

        }

        public void ConsultaProgramacionPorId(int id)
        {

            using (EntitiesModel dbContext = new EntitiesModel())
            {
                IEnumerable<Bu> categories = dbContext.Bus.Where(
                    b => b.Id == id);
            }

        }

        public void ConsultaOrdenada() //es un ejemplo...podemos ponerle un parametro de entrada
        {

            using (EntitiesModel dbContext = new EntitiesModel())
            {
                List<Programacion> programaciones = (from Programacion in dbContext.Programacions
                                  orderby Programacion.Fecha
                                  select Programacion).ToList();
            }

        }



    }
}
