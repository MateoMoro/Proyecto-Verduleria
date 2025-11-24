using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final.Clases
{
    public class DetalleVenta
    {
        //Atributos
        internal int idDetalleVenta;
        internal Venta idVenta;
        internal Producto idProducto;
        internal decimal precioVenta;
        internal int cantidad;
        internal decimal subtotal;
        internal DateTime fechaCreacion;

        //Constructor
        public DetalleVenta()
        {

        }

        //Autoimplentacion de propiedades
        public int IdDetalleVenta { get => idDetalleVenta; set => idDetalleVenta = value; }
        public Venta IdVenta { get => idVenta; set => idVenta = value; }
        public Producto IdProducto { get => idProducto; set => idProducto = value; }
        public decimal PrecioVenta { get => precioVenta; set => precioVenta = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public decimal Subtotal { get => subtotal; set => subtotal = value; }
        public DateTime FechaCreacion { get => fechaCreacion; set => fechaCreacion = value; }
    }
}
