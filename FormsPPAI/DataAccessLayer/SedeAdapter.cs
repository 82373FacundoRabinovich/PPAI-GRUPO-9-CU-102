using System.Data;

namespace Dashbord.DataAccessLayer {
	public static class SedeAdapter {
		public static int ReadMaxEntradas() => GeneralAdapter.QueryScalar("SELECT maximo_visitantes FROM Sede WHERE id = 1");
		public static DataTable obtenerExposiciones() => GeneralAdapter.Query("SELECT * FROM Exposicion");
	}
}

