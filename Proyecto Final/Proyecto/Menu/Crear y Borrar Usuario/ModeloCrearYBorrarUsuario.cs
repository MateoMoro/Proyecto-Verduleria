using MySql.Data.MySqlClient;
using Proyecto_Final.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final.Proyecto.Menu.Crear_y_Borrar_Usuario
{
    internal class ModeloCrearYBorrarUsuario
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
            sql = "Select * from usuarios where user Like @user";
            comando = new MySqlCommand(sql, conectar);
            comando.Parameters.AddWithValue("@user", user.UsuarioNombre);
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
            sql = "INSERT INTO usuarios (id_user, user, password, nombre, apellido)" +
                            " VALUES (@id_user, @user, @password, @nombre, @apellido)";
            MySqlCommand comando = new MySqlCommand(sql, conectar);
            comando.Parameters.AddWithValue("@id_user", null);
            comando.Parameters.AddWithValue("@user", user.UsuarioNombre);
            comando.Parameters.AddWithValue("@password", user.Password);
            comando.Parameters.AddWithValue("@nombre", user.Nombre);
            comando.Parameters.AddWithValue("@apellido", user.Apellido);
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
                sql = "DELETE FROM usuarios WHERE user = @user AND password = @password";
                comando = new MySqlCommand(sql, conectar);
                comando.Parameters.AddWithValue("@user", user.UsuarioNombre);
                comando.Parameters.AddWithValue("@password", user.Password);
                int tuplas = comando.ExecuteNonQuery();
                conectar.Close();
                return tuplas > 0;
            }

            public DataTable obtenerUsuarios()
            {
                miConexion = new ConexionMySQL();
                conectar = miConexion.getConexion();
                conectar.Open();
                sql = "SELECT concat(nombre,' ',apellido) as 'Nombre Completo', user as 'Nombre de Usuario' FROM usuarios";
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
