using AgroServicios.Modelo.DAO;
using AgroServicios.Vista.MenuPrincipal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;
using System.Windows.Forms;
using AgroServicios.Modelo.DTO;
using Bunifu.UI.WinForms.Helpers.Transitions;

namespace AgroServicios.Controlador.Helper
{
    public class ControladorCarrito
    {
        private VistaCarrito objCarrito;

        public ControladorCarrito(VistaCarrito vistaCarrito)
        {
            objCarrito = vistaCarrito;
            objCarrito.btneliminar.Click += Borrarcompra;
            objCarrito.Load += ChargeValue;
            objCarrito.btnComprar.Click += RealizarCompra;
        }
        private void RealizarCompra(object sender, EventArgs e)
        {
            DAOCarrito daoinsert = new DAOCarrito();

            // Validar selección del cliente
            if (objCarrito.cmbCliente.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar que el dgvTotal tenga al menos una fila
            if (objCarrito.dgvTotal.Rows.Count == 0 || objCarrito.dgvTotal.Rows[0].Cells[0].Value == null || string.IsNullOrWhiteSpace(objCarrito.dgvTotal.Rows[0].Cells[0].Value.ToString()))
            {
                MessageBox.Show("El carrito está vacío. No se puede realizar la compra.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            daoinsert.Idcliente = (int)objCarrito.cmbCliente.SelectedValue;
            daoinsert.Idempleado = StaticSession.Id;
            daoinsert.Fechaventa = DateTime.Now;
            decimal montoTotal = 0;

            // Calcular el monto total
            foreach (DataGridViewRow row in objCarrito.dgvCarrito.Rows)
            {
                if (row.Cells["PrecioTotal"].Value != null &&
                    !string.IsNullOrWhiteSpace(row.Cells["PrecioTotal"].Value.ToString()))
                {
                    if (decimal.TryParse(row.Cells["PrecioTotal"].Value.ToString(), NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal precioTotal))
                    {
                        montoTotal += precioTotal;
                    }
                    else
                    {
                        MessageBox.Show("Uno de los valores en 'Precio Total' no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            daoinsert.Montototal = montoTotal;
            int resp = daoinsert.RegistrarVenta();

            if (resp > 0)
            {
                MessageBox.Show("Se ha hecho la compra", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Imprimir();
            }
            else
            {
                MessageBox.Show("No se ha podido realizar la compra", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void Imprimir()
        {
            DTOCarrito dTOCarrito = new DTOCarrito();

            SaveFileDialog save = new SaveFileDialog();
            save.FileName = DateTime.Now.ToString("ddMMyyyyHHmmss") + ".pdf";
            

            string paginahtml_texto = Properties.Resources.Factura_Plantilla.ToString();
            // Obtén los valores necesarios para reemplazar en el HTML
            string cliente = objCarrito.cmbCliente.Text;
            string total = objCarrito.dgvTotal.Rows.Count > 0 && objCarrito.dgvTotal.Rows[0].Cells[0].Value != null
                           ? objCarrito.dgvTotal.Rows[0].Cells[0].Value.ToString()
                           : "0.00";
            string vendedor = StaticSession.Username;

            // Reemplaza los placeholders con los datos reales
            paginahtml_texto = paginahtml_texto.Replace("@Cliente", cliente);
            paginahtml_texto = paginahtml_texto.Replace("@total", total);
            paginahtml_texto = paginahtml_texto.Replace("@vendedor", vendedor);



            string filas = string.Empty;
            foreach (DataGridViewRow row in objCarrito.dgvCarrito.Rows)
            {
                // Verificar si la fila es una fila de datos (no es una fila de encabezado)
                if (row.IsNewRow) continue;

                filas += "<tr>";

                // Verificar si las celdas tienen valores antes de acceder a ellos
                string producto = row.Cells["Producto"].Value?.ToString() ?? "N/A";
                string cantidad = row.Cells["Cantidad"].Value?.ToString() ?? "0";
                string precioUnitario = row.Cells["PrecioUnitario"].Value?.ToString() ?? "0.00";
                string precioTotal = row.Cells["PrecioTotal"].Value?.ToString() ?? "0.00";

                filas += $"<td>{producto}</td>";
                filas += $"<td>{cantidad}</td>";
                filas += $"<td>{precioUnitario}</td>";
                filas += $"<td>{precioTotal}</td>";
                filas += "</tr>";
            }

            // Reemplazar el placeholder @filas en el HTML
            paginahtml_texto = paginahtml_texto.Replace("@filas", filas);

            if (save.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(save.FileName, FileMode.Create))
                {
                    Document pdfdoc = new Document(PageSize.A4, 25, 25, 25, 25);

                    PdfWriter writer = PdfWriter.GetInstance(pdfdoc, stream);

                    pdfdoc.Open();

                    pdfdoc.Add(new Phrase(""));

                    using (StringReader sr = new StringReader(paginahtml_texto))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfdoc, sr);
                    }

                    pdfdoc.Close();

                    stream.Close();
                }
                   
            }
        }


        private void ChargeValue(object sender, EventArgs e)
        {
            LlenarTextBox();
        }

        public void AgregarProductoAlCarrito(string producto, int cantidad, decimal precioUnitario, decimal precioTotal)
        {
            // Verifica si el producto ya existe en el carrito
            foreach (DataGridViewRow row in objCarrito.dgvCarrito.Rows)
            {
                if (row.Cells["Producto"].Value != null &&
                    row.Cells["Producto"].Value.ToString() == producto)
                {
                    // Producto ya existe, actualiza la cantidad y el precio total
                    int cantidadExistente = int.Parse(row.Cells["Cantidad"].Value.ToString());
                    decimal precioTotalExistente = decimal.Parse(row.Cells["PrecioTotal"].Value.ToString(), System.Globalization.NumberStyles.Currency);

                    int nuevaCantidad = cantidadExistente + cantidad;
                    decimal nuevoPrecioTotal = precioTotalExistente + precioTotal;

                    row.Cells["Cantidad"].Value = nuevaCantidad;
                    row.Cells["PrecioTotal"].Value = nuevoPrecioTotal.ToString("C");

                    // Actualiza el total general
                    ActualizarTotal();
                    return;
                }
            }

            // Si el producto no existe, agrega una nueva fila
            objCarrito.dgvCarrito.Rows.Add(producto, cantidad, precioUnitario.ToString("C"), precioTotal.ToString("C"));

            // Actualiza el total general
            ActualizarTotal();
        }

        private void ActualizarTotal()
        {
            decimal total = 0m;

            // Suma el precio total de todos los productos en el carrito
            foreach (DataGridViewRow row in objCarrito.dgvCarrito.Rows)
            {
                if (row.Cells["PrecioTotal"].Value != null &&
                    !string.IsNullOrWhiteSpace(row.Cells["PrecioTotal"].Value.ToString()))
                {
                    total += decimal.Parse(row.Cells["PrecioTotal"].Value.ToString(), System.Globalization.NumberStyles.Currency);
                }
            }

            // Muestra el total en el dgvTotal
            objCarrito.dgvTotal.Rows[0].Cells[0].Value = total.ToString("C");
        }
        private void Borrarcompra(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea eliminar está compra?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                objCarrito.dgvCarrito.Rows.Clear();
                objCarrito.dgvTotal.Rows.Clear();
            }

        }
        void LlenarTextBox()
        {
            DAOCarrito dao = new DAOCarrito();

            DataSet ds = dao.LlenarCombo();

            objCarrito.cmbCliente.DataSource = ds.Tables["Clientes"];
            objCarrito.cmbCliente.ValueMember = "idCliente";
            objCarrito.cmbCliente.DisplayMember = "Nombre";

        }

    }
}
