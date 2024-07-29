using System.Windows.Forms;
using AgroServicios.Controlador;
using AgroServicios.Controlador.CuentasContralador;

namespace AgroServicios.Vista.Cuentas
{
    public partial class CreateUser : Form
    {
        public CreateUser(int accion)
        {
            InitializeComponent();
           ControladorCreateUser ObjUsers = new ControladorCreateUser(this, accion);

        }

        private void CreateUser_Load(object sender, System.EventArgs e)
        {

        }
    }
}
