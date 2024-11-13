using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmTransferencia : Form
    {
        public frmTransferencia()
        {
            InitializeComponent();
        }

        private void frmTransferencia_Load(object sender, EventArgs e)
        {
            lblCriptoActual.Text = "";
            UsuarioCD capaDatos = new();
            capaDatos.CriptosDelUsuario(dgvTabla);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmMenuUsuario frmMenuUsuario = new();
            frmMenuUsuario.Show();
            Close();
        }

        private void dgvTabla_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex > -1)
                lblCriptoActual.Text = dgvTabla.CurrentCell.Value.ToString();

            else
                dgvTabla.ClearSelection();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            UsuarioCD capaDatos = new();

            capaDatos.TransferirCripto(dgvTabla.CurrentCell.Value.ToString(), UsuarioCE.userMain, Convert.ToDecimal(inputCantidad.Text), inputEmail.Text);
        }
    }
}
