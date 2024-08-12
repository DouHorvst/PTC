﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgroServicios.Controlador;
using AgroServicios.Controlador.Productos1;
using AgroServicios.Vista.Productos1;

namespace AgroServicios.Vista.Productos1 
{
    public partial class VistaProductos : Form
    {
        public VistaProductos()
        {
            InitializeComponent();
            ControladorVistaProductos1 ObjProductosVista = new ControladorVistaProductos1(this);
        }

        private void VistaProductos_Load(object sender, EventArgs e)
        {
            if (ControladorIdioma.idioma == 1)
            {
                bunifuLabel1.Text = Ingles.LabelTitulo;
                btnAgregarMarca.Text = Ingles.AgregarMarca;
                btnAgregarProducto.Text = Ingles.AgregarProducto;
                cmsEditarProducto.Text = Ingles.EditarProducto;
                cmsElimarProducto.Text = Ingles.Eliminar;
                cmsInformacion.Text = Ingles.Informacion;
            }

            if (ControladorTema.IsDarkMode == true) 
            {
              this.BackColor = Color.Black;
                bunifuLabel1.BackColor = Color.Transparent;
                bunifuLabel1.ForeColor = Color.White;
                GriewViewProductos.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
                GriewViewProductos.BackgroundColor = Color.FromArgb(50, 56, 62);
                bunifuGradientPanel1.GradientBottomLeft = Color.FromArgb(118, 88, 152);
                bunifuGradientPanel1.GradientTopRight = Color.FromArgb(118, 88, 152);
                bunifuGradientPanel1.GradientBottomRight = Color.FromArgb(34, 36, 49);
                bunifuGradientPanel1.GradientTopLeft = Color.FromArgb(34, 36, 49);
                btnAgregarProducto.IdleFillColor = Color.DarkViolet;
                btnAgregarProducto.ForeColor = Color.White;
            }
        }

        private void GriewViewProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ControladorTema.IsDarkMode == true)
            {
                GriewViewProductos.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
                GriewViewProductos.BackgroundColor = Color.FromArgb(50, 56, 62);
            }
        }

        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {

        }
    }
}
