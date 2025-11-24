using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final.Clases
{
    public class Producto
    {
        //Atributos
        private int idProducto;
        private string codigo;
        private string nombre;
        private string descripcion;
        private TipoProducto idTipoProducto;
        private int stock;
        private decimal precioCompra;
        private decimal precioVenta;
        
        //Constructor
        public Producto()
        {

        }

        //Autoimplementacion de propiedades
        public int IdProducto { get => idProducto; set => idProducto = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public TipoProducto IdTipoProducto { get => idTipoProducto; set => idTipoProducto = value; }
        public int Stock { get => stock; set => stock = value; }
        public decimal PrecioCompra { get => precioCompra; set => precioCompra = value; }
        public decimal PrecioVenta { get => precioVenta; set => precioVenta = value; }
    }
}
