using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class UsuarioCE
    {
        public static UsuarioCE userMain = new()
        {
            idUsuario = 0,
            Nombre = "",
            Apellido = "",
            Email = "",
            Password = "",
            Saldo = 0
        };

        public uint idUsuario { get; set; }
        public required string Nombre { get; set; }
        public required string Apellido { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }
        public decimal Saldo { get; set; }
    }
}
