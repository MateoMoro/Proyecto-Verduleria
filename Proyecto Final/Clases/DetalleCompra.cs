using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final.Clases
{
    public class DetalleCompra
    {
        //Atributos
        internal int idDetalleCompra;
        internal Compra idCompra;
        internal Producto idProducto;
        internal decimal precioCompra;
        internal int cantidad;
        internal DateTime fechaCreacion;

        //Constructor
        public DetalleCompra()
        {

        }

        //Autoimplentacion de propiedades
        public int IdDetalleCompra { get => idDetalleCompra; set => idDetalleCompra = value; }
        public Compra IdCompra { get => idCompra; set => idCompra = value; }
        public Producto IdProducto { get => idProducto; set => idProducto = value; }
        public decimal PrecioCompra { get => precioCompra; set => precioCompra = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public DateTime FechaCreacion { get  => fechaCreacion; set => fechaCreacion = value;} 
    }
}
