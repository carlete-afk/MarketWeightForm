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
    internal class MetodosUsuario
    {
        public void AltaUsuario(string nombre, string apellido, string email, string password, decimal? saldo)
        {
            UsuarioCE Usuario1 = new UsuarioCE()
            {
                Nombre = nombre,
                Apellido = apellido,
                Email = email,
                Password = password,
            };

            if (Convert.ToBoolean(saldo))
                Usuario1.Saldo = Convert.ToDecimal(saldo);

            UsuarioRegistro(Usuario1);
        }
    }
}
