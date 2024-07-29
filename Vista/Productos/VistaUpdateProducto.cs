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
using AgroServicios.Vista.Estadisticas;
using AgroServicios.Controlador.CuentasContralador;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net;

namespace AgroServicios.Vista.Productos
{
    public partial class VistaUpdateProducto : Form
    {
        public VistaUpdateProducto(int accion, int id, string name, string codigo, string precio, string stock, string marca, string descripcion)
        {
            InitializeComponent();
            ControladorUpdateProductos control = new ControladorUpdateProductos(this, accion, id, name, codigo, precio, stock, marca, descripcion);
        }
        private void bunifuGradientPanel3_Click(object sender, EventArgs e)
        {
        }

        private void VistaUpdateProducto_Load(object sender, EventArgs e)
        {

        }
    }
}
