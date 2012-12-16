using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ORM_STM.Controladores
{
    public class ControladorEmpleado
    {

        public void AñadirEmpleado(int Id, String tipo_id, String nombre, String email, String direccion, String telefono, String cargo, String estado_civil, int salario, Boolean estado)
        {

            using (EntitiesModel dbContext = new EntitiesModel())
            {

                Empleado empleado = new Empleado();
                empleado.Id = Id;
                empleado.Tipo_id = tipo_id;
                empleado.Nombre = nombre;
                empleado.Email = email;
                empleado.Direccion = direccion;
                empleado.Telefono = telefono;
                empleado.Cargo= cargo;
                //empleado.Estado_Civil = estado_civil;
                empleado.Salario = salario;
                empleado.Estado = estado;

                dbContext.Add(empleado);
                dbContext.SaveChanges();

            }


        }

        public void EditarEmpleado(String tipo_id, String nombre, String email, String direccion, String telefono, String cargo, String estado_civil, int salario, Boolean estado)
        {

            using (EntitiesModel dbContext = new EntitiesModel())
            {

                //se supone que debemos hacer el update pidiendo el ID.....falta implementarlo

                Empleado empleadoParaEditar = dbContext.Empleados.First();

                empleadoParaEditar.Tipo_id = tipo_id;
                empleadoParaEditar.Nombre = nombre;
                empleadoParaEditar.Email = email;
                empleadoParaEditar.Direccion = direccion;
                empleadoParaEditar.Telefono = telefono;
                empleadoParaEditar.Cargo = cargo;
                //empleadoParaEditar.Estado_Civil = estado_civil;
                empleadoParaEditar.Salario = salario;
                empleadoParaEditar.Estado = estado;

                dbContext.SaveChanges();

            }

        }

        public void EliminarEmpleado()
        {

            using (EntitiesModel dbContext = new EntitiesModel())
            {

                //eliminar debe ser solo cambiar el estado......

                Empleado EmpleadoParaBorrar = dbContext.Empleados.Last();
                dbContext.Delete(EmpleadoParaBorrar);
                dbContext.SaveChanges();

            }

        }

        public void ConsultaEmpleadoFull() //toca parametrizarlo
        {

            using (EntitiesModel dbContext = new EntitiesModel())
            {
                IEnumerable<Empleado> empleado = dbContext.Empleados.ToList();
            }

        }

        public void ConsultaBusPorId(int id)
        {

            using (EntitiesModel dbContext = new EntitiesModel())
            {
                IEnumerable<Empleado> categories = dbContext.Empleados.Where(
                    e => e.Id == id);
            }

        }

        public void ConsultaOrdenada() //es un ejemplo...podemos ponerle un parametro de entrada
        {

            using (EntitiesModel dbContext = new EntitiesModel())
            {
                List<Empleado> empleados = (from Empleados in dbContext.Empleados
                                  orderby Empleados.Id
                                  select Empleados).ToList();
            }

        }

        
    }
}
