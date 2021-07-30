using System;
using System.Data;
using Dashbord.Entity;

namespace Dashbord.Entity
{
    public class Sesion
    {
        public DateTime FechaFin { get; set; }
        public DateTime FechaInicio { get; set; }
        public DataTable getEmpleadoEnSesion()
        {
            var user = new Usuario();
            DataTable tabla = user.obtenerEmpleado();
            return tabla;
        }
    }
}
