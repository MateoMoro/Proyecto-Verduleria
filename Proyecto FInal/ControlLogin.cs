using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_FInal
{
    internal class ControlLogin
    {
        //Constructores
        public ControlLogin()
        {

        }
        //Servicios
        public bool usuarioValido(Usuario u)
        {
            ModeloLogin m = new ModeloLogin();
            if ((string.IsNullOrEmpty(u.UsuarioNombre)) || string.IsNullOrEmpty(u.Password))
                return false;
            else
            {
                Usuario usuarioBuscado = m.buscarUsuario(u);
                if (usuarioBuscado != null)
                {
                    if (usuarioBuscado.Password == u.Password)
                    return true;
                }
                return false;
            }
        }
        
    }
}
