using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashbord.Entity
{
    class ReservaVisita
    {
        public int CantAlumnos { get; set; }
        public int CantAlumnosConfirmados { get; set; }
        public int DuracionEstimada { get; set; }
        public DateTime FechaHoraCreaccion { get; set; }
        public DateTime FechaHoraReserva { get; set; }
        public DateTime HoraFinalReal { get; set; }
        public DateTime HoraInicioReal { get; set; }
        public DateTime NroReserva { get; set; }
    }
}
