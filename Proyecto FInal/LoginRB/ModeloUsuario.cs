using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_FInal
{
    internal class ModeloUsuario
    {
        internal bool existeUsuario(Usuario user)
        {
            throw new NotImplementedException();
        }

        internal bool registrarUsuario(Usuario user)
        {
            throw new NotImplementedException();
        }

        public class modeloUsuarios
        {
            //ATRIBUTOS DE INSTANCIA
            private ConexionMySQL miConexion;
            private MySqlConnection conectar;
            private String sql = "";
            private MySqlCommand comando;
            private MySqlDataReader reader;
            public bool existeUsuario(Usuario user)
            {
                bool rta = false;
                miConexion = new ConexionMySQL();
                conectar = miConexion.getConexion();
                conectar.Open();
                sql = "Select * from usuarios where User Like @user";
                comando = new MySqlCommand(sql, conectar);
                comando.Parameters.AddWithValue("@User", user.UsuarioNombre);
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                    rta = true;
                conectar.Close();
                return rta;
            }
            public bool registrarUsuario(Usuario user)
            {
                miConexion = new ConexionMySQL();
                conectar = miConexion.getConexion();
                conectar.Open();
                sql = "INSERT INTO usuarios (idUser, User, Password, Nombre, Apellido, idTipoUser)" +
                " VALUES (@idUser, @User, @Password, @Nombre, @Apellido, @idTipoUser)";
                MySqlCommand comando = new MySqlCommand(sql, conectar);
                comando.Parameters.AddWithValue("@idUser", null);
                comando.Parameters.AddWithValue("@User", user.UsuarioNombre);
                comando.Parameters.AddWithValue("@Password", user.Password);
                comando.Parameters.AddWithValue("@Nombre", user.Nombre);
                comando.Parameters.AddWithValue("@Apellido", user.Apellido);
                comando.Parameters.AddWithValue("@idTipoUser", user.IdTipo);
                int tuplas = comando.ExecuteNonQuery();
                conectar.Close();
                if (tuplas > 0)
                    return true;
                else
                    return false;
            }
            public DataTable obtenerTipos()
            {
                miConexion = new ConexionMySQL();
                conectar = miConexion.getConexion();
                conectar.Open();
                string consulta = "Select * from tipousuario";
                comando = new MySqlCommand(consulta, conectar);
                MySqlDataAdapter mysqldt = new MySqlDataAdapter(comando);
                DataTable dt = new DataTable();
                mysqldt.Fill(dt);
                return dt;
            }
        }
    }
}
