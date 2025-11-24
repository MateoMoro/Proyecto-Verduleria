using MySql.Data.MySqlClient;
using Proyecto_Final.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final.Proyecto.Menu.Tipos_Productos
{
    internal class ModeloTiposProductos
    {
        private ConexionMySQL miConexion;
        private MySqlConnection conectar;
        private String sql = "";
        private MySqlCommand comando;
        private MySqlDataReader reader;

        public bool existeTipoProducto(TipoProducto tipo)
        {
            bool rta = false;
            miConexion = new ConexionMySQL();
            conectar = miConexion.getConexion();
            conectar.Open();
            sql = "SELECT 1 FROM tipoproducto WHERE id_tipoproducto = @id_tipoproducto";
            comando = new MySqlCommand(sql, conectar);
            comando.Parameters.AddWithValue("@id_tipoproducto", tipo.IdTipoProducto);
            reader = comando.ExecuteReader();
            if (reader.HasRows)
                rta = true;
            conectar.Close();
            return rta;
        }

        public bool registrarTipoProducto(TipoProducto tipo)
        {
            miConexion = new ConexionMySQL();
            conectar = miConexion.getConexion();
            conectar.Open();
            sql = "INSERT INTO tipoproducto (id_tipoproducto, descripcion)" +
                        " VALUES (@id_tipoproducto, @descripcion)";
            MySqlCommand comando = new MySqlCommand(sql, conectar);
            comando.Parameters.AddWithValue("@id_tipoproducto", tipo.IdTipoProducto);
            comando.Parameters.AddWithValue("@descripcion", tipo.Descripcion);
            int tuplas = comando.ExecuteNonQuery();
            conectar.Close();
            return tuplas > 0;
        }

        public bool borrarTipoProducto(TipoProducto tipo)
        {
            miConexion = new ConexionMySQL();
            conectar = miConexion.getConexion();
            conectar.Open();
            sql = "DELETE FROM tipoproducto WHERE id_tipoproducto = @id_tipoproducto";
            comando = new MySqlCommand(sql, conectar);
            comando.Parameters.AddWithValue("@id_tipoproducto", tipo.IdTipoProducto);
            int tuplas = comando.ExecuteNonQuery();
            conectar.Close();
            return tuplas > 0;
        }

        public bool modificarTipoProducto(TipoProducto tipo)
        {
            miConexion = new ConexionMySQL();
            conectar = miConexion.getConexion();
            conectar.Open();
            sql = "UPDATE tipoproducto SET descripcion = @descripcion  WHERE id_tipoproducto = @id_tipoproducto";
            comando = new MySqlCommand(sql, conectar);
            comando.Parameters.AddWithValue("@descripcion", tipo.Descripcion);
            comando.Parameters.AddWithValue("@id_tipoproducto", tipo.IdTipoProducto);
            int tuplas = comando.ExecuteNonQuery();
            conectar.Close();
            return tuplas > 0;
        }

        public DataTable obtenerTipoProducto()
        {
            miConexion = new ConexionMySQL();
            conectar = miConexion.getConexion();
            conectar.Open();
            sql = "SELECT id_tipoproducto as 'ID Tipo Producto', descripcion as 'Descripcion' FROM tipoproducto";
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
