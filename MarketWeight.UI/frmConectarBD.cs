using MarketWeightForm.MarketWeight.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketWeightForm
{
    public partial class frmConectarBD : Form
    {
        public frmConectarBD()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conexion bdConnection = new Conexion();
            bdConnection.Conectar();

            frmUserTabla Usuarios = new frmUserTabla();
            Usuarios.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }
    }
}
