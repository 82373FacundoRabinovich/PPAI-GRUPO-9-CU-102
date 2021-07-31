using Dashbord.Entity;
using System;
using System.Windows.Forms;

namespace Dashbord {
	public partial class TarifasSede : Form {
		private string username;

		public TarifasSede(string username) {
			InitializeComponent();

			this.username = username;
		}

		private void btnAceptar_Click(object sender, EventArgs e) => new ElegirTarifa(username).ShowDialog();

		private void TarifasSede_Load(object sender, EventArgs e) {
			var gestor = new GestorVentaEntrada();

			lblCargo.Text = gestor.buscarEmpleadoLogueado().Apellido;
			dtgTarifaSede.DataSource = gestor.obtenerTarifasVigentes();
		}

		private void btnCloseForm_Click(object sender, EventArgs e) => Close();
	}
}
