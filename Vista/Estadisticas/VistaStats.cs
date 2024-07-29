using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgroServicios.Controlador.ControladorStats;

namespace AgroServicios.Vista.Estadisticas
{
    public partial class VistaStats : Form
    {
        public VistaStats()
        {
            InitializeComponent();
            ControladorStats control = new ControladorStats(this);
        }

        private void btnAbrirSuministros_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
