using AgroServicios.Modelo.DAO;
using AgroServicios.Vista.Clientes;
using AgroServicios.Vista.MenuPrincipal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgroServicios.Controlador.Clientes
{
    class ControladorVistaClientes
    {
        VistaClientes ObjClientes;

        public ControladorVistaClientes(VistaClientes objClientes)
        {
            ObjClientes = objClientes;
            ObjClientes.Load += new EventHandler(LoadData);
            //Evento click de botones
            ObjClientes.btnCrearCliente.Click += new EventHandler(NuevoCliente);
            ObjClientes.cmsEliminarCliente.Click += new EventHandler(EliminarCliente);
            ObjClientes.cmsEditarCliente.Click += new EventHandler(UbdateCliente);
            ObjClientes.cmsInformacionCliente.Click += new EventHandler(InformacionCLiente);
        }

        public void LoadData(object sender, EventArgs e)
        {
            RefrescarData();
        }

        public void RefrescarData()
        {
            //Objeto de la clase DAOAdminUsuarios
            DAOClientes dAOClientes = new DAOClientes();
            //Declarando nuevo DataSet para que obtenga los datos del metodo ObtenerProductos
            DataSet ds = dAOClientes.ObtenerClientes();
            ////Llenar DataGridView
            ObjClientes.GriewClientes.DataSource = ds.Tables["Clientes"];

            ObjClientes.GriewClientes.Columns["idCliente"].Visible = false;
        }

        private void NuevoCliente(object sender, EventArgs e)
        {
            VistaCreateCliente nuevoProducto = new VistaCreateCliente(1);
            nuevoProducto.ShowDialog();
            RefrescarData();
        }

        private void EliminarCliente(object sender, EventArgs e)
        {
            int pos = ObjClientes.GriewClientes.CurrentRow.Index;

            if (MessageBox.Show($"¿Seguro que deseas eliminar a: \n {ObjClientes.GriewClientes[1, pos].Value.ToString()}\nLa eliminación sera permanente.", "Confirmar acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DAOClientes daodelete = new DAOClientes();
                daodelete.IdCliente = int.Parse(ObjClientes.GriewClientes[0, pos].Value.ToString());
                int valorretornado = daodelete.DeleteCLiente();
                if (valorretornado == 1)
                {
                    MessageBox.Show("Producto eliminado", "Se ha eliminado correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefrescarData();
                }
                else
                {
                    MessageBox.Show("Eliminación fallida", "No seb ha podido eliminar el producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UbdateCliente(object sender, EventArgs e)
        {
            int pos = ObjClientes.GriewClientes.CurrentRow.Index;
            int id;
            string Name, telefono, correo, direccion;

            id = int.Parse(ObjClientes.GriewClientes[0, pos].Value.ToString());
            Name = ObjClientes.GriewClientes[1, pos].Value.ToString();
            telefono = ObjClientes.GriewClientes[2, pos].Value.ToString();
            correo = ObjClientes.GriewClientes[3, pos].Value.ToString();
            direccion = ObjClientes.GriewClientes[4, pos].Value.ToString();

            VistaUbdateCliente vistaUpdate = new VistaUbdateCliente(1, id, Name, telefono, correo, direccion);
            vistaUpdate.ShowDialog();
            RefrescarData();
        }

        private void InformacionCLiente(object sender, EventArgs e)
        {
            int pos = ObjClientes.GriewClientes.CurrentRow.Index;
            int id;
            string Name, telefono, correo, direccion;

            id = int.Parse(ObjClientes.GriewClientes[0, pos].Value.ToString());
            Name = ObjClientes.GriewClientes[1, pos].Value.ToString();
            telefono = ObjClientes.GriewClientes[2, pos].Value.ToString();
            correo = ObjClientes.GriewClientes[3, pos].Value.ToString();
            direccion = ObjClientes.GriewClientes[4, pos].Value.ToString();

            VistaUbdateCliente vistaUpdate = new VistaUbdateCliente(2, id, Name, telefono, correo, direccion);
            vistaUpdate.ShowDialog();
            RefrescarData();
        }

    }
}
