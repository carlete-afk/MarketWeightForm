using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class MonedaCE
    {
        public int idMoneda { get; set; }
        public required decimal Precio { get; set; }
        public required decimal Cantidad { get; set; }
        public required string Nombre { get; set; }
    }
}
