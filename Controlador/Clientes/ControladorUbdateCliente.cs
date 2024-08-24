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
    class ControladorUbdateCliente
    {
        VistaUbdateCliente Objupdate;
        private int accion;
        private string marca;

        public ControladorUbdateCliente(VistaUbdateCliente Vista, int accion, int id, string Name, string telefono, string correo, string direccion)
        {
            Objupdate = Vista;
            this.accion = accion;
            //Objupdate.Load += new EventHandler(InitialCharge);
            verificarAccion();
            ChargeValues(id, Name, telefono, correo, direccion);
            Objupdate.btnUbdateCliente.Click += new EventHandler(ActualizarRegistro);
        }

        public void verificarAccion()
        {
            if (accion == 2)
            {
                Objupdate.btnUbdateCliente.Enabled = false;
                Objupdate.txtUbdateNombreCliente.Enabled = false;
                Objupdate.txtUbdateCorreoCliente.Enabled = false;
                Objupdate.txtUbdateTelefonoCliente.Enabled = false;
                Objupdate.txtUbdateDireccionCliente.Enabled = false;
            }
        }

        public void ChargeValues(int id, string Name, string telefono, string correo, string direccion)
        {
            Objupdate.txtid.Text = id.ToString();
            Objupdate.txtUbdateNombreCliente.Text = Name;
            Objupdate.txtUbdateTelefonoCliente.Text = telefono;
            Objupdate.txtUbdateCorreoCliente.Text = correo;
            Objupdate.txtUbdateDireccionCliente.Text = direccion;
        }

        private void ActualizarRegistro(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Objupdate.txtUbdateNombreCliente.Text) ||
                string.IsNullOrWhiteSpace(Objupdate.txtUbdateTelefonoCliente.Text) ||
                string.IsNullOrWhiteSpace(Objupdate.txtUbdateCorreoCliente.Text) ||
                string.IsNullOrWhiteSpace(Objupdate.txtUbdateDireccionCliente.Text))
            {
                MessageBox.Show("Se han dejado espacios sin llenar",
                                "Error de actualización",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            DAOClientes DaoUpdate = new DAOClientes();
            DaoUpdate.IdCliente = int.Parse(Objupdate.txtid.Text.Trim());
            DaoUpdate.Nombre1 = Objupdate.txtUbdateNombreCliente.Text.Trim();
            DaoUpdate.Telefono1 = Objupdate.txtUbdateTelefonoCliente.Text.Trim();
            DaoUpdate.Correo1 = Objupdate.txtUbdateCorreoCliente.Text.Trim();
            DaoUpdate.Dirreccion1 = Objupdate.txtUbdateDireccionCliente.Text.Trim();
            int valorRetornado = DaoUpdate.ActualizarCliente();

            if (valorRetornado == 1)
            {
                MessageBox.Show("Los datos han sido actualizados exitosamente",
                                "Proceso completado",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                Objupdate.Close();
            }
            else
            {
                MessageBox.Show("Los datos no pudieron ser actualizados",
                                "Proceso interrumpido",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
    }
}
