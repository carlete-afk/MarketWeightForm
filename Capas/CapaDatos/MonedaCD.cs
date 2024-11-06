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
    public class MonedaCD
    {
        //Monedas 
        public void TraerCriptos(DataGridView tablaMonedas)
        {
            try
            {
                Conexion objetoConectar = new Conexion();

                string query = "SELECT nombre AS 'Criptomoneda', precio AS 'Precio', cantidad AS 'Cantidad' FROM Moneda;";
                tablaMonedas.DataSource = null;

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, objetoConectar.Conectar());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                tablaMonedas.DataSource = dt;

                objetoConectar.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo mostrar las criptos" + ex.ToString());
            }
        }


        internal void BuscarCriptos(MonedaCE monedaCE, DataGridView tablaMonedas)
        {
            try
            {
                Conexion objetoConectar = new();

                string query = "SELECT nombre, precio, cantidad FROM Moneda WHERE nombre = @nombre;";
                tablaMonedas.DataSource = null;

                tablaMonedas.DataSource = null;
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, objetoConectar.Conectar());
                adapter.SelectCommand.Parameters.AddWithValue("@nombre", monedaCE.Nombre);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                tablaMonedas.DataSource = dt;

                objetoConectar.CerraConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se encontro la criptomoneda" + ex.ToString());
            }
        }

        internal int ObtenerIdMoneda(MonedaCE moneda)
        {
            try
            {
                Conexion conexion = new Conexion();
                MySqlCommand cmd = new MySqlCommand("ObtenerIdMoneda", conexion.Conectar());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("xnombre", moneda.Nombre);
                var resultado = cmd.ExecuteScalar();
                return Convert.ToInt32(resultado);

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo obtener el ID: " + ex.Message);
                return 0;
            }
        }
    }
}
