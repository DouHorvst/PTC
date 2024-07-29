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
        public VistaUpdateProducto(int accion, int id, string Name, int codigo, decimal precio, int stock, string descripcion)
        {
            InitializeComponent();
            ControladorUpdateProductos control = new ControladorUpdateProductos(this, accion, id, Name, codigo, precio, stock, descripcion);
        }
        private void bunifuGradientPanel3_Click(object sender, EventArgs e)
        {
        }

        private void VistaUpdateProducto_Load(object sender, EventArgs e)
        {

        }
    }
}
