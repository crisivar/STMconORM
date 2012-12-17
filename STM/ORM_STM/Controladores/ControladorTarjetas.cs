using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telerik.OpenAccess.Data.Common;

namespace ORM_STM.Controladores
{
    public class ControladorTarjetas
    {

        public void AñadirTarjeta(int id, int estacion)
        {

            using (EntitiesModel dbContext = new EntitiesModel())
            {

                Tarjetum tarjeta = new Tarjetum();

                tarjeta.Id = id;
                tarjeta.Saldo = 0;
                tarjeta.Estado = true;
                tarjeta.Id_estacion = estacion;
                

                dbContext.Add(tarjeta);
                dbContext.SaveChanges();

            }


        }

        public void EditarTarjeta(int id, int saldo, Boolean estado)
        {

            using (EntitiesModel dbContext = new EntitiesModel())
            {

                //se supone que debemos hacer el update pidiendo el ID.....falta implementarlo

                Tarjetum TarjetaParaEditar = dbContext.Tarjeta.First();

                TarjetaParaEditar.Saldo = saldo;
                TarjetaParaEditar.Estado = estado;
                
                dbContext.SaveChanges();

            }

        }

        public void EliminarTarjeta()
        {

            using (EntitiesModel dbContext = new EntitiesModel())
            {

                Recarga TarjetaParaBorrar = dbContext.Recargas.Last();
                dbContext.Delete(TarjetaParaBorrar);

                dbContext.SaveChanges();

            }

        }

        public void ConsultaTarjetasFull() //toca parametrizarlo
        {

            using (EntitiesModel dbContext = new EntitiesModel())
            {
                IEnumerable<Tarjetum> tarjetas = dbContext.Tarjeta.ToList();
            }

        }

        public void ConsultaTarjetas(int id)
        {

            using (EntitiesModel dbContext = new EntitiesModel())
            {
                IEnumerable<Tarjetum> categories = dbContext.Tarjeta.Where(
                    tar => tar.Id == id);
            }

        }

        public Boolean comprobarTarjeta(int id)
        {
            OACommand command;
            Boolean exist = false;
            // 1. Create a new instance of the OpenAccessContext.
            using (EntitiesModel dbContext = new EntitiesModel())
            {
                // 2. Initialize the sql query.
                string SqlQuery = "Select id from tarjeta where tarjeta.id=" + id;

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
                List<Tarjetum> tarjeta = (from Tarjeta in dbContext.Tarjeta
                                         orderby Tarjeta.Id
                                         select Tarjeta).ToList();
            }

        }


    }
}
