using AgroServicios.Vista.Cuentas;
using AgroServicios.Vista.Productos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgroServicios.Modelo.DAO;
using AgroServicios.Vista.Estadisticas;
using System.Data;

namespace AgroServicios.Controlador.Productos
{
    class ControladorProductos
    {
        //Creamos un objeto de el form llamado vistaProductos, el cual servira para poder manipular todos los elementos que se encuentren dentro de este form
        VistaProductos ObjProductos;

        public ControladorProductos(VistaProductos objProductos)
        {
            ObjProductos = objProductos;
            ObjProductos.btnAgregarProducto.Click += new EventHandler(OpenFormCreateProducto);
        }

        private void RefrescarData()
        {
            //Objeto de la clase DAOAProductos
            DAOProductos objAdmin = new DAOProductos();
            //Declarando nuevo DataSet para que obtenga los datos del metodo ObtenerPersonas
            DataSet ds = objAdmin.ObtenerProductos();
            ////Llenar DataGridView
            ObjProductos.GriewProductos.DataSource = ds.Tables["Productos"];
        }

        private void OpenFormCreateProducto(object sender, EventArgs e) 
        {
            CreateProducto createProducto = new CreateProducto(1);
            createProducto.ShowDialog();
            RefrescarData();
        }
    }
}
