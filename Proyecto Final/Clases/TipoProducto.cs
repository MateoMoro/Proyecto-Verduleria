using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final.Clases
{
    internal class TipoProducto
    {
        //Atributos
        private int idTipoProducto;
        private string descripcion;

        //Constructores
        public TipoProducto()
        {

        }

        public TipoProducto(int idTipoProducto)
        {
            this.idTipoProducto = idTipoProducto;
        }

        //Autoimplementacion de propiedades
        public int IdTipoProducto { get => idTipoProducto; set => idTipoProducto = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}
