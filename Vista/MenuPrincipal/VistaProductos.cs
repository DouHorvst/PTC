﻿using AgroServicios.Modelo.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgroServicios.Vista.MenuPrincipal
{
    public partial class VistaProductos : Form
    {
        public VistaProductos()
        {
            InitializeComponent();
            RellenarProductos();
        }
        private void RellenarProductos()
        {
            DAOTargproductos obj = new DAOTargproductos();
            obj.RellenarTargetas(flowLayoutPanel1);
        }
    }
}
