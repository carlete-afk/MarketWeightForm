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
    public class UsuarioCD
    {
        //Ingreso de login
        public bool UsuarioLogin (UsuarioCE usuario)
        {
            try
            {
                Conexion objetoConectar = new Conexion();
                string query = $"SELECT * FROM Usuario WHERE email = @email AND pass = @Password;";

                //Uso de parametros
                MySqlCommand cmd = new MySqlCommand(query, objetoConectar.Conectar());
                cmd.Parameters.AddWithValue("@Email", usuario.Email);
                cmd.Parameters.AddWithValue("@Password", usuario.Password);


                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                objetoConectar.CerrarConexion();


                return dt.Rows.Count > 0;
            }
            catch(Exception)
            {
                return false;
            }
        }

        //Registro
        public bool UsuarioRegistro(UsuarioCE usuario)
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

                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error! \n\n{ex} ");
                return false;
            }
        }

        //Traer las monedas del usuario

        internal void CriptosDelUsuario(UsuarioMonedaCE usuarioMonedaCE, DataGridView tablaCriptoUsuario)
        {
            try
            {
                Conexion objetoConectar = new Conexion();

              
                string query = "SELECT M.nombre, UM.cantidad FROM UsuarioMoneda UM JOIN Moneda M USING(idMoneda) WHERE idUsuario = @idUsuario;";

                
                tablaCriptoUsuario.DataSource = null;
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, objetoConectar.Conectar());
                adapter.SelectCommand.Parameters.AddWithValue("@idUsuario", usuarioMonedaCE.idUsuario);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                tablaCriptoUsuario.DataSource = dt;

                objetoConectar.CerraConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo mostrar las criptos: " + ex.Message);
            }
        }

    }
}
