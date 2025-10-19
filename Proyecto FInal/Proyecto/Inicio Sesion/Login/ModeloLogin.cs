using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_FInal
{
    internal class ModeloLogin
    {
        private MySqlConnection miConexion;
        private string sql = "";
        private MySqlCommand comando;
        private MySqlDataReader reader;
        public Usuario buscarUsuario(Usuario u)
        {
            Usuario usuarioResultante = null;
            ConexionMySQL c = new ConexionMySQL(); //Instancia de la clase conexión
            miConexion = c.getConexion();
            miConexion.Open();
            sql = "Select * from usuarios where User Like @user";
            comando = new MySqlCommand(sql, miConexion);
            comando.Parameters.AddWithValue("@user", u.UsuarioNombre);
            reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    usuarioResultante = new Usuario();
                    usuarioResultante.Id = int.Parse(reader["idUser"].ToString());
                    usuarioResultante.UsuarioNombre = reader["User"].ToString();
                    usuarioResultante.Password = reader["Password"].ToString();
                    usuarioResultante.Nombre = reader["Nombre"].ToString();
                    usuarioResultante.Apellido = reader["Apellido"].ToString();
                }
            }
            miConexion.Close();
            return usuarioResultante;
        }
    }
}
