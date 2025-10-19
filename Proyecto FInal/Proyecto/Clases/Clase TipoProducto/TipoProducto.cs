using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_FInal.Proyecto.Clases.Clase_TipoProducto
{
    internal class TipoProducto
    {
        //Atributos
        private int idTipoProducto;
        private string descripcion;
        private bool estado;

        //Constructores
        public TipoProducto()
        {

        }

        //Autoimplementacion de propiedades
        public int IdTipoProducto { get => idTipoProducto; set => idTipoProducto = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public bool Estado { get => estado; set => estado = value; }
    }
}
