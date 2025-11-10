using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final.Clases
{
    internal class Proveedor
    {
        public int IdProveedor { get; set; }
        public string Documento { get; set; }
        public string RazonSocial { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }

        //Constructores
        public Proveedor()
        {

        }

        public Proveedor(int idProveedor, string documento, string razonSocial, string correo, string telefono)
        {
            IdProveedor = idProveedor;
            Documento = documento;
            RazonSocial = razonSocial;
            Correo = correo;
            Telefono = telefono;
        }
    }
}
