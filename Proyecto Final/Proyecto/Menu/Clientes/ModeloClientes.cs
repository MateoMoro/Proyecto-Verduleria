using MySql.Data.MySqlClient;
using Proyecto_Final.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final.Proyecto.Menu.Clientes
{
    internal class ModeloClientes
    {
        //ATRIBUTOS DE INSTANCIA
        private ConexionMySQL miConexion;
        private MySqlConnection conectar;
        private string sql = "";
        private MySqlCommand comando;
        private MySqlDataReader reader;

        public bool existeCliente(Cliente cli)
        {
            bool rta = false;
            miConexion = new ConexionMySQL();
            conectar = miConexion.getConexion();
            try
            {
                conectar.Open();
                sql = "SELECT 1 FROM clientes WHERE id_cliente = @id_cliente";
                comando = new MySqlCommand(sql, conectar);
                comando.Parameters.AddWithValue("@id_cliente", cli.IdCliente);
                reader = comando.ExecuteReader();
                rta = reader.HasRows;
            }
            finally
            {
                if (reader != null) reader.Close();
                if (conectar != null) conectar.Close();
            }
            return rta;
        }

        public bool registrarCliente(Cliente cli)
        {
            miConexion = new ConexionMySQL();
            conectar = miConexion.getConexion();
            try
            {
                conectar.Open();
                sql = "INSERT INTO clientes (id_cliente, documento, nombre_completo, telefono) " +
                      "VALUES (@id_cliente, @documento, @nombre_completo, @telefono)";
                comando = new MySqlCommand(sql, conectar);
                comando.Parameters.AddWithValue("@id_cliente", cli.IdCliente);
                comando.Parameters.AddWithValue("@documento", cli.Documento);
                comando.Parameters.AddWithValue("@nombre_completo", cli.Nombre);
                comando.Parameters.AddWithValue("@telefono", cli.Telefono);
                int tuplas = comando.ExecuteNonQuery();
                return tuplas > 0;
            }
            finally
            {
                if (conectar != null) conectar.Close();
            }
        }

        public bool borrarCliente(Cliente cli)
        {
            miConexion = new ConexionMySQL();
            conectar = miConexion.getConexion();
            try
            {
                conectar.Open();
                sql = "DELETE FROM clientes WHERE id_cliente = @id_cliente";
                comando = new MySqlCommand(sql, conectar);
                comando.Parameters.AddWithValue("@id_cliente", cli.IdCliente);
                int tuplas = comando.ExecuteNonQuery();
                return tuplas > 0;
            }
            finally
            {
                if (conectar != null) conectar.Close();
            }
        }

        public bool modificarCliente(Cliente cli)
        {
            miConexion = new ConexionMySQL();
            conectar = miConexion.getConexion();
            try
            {
                conectar.Open();
                sql = "UPDATE clientes SET documento = @documento, nombre_completo = @nombre_completo, telefono = @telefono, id_cliente = @id_cliente " +
                      "WHERE id_cliente = @id_cliente";
                comando = new MySqlCommand(sql, conectar);
                comando.Parameters.AddWithValue("@documento", cli.Documento);
                comando.Parameters.AddWithValue("@nombre_completo", cli.Nombre);
                comando.Parameters.AddWithValue("@telefono", cli.Telefono);
                comando.Parameters.AddWithValue("@id_cliente", cli.IdCliente);
                int tuplas = comando.ExecuteNonQuery();
                return tuplas > 0;
            }
            finally
            {
                if (conectar != null) conectar.Close();
            }
        }

        public DataTable obtenerCliente()
        {
            miConexion = new ConexionMySQL();
            conectar = miConexion.getConexion();
            try
            {
                conectar.Open();
                sql = "SELECT id_cliente AS 'ID', documento AS 'Documento', nombre_completo AS 'Nombre Completo', telefono AS 'Telefono' FROM clientes";
                comando = new MySqlCommand(sql, conectar);
                MySqlDataAdapter adapter = new MySqlDataAdapter
                {
                    SelectCommand = comando
                };
                DataTable tabla = new DataTable();
                tabla.Locale = System.Globalization.CultureInfo.InvariantCulture;
                adapter.Fill(tabla);
                return tabla;
            }
            finally
            {
                if (conectar != null) conectar.Close();
            }
        }
    }
}
