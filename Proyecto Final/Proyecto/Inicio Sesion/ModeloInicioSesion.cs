using MySql.Data.MySqlClient;
using Proyecto_Final.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final.Proyecto.Inicio_Sesion
{
    internal class ModeloInicioSesion
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
            sql = "Select * from usuarios where user Like @user";
            comando = new MySqlCommand(sql, miConexion);
            comando.Parameters.AddWithValue("@user", u.UsuarioNombre);
            reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    usuarioResultante = new Usuario();
                    usuarioResultante.Id = int.Parse(reader["id_user"].ToString());
                    usuarioResultante.UsuarioNombre = reader["user"].ToString();
                    usuarioResultante.Password = reader["password"].ToString();
                    usuarioResultante.Nombre = reader["nombre"].ToString();
                    usuarioResultante.Apellido = reader["apellido"].ToString();
                }
            }
            miConexion.Close();
            return usuarioResultante;
        }
    }
}
