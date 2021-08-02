using Dashbord.DataAccessLayer;
using System;
using System.Windows.Forms;

namespace Dashbord {
	public partial class ElegirEntradas : Form {
		private string username;
		private string tipoEntrada;
		private string tipoVisita;
		private bool hayGuia;
		private int tiempo;

		public ElegirEntradas(/*string username,*/ int tipoEntrada, int tipoVisita, bool hayGuia/*, int tiempo*/) {
			InitializeComponent();

			//this.username = username;
			this.tipoEntrada = tipoEntrada;
			this.tipoVisita = tipoVisita;
			this.hayGuia = hayGuia;
			//this.tiempo = tiempo;
		}

		private void btnCloseForm_Click(object sender, EventArgs e) => Close();

		private void btnAceptar_Click(object sender, EventArgs e) {
			if (txtNroEntradas.Text.Equals("")) {
				MessageBox.Show("Insertar datos.");
				return;
			}

			if (int.Parse(txtNroEntradas.Text.Trim()) > (SedeAdapter.ReadMaxEntradas() - EntradaAdapter.ReadCantEntradas())) {
				MessageBox.Show("Numero de entradas maximo superado.");
				return;
			}

			new DetalleEntradas(username, tipoEntrada, tipoVisita, hayGuia, int.Parse(txtNroEntradas.Text.Trim())).ShowDialog();
		}

		private void ElegirEntradas_Load(object sender, EventArgs e) {
			lblCargo.Text = UsuarioAdapter.ReadCargo(username).Rows[0][0].ToString();

			lblMaximo.Text = $"Maximo: {SedeAdapter.ReadMaxEntradas() - EntradaAdapter.ReadCantEntradas()} entradas en la \nSede {UsuarioAdapter.ReadSede(username).Rows[0][0]}";
		}
    }
}
