using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ORM_STM.Controladores
{
    class ControladorRecarga
    {

        public void AñadirRecarga(Estacion estacion, Tarjetum tarjeta, DateTime fecha, DateTime hora)
        {

            using (EntitiesModel dbContext = new EntitiesModel())
            {

                Recarga recarga = new Recarga();
                
                recarga.Estacion = estacion ;
                recarga.Tarjetum = tarjeta;
                recarga.Fecha = fecha;
                recarga.Hora = hora;

                dbContext.Add(recarga);
                dbContext.SaveChanges();

            }


        }

        public void EditarRecarga(Estacion estacion, Tarjetum tarjeta, DateTime fecha, DateTime hora)
        {

            using (EntitiesModel dbContext = new EntitiesModel())
            {

                //se supone que debemos hacer el update pidiendo el ID.....falta implementarlo

                Recarga RecargaParaEditar = dbContext.Recargas.First();

                RecargaParaEditar.Estacion = estacion ;
                RecargaParaEditar.Tarjetum = tarjeta ;
                RecargaParaEditar.Fecha = fecha ;
                RecargaParaEditar.Hora = hora;

                dbContext.SaveChanges();

            }

        }

        public void EliminarRecarga()
        {

            using (EntitiesModel dbContext = new EntitiesModel())
            {

                Recarga RecargaParaBorrar = dbContext.Recargas.Last();
                dbContext.Delete(RecargaParaBorrar);

                dbContext.SaveChanges();

            }

        }

        public void ConsultaRecargasFull() //toca parametrizarlo
        {

            using (EntitiesModel dbContext = new EntitiesModel())
            {
                IEnumerable<Recarga> recarga = dbContext.Recargas.ToList();
            }

        }

        public void ConsultaRecargaPorId(int id)
        {

            using (EntitiesModel dbContext = new EntitiesModel())
            {
                IEnumerable<Recarga> categories = dbContext.Recargas.Where(
                    rec => rec.Id_estacion == id);
            }

        }

        public void ConsultaOrdenada() //es un ejemplo...podemos ponerle un parametro de entrada
        {

            using (EntitiesModel dbContext = new EntitiesModel())
            {
                List<Recarga> recarga = (from Recarga in dbContext.Recargas
                                             orderby Recarga.Id_tarjeta
                                             select Recarga).ToList();
            }

        }



    }
}
