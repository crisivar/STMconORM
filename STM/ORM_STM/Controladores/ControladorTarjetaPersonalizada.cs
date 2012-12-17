using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telerik.OpenAccess.Data.Common;

namespace ORM_STM.Controladores
{
    public class ControladorTarjetaPersonalizada
    {

        public void AñadirTarjetaPersonalizada(int id, int id_cliente, String numeroTel, String nombreCliente, int estacion)
        {

            using (EntitiesModel dbContext = new EntitiesModel())
            {

                Tarjeta_personalizada tarjetaP = new Tarjeta_personalizada();

                tarjetaP.Id = id;
                tarjetaP.Saldo = 0;
                tarjetaP.Estado = true;
                tarjetaP.Id_estacion = estacion;
                tarjetaP.Id_cliente = id_cliente;
                tarjetaP.Nombre = nombreCliente;
                tarjetaP.Telefono = numeroTel;

                dbContext.Add(tarjetaP);
                dbContext.SaveChanges();

            }


        }

        public void EditarTarjetaPersonalizada(int id, int saldo, Boolean estado, String nombre, String numTelefono)
        {

            using (EntitiesModel dbContext = new EntitiesModel())
            {

                //se supone que debemos hacer el update pidiendo el ID.....falta implementarlo

                Tarjeta_personalizada TarjetaPersParaEditar = dbContext.Tarjeta_personalizadas.First();

                TarjetaPersParaEditar.Saldo = saldo;
                TarjetaPersParaEditar.Estado = estado;
                TarjetaPersParaEditar.Nombre = nombre;
                TarjetaPersParaEditar.Telefono = numTelefono;

                dbContext.SaveChanges();

            }

        }

        public void EliminarTarjetaPersonalizada()
        {

            using (EntitiesModel dbContext = new EntitiesModel())
            {

                Recarga TarjetaPersParaBorrar = dbContext.Recargas.Last();
                dbContext.Delete(TarjetaPersParaBorrar);

                dbContext.SaveChanges();

            }

        }

        public void ConsultaTarjetasFull() //toca parametrizarlo
        {

            using (EntitiesModel dbContext = new EntitiesModel())
            {
                IEnumerable<Tarjeta_personalizada> tarjetasPersonalizadas = dbContext.Tarjeta_personalizadas.ToList();
            }

        }

        public void ConsultaTarjetasPersonalizada(int id)
        {

            using (EntitiesModel dbContext = new EntitiesModel())
            {
                IEnumerable<Tarjeta_personalizada> categories = dbContext.Tarjeta_personalizadas.Where(
                    tarP => tarP.Id == id);
            }

        }

        public Boolean comprobarTarjetaPersonalizada(int id)
        {
            OACommand command;
            Boolean exist = false;
            // 1. Create a new instance of the OpenAccessContext.
            using (EntitiesModel dbContext = new EntitiesModel())
            {
                // 2. Initialize the sql query.
                string SqlQuery = "Select id from tarjeta_personalizada where tarjeta_personalizada.id=" + id;

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
                List<Tarjeta_personalizada> tarjetaPers = (from Tarjeta_personalizada in dbContext.Tarjeta_personalizadas
                                          orderby Tarjeta_personalizada.Id
                                          select Tarjeta_personalizada).ToList();
            }

        }


    }
}