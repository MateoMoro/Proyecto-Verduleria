using MySql.Data.MySqlClient;
using Proyecto_Final.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final.Proyecto.Menu.Proveedores
{
    internal class ModeloProveedores
    {
        //ATRIBUTOS DE INSTANCIA
        private ConexionMySQL miConexion;
        private MySqlConnection conectar;
        private string sql = "";
        private MySqlCommand comando;
        private MySqlDataReader reader;

        public bool existeProveedor(Proveedor prov)
        {
            bool rta = false;
            miConexion = new ConexionMySQL();
            conectar = miConexion.getConexion();
            try
            {
                conectar.Open();
                sql = "SELECT 1 FROM proveedor WHERE id_proveedor = @id_proveedor";
                comando = new MySqlCommand(sql, conectar);
                comando.Parameters.AddWithValue("@id_proveedor", prov.IdProveedor);
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

        public bool registrarProveedor(Proveedor prov)
        {
            miConexion = new ConexionMySQL();
            conectar = miConexion.getConexion();
            try
            {
                conectar.Open();
                sql = "INSERT INTO proveedor (id_proveedor, documento, razon_social, correo, telefono) " +
                      "VALUES (@id_proveedor, @documento, @razon_social, @correo, @telefono)";
                comando = new MySqlCommand(sql, conectar);
                comando.Parameters.AddWithValue("@id_proveedor", prov.IdProveedor);
                comando.Parameters.AddWithValue("@documento", prov.Documento);
                comando.Parameters.AddWithValue("@razon_social", prov.RazonSocial);
                comando.Parameters.AddWithValue("@correo", prov.Correo);
                comando.Parameters.AddWithValue("@telefono", prov.Telefono);
                int tuplas = comando.ExecuteNonQuery();
                return tuplas > 0;
            }
            finally
            {
                if (conectar != null) conectar.Close();
            }
        }

        public bool borrarProveedor(Proveedor prov)
        {
            miConexion = new ConexionMySQL();
            conectar = miConexion.getConexion();
            try
            {
                conectar.Open();
                sql = "DELETE FROM proveedor WHERE id_proveedor = @id_proveedor";
                comando = new MySqlCommand(sql, conectar);
                comando.Parameters.AddWithValue("@id_proveedor", prov.IdProveedor);
                int tuplas = comando.ExecuteNonQuery();
                return tuplas > 0;
            }
            finally
            {
                if (conectar != null) conectar.Close();
            }
        }

        public bool modificarProveedor(Proveedor prov)
        {
            miConexion = new ConexionMySQL();
            conectar = miConexion.getConexion();
            try
            {
                conectar.Open();
                sql = "UPDATE proveedor SET documento = @documento, razon_social = @razon_social, correo = @correo, telefono = @telefono, id_proveedor = @id_proveedor " +
                      "WHERE id_proveedor = @id_proveedor";
                comando = new MySqlCommand(sql, conectar);
                comando.Parameters.AddWithValue("@documento", prov.Documento);
                comando.Parameters.AddWithValue("@razon_social", prov.RazonSocial);
                comando.Parameters.AddWithValue("@correo", prov.Correo);
                comando.Parameters.AddWithValue("@telefono", prov.Telefono);
                comando.Parameters.AddWithValue("@id_proveedor", prov.IdProveedor);
                int tuplas = comando.ExecuteNonQuery();
                return tuplas > 0;
            }
            finally
            {
                if (conectar != null) conectar.Close();
            }
        }

        public DataTable obtenerProveedor()
        {
            miConexion = new ConexionMySQL();
            conectar = miConexion.getConexion();
            try
            {
                conectar.Open();
                sql = "SELECT id_proveedor AS 'ID', documento AS 'Documento', razon_social AS 'Razon Social', correo AS 'Correo', telefono AS 'Telefono' FROM proveedor";
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
