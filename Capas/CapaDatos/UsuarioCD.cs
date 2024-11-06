using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using System.Data;
using MySql.Data.MySqlClient;


namespace CapaDatos
{
    public class UsuarioCD
    {
        

        //Ingreso de login
        public bool UsuarioLogin (string email, string pass)
        {
            try
            {
                Conexion objetoConectar = new Conexion();
                string query = $"SELECT * FROM Usuario WHERE email = @Email AND pass = @Password;";

                //Uso de parametros
                MySqlCommand cmd = new MySqlCommand(query, objetoConectar.Conectar());
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Password", pass);


                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                objetoConectar.CerrarConexion();

                return dt.Rows.Count > 0;
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error! \n\n{ex} ");
                return false;
            }
        }

        //Registro
        internal IEnumerable<UsuarioCE> UsuarioRegistro(UsuarioCE usuario)
        {
            try
            {
                Conexion conexion = new();
                MySqlCommand cmd = new("AltaUsuario", conexion.Conectar());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("xnombre", usuario.Nombre);
                cmd.Parameters.AddWithValue("xapellido", usuario.Apellido);
                cmd.Parameters.AddWithValue("xemail", usuario.Email);
                cmd.Parameters.AddWithValue("xpass", usuario.Password);

                cmd.ExecuteNonQuery();
                return (IEnumerable<UsuarioCE>)usuario;
            }
            catch (Exception ex)
            {
                return MessageBox.Show("Error no se pudo registrar", ex);
            }
        }

        //Traer las monedas del usuario

        public void CriptosDelUsuario(UsuarioMonedaCE usuarioMonedaCE, DataGridView tablaCriptoUsuario)
        {
            try
            {
                Conexion objetoConectar = new Conexion();

                string query = @"
                    SELECT M.nombre AS 'Criptomoneda', UM.cantidad AS 'Cantidad'
                    FROM UsuarioMoneda UM
                    JOIN Moneda M USING(idMoneda)
                    WHERE idUsuario = @idUsuario;
                ";
                
                tablaCriptoUsuario.DataSource = null;
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, objetoConectar.Conectar());
                adapter.SelectCommand.Parameters.AddWithValue("@idUsuario", usuarioMonedaCE.idUsuario);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                tablaCriptoUsuario.DataSource = dt;

                objetoConectar.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo mostrar las criptos: " + ex.Message);
            }
        }

        internal bool CompraCripto(UsuarioMonedaCE UsuarioMonedaE,UsuarioCE usuarioE, decimal cantidad )
        {
            try
            {
                Conexion conexion = new();
                MySqlCommand cmd = new MySqlCommand("ComprarMoneda", conexion.Conectar());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("xidusuario", usuarioE.idUsuario);
                cmd.Parameters.AddWithValue("xcantidad", cantidad);
                cmd.Parameters.AddWithValue("xidmoneda", UsuarioMonedaE. idMoneda);

                int rowsAffected = cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        internal int ObtenerIdUsuario(UsuarioCE usuario)
        {
            try
            {
                Conexion conexion = new Conexion();
                MySqlCommand cmd = new MySqlCommand("ObtenerIdUsuario", conexion.Conectar());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("xnombre", usuario.Nombre);
                cmd.Parameters.AddWithValue("xapellido", usuario.Apellido);
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
