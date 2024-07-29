using AgroServicios.Vista.Productos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgroServicios.Modelo.DAO;
using System.Data;
using System.Windows.Forms;
using AgroServicios.Vista.Cuentas;
using AgroServicios.Vista.Estadisticas;

namespace AgroServicios.Controlador.Productos
{
    class ControladorProductos
    {
        //Creamos un objeto de el form llamado vistaProductos, el cual servira para poder manipular todos los elementos que se encuentren dentro de este form
        VistaProductos ObjProductos;

        public ControladorProductos(VistaProductos objProductos)
        {
            ObjProductos = objProductos;
            ObjProductos.Load += new EventHandler(LoadData);
            ObjProductos.btnAgregarProducto.Click += new EventHandler(OpenFormCreateProducto);
            ObjProductos.cmsEliminar.Click += new EventHandler(EliminarProducto);
            ObjProductos.cmsActualizar.Click += new EventHandler(ActualizarProducto);
        }

        private void ActualizarProducto(object sender, EventArgs e)
        {
            int pos = ObjProductos.GriewProductos.CurrentRow.Index;
            int id;
            string Name, precio, stock, descripcion;

            id = int.Parse(ObjProductos.GriewProductos[0, pos].Value.ToString());
            Name = ObjProductos.GriewProductos[1, pos].Value.ToString();
            precio = ObjProductos.GriewProductos[3, pos].Value.ToString();
            stock = ObjProductos.GriewProductos[4, pos].Value.ToString();
            descripcion = ObjProductos.GriewProductos[5, pos].Value.ToString();


            VistaUpdateProducto vistaUpdate = new VistaUpdateProducto(1, id, Name, precio, stock, descripcion);
            vistaUpdate.ShowDialog();
            RefrescarData();
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

        private void LoadData(object sender, EventArgs e)
        {
            RefrescarData();
        }

        private void EliminarProducto(object sender, EventArgs e)
        {
            int pos = ObjProductos.GriewProductos.CurrentRow.Index;

            if (MessageBox.Show($"¿Seguro que deseas eliminar a: \n {ObjProductos.GriewProductos[1, pos].Value.ToString()}\nLa eliminación sera permanente.", "Confirmar acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DAOAdminUsers daodelete = new DAOAdminUsers();
                daodelete.IdEmpleado = int.Parse(ObjProductos.GriewProductos[0, pos].Value.ToString());
                int valorretornado = daodelete.DeteleEmpleado();
                if (valorretornado == 1)
                {
                    MessageBox.Show("Empleado eliminado", "Se ha eliminado correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefrescarData();
                }
                else
                {
                    MessageBox.Show("Eliminación fallida", "No seb ha podido eliminar el empleado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
