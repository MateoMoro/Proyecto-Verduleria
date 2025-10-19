using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_FInal
{
    internal class ControlRegistroUsuario
    {
        public string ctrlRegistroUsuarios(Usuario user)
        {
            ModeloUsuario modelo = new ModeloUsuario();
            string rta = "";
            if ((string.IsNullOrEmpty(user.Nombre)) ||
            (string.IsNullOrEmpty(user.Apellido)) ||
            (string.IsNullOrEmpty(user.UsuarioNombre) || 
            (string.IsNullOrEmpty(user.Password)) ||
            (string.IsNullOrEmpty(user.PasswordConfirma))))
                rta = "Datos incompletos";
            else
            {
                if (user.Password == user.PasswordConfirma)
                {
                    if (modelo.existeUsuario(user))
                        rta = "¡El nombre de usuario " + user.UsuarioNombre + " no esta disponible!";
                    else
                    {

                        user.Password = generarSHA1(user.Password);

                        if (modelo.registrarUsuario(user))
                            rta = "¡Alta exitosa!";
                        else
                            rta = "¡Error inesperado!";
                    }
                }
                else
                    rta = "¡Las contraseñas no coinciden";
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
