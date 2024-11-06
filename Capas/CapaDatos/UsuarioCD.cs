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
    internal class UsuarioCD
    {
        //Ingreso de login
        internal bool UsuarioLogin (UsuarioCE usuario)
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

                objetoConectar.CerraConexion();


                return dt.Rows.Count > 0;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        //Registro
        internal bool UsuarioRegistro(UsuarioCE usuario)
        {
            try
            {
                Conexion conexion = new Conexion();
                MySqlCommand cmd = new MySqlCommand("AltaUsuario", conexion.Conectar());
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
                return false;
            }
        }
    }
}
