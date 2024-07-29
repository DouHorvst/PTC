using AgroServicios.Controlador.Productos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgroServicios.Vista.Productos
{
    public partial class CreateProducto : Form
    {
        public CreateProducto(int accion)
        {
            InitializeComponent();
            ControladorCreateProducto ObjUsers = new ControladorCreateProducto(this, accion);
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
    }
}
