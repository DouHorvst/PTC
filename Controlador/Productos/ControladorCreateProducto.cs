using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgroServicios.Modelo.DAO;
using AgroServicios.Vista.Cuentas;
using AgroServicios.Vista.Productos;

namespace AgroServicios.Controlador.Productos
{
    class ControladorCreateProducto
    {
        CreateProducto ObjCreateProducto;
        private int accion;
        private string role;

        /// <summary>
        /// Constructor para inserción de datos
        /// </summary>
        /// <param name="Vista"></param>
        /// <param name="accion"> INSERCIÓN </param>

        public ControladorCreateProducto(CreateProducto Vista, int accion)
        {
            ObjCreateProducto = Vista;
            this.accion = accion;
            ObjCreateProducto.Load += new EventHandler(InitialCharge);

            ObjCreateProducto.btnCrearProducto.Click += new EventHandler(NuevoRegistro);
        }

        public void InitialCharge(object sender, EventArgs e)
        {
            //Objeto de la clase DAOProducto
            DAOAdminUsers objAdmin = new DAOAdminUsers();
            //Declarando nuevo DataSet para que obtenga los datos del metodo LlenarCombo
            DataSet ds = objAdmin.LlenarCombo();
            //Llenar combobox tbRole
            ObjCreateProducto.DropMarcas.DataSource = ds.Tables["Marca"];
            ObjCreateProducto.DropMarcas.ValueMember = "idMarca";
            ObjCreateProducto.DropMarcas.DisplayMember = "Nombre";

            //La condición sirve para que al actualizar un registro, el valor del registro aparezca seleccionado.
            if (accion == 2)
            {
                ObjCreateProducto.DropMarcas.Text = role;
            }
        }

        public void NuevoRegistro(object sender, EventArgs e)
        {
            // Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(ObjCreateProducto.txtNombreProducto.Text) ||
                string.IsNullOrWhiteSpace(ObjCreateProducto.txtCodigoProducto.Text) ||
                string.IsNullOrWhiteSpace(ObjCreateProducto.txtPrecioProducto.Text) ||
                string.IsNullOrWhiteSpace(ObjCreateProducto.txtCantidadProducto.Text) ||
                string.IsNullOrWhiteSpace(ObjCreateProducto.txtNuevaMarcaProducto.Text) ||
                string.IsNullOrWhiteSpace(ObjCreateProducto.txtDescripcionProducto.Text) ||
                ObjCreateProducto.DropMarcas.SelectedValue == null)
            {
                MessageBox.Show("Todos los campos son obligatorios.",
                                "Error de validación",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }
            DAOProductos DaoInsert = new DAOProductos();

            // Asignar los valores a las propiedades de DaoInsert
            DaoInsert.Nombre1 = ObjCreateProducto.txtNombreProducto.Text.Trim();
            DaoInsert.Codigo1 = ObjCreateProducto.txtCodigoProducto.Text.Trim();
            DaoInsert.Precio1 = ObjCreateProducto.txtPrecioProducto.Text.Trim();
            DaoInsert.Stock1 =  ObjCreateProducto.txtCantidadProducto.Text.Trim();
            DaoInsert.Descripcion1 = ObjCreateProducto.txtDescripcionProducto.Text.Trim();
            DaoInsert.IdMarca = int.Parse(ObjCreateProducto.DropMarcas.SelectedValue.ToString());

            int valorRetornado = DaoInsert.RegistrarProducto();
            if (valorRetornado == 1)
            {
                MessageBox.Show("Los datos han sido registrados exitosamente",
                                "Proceso completado",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                ObjCreateProducto.Close();
            }
            else
            {
                MessageBox.Show("Los datos no pudieron ser registrados",
                                "Proceso interrumpido",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
    }
}