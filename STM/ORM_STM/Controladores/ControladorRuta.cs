using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telerik.OpenAccess.Data.Common;

namespace ORM_STM.Controladores
{
    public class ControladorRuta
    {

        public void AñadirRuta(int Id, DateTime Fecha_creacion, String descripcion, Boolean estado)
        {

            using (EntitiesModel dbContext = new EntitiesModel())
            {

                Ruta ruta = new Ruta();
                ruta.Id = Id;
                ruta.Fecha_creacion = Fecha_creacion;
                ruta.Descripcion = descripcion;
                ruta.Estado = estado;

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

        public Boolean comprobarRuta(int id)
        {
            OACommand command;
            Boolean exist = false;
            // 1. Create a new instance of the OpenAccessContext.
            using (EntitiesModel dbContext = new EntitiesModel())
            {
                // 2. Initialize the sql query.
                string SqlQuery = "Select id from ruta where ruta.id=" + id;

                using (OAConnection connection = dbContext.Connection)
                {
                    // 3. Create a new instance of the OACommand class.
                    using (command = connection.CreateCommand())
                    {
                        command.CommandText = SqlQuery;

                        // 4. Execute the command and retrieve the scalar values.
                        using (System.Data.Common.DbDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read()) { exist = true; }

                        }

                    }
                }
            }
            return exist;
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
