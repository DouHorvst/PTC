﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgroServicios.Controlador.CuentasContralador;

namespace AgroServicios.Vista.Cuentas
{
    public partial class VistaCuentas : Form
    {
        public VistaCuentas()
        {
            InitializeComponent();
            ControladorCuentas control = new ControladorCuentas(this);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void VistaCuentas_Load(object sender, EventArgs e)
        {

        }
    }
}
