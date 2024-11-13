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
        public uint ObtenerIdUsuario(UsuarioCE user)
        {
            UsuarioCD capaDatos = new UsuarioCD();
            
            uint id = capaDatos.ObtenerIdUsuario(user.Email);

            return id;
        }
        
        public UsuarioCE CrearUsuario(string nombre, string apellido, string email, string password, decimal saldo)
        {
            UsuarioCE user = new UsuarioCE()
            {
                idUsuario = 0,
                Nombre = nombre,
                Apellido = apellido,
                Email = email,
                Password = password,
                Saldo = saldo
            };

            user.idUsuario = ObtenerIdUsuario(user);

            return user;
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
