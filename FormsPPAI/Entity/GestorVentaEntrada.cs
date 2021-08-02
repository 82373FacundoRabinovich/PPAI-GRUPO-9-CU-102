using Dashbord.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Dashbord.Entity
{
    public static class GestorVentaEntrada
    {
        public static int Empleado { get; set; }
        public static int Entrada { get; set; }
        public static int ImpresoraEntradas { get; set; }
        public static int PantallaEntrada { get; set; }
        public static int PantallaVentaEntrada { get; set; }
        public static int ReservaVisita { get; set; }
        public static int Sede { get; set; }
        public static int Sesion { get; set; }

        public static Empleado logueado { get; set; }
        public static void opcionVentaEntrada()
        {
            buscarEmpleadoLogueado();
            
        }
        public static void buscarEmpleadoLogueado()
        {
            var sesion = new Sesion();
            var tupla = sesion.getEmpleadoEnSesion();
            logueado = tupla.Item1;
            Empleado = logueado.Dni;
            Sesion = tupla.Item2;
            buscarSede();
        }
        public static void buscarSede()
        {
            int sede = obtenerSede();
            Sede = sede;
            buscarTarifasDeSede();
        }

        public static int obtenerSede()
        {
            int sede = logueado.IdSede;
            return sede;
        }

        public static void buscarTarifasDeSede()
        {
            var Actual = new Sede();
            DataTable tablaTarifas = Actual.obtenerTarifasVigentes();
            //return sedeActual.obtenerTarifasVigentes();
            string username = "tanomartinoli";
            TarifasSede pantalla = new TarifasSede(username);
            pantalla.mostrarTarifasVigentes(tablaTarifas);
            pantalla.ShowDialog();
        }
        public static void tomarSeleccionTarifa(int idEntrada)
        {
            Entrada = idEntrada;
            buscarExposicionVigente();
        }

        private static void buscarExposicionVigente()
        {
            var Actual = new Sede();
            var duracionesObra = Actual.calcularDuracionExposicionesVigentes();
        }
    }
}
