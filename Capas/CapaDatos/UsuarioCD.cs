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
        internal void UsuarioLogin (UsuarioCE usuario)
        {
            try
            {
                Conexion objetoConectar = new Conexion();
                string query = $"SELECT * FROM Usuario WHERE email = {usuario.Email}";
            }
        }

        //Registro
        internal void Registro(UsuarioCE usuario)
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
                MessageBox.Show("Lograste registraste con exito!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo dar de alta el usuario| Error System!!!" + ex.ToString());
            }
        }
    }
}
