using CapaEntidad;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.Common;
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
                    UsuarioCE usuario = new()
                    {
                        idUsuario = reader.GetUInt32("idUsuario"),
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
            catch (DbException ex)
            {
                MessageBox.Show(ex.Message, "Error en UsuarioCD.UsuarioLogin");
                return null;
            }
        }

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

                UsuarioCE.userMain = usuario;
                UsuarioCE.userMain.idUsuario = ObtenerIdUsuario(usuario.Email);

                return true;
            }
            catch (DbException ex)
            {
                MessageBox.Show(ex.Message, "Error en UsuarioCD.UsuarioRegistro");
                return false;
            }
        }

        public void CriptosDelUsuario(DataGridView tablaCriptoUsuario)
        {
            try
            {
                Conexion objetoConectar = new Conexion();

                string query = @"
                    SELECT M.nombre 'Criptomoneda', UM.cantidad 'Cantidad', M.precio 'Cotización'
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
            catch (DbException ex)
            {
                MessageBox.Show(ex.Message, "Error en UsuarioCD.CriptosDelUsuario");
            }
        }

        public bool CompraCripto(string nombreMoneda, UsuarioCE usuarioE, decimal cantidad)
        {
            try
            {
                Conexion conexion = new();
                MySqlCommand cmd = new MySqlCommand("ComprarMoneda", conexion.Conectar());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("xidusuario", usuarioE.idUsuario);
                cmd.Parameters.AddWithValue("xcantidad", cantidad);
                cmd.Parameters.AddWithValue("xnombre", nombreMoneda);

                cmd.ExecuteNonQuery();

                return true;
            }

            catch (DbException ex)
            {
                MessageBox.Show(ex.Message, "Error en UsuarioCD.CompraCripto");
                return false;
            }
        }

        public bool VenderCripto(string nombreMoneda, UsuarioCE usuarioE, decimal cantidad)
        {
            try
            {
                Conexion conexion = new();
                MySqlCommand cmd = new MySqlCommand("VenderMoneda", conexion.Conectar());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("xidusuario", usuarioE.idUsuario);
                cmd.Parameters.AddWithValue("xcantidad", cantidad);
                cmd.Parameters.AddWithValue("xnombre", nombreMoneda);

                cmd.ExecuteNonQuery();

                return true;
            }

            catch (DbException ex)
            {
                MessageBox.Show(ex.Message, "Error en UsuarioCD.VenderCripto");
                return false;
            }
        }

        public bool TransferirCripto(string nombreMoneda, UsuarioCE usuarioE, decimal cantidad, string emailUsuarioTransferido)
        {
            try
            {
                Conexion conexion = new();
                MySqlCommand cmd = new("Transferencia", conexion.Conectar());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("xnombre", nombreMoneda);
                cmd.Parameters.AddWithValue("xcantidad", cantidad);
                cmd.Parameters.AddWithValue("xidUsuarioTransfiere", usuarioE.idUsuario);
                cmd.Parameters.AddWithValue("xemail", emailUsuarioTransferido);

                cmd.ExecuteNonQuery();
                conexion.CerrarConexion();

                return true;
            }

            catch (DbException ex)
            {
                MessageBox.Show(ex.Message, "Error en UsuarioCD.TransferirCripto");
                return false;
                
            }
        }

        public uint ObtenerIdUsuario(string email)
        {
            try
            {
                Conexion conexion = new Conexion();
                MySqlCommand cmd = new MySqlCommand("SELECT ObtenerIdUsuario(@xemail);", conexion.Conectar());

                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@xemail", email);

                var resultado = cmd.ExecuteScalar();

                if (resultado == DBNull.Value)
                {
                    return 0;
                }
                return Convert.ToUInt32(resultado);
            }

            catch (DbException ex)
            {
                MessageBox.Show(ex.Message, "Error en UsuarioCD.ObtenerIdUsuario");
                return 0;
            }
        }

        public bool IngresarDinero(UsuarioCE usuario, decimal saldo)
        {
            try
            {
                Conexion conexion = new();
                MySqlCommand cmd = new MySqlCommand("IngresarDinero", conexion.Conectar());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("xidusuario", usuario.idUsuario);
                cmd.Parameters.AddWithValue("xsaldo", saldo);

                cmd.ExecuteNonQuery();

                return true;
            }
            catch (DbException ex)
            {
                MessageBox.Show(ex.Message, "Error en UsuarioCD.IngresarDinero");
                return false;
            }
        }
        /*
        `idMoneda` INT UNSIGNED NOT NULL,
        `cantidad` DECIMAL(20,10) NOT NULL,
        `fechaHora` DATETIME NOT NULL,
        `compra` TINYINT UNSIGNED,*/
        public void HistorialUsuario(string input, DataGridView tablaHistorialUsuario)
        {
            try
            {
                Conexion objetoConectar = new Conexion();

                string query = @$"
                    SELECT M.nombre 'Criptomoneda', H.cantidad 'Cantidad', H.fechaHora 'Fecha', H.tipoAccion 'Tipo de accion'
                    FROM Historial H
                    JOIN Usuario U USING(idUsuario)
                    JOIN Moneda M USING(idMoneda)
                    WHERE idUsuario = @idUsuario
                    AND M.nombre LIKE '%{input}%';
                ";

                tablaHistorialUsuario.DataSource = null;
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, objetoConectar.Conectar());
                adapter.SelectCommand.Parameters.AddWithValue("@idUsuario", UsuarioCE.userMain.idUsuario);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                tablaHistorialUsuario.DataSource = dt;

                objetoConectar.CerrarConexion();
            }

            catch (DbException ex)
            {
                MessageBox.Show(ex.Message, "Error en UsuarioCD.HistorialUsuario");
            }
        }

        public void ActualizarSaldo()
        {
            Conexion conexion = new();
            var saldo = 0m;

            try
            {
                string query = @$"
                SELECT saldo
                FROM Usuario
                WHERE idUsuario = @idUsuario;
                ";
                MySqlCommand cmd = new(query, conexion.Conectar());

                cmd.Parameters.AddWithValue("@idUsuario", UsuarioCE.userMain.idUsuario);

                cmd.CommandType = CommandType.Text;

                saldo = Convert.ToDecimal(cmd.ExecuteScalar());
            }

            catch (DbException ex)
            {
                MessageBox.Show(ex.Message, "Error en UsuarioCD.ActualizarSaldo");
            }

            UsuarioCE.userMain.Saldo = saldo;
        }
    }
}
