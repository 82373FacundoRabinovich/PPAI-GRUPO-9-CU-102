using Dashbord.DataAccessLayer;
using System.Collections.Generic;
using System.Data;

namespace Dashbord.DataAccessLayer {
	public static class SedeAdapter {
		public static int ReadMaxEntradas(string id) => GeneralAdapter.QueryScalar("SELECT maximo_visitantes FROM Sede WHERE id = @idSesion", new Dictionary<string, string>() {{"@idSesion", id}});
		
		public static DataTable obtenerExposiciones() => GeneralAdapter.Query("SELECT * FROM Exposicion");
	}
}

