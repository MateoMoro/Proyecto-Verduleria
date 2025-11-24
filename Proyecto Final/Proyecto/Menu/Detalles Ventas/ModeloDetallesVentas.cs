using MySql.Data.MySqlClient;
using Proyecto_Final.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final.Proyecto.Menu.Detalles_Ventas
{
    internal class ModeloDetallesVentas
    {
        //ATRIBUTOS DE INSTANCIA
        private ConexionMySQL miConexion;
        private MySqlConnection conectar;
        private string sql = "";
        private MySqlCommand comando;
        private MySqlDataReader reader;

        public bool existeDetalleVenta(DetalleVenta detalle)
        {
            bool rta = false;
            miConexion = new ConexionMySQL();
            conectar = miConexion.getConexion();
            try
            {
                conectar.Open();
                sql = "SELECT 1 FROM detalleventa WHERE id_detalleventa = @id_detalleventa";
                comando = new MySqlCommand(sql, conectar);
                comando.Parameters.AddWithValue("@id_detalleventa", detalle.IdDetalleVenta);
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

        public bool registrarDetalleVenta(DetalleVenta detalle)
        {
            miConexion = new ConexionMySQL();
            conectar = miConexion.getConexion();
            try
            {
                conectar.Open();
                sql = "INSERT INTO detalleventa (id_detalleventa, id_venta, id_producto, precio_venta, cantidad, sub_total, fecha_creacion) " +
                      "VALUES (@id_detalleventa, @id_venta, @id_producto, @precio_venta, @cantidad, @sub_total, @fecha_creacion)";
                comando = new MySqlCommand(sql, conectar);
                comando.Parameters.AddWithValue("@id_detalleventa", detalle.IdDetalleVenta);
                int id_venta = detalle.IdVenta.IdVenta;
                comando.Parameters.AddWithValue("@id_venta", id_venta);
                int id_producto = detalle.IdProducto.IdProducto;
                comando.Parameters.AddWithValue("@id_producto", id_producto);
                comando.Parameters.AddWithValue("@precio_venta", detalle.PrecioVenta);
                comando.Parameters.AddWithValue("@cantidad", detalle.Cantidad);
                comando.Parameters.AddWithValue("@sub_total", detalle.Subtotal);
                comando.Parameters.AddWithValue("@fecha_creacion", detalle.FechaCreacion);
                int tuplas = comando.ExecuteNonQuery();
                return tuplas > 0;
            }
            finally
            {
                if (conectar != null) conectar.Close();
            }
        }

        public bool borrarDetalleVenta(DetalleVenta detalle)
        {
            miConexion = new ConexionMySQL();
            conectar = miConexion.getConexion();
            try
            {
                conectar.Open();
                sql = "DELETE FROM detalleventa WHERE id_detalleventa = @id_detalleventa";
                comando = new MySqlCommand(sql, conectar);
                comando.Parameters.AddWithValue("@id_detalleventa", detalle.IdDetalleVenta);
                int tuplas = comando.ExecuteNonQuery();
                return tuplas > 0;
            }
            finally
            {
                if (conectar != null) conectar.Close();
            }
        }

        public bool modificarDetalleVenta(DetalleVenta detalle)
        {
            miConexion = new ConexionMySQL();
            conectar = miConexion.getConexion();
            try
            {
                conectar.Open();
                sql = "UPDATE detalleventa SET id_venta = @id_venta, id_producto = @id_producto, precio_venta = @precio_venta, " +
                      "cantidad = @cantidad, sub_total = @sub_total, fecha_creacion = @fecha_creacion " +
                      "WHERE id_detalleventa = @id_detalleventa";
                comando = new MySqlCommand(sql, conectar);
                comando.Parameters.AddWithValue("@id_detalleventa", detalle.IdDetalleVenta);
                int id_venta = detalle.IdVenta.IdVenta;
                comando.Parameters.AddWithValue("@id_venta", id_venta);
                int id_producto = detalle.IdProducto.IdProducto;
                comando.Parameters.AddWithValue("@id_producto", id_producto);
                comando.Parameters.AddWithValue("@precio_venta", detalle.PrecioVenta);
                comando.Parameters.AddWithValue("@cantidad", detalle.Cantidad);
                comando.Parameters.AddWithValue("@sub_total", detalle.Subtotal);
                comando.Parameters.AddWithValue("@fecha_creacion", detalle.FechaCreacion);
                int tuplas = comando.ExecuteNonQuery();
                return tuplas > 0;
            }
            finally
            {
                if (conectar != null) conectar.Close();
            }
        }

        public DataTable obtenerDetalleVenta()
        {
            miConexion = new ConexionMySQL();
            conectar = miConexion.getConexion();
            try
            {
                conectar.Open();
                sql = "SELECT id_detalleventa AS 'ID', id_venta AS 'ID de la Venta', id_producto AS 'ID del Producto', precio_venta AS 'Precio de Venta', " +
                      "cantidad AS 'Cantidad', sub_total AS 'SubTotal', fecha_creacion AS 'Fecha' " +
                      "FROM detalleventa";
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

        public DataTable obtenerIDVenta()
        {
            miConexion = new ConexionMySQL();
            conectar = miConexion.getConexion();
            conectar.Open();
            string consulta = "SELECT * FROM ventas";
            comando = new MySqlCommand(consulta, conectar);

            MySqlDataAdapter mysqldt = new MySqlDataAdapter(comando);
            DataTable dt = new DataTable();
            mysqldt.Fill(dt);

            return dt;
        }

        public DataTable obtenerIDProducto()
        {
            miConexion = new ConexionMySQL();
            conectar = miConexion.getConexion();
            conectar.Open();
            string consulta = "SELECT * FROM productos";
            comando = new MySqlCommand(consulta, conectar);

            MySqlDataAdapter mysqldt = new MySqlDataAdapter(comando);
            DataTable dt = new DataTable();
            mysqldt.Fill(dt);

            return dt;
        }
    }
}
