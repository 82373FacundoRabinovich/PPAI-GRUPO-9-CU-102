using System.Data;

namespace Dashbord.Entity
{
    public class Sede
    {
        public DataTable obtenerTarifasVigentes()
        {
            var tarifa = new Tarifa();
            return tarifa.mostrarMontosVigentes();
        }
    }
}
