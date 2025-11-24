using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Proyecto_Final.Clases
{
    internal class ConexionMySQL
    {
        //Atributos de clase
        private const string servidor = "datasource = 127.0.0.1";
        private const string puerto = "port = 3306";
        private const string username = "username = root";
        private const string password = "password = 1234";
        private const string bd = "database = Disfrutable";

        //Atributo de instancia
        private String cadenaConexion;

        //Constructores
        public ConexionMySQL()
        {
            cadenaConexion = servidor + ";" + puerto + ";" + username + ";" + password + ";" + bd;
        }

        //Servicios
        public MySqlConnection getConexion()
        {
            return new MySqlConnection(cadenaConexion);
        }
    }
}
