﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgroServicios.Modelo.DAO;
using AgroServicios.Modelo.DTO;
using AgroServicios.Vista.Cuentas;
using AgroServicios.Vista.Productos1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace AgroServicios.Controlador.Productos1
{
    class ControladorVistaProductos1
    {
        VistaProductos ObjProductos;

        public ControladorVistaProductos1(VistaProductos objProductos)
        {
            ObjProductos = objProductos;
            ObjProductos.Load += new EventHandler(LoadData);
            //Evento click de botones
            ObjProductos.btnAgregarProducto.Click += new EventHandler(NuevoProducto);
            ObjProductos.btnAgregarMarca.Click += new EventHandler(NuevaMarca);
            ObjProductos.cmsElimarProducto.Click += new EventHandler(EliminarProducto);
            ObjProductos.cmsEditarProducto.Click += new EventHandler(EditarProducto);
            ObjProductos.cmsInformacion.Click += new EventHandler(InformacionProducto);
        }

        public void LoadData(object sender, EventArgs e)
        {
            RefrescarData();
        }

        public void RefrescarData()
        {
            //Objeto de la clase DAOAdminUsuarios
            DAOProductos1 dAOProductos1 = new DAOProductos1();
            //Declarando nuevo DataSet para que obtenga los datos del metodo ObtenerProductos
            DataSet ds = dAOProductos1.ObtenerProductos();
            ////Llenar DataGridView
            ObjProductos.GriewViewProductos.DataSource = ds.Tables["ProductosMarcaView"];

            ObjProductos.GriewViewProductos.Columns["Imagen del producto"].Visible = false;
            TraducirEncabezados(ObjProductos.GriewViewProductos);
        }

        private void NuevoProducto(object sender, EventArgs e)
        {
            VistaCreateProducto nuevoProducto = new VistaCreateProducto(1);
            nuevoProducto.ShowDialog();
            RefrescarData();
        }

        private void NuevaMarca(object sender, EventArgs e)
        {
            VistaCreateMarca nuevaMarca = new VistaCreateMarca(1);
            nuevaMarca.ShowDialog();
            RefrescarData();
        }

        private void InformacionProducto(object sender, EventArgs e)
        {
            int pos = ObjProductos.GriewViewProductos.CurrentRow.Index;
            int id, idMarc;
            string Name, code, stock, price, description, marc;
            byte[] imagen;

            id = int.Parse(ObjProductos.GriewViewProductos[0, pos].Value.ToString());
            idMarc = int.Parse(ObjProductos.GriewViewProductos[2, pos].Value.ToString());
            Name = ObjProductos.GriewViewProductos[1, pos].Value.ToString();
            code = ObjProductos.GriewViewProductos[6, pos].Value.ToString();
            stock = ObjProductos.GriewViewProductos[4, pos].Value.ToString();
            price = ObjProductos.GriewViewProductos[3, pos].Value.ToString();
            description = ObjProductos.GriewViewProductos[5, pos].Value.ToString();
            imagen = (byte[])ObjProductos.GriewViewProductos[7, pos].Value;
            marc = ObjProductos.GriewViewProductos[2, pos].Value.ToString();

            VistaUbdateProducto vistaUpdate = new VistaUbdateProducto(2, id, idMarc, Name, stock, price, description, marc, code, imagen);
            vistaUpdate.ShowDialog();
            RefrescarData();
        }


        private void EditarProducto(object sender, EventArgs e)
        {
            int pos = ObjProductos.GriewViewProductos.CurrentRow.Index;
            int id, idMarc;
            string Name, code, stock, price, description, marc;
            byte[] imagen;

            id = int.Parse(ObjProductos.GriewViewProductos[0, pos].Value.ToString());
            idMarc = int.Parse(ObjProductos.GriewViewProductos[2, pos].Value.ToString());
            Name = ObjProductos.GriewViewProductos[1, pos].Value.ToString();
            code = ObjProductos.GriewViewProductos[6, pos].Value.ToString();
            stock = ObjProductos.GriewViewProductos[4, pos].Value.ToString();
            price = ObjProductos.GriewViewProductos[3, pos].Value.ToString();
            description = ObjProductos.GriewViewProductos[5, pos].Value.ToString();
            imagen = (byte[])ObjProductos.GriewViewProductos[7, pos].Value;
            marc = ObjProductos.GriewViewProductos[2, pos].Value.ToString();

            VistaUbdateProducto vistaUpdate = new VistaUbdateProducto(1, id, idMarc, Name, stock, price, description, marc, code, imagen);
            vistaUpdate.ShowDialog();
            RefrescarData();
        }

        private void EliminarProducto(object sender, EventArgs e)
        {
            int pos = ObjProductos.GriewViewProductos.CurrentRow.Index;

            if (MessageBox.Show($"¿Seguro que deseas eliminar a: \n {ObjProductos.GriewViewProductos[1, pos].Value.ToString()}\nLa eliminación sera permanente.", "Confirmar acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DAOProductos1 daodelete = new DAOProductos1();
                daodelete.IdProducto = int.Parse(ObjProductos.GriewViewProductos[0, pos].Value.ToString());
                daodelete.IdMarca = int.Parse(ObjProductos.GriewViewProductos[2, pos].Value.ToString());
                int valorretornado = daodelete.DeleteProducto();
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

        private void TraducirEncabezados(DataGridView dgv)
        {
            if (ControladorIdioma.idioma == 1)
            {
                dgv.Columns["id del producto"].HeaderText = "Product id";
                dgv.Columns["Nombre del producto"].HeaderText = "Product name";
                dgv.Columns["Marca del producto"].HeaderText = "Product brand";
                dgv.Columns["Precio del producto"].HeaderText = "Product price";
                dgv.Columns["Cantidad del producto"].HeaderText = "Product quantity";
                dgv.Columns["Descripcion del producto"].HeaderText = "Product Description";
                dgv.Columns["Codigo del producto"].HeaderText = "Product code";
                dgv.Columns["Imagen del producto"].HeaderText = "Product image";
            }
            else
            {
                dgv.Columns["id del producto"].HeaderText = "id del producto";
                dgv.Columns["Nombre del producto"].HeaderText = "Nombre del producto";
                dgv.Columns["Marca del producto"].HeaderText = "Marca del producto";
                dgv.Columns["Precio del producto"].HeaderText = "Precio del producto";
                dgv.Columns["Cantidad del producto"].HeaderText = "Cantidad del producto";
                dgv.Columns["Descripcion del producto"].HeaderText = "Descripcion del producto";
                dgv.Columns["Codigo del producto"].HeaderText = "Codigo del producto";
                dgv.Columns["Imagen del producto"].HeaderText = "Imagen del producto";
            }
        }
    }
}
