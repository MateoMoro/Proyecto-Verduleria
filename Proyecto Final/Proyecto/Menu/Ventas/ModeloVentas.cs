using MySql.Data.MySqlClient;
using Proyecto_Final.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final.Proyecto.Menu.Ventas
{
    internal class ModeloVentas
    {
        //ATRIBUTOS DE INSTANCIA
        private ConexionMySQL miConexion;
        private MySqlConnection conectar;
        private string sql = "";
        private MySqlCommand comando;
        private MySqlDataReader reader;

        public bool existeVenta(Venta vent)
        {
            bool rta = false;
            miConexion = new ConexionMySQL();
            conectar = miConexion.getConexion();
            try
            {
                conectar.Open();
                sql = "SELECT 1 FROM ventas WHERE numero_factura = @numero_factura";
                comando = new MySqlCommand(sql, conectar);
                comando.Parameters.AddWithValue("@numero_factura", vent.NumeroFactura);
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

        public bool registrarVenta(Venta vent)
        {
            miConexion = new ConexionMySQL();
            conectar = miConexion.getConexion();
            try
            {
                conectar.Open();
                sql = "INSERT INTO ventas (id_ventas, id_usuario, numero_factura, monto_pago, monto_cambio, monto_total, fecha_registro, id_cliente) " +
                      "VALUES (@id_ventas, @id_usuario, @numero_factura, @monto_pago, @monto_cambio, @monto_total, @fecha_registro, @id_cliente)";
                comando = new MySqlCommand(sql, conectar);
                comando.Parameters.AddWithValue("@id_ventas", null);
                int id_usuario = vent.IdUsuario.Id;
                comando.Parameters.AddWithValue("@id_usuario", id_usuario);
                comando.Parameters.AddWithValue("@numero_factura", vent.NumeroFactura);
                comando.Parameters.AddWithValue("@monto_pago", vent.MontoPago);
                comando.Parameters.AddWithValue("@monto_cambio", vent.MontoCambio);
                comando.Parameters.AddWithValue("@monto_total", vent.MontoTotal);
                comando.Parameters.AddWithValue("@fecha_registro", vent.FechaVenta);
                int id_cliente = vent.IdCliente.IdCliente;
                comando.Parameters.AddWithValue("@id_cliente", id_cliente);
                int tuplas = comando.ExecuteNonQuery();
                return tuplas > 0;
            }
            finally
            {
                if (conectar != null) conectar.Close();
            }
        }

        public bool borrarVenta(Venta vent)
        {
            miConexion = new ConexionMySQL();
            conectar = miConexion.getConexion();
            try
            {
                conectar.Open();
                sql = "DELETE FROM ventas WHERE numero_factura = @numero_factura";
                comando = new MySqlCommand(sql, conectar);
                comando.Parameters.AddWithValue("@numero_factura", vent.NumeroFactura);
                int tuplas = comando.ExecuteNonQuery();
                return tuplas > 0;
            }
            finally
            {
                if (conectar != null) conectar.Close();
            }
        }

        public bool modificarVenta(Venta vent)
        {
            miConexion = new ConexionMySQL();
            conectar = miConexion.getConexion();
            try
            {
                conectar.Open();
                sql = "UPDATE ventas SET id_usuario = @id_usuario, numero_factura = @numero_factura, monto_pago = @monto_pago, " +
                      "monto_cambio = @monto_cambio, monto_total = @monto_total, fecha_registro = @fecha_registro, " +
                      "id_cliente = @id_cliente WHERE numero_factura = @numero_factura";
                comando = new MySqlCommand(sql, conectar);
                comando.Parameters.AddWithValue("@id_ventas", null);
                int id_usuario = vent.IdUsuario.Id;
                comando.Parameters.AddWithValue("@id_usuario", id_usuario);
                comando.Parameters.AddWithValue("@numero_factura", vent.NumeroFactura);
                comando.Parameters.AddWithValue("@monto_pago", vent.MontoPago);
                comando.Parameters.AddWithValue("@monto_cambio", vent.MontoCambio);
                comando.Parameters.AddWithValue("@monto_total", vent.MontoTotal);
                comando.Parameters.AddWithValue("@fecha_registro", vent.FechaVenta);
                int id_cliente = vent.IdCliente.IdCliente;
                comando.Parameters.AddWithValue("@id_cliente", id_cliente);
                int tuplas = comando.ExecuteNonQuery();
                return tuplas > 0;
            }
            finally
            {
                if (conectar != null) conectar.Close();
            }
        }

        public DataTable obtenerVenta()
        {
            miConexion = new ConexionMySQL();
            conectar = miConexion.getConexion();
            try
            {
                conectar.Open();
                sql = "SELECT id_ventas AS 'ID', numero_factura AS 'Numero de Factura', id_usuario AS 'ID del Usuario', id_cliente AS 'ID del Cliente', " +
                      "monto_pago AS 'Pago', monto_cambio AS 'Cambio', monto_total AS 'Total', fecha_registro AS 'Fecha' " +
                      "FROM ventas";
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

        public DataTable obtenerIDCliente()
        {
            miConexion = new ConexionMySQL();
            conectar = miConexion.getConexion();
            conectar.Open();
            string consulta = "Select * from clientes";
            comando = new MySqlCommand(consulta, conectar);

            MySqlDataAdapter mysqldt = new MySqlDataAdapter(comando);
            DataTable dt = new DataTable();
            mysqldt.Fill(dt);

            return dt;
        }
    }
}
