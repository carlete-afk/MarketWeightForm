using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace CapaDatos
{
    internal class MonedaCD
    {
        //Monedas 
        internal void TraerCriptos(DataGridView tablaMonedas)
        {
            try
            {
                Conexion objetoConectar = new Conexion();

                string query = "SELECT * FROM Moneda;";
                tablaMonedas.DataSource = null;

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, objetoConectar.Conectar());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                tablaMonedas.DataSource = dt;

                objetoConectar.CerraConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo mostrar las criptos" + ex.ToString());
            }
        }
    }
}
