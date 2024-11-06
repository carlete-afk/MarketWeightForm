using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class UsuarioMonedaCE
    {
        public UInt128 idUsuario { get; set; }
        public UInt128 idMoneda { get; set; }
        public decimal Cantidad { get; set; }
    }
}
