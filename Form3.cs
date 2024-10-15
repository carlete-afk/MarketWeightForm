using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketWeightForm
{
    public partial class MostrarUsuarios : Form
    {
        public MostrarUsuarios()
        {
            InitializeComponent();
        }

        private void MostrarUsuarios_Load(object sender, EventArgs e)
        {
            Conexion bdConnection = new Conexion();
            MySqlConnection conn = bdConnection.Conectar();
            TraerTablaUsuarios(conn);
        }

        internal bool TraerTablaUsuarios(MySqlConnection conn)
        {
            try
            {
                // Consulta para obtener los datos de la tabla Piloto
                string query = "SELECT * FROM Usuario;";

                MySqlDataAdapter adaptador = new MySqlDataAdapter(query,conn);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                MessageBox.Show("Filas encontradas: " + dt.Rows.Count);
                dataGridViewUsuarios.DataSource = dt;

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al traer los Usuarios: " + ex.Message);
                return false;
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void dataGridViewUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
