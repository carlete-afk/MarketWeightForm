using CapaDatos;
using CapaEntidad;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    internal class MonedaCN
    {
        public MonedaCE ObtenerIdMoneda(MonedaCE Moneda1)
        {
            Moneda1.idMoneda = Convert.ToInt32(ObtenerIdMoneda(Moneda1));

            return Moneda1;
        }
    }
}
