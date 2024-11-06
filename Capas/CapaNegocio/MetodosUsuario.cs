using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;


namespace CapaNegocio
{
    internal class MetodosUsuario
    {
        public void MostrarUsuarios(DataGridView tablaUsuarios)
        {
            try
            {
                Conexion objetoConectar = new Conexion();

                string query = "SELECT * FROM Usuario;";
                tablaUsuarios.DataSource = null;
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, objetoConectar.Conectar());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                tablaUsuarios.DataSource = dt;
                objetoConectar.CerraConexion();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo mostrar los usuarios" + ex.ToString());
            }
        }

        //Compra
        public void ComprarMoneda(int idusuario, int idmoneda, decimal cantidad)
        {
            try
            {
                Conexion conexion = new Conexion();

                MySqlCommand cmd = new MySqlCommand("ComprarMoneda", conexion.Conectar());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("xidusuario", idusuario);
                cmd.Parameters.AddWithValue("xidmoneda", idmoneda);
                cmd.Parameters.AddWithValue("xidusuario", idusuario);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"El usuario n°{idusuario} no pudo comprar {cantidad} cripto/s n°{idmoneda}" + ex.ToString());
            }
        }

        //Venta
        public void VenderMoneda(int idusuario, int idmoneda, decimal cantidad)
        {
            try
            {
                Conexion conexion = new Conexion();

                MySqlCommand cmd = new MySqlCommand("VenderMoneda", conexion.Conectar());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("xidusuario", idusuario);
                cmd.Parameters.AddWithValue("xidmoneda", idmoneda);
                cmd.Parameters.AddWithValue("xidusuario", idusuario);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"El usuario n°{idusuario} no pudo vender {cantidad} cripto/s n°{idmoneda}" + ex.ToString());
            }
        }

        //Trasnferencia
        public void TransfererirMoneda(int idmoneda, decimal cantidad, int idusuarioTransfiere, int idusuarioTransferido)
        {
            try
            {
                Conexion conexion = new Conexion();

                MySqlCommand cmd = new MySqlCommand("Transferencia", conexion.Conectar());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("xidMoneda", idmoneda);
                cmd.Parameters.AddWithValue("xCantidad", cantidad);
                cmd.Parameters.AddWithValue("xidUsuarioTransfiere", idusuarioTransfiere);
                cmd.Parameters.AddWithValue("xidUsuarioTransferido", idusuarioTransferido);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en la transferencia." + ex.ToString());
            }
        }

        //ObtenerPorCondicion
        public void ObtenerConCondicion(DataGridView tabla, string condicion)
        {
            try
            {
                Conexion objetoConectar = new Conexion();

                string query = $"SELECT * FROM Moneda WHERE {condicion}";

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, objetoConectar.Conectar());

                tabla.DataSource = null;

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                tabla.DataSource = dt;

                objetoConectar.CerraConexion();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo mostrar la/s moneda/s" + ex.ToString());
            }
        }
    }
}
