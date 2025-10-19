using Proyecto_FInal.Proyecto.Clases.Clase_Compras;
using Proyecto_FInal.Proyecto.Clases.Clase_Producto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_FInal.Proyecto.Clases.Clase_DetalleCompra
{
    internal class DetalleCompra
    {
        //Atributos
        private int idDetalleCompra;
        private Compras idCompra;
        private Producto idProducto;
        private decimal precioCompra;
        private decimal precioVenta;
        private int cantidad;
        private DateTime fechaCreacion;

        //Constructor
        public DetalleCompra()
        {
        }

        //Autoimplementacion de propiedades
        public int IdDetalleCompra { get => idDetalleCompra; set => idDetalleCompra = value; }
        public Compras IdCompra { get => idCompra; set => idCompra = value; }
        public Producto IdProducto { get => idProducto; set => idProducto = value; }
        public decimal PrecioCompra { get => precioCompra; set => precioCompra = value; }
        public decimal PrecioVenta { get => precioVenta; set => precioVenta = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public DateTime FechaCreacion { get => fechaCreacion; set => fechaCreacion = value; }

    }
}
