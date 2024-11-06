using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDatos
{

    //Conexion
    public class Conexion
    {
        MySqlConnection connection = new MySqlConnection();

        static string servidor = "localhost";
        static string bd = "5to_marketweight";
        static string usuario = "root";
        static string password = "root";
        static string puerto = "3306";

        string connectionString = $"server={servidor}; port={puerto}; user id={usuario}; password={password}; database={bd};";


        public MySqlConnection Conectar()
        {
            try
            {
                connection.ConnectionString = connectionString;
                connection.Open();
            }

            catch (MySqlException e)
            {
                MessageBox.Show("No se puede conctar a la BD, error:" + e.ToString());
            }

            return connection;
        }

        public void CerrarConexion()
        {
            connection.Close();
        }


    }
}
