using MySql.Data.MySqlClient;
using Proyecto_Final.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final.Proyecto.Menu.Productos
{
    public class ModeloProductos
    {
        //ATRIBUTOS DE INSTANCIA
        private ConexionMySQL miConexion;
        private MySqlConnection conectar;
        private string sql = "";
        private MySqlCommand comando;
        private MySqlDataReader reader;

        public bool existeProducto(Producto prod)
        {
            bool rta = false;
            miConexion = new ConexionMySQL();
            conectar = miConexion.getConexion();
            try
            {
                conectar.Open();
                sql = "SELECT 1 FROM productos WHERE codigo = @codigo";
                comando = new MySqlCommand(sql, conectar);
                comando.Parameters.AddWithValue("@codigo", prod.Codigo);
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

        public bool registrarProducto(Producto prod)
        {
            miConexion = new ConexionMySQL();
            conectar = miConexion.getConexion();
            try
            {
                conectar.Open();
                sql = "INSERT INTO productos (id, codigo, nombre, descripcion, id_tipoproducto, stock, precio_compra, precio_venta) " +
                      "VALUES (@id, @codigo, @nombre, @descripcion, @id_tipoproducto, @stock, @precio_compra, @precio_venta)";
                comando = new MySqlCommand(sql, conectar);
                comando.Parameters.AddWithValue("@id", null);
                comando.Parameters.AddWithValue("@codigo", prod.Codigo);
                comando.Parameters.AddWithValue("@nombre", prod.Nombre);
                comando.Parameters.AddWithValue("@descripcion", prod.Descripcion);
                int id = prod.IdTipoProducto.IdTipoProducto;
                comando.Parameters.AddWithValue("@id_tipoproducto", id);
                comando.Parameters.AddWithValue("@stock", prod.Stock);
                comando.Parameters.AddWithValue("@precio_compra", prod.PrecioCompra);
                comando.Parameters.AddWithValue("@precio_venta", prod.PrecioVenta);
                int tuplas = comando.ExecuteNonQuery();
                return tuplas > 0;
            }
            finally
            {
                if (conectar != null) conectar.Close();
            }
        }

        public bool borrarProducto(Producto prod)
        {
            miConexion = new ConexionMySQL();
            conectar = miConexion.getConexion();
            try
            {
                conectar.Open();
                sql = "DELETE FROM productos WHERE codigo = @codigo";
                comando = new MySqlCommand(sql, conectar);
                comando.Parameters.AddWithValue("@codigo", prod.Codigo);
                int tuplas = comando.ExecuteNonQuery();
                return tuplas > 0;
            }
            finally
            {
                if (conectar != null) conectar.Close();
            }
        }

        public bool modificarProducto(Producto prod)
        {
            miConexion = new ConexionMySQL();
            conectar = miConexion.getConexion();
            try
            {
                conectar.Open();
                sql = "UPDATE productos SET codigo = @codigo, nombre = @nombre, descripcion = @descripcion, " +
                      "id_tipoproducto = @id_tipoproducto, stock = @stock, precio_compra = @precio_compra, " +
                      "precio_venta = @precio_venta WHERE id = @id";
                comando.Parameters.AddWithValue("@id", null);
                comando.Parameters.AddWithValue("@codigo", prod.Codigo);
                comando.Parameters.AddWithValue("@nombre", prod.Nombre);
                comando.Parameters.AddWithValue("@descripcion", prod.Descripcion);
                int id = prod.IdTipoProducto.IdTipoProducto;
                comando.Parameters.AddWithValue("@id_tipoproducto", id);
                comando.Parameters.AddWithValue("@stock", prod.Stock);
                comando.Parameters.AddWithValue("@precio_compra", prod.PrecioCompra);
                comando.Parameters.AddWithValue("@precio_venta", prod.PrecioVenta);
                int tuplas = comando.ExecuteNonQuery();
                return tuplas > 0;
            }
            finally
            {
                if (conectar != null) conectar.Close();
            }
        }

        public DataTable obtenerProducto()
        {
            miConexion = new ConexionMySQL();
            conectar = miConexion.getConexion();
            try
            {
                conectar.Open();
                sql = "SELECT id AS 'ID', codigo AS 'Codigo', nombre AS 'Nombre', descripcion AS 'Descripcion'," +
                      "id_tipoproducto AS 'Tipo de Producto', stock AS 'Stock', precio_compra AS 'Precio de Compra', precio_venta AS 'Precio de Venta'" +
                      "FROM productos";
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

        public DataTable obtenerTipos()
        {
            miConexion = new ConexionMySQL();
            conectar = miConexion.getConexion();
            conectar.Open();
            string consulta = "Select * from tipoproducto";
            comando = new MySqlCommand(consulta, conectar);

            MySqlDataAdapter mysqldt = new MySqlDataAdapter(comando);
            DataTable dt = new DataTable();
            mysqldt.Fill(dt);

            return dt;
        }

    }
}
