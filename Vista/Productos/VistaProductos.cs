using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgroServicios.Controlador.Productos;
using System.Windows.Forms;

namespace AgroServicios.Vista.Productos // Ya lo reconoce
{
    public partial class VistaProductos : Form
    {
        public VistaProductos()
        {
            InitializeComponent();
            ControladorProductos control = new ControladorProductos(this);
        }

        private void VistaProductos_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }
    }
}
