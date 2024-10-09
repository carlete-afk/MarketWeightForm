using System;
using MySql.Data.MySqlClient;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

public class Conexion
{
    MySqlConnection connection = new MySqlConnection();

    static string servidor = "localhost";
    static string bd = "bdmysql";
    static string usuario = "root";
    static string password = "root";
    static string puerto = "3307";

    string connectionString = $"server={servidor}; port={puerto}; user id={usuario}; password={password}; database={bd};";


    public MySqlConnection Conectar ()
    {
        try
        {
            connection.ConnectionString = connectionString;
            connection.Open();
            MessageBox.Show("Lograste meterte en la BD");
        }

        catch (MySqlException e )
        {
            MessageBox.Show("No se puede conctar a la BD, error:" + e.ToString());
        }

        return connection;
    }
}
