using AgroServicios.Modelo.DAO;
using AgroServicios.Vista.Clientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgroServicios.Controlador.Clientes
{
    class ControladorCreateCliente
    {
        VistaCreateCliente ObjCreateCliente;
        private int accion;
        private int marca;
        bool verificacion;
        /// <summary>
        /// Constructor para inserción de datos
        /// </summary>
        /// <param name="Vista"></param>
        /// <param name="accion"> INSERCIÓN </param>

        public ControladorCreateCliente(VistaCreateCliente Vista, int accion)
        {
            ObjCreateCliente = Vista;
            this.accion = accion;
            ObjCreateCliente.btnAgregarCliente.Click += new EventHandler(NuevoRegistro);
        }

        public void NuevoRegistro(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ObjCreateCliente.txtNombreCliente.Text) ||
               string.IsNullOrWhiteSpace(ObjCreateCliente.txtTelefonoCliente.Text) ||
               string.IsNullOrWhiteSpace(ObjCreateCliente.txtCorreoCliente.Text) ||
               string.IsNullOrWhiteSpace(ObjCreateCliente.txtDireccionCliente.Text) ||
               string.IsNullOrWhiteSpace(ObjCreateCliente.maskedDui.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.",
                                "Error de validación",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            if (!ValidarLetra(ObjCreateCliente.txtNombreCliente.Text)) 
            {
                MessageBox.Show("Si sirve", "Si", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Validar el formato del número de teléfono
            if (!ValidarTelefono(ObjCreateCliente.txtTelefonoCliente.Text))
            {
                MessageBox.Show("El formato del número de teléfono es incorrecto. Debe ser +XXX XXXX-XXXX o XXXX-XXXX.",
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
            DaoInsert.DUI1 = ObjCreateCliente.maskedDui.Text;
            verificacion = ValidarCorreo();
            if (verificacion == true)
            {
                int valorRetornado = DaoInsert.RetgistraCliente();
                if (valorRetornado > 0)
                {
                    MessageBox.Show("Los datos han sido registrados exitosamente",
                                    "Proceso completado",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    ObjCreateCliente.Close();
                }
                else
                {
                    MessageBox.Show("Los datos no pudieron ser registrados",
                                    "Proceso interrumpido",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }

            bool ValidarTelefono(string phoneNumber)
            {
                // Expresión regular para validar números de teléfono en los formatos: +XXX XXXX-XXXX o XXXX-XXXX
                string pattern = @"^(\+\d{1,3}\s\d{4}-\d{4}|\d{4}-\d{4})$";
                return Regex.IsMatch(phoneNumber, pattern);
            }

            bool ValidarCorreo()
            {
                string email = ObjCreateCliente.txtCorreoCliente.Text.Trim();
                if (!(email.Contains("@")))
                {
                    MessageBox.Show("Formato de correo invalido, verifica que contiene @.", "Formato incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                return true;
            }


            // Método que valida si un carácter es una letra
            bool ValidarLetra(string texto)
            {
                foreach (char c in texto)
                {
                    if (!char.IsLetter(c) && !char.IsWhiteSpace(c)) // Permite espacios
                    {
                        return false; // Si encuentra un carácter no válido, retorna false
                    }
                }
                return true; // Si todos los caracteres son válidos, retorna true
            }
        }
    }
}
