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
    public partial class frmObtenerUsuarios : Form
    {
        public frmObtenerUsuarios()
        {
            InitializeComponent();
            MarketWeightForm.MarketWeight.Core.Usuario objetoUsuario = new MarketWeightForm.MarketWeight.Core.Usuario();
            objetoUsuario.MostrarUsuarios(dgvObtenerUsuarios);

        }

        private void dgvMostrarUsuarios(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmObtenerUsuarios_Load(object sender, EventArgs e)
        {

        }
    }
}
