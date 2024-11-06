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
        public UsuarioCE ObtenerIdUsuario(UsuarioCE Usuario1)
        {
            Usuario1.idUsuario = Convert.ToInt32(ObtenerIdUsuario(Usuario1));

            return Usuario1;
        }
    }
}
