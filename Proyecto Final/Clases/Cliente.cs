using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final.Clases
{
    public class Cliente
    {
        //Atributos
        private int idCliente;
        private string documento;
        private string nombre;
        private string telefono;

        //Constructor
        public Cliente()
        {

        }

        //Autoimplementacion de propiedades
        public int IdCliente { get => idCliente; set => idCliente = value; }
        public string Documento { get => documento; set => documento = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Telefono { get => telefono; set => telefono = value; }
    }
}
