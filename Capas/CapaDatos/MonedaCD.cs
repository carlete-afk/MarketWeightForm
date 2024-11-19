using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
using System.Data.Common;

namespace CapaDatos
{
    public class MonedaCD
    {
        //Monedas 
        public void TraerCriptos(DataGridView tablaMonedas)
        {
            try
            {
                Conexion objetoConectar = new();

                string query = "SELECT nombre 'Criptomoneda', precio 'Cotización', cantidad 'Cantidad' FROM Moneda;";
                tablaMonedas.DataSource = null;

                MySqlDataAdapter adapter = new(query, objetoConectar.Conectar());
                DataTable dt = new();
                adapter.Fill(dt);
                tablaMonedas.DataSource = dt;

                objetoConectar.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en MonedaCD.TraerCriptos");
            }
        }


        public bool BuscarCriptos(string nombre, DataGridView tablaMonedas)
        {
            try
            {
                Conexion objetoConectar = new();

                string query = $"SELECT nombre 'Criptomoneda', precio 'Cotización', cantidad 'Cantidad' FROM Moneda WHERE nombre LIKE '%{nombre}%';";
                tablaMonedas.DataSource = null;

                tablaMonedas.DataSource = null;
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, objetoConectar.Conectar());
                DataTable dt = new();
                adapter.Fill(dt);
                tablaMonedas.DataSource = dt;

                objetoConectar.CerrarConexion();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en MonedaCD.BuscarCriptos");

                return false;
            }
        }

        public int ObtenerIdMoneda(MonedaCE moneda)
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
                MessageBox.Show(ex.Message, "Error en MonedaCD.ObtenerIdMoneda");
                return 0;
            }

        }

        public MonedaCE CrearMonedaOBJ(string xnombre)
        {
            try
            {
                Conexion objetoConectar = new Conexion();

                string query = $"SELECT * FROM Moneda WHERE nombre = @xnombre;";

                MySqlCommand cmd = new MySqlCommand(query, objetoConectar.Conectar());
                cmd.Parameters.AddWithValue("@xnombre", xnombre);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    MonedaCE moneda = new MonedaCE
                    {
                        idMoneda = reader.GetUInt32("idmoneda"),
                        Precio = reader.GetDecimal("cantidad"),
                        Cantidad = reader.GetDecimal("precio"),
                        Nombre = reader.GetString("nombre")
                    };

                    reader.Close();
                    objetoConectar.CerrarConexion();

                    return moneda;
                }
                else
                {
                    reader.Close();
                    objetoConectar.CerrarConexion();
                    return null;
                }
            }
            catch (DbException ex)
            {
                MessageBox.Show(ex.Message, "Error en MonedaCD.CrearMonedaOBJ");
                return null;
            }
        }
    }
}
