using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashbord.Entity
{
    class Entrada
    {
        public DateTime FechaVencimiento { get; set; }
        public DateTime HoraVenta { get; set; }
        public float Monto { get; set; }
        public int Numero { get; set; }
    }
}
