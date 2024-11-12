using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;


namespace CapaNegocio
{
    public class UsuarioCN
    {
        public int ObtenerIdUsuario(UsuarioCE Usuario1)
        {
            UsuarioCD capaDatos = new UsuarioCD();
            //TODO: colocar un return bueno
            int id = Convert.ToInt32(capaDatos.ObtenerIdUsuario(Usuario1));

            return id;
        }
        
        public UsuarioCE CrearUsuario(string nombre, string apellido, string email, string password, decimal saldo)
        {
            UsuarioCE Usuario1 = new UsuarioCE()
            {
                idUsuario = 0,
                Nombre = nombre,
                Apellido = apellido,
                Email = email,
                Password = password,
                Saldo = saldo
            };

            Usuario1.idUsuario = ObtenerIdUsuario(Usuario1);

            return Usuario1;
        }

        public bool EstablecerUsuarioDelLogin(string email, string pass)
        {
            UsuarioCD capaDatos = new();

            UsuarioCE user = capaDatos.UsuarioLogin(email, pass);

            if (user is not null)
            {
                UsuarioCE.userMain = user;
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
