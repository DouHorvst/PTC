using AgroServicios.Controlador.Productos;
using System;
using System.Windows.Forms;

namespace AgroServicios.Vista.Productos
{
    public partial class CreateProducto : Form
    {
        public CreateProducto(int accion)
        {
            InitializeComponent();
            ControladorCreateProducto ObjProductos = new ControladorCreateProducto(this, accion);
        }

        private void bunifuGradientPanel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel3_Click(object sender, EventArgs e)
        {

        }

        private void btnCrearProducto_Click(object sender, EventArgs e)
        {

        }

        private void VistaCreateProducto_Load(object sender, EventArgs e)
        {

        }

        private void txtCodigoProducto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
