using AgroServicios.Modelo.DAO;
using AgroServicios.Vista.Clientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgroServicios.Controlador.Clientes
{
    class ControladorCreateCliente
    {
        VistaCreateCliente ObjCreateCliente;
        private int accion;
        private int marca;
        /// <summary>
        /// Constructor para inserción de datos
        /// </summary>
        /// <param name="Vista"></param>
        /// <param name="accion"> INSERCIÓN </param>

        public ControladorCreateCliente(VistaCreateCliente Vista, int accion)
        {
            ObjCreateCliente = Vista;
            this.accion = accion;
            ObjCreateCliente.btnCrearCliente.Click += new EventHandler(NuevoRegistro);
        }

        public void NuevoRegistro(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ObjCreateCliente.txtNombreCliente.Text) ||
               string.IsNullOrWhiteSpace(ObjCreateCliente.txtTelefonoCliente.Text) ||
               string.IsNullOrWhiteSpace(ObjCreateCliente.txtCorreoCliente.Text) ||
               string.IsNullOrWhiteSpace(ObjCreateCliente.txtDireccionCliente.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.",
                                "Error de validación",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            DAOClientes DaoInsert = new DAOClientes();
            // Asignar los valores a las propiedades de DaoInsert
            DaoInsert.Nombre1 = ObjCreateCliente.txtNombreCliente.Text.Trim();
            DaoInsert.Telefono1 = ObjCreateCliente.txtTelefonoCliente.Text.Trim();
            DaoInsert.Correo1 = ObjCreateCliente.txtCorreoCliente.Text.Trim();
            DaoInsert.Dirreccion1 = ObjCreateCliente.txtDireccionCliente.Text.Trim();
            int valorRetornado = DaoInsert.RetgistraCliente();
            if (valorRetornado == 1)
            {
                MessageBox.Show("Los datos no pudieron ser registrados",
                                "Proceso interrumpido",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Los datos han sido registrados exitosamente",
                                   "Proceso completado",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Information);
                ObjCreateCliente.Close();
            }
        }
    }
}