using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Proyecto_Final.Clases;
using System.Data;

namespace Proyecto_Final.Proyecto.Menu.Detalles_Compras
{
    internal class ModeloDetallesCompras
    {
        //ATRIBUTOS DE INSTANCIA
        private ConexionMySQL miConexion;
        private MySqlConnection conectar;
        private string sql = "";
        private MySqlCommand comando;
        private MySqlDataReader reader;

        public bool existeDetalleCompra(DetalleCompra detalleCompra)
        {
            bool rta = false;
            miConexion = new ConexionMySQL();
            conectar = miConexion.getConexion();
            try
            {
                conectar.Open();
                sql = "SELECT 1 FROM detallecompra WHERE id_detallecompra = @id_detallecompra";
                comando = new MySqlCommand(sql, conectar);
                comando.Parameters.AddWithValue("@id_detallecompra", detalleCompra.IdDetalleCompra);
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

        public bool registrarDetalleCompra(DetalleCompra detalleCompra)
        {
            miConexion = new ConexionMySQL();
            conectar = miConexion.getConexion();
            try
            {
                conectar.Open();
                sql = "INSERT INTO detallecompra (id_detallecompra, id_compra, id_producto, precio_compra, cantidad, fecha_creacion) " +
                      "VALUES (@id_detallecompra, @id_compra, @id_producto, @precio_compra, @cantidad, @fecha_creacion)";
                comando = new MySqlCommand(sql, conectar);
                comando.Parameters.AddWithValue("@id_detallecompra", detalleCompra.IdDetalleCompra);
                int id_compra = detalleCompra.IdCompra.IdCompra;
                comando.Parameters.AddWithValue("@id_compra", id_compra);
                int id_producto = detalleCompra.IdProducto.IdProducto;
                comando.Parameters.AddWithValue("@id_producto", id_producto);
                comando.Parameters.AddWithValue("@precio_compra", detalleCompra.PrecioCompra);
                comando.Parameters.AddWithValue("@cantidad", detalleCompra.Cantidad);
                comando.Parameters.AddWithValue("@fecha_creacion", detalleCompra.FechaCreacion);
                int tuplas = comando.ExecuteNonQuery();
                return tuplas > 0;
            }
            finally
            {
                if (conectar != null) conectar.Close();
            }
        }

        public bool borrarDetalleCompra(DetalleCompra detalleCompra)
        {
            miConexion = new ConexionMySQL();
            conectar = miConexion.getConexion();
            try
            {
                conectar.Open();
                sql = "DELETE FROM detallecompra WHERE id_detallecompra = @id_detallecompra";
                comando = new MySqlCommand(sql, conectar);
                comando.Parameters.AddWithValue("@id_detallecompra", detalleCompra.IdDetalleCompra);
                int tuplas = comando.ExecuteNonQuery();
                return tuplas > 0;
            }
            finally
            {
                if (conectar != null) conectar.Close();
            }
        }

        public bool modificarDetalleCompra(DetalleCompra detalleCompra)
        {
            miConexion = new ConexionMySQL();
            conectar = miConexion.getConexion();
            try
            {
                conectar.Open();
                sql = "UPDATE detallecompra SET id_compra = @id_compra, id_producto = @id_producto, precio_compra = @precio_compra, " +
                      "cantidad = @cantidad, fecha_creacion = @fecha_creacion " +
                      "WHERE id_detallecompra = @id_detallecompra";
                comando = new MySqlCommand(sql, conectar);
                comando.Parameters.AddWithValue("@id_detallecompra", detalleCompra.IdDetalleCompra);
                int id_compra = detalleCompra.IdCompra.IdCompra;
                comando.Parameters.AddWithValue("@id_compra", id_compra);
                int id_producto = detalleCompra.IdProducto.IdProducto;
                comando.Parameters.AddWithValue("@id_producto", id_producto);
                comando.Parameters.AddWithValue("@precio_compra", detalleCompra.PrecioCompra);
                comando.Parameters.AddWithValue("@cantidad", detalleCompra.Cantidad);
                comando.Parameters.AddWithValue("@fecha_creacion", detalleCompra.FechaCreacion);
                int tuplas = comando.ExecuteNonQuery();
                return tuplas > 0;
            }
            finally
            {
                if (conectar != null) conectar.Close();
            }
        }

        public DataTable obtenerDetalleCompra()
        {
            miConexion = new ConexionMySQL();
            conectar = miConexion.getConexion();
            try
            {
                conectar.Open();
                sql = "SELECT id_detallecompra AS 'ID', id_compra AS 'ID de la Compra', id_producto AS 'ID del Producto', precio_compra AS 'Precio de Compra', " +
                      "cantidad AS 'Cantidad', fecha_creacion AS 'Fecha de la Compra' " +
                      "FROM detallecompra";
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

        public DataTable obtenerIDCompra()
        {
            miConexion = new ConexionMySQL();
            conectar = miConexion.getConexion();
            conectar.Open();
            string consulta = "Select * from compras";
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
            string consulta = "Select * from productos";
            comando = new MySqlCommand(consulta, conectar);

            MySqlDataAdapter mysqldt = new MySqlDataAdapter(comando);
            DataTable dt = new DataTable();
            mysqldt.Fill(dt);

            return dt;
        }
    }
}
