﻿using AgroServicios.Controlador.Clientes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgroServicios.Vista.Clientes
{
    public partial class VistaClientes : Form
    {
        public VistaClientes()
        {
            InitializeComponent();
            ControladorVistaClientes control = new ControladorVistaClientes(this);
        }

        private void VistaClientes_Load(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel1_Click(object sender, EventArgs e)
        {

        }
    }
}
