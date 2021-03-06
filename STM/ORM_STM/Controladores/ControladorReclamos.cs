﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ORM_STM.Controladores
{
    public class ControladorReclamos
    {

        public void AñadirReclamo(int id,int tarjeta,int estacion, String tipo_sol, String descripcion)
        {

            using (EntitiesModel dbContext = new EntitiesModel())
            {

                Solicitud_reclamo reclamo = new Solicitud_reclamo();
                reclamo.Id_tarjeta = tarjeta;
                reclamo.Id_estacion = estacion;
                reclamo.Tipo = tipo_sol;
                reclamo.Descripcion = descripcion;
                //reclamo.Respuesta = respuesta;
                reclamo.Estado = "Pendiente";
                reclamo.Id = id;
                dbContext.Add(reclamo);
                dbContext.SaveChanges();

            }


        }

        public void EditarReclamo(String tipo_sol, String descripcion, String respuesta, Boolean estado)
        {

            using (EntitiesModel dbContext = new EntitiesModel())
            {

                //se supone que debemos hacer el update pidiendo el ID.....falta implementarlo

                Solicitud_reclamo ReclamoParaEditar = dbContext.Solicitud_reclamos.First();

                ReclamoParaEditar.Descripcion = descripcion;
                //ReclamoParaEditar.Respuesta = respuesta; falta
                //ReclamoParaEditar = estado; falta tambien

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
                    r => r.Id == id);
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
