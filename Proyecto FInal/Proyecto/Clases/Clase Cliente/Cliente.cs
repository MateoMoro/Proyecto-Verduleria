using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_FInal.Proyecto.Clases.Clase_Cliente
{
    internal class Cliente
    {
        //Atributos
        private int idCliente;
        private string documento;
        private string nombreCompleto;
        private string telefono;
        private bool estado;
       
        //Constructor
        public Cliente()
        {

        }
        
        //Autoimplementacion de propiedades
        public int IdCliente { get => idCliente; set => idCliente = value; }
        public string Documento { get => documento; set => documento = value; }
        public string NombreCompleto { get => nombreCompleto; set => nombreCompleto = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public bool Estado { get => estado; set => estado = value; }
    }
}
