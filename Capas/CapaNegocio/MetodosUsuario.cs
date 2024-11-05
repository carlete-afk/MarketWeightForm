using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa


namespace CapaNegocio
{
    internal class MetodosUsuario
    {
        public void MostrarUsuarios(DataGridView tablaUsuarios)
        {
            try
            {
                Conexion objetoConectar = new Conexion();

                string query = "SELECT * FROM Usuario;";
                tablaUsuarios.DataSource = null;
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, objetoConectar.Conectar());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                tablaUsuarios.DataSource = dt;
                objetoConectar.CerraConexion();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo mostrar los usuarios" + ex.ToString());
            }
        }
    }
}
