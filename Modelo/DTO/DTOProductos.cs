using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroServicios.Modelo.DTO
{
    internal class DTOProductos : dbContext
    {
        //Productos
        private int idProducto;
        private string Nombre;
        private decimal Precio;
        private int Stock;
        private string imgNombre;
        private string Descripcion;
        //Para la tabla de productos
        private int idMarca;

        public int IdProducto { get => idProducto; set => idProducto = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public decimal Precio1 { get => Precio; set => Precio = value; }
        public int Stock1 { get => Stock; set => Stock = value; }
        public string ImgNombre { get => imgNombre; set => imgNombre = value; }
        public string Descripcion1 { get => Descripcion; set => Descripcion = value; }
        public int IdMarca { get => idMarca; set => idMarca = value; }
    }
}
