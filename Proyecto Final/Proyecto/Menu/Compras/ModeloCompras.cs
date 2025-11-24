using MySql.Data.MySqlClient;
using Proyecto_Final.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final.Proyecto.Menu.Compras
{
    internal class ModeloCompras
    {
        //ATRIBUTOS DE INSTANCIA
        private ConexionMySQL miConexion;
        private MySqlConnection conectar;
        private string sql = "";
        private MySqlCommand comando;
        private MySqlDataReader reader;

        public bool existeCompra(Compra comp)
        {
            bool rta = false;
            miConexion = new ConexionMySQL();
            conectar = miConexion.getConexion();
            try
            {
                conectar.Open();
                sql = "SELECT 1 FROM compras WHERE numero_factura = @numero_factura";
                comando = new MySqlCommand(sql, conectar);
                comando.Parameters.AddWithValue("@numero_factura", comp.NumeroFactura);
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

        public bool registrarCompra(Compra comp)
        {
            miConexion = new ConexionMySQL();
            conectar = miConexion.getConexion();
            try
            {
                conectar.Open();
                sql = "INSERT INTO compras (id_compras, id_usuario, id_proveedor, numero_factura, monto_total, fecha_registro) " +
                      "VALUES (@id_compras, @id_usuario, @id_proveedor, @numero_factura, @monto_total, @fecha_registro)";
                comando = new MySqlCommand(sql, conectar);
                comando.Parameters.AddWithValue("@id_compras", null);
                int id_usuario = comp.IdUsuario.Id;
                comando.Parameters.AddWithValue("@id_usuario", id_usuario);
                int id_proveedor = comp.IdProveedor.IdProveedor;
                comando.Parameters.AddWithValue("@id_proveedor", id_proveedor);
                comando.Parameters.AddWithValue("@numero_factura", comp.NumeroFactura);
                comando.Parameters.AddWithValue("@monto_total", comp.MontoTotal);
                comando.Parameters.AddWithValue("@fecha_registro", comp.FechaCompra);
                int tuplas = comando.ExecuteNonQuery();
                return tuplas > 0;
            }
            finally
            {
                if (conectar != null) conectar.Close();
            }
        }

        public bool borrarCompra(Compra comp)
        {
            miConexion = new ConexionMySQL();
            conectar = miConexion.getConexion();
            try
            {
                conectar.Open();
                sql = "DELETE FROM compras WHERE numero_factura = @numero_factura";
                comando = new MySqlCommand(sql, conectar);
                comando.Parameters.AddWithValue("@numero_factura", comp.NumeroFactura);
                int tuplas = comando.ExecuteNonQuery();
                return tuplas > 0;
            }
            finally
            {
                if (conectar != null) conectar.Close();
            }
        }

        public bool modificarCompra(Compra comp)
        {
            miConexion = new ConexionMySQL();
            conectar = miConexion.getConexion();
            try
            {
                conectar.Open();
                sql = "UPDATE compras SET id_usuario = @id_usuario, id_proveedor = @id_proveedor, " +
                      "monto_total = @monto_total, fecha_registro = @fecha_registro " +
                      "WHERE numero_factura = @numero_factura ";
                comando = new MySqlCommand(sql, conectar);
                comando.Parameters.AddWithValue("@id_compras", null);
                int id_usuario = comp.IdUsuario.Id;
                comando.Parameters.AddWithValue("@id_usuario", id_usuario);
                int id_proveedor = comp.IdProveedor.IdProveedor;
                comando.Parameters.AddWithValue("@id_proveedor", id_proveedor);
                comando.Parameters.AddWithValue("@numero_factura", comp.NumeroFactura);
                comando.Parameters.AddWithValue("@monto_total", comp.MontoTotal);
                comando.Parameters.AddWithValue("@fecha_registro", comp.FechaCompra);
                int tuplas = comando.ExecuteNonQuery();
                return tuplas > 0;
            }
            finally
            {
                if (conectar != null) conectar.Close();
            }
        }

        public DataTable obtenerCompra()
        {
            miConexion = new ConexionMySQL();
            conectar = miConexion.getConexion();
            try
            {
                conectar.Open();
                sql = "SELECT id_compras AS 'ID', numero_factura AS 'Numero de Factura', id_usuario AS 'ID del Usuario', id_proveedor AS 'ID del Proveedor', " +
                      "monto_total AS 'Total de Compra', fecha_registro AS 'Fecha' " +
                      "FROM compras";
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

        public DataTable obtenerIDUsuario()
        {
            miConexion = new ConexionMySQL();
            conectar = miConexion.getConexion();
            conectar.Open();
            string consulta = "Select * from usuarios";
            comando = new MySqlCommand(consulta, conectar);

            MySqlDataAdapter mysqldt = new MySqlDataAdapter(comando);
            DataTable dt = new DataTable();
            mysqldt.Fill(dt);

            return dt;
        }

        public DataTable obtenerIDProveedor()
        {
            miConexion = new ConexionMySQL();
            conectar = miConexion.getConexion();
            conectar.Open();
            string consulta = "Select * from proveedor";
            comando = new MySqlCommand(consulta, conectar);

            MySqlDataAdapter mysqldt = new MySqlDataAdapter(comando);
            DataTable dt = new DataTable();
            mysqldt.Fill(dt);

            return dt;
        }
    }
}
