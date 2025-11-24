using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final.Clases
{
    public class Venta
    {
        //Atributos
        private int idVenta;
        private Usuario idUsuario;
        private int numeroFactura;
        private Cliente idCliente;
        private decimal montoPago;
        private decimal montoCambio;
        private decimal montoTotal;
        private DateTime fechaVenta;

        //Constructor
        public Venta()
        {

        }

        //Autoimplementacion de propiedades
        public int IdVenta { get => idVenta; set => idVenta = value; }
        internal Usuario IdUsuario { get => idUsuario; set => idUsuario = value; }
        public int NumeroFactura { get => numeroFactura; set => numeroFactura = value; }
        public Cliente IdCliente { get => idCliente; set => idCliente = value; }
        public decimal MontoPago { get => montoPago; set => montoPago = value; }
        public decimal MontoCambio { get => montoCambio; set => montoCambio = value; }
        public decimal MontoTotal { get => montoTotal; set => montoTotal = value; }
        public DateTime FechaVenta { get => fechaVenta; set => fechaVenta = value; }
    }
}
