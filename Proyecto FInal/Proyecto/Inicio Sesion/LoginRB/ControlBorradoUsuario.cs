using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_FInal.LoginRB
{
    internal class ControlBorradoUsuario
    {
        public string ctrlBorrarUsuario(Usuario user)
        {
            ModeloUsuario modelo = new ModeloUsuario();
            string rta = "";

            if ((string.IsNullOrEmpty(user.UsuarioNombre)) ||
                (string.IsNullOrEmpty(user.Password)) ||
                (string.IsNullOrEmpty(user.PasswordConfirma)))
            {
                rta = "Datos incompletos";
            }
            else
            {
                if (user.Password != user.PasswordConfirma)
                {
                    rta = "¡Las contraseñas no coinciden!";
                }
                else
                {
                    // Comprobar existencia por nombre de usuario primero
                    Usuario tmp = new Usuario();
                    tmp.UsuarioNombre = user.UsuarioNombre;
                    if (!modelo.existeUsuario(tmp))
                    {
                        rta = "¡El usuario no existe!";
                    }
                    else
                    {
                        // Hashear la contraseña ingresada y solicitar borrado usando username+hash
                        user.Password = generarSHA1(user.Password);

                        if (modelo.borrarUsuario(user))
                            rta = "¡Usuario borrado con éxito!";
                        else
                            rta = "¡Contraseña incorrecta o error al borrar!";
                    }
                }
            }

            return rta;
        }

        private string generarSHA1(string cadena)
        {
            UTF8Encoding enc = new UTF8Encoding();
            byte[] data = enc.GetBytes(cadena);
            byte[] result;
            SHA1CryptoServiceProvider sha = new SHA1CryptoServiceProvider();
            result = sha.ComputeHash(data);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] < 16)
                {
                    sb.Append("0");
                }
                sb.Append(result[i].ToString("x"));
            }
            return sb.ToString();
        }
    }
}
