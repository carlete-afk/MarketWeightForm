using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketWeightForm.MarketWeight.UI
{
    public partial class frmUserTabla : Form
    {
        Usuario user = new Usuario();

        public frmUserTabla()
        {
            InitializeComponent();
        }

        private void dgvMostrarUsuarios(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void frmObtenerUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string condicion = textBoxCondicion.Text;

            if (condicion.Trim().Length < 1)
                user.MostrarMonedas(dgvObtenerUsuarios);

            else
                user.ObtenerConCondicion(dgvObtenerUsuarios, condicion);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
