using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_FInal.Proyecto.Clases.Clase_Compras
{
    internal class Compras
    {
        //Atributos
        private int idCompras;
        private Usuario idUsuario;
        private Proveedor idProveedor;
        private string tipoDocumento;
        private string numeroDocumento;
        private decimal montoTotal;
        private DateTime fechaRegistro;

        //Constructor
        public Compras()
        {

        }

        //Autoimplementacion de propiedades
        public int IdCompras { get => idCompras; set => idCompras = value; }
        public Usuario IdUsuario { get => idUsuario; set => idUsuario = value; }
        public Proveedor IdProveedor { get => idProveedor; set => idProveedor = value; }
        public string TipoDocumento { get => tipoDocumento; set => tipoDocumento = value; }
        public string NumeroDocumento { get => numeroDocumento; set => numeroDocumento = value; }
        public decimal MontoTotal { get => montoTotal; set => montoTotal = value; }
        public DateTime FechaRegistro { get => fechaRegistro; set => fechaRegistro = value; }
    }
}
