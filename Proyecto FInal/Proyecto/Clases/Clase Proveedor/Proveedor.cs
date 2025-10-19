using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_FInal.Proyecto.Clases.Clase_Proveedor
{
    internal class Proveedor
    {
        //Atributos
        private int idProveedor;
        private string documento;
        private string razonSocial;
        private string correo;
        private string telefono;
        private bool estado;

        //Constructores

        public Proveedor()
        {

        }


        //Autoimplementacion de propiedades
        public int IdProveedor { get => idProveedor; set => idProveedor = value; }
        public string Documento { get => Documento; set => Documento = value; }
        public string RazonSocial { get => RazonSocial; set => RazonSocial = value; }
        public string Correo { get => Correo; set => Correo = value; }
        public string Telefono { get => Telefono; set => Telefono = value; }
        public bool Estado { get => estado; set => estado = value; }

    }
}
