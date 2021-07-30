using System.Data;
using Dashbord.DataAccessLayer;

namespace Dashbord.Entity
{
    public class Usuario
    {
        public int Caducidad { get; set; }
        public string Contraseña { get; set; }
        public string Nombre { get; set; }
        public DataTable obtenerEmpleado() => UsuarioAdapter.ReadUsuario("tanomartinoli", "#tano12345");
    }
}
