using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_FInal
{
    internal class Usuario
    {
        //Atributos
        private int id;
        private string usuarioNombre;
        private string password;
        private string passwordConfirma;
        private string nombre;
        private string apellido;
        
        //Constructores
        public Usuario()
        {

        }
       
        public Usuario(string un, string pass)
        {
            UsuarioNombre = un;
            Password = pass;
        }
       
        //Autoimplementacion de propiedades
        public int Id { get => id; set => id = value; }
        public string UsuarioNombre { get => usuarioNombre; set => usuarioNombre = value; }
        public string Password { get => password; set => password = value; }
        public string PasswordConfirma { get => passwordConfirma; set => passwordConfirma = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
    }
}
