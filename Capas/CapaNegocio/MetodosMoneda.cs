using CapaDatos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    internal class MetodosMoneda
    {
        //Ingreso
        public void InsertarMoneda(decimal precio, decimal cantidad, string nombre)
        {
            try
            {
                Conexion objetoConectar = new Conexion();

                string query = $"INSERT INTO Moneda" +
                               $"VALUES ({precio}, {cantidad}, {nombre});";

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, objetoConectar.Conectar());

                objetoConectar.CerraConexion();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo insertar la moneda" + ex.ToString());
            }

        //Mostrar Cri
        }
    }
}
