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
    public class MetodosUsuario
    {
        public UsuarioCE ObtenerIdUsuario(UsuarioCE Usuario1)
        {
            //TODO: colocar un return bueno
            Usuario1.idUsuario = Convert.ToInt32(ObtenerIdUsuario(Usuario1));

            return Usuario1;
        }
        
        public UsuarioCE CrearUsuario(string nombre, string apellido, string email, string password, decimal saldo)
        {
            UsuarioCE Usuario1 = new UsuarioCE()
            {
                Nombre = nombre,
                Apellido = apellido,
                Email = email,
                Password = password,
                Saldo = saldo
            };

            return Usuario1;
        }
    }
}
