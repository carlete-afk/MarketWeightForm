using CapaEntidad;
using MySql.Data.MySqlClient;
using System.Data;
using System.Security.Cryptography;
using System.Text;

namespace CapaDatos
{
    public class UsuarioCD
    {
        private static string HashPassword(string password)
        {
            // Esta funcion recibe string y devuelve un HASH con el método SHA256.

            using SHA256 sha256Hash = SHA256.Create();
            byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < bytes.Length; i++)
            {
                builder.Append(bytes[i].ToString("x2"));
            }
            return builder.ToString();
        }

        //Ingreso de login
        public UsuarioCE UsuarioLogin(string email, string pass)
        {
            pass = HashPassword(pass);

            try
            {
                Conexion objetoConectar = new Conexion();

                string query = $"SELECT * FROM Usuario WHERE email = @Email AND pass = @Password;";

                MySqlCommand cmd = new MySqlCommand(query, objetoConectar.Conectar());
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Password", pass);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    UsuarioCE usuario = new UsuarioCE
                    {
                        idUsuario = reader.GetInt32("idUsuario"),
                        Nombre = reader.GetString("Nombre"),
                        Apellido = reader.GetString("Apellido"),
                        Email = reader.GetString("Email"),
                        Password = reader.GetString("pass"),
                        Saldo = reader.GetDecimal("Saldo")
                    };

                    reader.Close();
                    objetoConectar.CerrarConexion();

                    return usuario;
                }
                else
                {
                    reader.Close();
                    objetoConectar.CerrarConexion();
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error! \n\n{ex} ");
                return null;
            }
        }

        public UsuarioCE UsuarioRegistro(UsuarioCE usuario)
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

                UsuarioCE.userMain = usuario;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error no se pudo registrar\n" + ex.Message);
            }

            return usuario;
        }

        public void CriptosDelUsuario(DataGridView tablaCriptoUsuario)
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
                adapter.SelectCommand.Parameters.AddWithValue("@idUsuario", UsuarioCE.userMain.idUsuario);
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

        internal bool CompraCripto(MonedaCE MonedaE, UsuarioCE usuarioE, decimal cantidad)
        {
            try
            {
                Conexion conexion = new();
                MySqlCommand cmd = new MySqlCommand("ComprarMoneda", conexion.Conectar());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("xidusuario", usuarioE.idUsuario);
                cmd.Parameters.AddWithValue("xcantidad", cantidad);
                cmd.Parameters.AddWithValue("xidmoneda", MonedaE.idMoneda);

                int rowsAffected = cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        internal bool VenderCripto(MonedaCE MonedaE, UsuarioCE usuarioE, decimal cantidad)
        {
            try
            {
                Conexion conexion = new();
                MySqlCommand cmd = new MySqlCommand("VenderMoneda", conexion.Conectar());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("xidusuario", usuarioE.idUsuario);
                cmd.Parameters.AddWithValue("xcantidad", cantidad);
                cmd.Parameters.AddWithValue("xidmoneda", MonedaE.idMoneda);

                int rowsAffected = cmd.ExecuteNonQuery();


                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        internal bool TransferirCripto(MonedaCE MonedaE, UsuarioCE usuarioE, decimal cantidad, string emailUsuarioTransferido)
        {
            try
            {
                Conexion conexion = new();
                MySqlCommand cmd = new MySqlCommand("Transferencia", conexion.Conectar());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("xidusuario", usuarioE.idUsuario);
                cmd.Parameters.AddWithValue("xcantidad", cantidad);
                cmd.Parameters.AddWithValue("xidmoneda", MonedaE.idMoneda);

                int rowsAffected = cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public int ObtenerIdUsuario(UsuarioCE usuario)
        {
            try
            {
                Conexion conexion = new Conexion();
                MySqlCommand cmd = new MySqlCommand("ObtenerIdUsuario", conexion.Conectar());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("xemail", usuario.Email);
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
