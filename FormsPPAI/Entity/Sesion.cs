using System;
using System.Data;
using Dashbord.Entity;

namespace Dashbord.Entity
{
    public class Sesion
    {
        public DateTime FechaFin { get; set; }
        public DateTime FechaInicio { get; set; }
        public Empleado getEmpleadoEnSesion()
        {
            var user = new Usuario();
            Empleado empleado = user.obtenerEmpleado();
            return empleado;
        }
    }
}
