using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_FInal.Proyecto.Clases.Clase_Ventas
{
    internal class Ventas
    {
        //Atributos
        private int idVentas;
        private Usuario idUsurio;
        private string tipoDocumento;
        private string numeroDocumento;
        private string documentoCliente;
        private string nombreCliente;
        private decimal montoPago;
        private decimal montoCambio;
        private decimal montoTotal;
        private DateTime fechaRegistro;

        //Constructor
        public Ventas()
        {
            
        }

        //Autoimplementacion de propiedades
        public int IdVentas { get => idVentas; set => idVentas = value; }
        public Usuario IdUsurio { get => idUsurio; set => idUsurio = value; }
        public string TipoDocumento { get => tipoDocumento; set => tipoDocumento = value; }
        public string NumeroDocumento { get => numeroDocumento; set => numeroDocumento = value; }
        public string DocumentoCliente { get => documentoCliente; set => documentoCliente = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public decimal MontoPago { get => montoPago; set => montoPago = value; }
        public decimal MontoCambio { get => montoCambio; set => montoCambio = value; }
        public decimal MontoTotal { get => montoTotal; set => montoTotal = value; }
        public DateTime FechaRegistro { get => fechaRegistro; set => fechaRegistro = value; }
    }
}
