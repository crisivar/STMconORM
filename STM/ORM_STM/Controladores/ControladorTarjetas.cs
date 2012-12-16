using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ORM_STM.Controladores
{
    class ControladorTarjetas
    {

        public void AñadirTarjeta(int id, int saldo , Boolean estado)
        {

            using (EntitiesModel dbContext = new EntitiesModel())
            {

                Tarjetum tarjeta = new Tarjetum();

                tarjeta.Id = id;
                tarjeta.Saldo = saldo;
                tarjeta.Estado = estado;
                

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
