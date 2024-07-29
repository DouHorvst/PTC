using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgroServicios.Modelo.DAO;
using AgroServicios.Vista.Productos;
using System.Windows.Forms;
using AgroServicios.Vista.Cuentas;
using System.Collections;

namespace AgroServicios.Controlador.Productos
{
     class ControladorUpdateProductos
    {
        VistaUpdateProducto Objupdate;
        private int accion;
        private string marca;

        public ControladorUpdateProductos(VistaUpdateProducto Vista, int accion, int id, string name, int codigo ,decimal precio, int stock, string descripcion)
        {
            Objupdate = Vista;
            this.accion = accion;
            //Objupdate.Load += new EventHandler(InitialCharge);
            ChargeValues(id, name, codigo,precio, stock, descripcion);

            Objupdate.btnUbdateProducto.Click += new EventHandler(ActualizarRegistro);
        }

        private void ActualizarRegistro(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Objupdate.txtUbdateNombre.Text) ||
                string.IsNullOrWhiteSpace(Objupdate.txtUbdateCodigo.Text) ||
                string.IsNullOrWhiteSpace(Objupdate.txtUbdateCantidad.Text) ||
                string.IsNullOrWhiteSpace(Objupdate.txtUbdatePrecio.Text) ||
                string.IsNullOrWhiteSpace(Objupdate.txtUbdateMarca.Text) ||
                string.IsNullOrWhiteSpace(Objupdate.txtUbdateDescripcion.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.",
                                "Error de validación",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }
        }

        public void ChargeValues(int id, string Name, int codigo  ,decimal precio, int cantidad)
        {
            Objupdate.txtid.Text = id.ToString();
            Objupdate.txtUbdateNombre.Text = Name;
            Objupdate.txtUbdateCodigo.Text = codigo;
            Objupdate.txtUbdatePrecio.Text = precio;
            Objupdate.txtUbdateCantidad.Text = cantidad;
        }

    }
}