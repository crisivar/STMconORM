using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telerik.OpenAccess.Data.Common;

namespace ORM_STM.Controladores
{
    
    public class ControladorBus
    {

        public void AñadirBus(int Id, DateTime Fecha_adq, String modelo, String placa, String tipo, String color, String fabricante, String capacidad, String tipo_combust)
        {

            using (EntitiesModel dbContext = new EntitiesModel())
            {

                Bu bus = new Bu();
                bus.Id = Id;
                bus.Fecha_adq = Fecha_adq;
                bus.Modelo = modelo;
                bus.Placa = placa;
                bus.Tipo = tipo;
                bus.Color = color;
                bus.Fabricante = fabricante;
                bus.Capacidad = capacidad;
                bus.Tipo_combust = tipo_combust;
                bus.Estado = true;

                dbContext.Add(bus);
                dbContext.SaveChanges();

            }


        }

        public void EditarBus(DateTime Fecha_adq, String modelo, String placa, String tipo, String color, String fabricante, String capacidad, String tipo_combust, Boolean estado)
        {

            using (EntitiesModel dbContext = new EntitiesModel())
            {

                //se supone que debemos hacer el update pidiendo el ID.....falta implementarlo

                Bu busParaEditar = dbContext.Bus.First();
                               
                busParaEditar.Fecha_adq = Fecha_adq;
                busParaEditar.Modelo = modelo;
                busParaEditar.Placa = placa;
                busParaEditar.Tipo = tipo;
                busParaEditar.Color = color;
                busParaEditar.Fabricante = fabricante;
                busParaEditar.Capacidad = capacidad;
                busParaEditar.Tipo_combust = tipo_combust;
                busParaEditar.Estado = estado;

                dbContext.SaveChanges();

            }
                   
        }

        public void EliminarBus()
        {

            using (EntitiesModel dbContext = new EntitiesModel())
            {

                Bu BusParaBorrar = dbContext.Bus.Last();
                dbContext.Delete(BusParaBorrar);
                dbContext.SaveChanges();

            }
        
        }

        public void ConsultaBusFull() //toca parametrizarlo
        {
            
            using (EntitiesModel dbContext = new EntitiesModel())
            {
                IEnumerable<Bu> bus = dbContext.Bus.ToList();
            }
            
        }

        public void ConsultaBusPorId(int id)
        {

            using (EntitiesModel dbContext = new EntitiesModel())
            {
                IEnumerable<Bu> categories = dbContext.Bus.Where(
                    b =>  b.Id== id);
            }
        
        }

        public Boolean comprobarBus(int id)
        {
            OACommand command;
            Boolean exist = false;
            // 1. Create a new instance of the OpenAccessContext.
            using (EntitiesModel dbContext = new EntitiesModel())
            {
                // 2. Initialize the sql query.
                string SqlQuery = "Select id from bus where bus.id=" + id;

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
                List<Bu> buses = (from Bus in dbContext.Bus
                                  orderby Bus.Placa
                                  select Bus).ToList();
            }
        
        }

    }
}