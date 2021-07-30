using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Dashbord.Entity
{
    public class GestorVentaEntrada
    {
        public int Empleado { get; set; }
        public int Entrada { get; set; }
        public int ImpresoraEntradas { get; set; }
        public int PantallaEntrada { get; set; }
        public int PantallaVentaEntrada { get; set; }
        public int ReservaVisita { get; set; }
        public int Sede { get; set; }
        public int Sesion { get; set; }

        public void opcionVentaEntrada()
        {
            DataTable tabla = new DataTable();
            tabla = buscarEmpleadoLogueado();
        }
        public DataTable buscarEmpleadoLogueado()
        {
            var sesion = new Sesion();
            DataTable tabla = sesion.getEmpleadoEnSesion();
            return tabla;
        }
    }
}
