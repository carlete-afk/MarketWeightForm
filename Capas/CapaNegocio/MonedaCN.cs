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
            Moneda1.idMoneda = Convert.ToUInt32(ObtenerIdMoneda(Moneda1));

            return Moneda1;
        }

        public MonedaCE CrearMoneda(uint xidMoneda, decimal xprecio, decimal xcantidad, string xnombre)
        {
            MonedaCE Moneda1 = new MonedaCE()
            {
                idMoneda = xidMoneda,
                Precio = xprecio,
                Cantidad = xcantidad,
                Nombre = xnombre
            };

            return Moneda1;
        }



    }
}
