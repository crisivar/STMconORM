using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ORM_STM.Controladores
{
    public class ControladorEstacion
    {

        public void AñadirEstacion(int Id, String nombre, String direccion, Boolean estado)
        {

            using (EntitiesModel dbContext = new EntitiesModel())
            {

                Estacion estacion = new Estacion();
                estacion.Id = Id;
                estacion.Nombre = nombre;
                estacion.Direccion = direccion;
                estacion.Estado = estado;

                dbContext.Add(estacion);
                dbContext.SaveChanges();

            }


        }

        public void EditarEstacion(String nombre, String direccion, Boolean estado)
        {

            using (EntitiesModel dbContext = new EntitiesModel())
            {

                //se supone que debemos hacer el update pidiendo el ID.....falta implementarlo

                Estacion EstacionParaEditar = dbContext.Estacions.First();

                EstacionParaEditar.Nombre = nombre;
                EstacionParaEditar.Direccion = direccion;
                EstacionParaEditar.Estado = estado;

                dbContext.SaveChanges();

            }

        }

        public void EliminarEstacion()
        {

            using (EntitiesModel dbContext = new EntitiesModel())
            {

                Estacion EstacionParaBorrar = dbContext.Estacions.Last();
                dbContext.Delete(EstacionParaBorrar);

                dbContext.SaveChanges();

            }

        }

        public void ConsultaEstacionFull() //toca parametrizarlo
        {

            using (EntitiesModel dbContext = new EntitiesModel())
            {
                IEnumerable<Estacion> estacion = dbContext.Estacions.ToList();
            }

        }

        public void ConsultaEstacionPorId(int id)
        {

            using (EntitiesModel dbContext = new EntitiesModel())
            {
                IEnumerable<Estacion> categories = dbContext.Estacions.Where(
                    e => e.Id == id);
            }

        }

        public Boolean ConsultaEstacionPorId(int id)
        {

            Boolean existe = false;

            
            using (EntitiesModel dbContext = new EntitiesModel())
            {
                IEnumerable<Estacion> categories = dbContext.Estacions.Where(
                    e => e.Id == id);

                if (categories.Equals(null)){
                
                    existe = false;
                }
                else {
                
                    existe = true;
                
                }
            }



            return existe;

        }



        public void ConsultaOrdenada() //es un ejemplo...podemos ponerle un parametro de entrada
        {

            using (EntitiesModel dbContext = new EntitiesModel())
            {
                List<Estacion> estaciones = (from Estacion in dbContext.Estacions
                                             orderby Estacion.Id
                                             select Estacion).ToList();
            }

        }



    }
}
