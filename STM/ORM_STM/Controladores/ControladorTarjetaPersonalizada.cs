using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ORM_STM.Controladores
{
    public class ControladorTarjetaPersonalizada
    {

        public void AñadirTarjetaPersonalizada(int id, int saldo, Boolean estado, String id_cliente, String numeroTel, String nombreCliente)
        {

            using (EntitiesModel dbContext = new EntitiesModel())
            {

                Tarjeta_personalizada tarjetaP = new Tarjeta_personalizada();

                tarjetaP.Id = id;
                tarjetaP.Saldo = saldo;
                tarjetaP.Estado = estado;


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