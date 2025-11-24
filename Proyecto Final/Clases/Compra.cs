using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final.Clases
{
    public class Compra
    {
        //Atributos
        private int idCompra;
        private Usuario idUsuario;
        private Proveedor idProveedor;
        private int numeroFactura;
        private decimal montoTotal;
        private DateTime fechaCompra;

        //Constructor
        public Compra()
        {

        }

        //Autoimplementacion de propiedades
        public int IdCompra { get => idCompra; set => idCompra = value; }
        internal Usuario IdUsuario { get => idUsuario; set => idUsuario = value; }
        internal Proveedor IdProveedor { get => idProveedor; set => idProveedor = value; }
        public int NumeroFactura { get => numeroFactura; set => numeroFactura = value; }
        public decimal MontoTotal { get => montoTotal; set => montoTotal = value; }
        public DateTime FechaCompra { get => fechaCompra; set => fechaCompra = value; }
    }
}
