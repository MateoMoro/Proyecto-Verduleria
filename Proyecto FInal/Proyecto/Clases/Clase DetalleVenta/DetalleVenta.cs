using Proyecto_FInal.Proyecto.Clases.Clase_Producto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_FInal.Proyecto.Clases.Clase_DetalleVenta
{
    internal class DetalleVenta
    {
        //Atributos
        private int idDetalleVenta;
        private Venta idVenta;
        private Producto idProducto;
        private decimal precioVenta;
        private int cantidad;
        private decimal subTotal;
        private DateTime fechaCreacion;

        //Constructor
        public DetalleVenta()
        {

        }

        //Autoimplementacion de propiedades
        public int IdDetalleVenta { get => idDetalleVenta; set => idDetalleVenta = value; }
        public Venta IdVenta { get => idVenta; set => idVenta = value; }
        public Producto IdProducto { get => idProducto; set => idProducto = value; }
        public decimal PrecioVenta { get => precioVenta; set => precioVenta = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public decimal SubTotal { get => subTotal; set => subTotal = value; }
        public DateTime FechaCreacion { get => fechaCreacion; set => fechaCreacion = value; }
    }
}
