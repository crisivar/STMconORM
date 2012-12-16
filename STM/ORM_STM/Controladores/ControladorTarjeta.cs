using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ORM_STM.Controladores
{

    public class ControladorTarjeta
    {

        public void AñadirTarjeta(int codigo, int saldo, Boolean estado)
        {

            using (EntitiesModel dbContext = new EntitiesModel())
            {

                Tarjetum tarjeta = new Tarjetum();
                tarjeta.Id = codigo;
                tarjeta.Saldo = saldo;
                tarjeta.Estado = estado;
                
                dbContext.Add(tarjeta);
                dbContext.SaveChanges();

            }


        }

        public void EditarTarjeta(int saldo, Boolean estado)
        {

            using (EntitiesModel dbContext = new EntitiesModel())
            {

                //se supone que debemos hacer el update pidiendo el ID.....falta implementarlo

                Tarjetum tarjetaParaEditar = dbContext.Tarjeta.First();

                tarjetaParaEditar.Saldo = saldo;
                tarjetaParaEditar.Estado = estado;
                
                dbContext.SaveChanges();

            }

        }

        public void EliminarTarjeta()
        {

            using (EntitiesModel dbContext = new EntitiesModel())
            {

                Tarjetum TarjetaParaBorrar = dbContext.Tarjeta.Last();
                dbContext.Delete(TarjetaParaBorrar);
                dbContext.SaveChanges();

            }

        }

        public void ConsultaTarjetaFull() //toca parametrizarlo
        {

            using (EntitiesModel dbContext = new EntitiesModel())
            {
                IEnumerable<Tarjetum> tarjeta = dbContext.Tarjeta.ToList();
            }

        }

        public void ConsultaTarjetaorId(int id)
        {

            using (EntitiesModel dbContext = new EntitiesModel())
            {
                IEnumerable<Tarjetum> categories = dbContext.Tarjeta.Where(
                    t => t.Id == id);
            }

        }

        public void ConsultaOrdenada() //es un ejemplo...podemos ponerle un parametro de entrada
        {

            using (EntitiesModel dbContext = new EntitiesModel())
            {
                List<Tarjetum> tarjetas = (from Tarjeta in dbContext.Tarjeta
                                  orderby Tarjeta.Id
                                  select Tarjeta).ToList();
            }

        }



    }
}