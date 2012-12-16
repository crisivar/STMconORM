using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ORM_STM.Controladores
{
    public class ControladorConsumo
    {

        public void AñadirConsumo(Estacion estacion, Tarjetum tarjeta, DateTime fecha, DateTime hora)
        {

            using (EntitiesModel dbContext = new EntitiesModel())
            {

                Consumo consumo = new Consumo();

                consumo.Estacion = estacion;
                consumo.Tarjetum = tarjeta;
                consumo.Fecha = fecha;
                consumo.Hora = hora;

                dbContext.Add(consumo);
                dbContext.SaveChanges();

            }


        }

        public void EditarConsumo(Estacion estacion, Tarjetum tarjeta, DateTime fecha, DateTime hora)
        {

            using (EntitiesModel dbContext = new EntitiesModel())
            {

                //se supone que debemos hacer el update pidiendo el ID.....falta implementarlo

                Consumo ConsumoParaEditar = dbContext.Consumos.First();

                ConsumoParaEditar.Estacion = estacion;
                ConsumoParaEditar.Tarjetum = tarjeta;
                ConsumoParaEditar.Fecha = fecha;
                ConsumoParaEditar.Hora = hora;

                dbContext.SaveChanges();

            }

        }

        public void EliminarConsumo()
        {

            using (EntitiesModel dbContext = new EntitiesModel())
            {

                Recarga ConsumoParaBorrar = dbContext.Recargas.Last();
                dbContext.Delete(ConsumoParaBorrar);

                dbContext.SaveChanges();

            }

        }

        public void ConsultaRecargasFull() //toca parametrizarlo
        {

            using (EntitiesModel dbContext = new EntitiesModel())
            {
                IEnumerable<Consumo> consumo = dbContext.Consumos.ToList();
            }

        }

        public void ConsultaConsumoPorId(int id)
        {

            using (EntitiesModel dbContext = new EntitiesModel())
            {
                IEnumerable<Consumo> categories = dbContext.Consumos.Where(
                    con => con.Id_tarjeta == id);
            }

        }

        public void ConsultaOrdenada() //es un ejemplo...podemos ponerle un parametro de entrada
        {

            using (EntitiesModel dbContext = new EntitiesModel())
            {
                List<Consumo> consumo = (from Consumo in dbContext.Consumos
                                         orderby Consumo.Id_tarjeta
                                         select Consumo).ToList();
            }

        }


    }
}
