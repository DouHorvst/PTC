using AgroServicios.Controlador;
using AgroServicios.Controlador.Productos1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgroServicios.Vista.Productos1
{
    public partial class VistaCreateMarca : Form
    {
        public VistaCreateMarca(int accion)
        {
            InitializeComponent();
            ControladorCreateMarca1 ObjCreateMarca = new ControladorCreateMarca1(this, accion);
        }

        private void bunifuGradientPanel1_Click(object sender, EventArgs e)
        {

        }

        private void VistaCreateMarca_Load(object sender, EventArgs e)
        {
            if (ControladorTema.IsDarkMode == true)
            {
                this.BackColor = Color.Black;
                GriewViewMarcas.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
                GriewViewMarcas.BackgroundColor = Color.FromArgb(50, 56, 62);
                bunifuGradientPanel2.GradientBottomLeft = Color.FromArgb(118, 88, 152);
                bunifuGradientPanel2.GradientTopRight = Color.FromArgb(118, 88, 152);
                bunifuGradientPanel2.GradientBottomRight = Color.FromArgb(34, 36, 49);
                bunifuGradientPanel2.GradientTopLeft = Color.FromArgb(34, 36, 49);
                btnIngresarMarca.IdleFillColor = Color.FromArgb(118, 88, 152);
                btnIngresarMarca.BackColor = Color.DarkViolet;
            }

            if (ControladorIdioma.idioma == 1)
            {
                lbCrearNuevaMarca.Text = Ingles.CreateMarca;
                txtNombreMarca.Text = Ingles.NombreMarca;
                bunifuLabel1.Text = Ingles.TablaMarcas;
                btnIngresarMarca.Text = Ingles.Agregar;
                cmsElimarProducto.Text = Ingles.Eliminar;
                cmsEditarMarca.Text = Ingles.EditarDatos;
            }
        }
    }
}
