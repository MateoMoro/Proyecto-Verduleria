using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Proyecto_FInal
{
    internal class ModeloUsuario
    {
        // Implementación pública/externa que usan los controladores
        internal bool existeUsuario(Usuario user)
        {
            modeloUsuarios m = new modeloUsuarios();
            return m.existeUsuario(user);
        }

        internal bool registrarUsuario(Usuario user)
        {
            modeloUsuarios m = new modeloUsuarios();
            return m.registrarUsuario(user);
        }

        internal bool borrarUsuario(Usuario user)
        {
            modeloUsuarios m = new modeloUsuarios();
            return m.borrarUsuario(user);
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
                sql = "INSERT INTO usuarios (idUser, User, Password, Nombre, Apellido)" +
                            " VALUES (@idUser, @User, @Password, @Nombre, @Apellido)";
                MySqlCommand comando = new MySqlCommand(sql, conectar);
                comando.Parameters.AddWithValue("@idUser", null);
                comando.Parameters.AddWithValue("@User", user.UsuarioNombre);
                comando.Parameters.AddWithValue("@Password", user.Password);
                comando.Parameters.AddWithValue("@Nombre", user.Nombre);
                comando.Parameters.AddWithValue("@Apellido", user.Apellido);
                int tuplas = comando.ExecuteNonQuery();
                conectar.Close();
                if (tuplas > 0)
                    return true;
                else
                    return false;
            }

            public bool borrarUsuario(Usuario user)
            {
                miConexion = new ConexionMySQL();
                conectar = miConexion.getConexion();
                conectar.Open();
                sql = "DELETE FROM usuarios WHERE User = @User AND Password = @Password";
                comando = new MySqlCommand(sql, conectar);
                comando.Parameters.AddWithValue("@User", user.UsuarioNombre);
                comando.Parameters.AddWithValue("@Password", user.Password);
                int tuplas = comando.ExecuteNonQuery();
                conectar.Close();
                return tuplas > 0;
            }

            public DataTable obtenerUsuarios()
            {
                miConexion = new ConexionMySQL();
                conectar = miConexion.getConexion();
                conectar.Open();
                sql = "SELECT concat(Nombre,' ',Apellido) as 'Nombre Completo', User as 'Nombre de Usuario' FROM usuarios";
                MySqlCommand comando = new MySqlCommand(sql, conectar);
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = comando;
                DataTable tabla = new DataTable();
                tabla.Locale = System.Globalization.CultureInfo.InvariantCulture;
                adapter.Fill(tabla);
                conectar.Close();
                return tabla;
            }
        }
    }
}
