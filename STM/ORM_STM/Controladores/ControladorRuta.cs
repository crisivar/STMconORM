using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ORM_STM.Controladores
{
    
    public class ControladorRuta
    {

        public void AñadirRuta(int Id, DateTime Fecha_creacion, String descripcion)
        {

            using (EntitiesModel dbContext = new EntitiesModel())
            {

                Ruta ruta = new Ruta();
                ruta.Id = Id;
                ruta.Fecha_creacion = Fecha_creacion;
                ruta.Descripcion = descripcion;

                dbContext.Add(ruta);
                dbContext.SaveChanges();

            }


        }

        public void EditarRuta(DateTime Fecha_creacion, String Descripcion )
        {

            using (EntitiesModel dbContext = new EntitiesModel())
            {

                //se supone que debemos hacer el update pidiendo el ID.....falta implementarlo

                Ruta rutaParaEditar = dbContext.Rutas.First();

                rutaParaEditar.Fecha_creacion = Fecha_creacion;
                rutaParaEditar.Descripcion = Descripcion;
                
                dbContext.SaveChanges();

            }
                   
        }

        public void EliminarRuta()
        {

            using (EntitiesModel dbContext = new EntitiesModel())
            {

                Ruta RutaParaBorrar = dbContext.Rutas.Last();
                dbContext.Delete(RutaParaBorrar);
                
                dbContext.SaveChanges();

            }
        
        }

        public void ConsultaBusFull() //toca parametrizarlo
        {
            
            using (EntitiesModel dbContext = new EntitiesModel())
            {
                IEnumerable<Ruta> ruta = dbContext.Rutas.ToList();
            }
            
        }

        public void ConsultaBusPorId(int id)
        {

            using (EntitiesModel dbContext = new EntitiesModel())
            {
                IEnumerable<Ruta> categories = dbContext.Rutas.Where(
                    r =>  r.Id== id);
            }
        
        }

        public void ConsultaOrdenada() //es un ejemplo...podemos ponerle un parametro de entrada
        {

            using (EntitiesModel dbContext = new EntitiesModel())
            {
                List<Bu> buses = (from Ruta in dbContext.Bus
                                  orderby Ruta.Placa
                                  select Ruta).ToList();
            }
        
        }



    }
}