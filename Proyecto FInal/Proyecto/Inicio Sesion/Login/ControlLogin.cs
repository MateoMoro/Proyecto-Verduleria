﻿using System;
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
                    if (usuarioBuscado.Password == generarEncriptacionSHA1(u.Password))
                        return true;
                }
                return false;
            }
        }

        private string generarEncriptacionSHA1(string cadena)
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
                    sb.Append("0");
                sb.Append(result[i].ToString("x"));
            }
            return sb.ToString();
        }

    }
}
