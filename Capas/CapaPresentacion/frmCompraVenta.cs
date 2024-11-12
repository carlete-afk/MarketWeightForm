using CapaDatos;
using CapaNegocio;
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
    public partial class frmCompraVenta : Form
    {
        private bool _compra = true;
        MonedaCD capaDatosM = new();
        UsuarioCD capaDatosU = new();

        public frmCompraVenta()
        {
            InitializeComponent();
        }

        private void CambiarCompraVenta(bool compra)
        {
            


            if (_compra)
            {
                lblCompraVenta.Text = "Comprando";
                btnCambiarTransaccion.Text = "Cambiar a Venta";
                btnConfirmar.Text = "Comprar";
                capaDatosM.TraerCriptos(dgvTabla);
            }

            else
            {
                lblCompraVenta.Text = "Vendiendo";
                btnCambiarTransaccion.Text = "Cambiar a Compra";
                btnConfirmar.Text = "Vender";
                capaDatosU.CriptosDelUsuario(dgvTabla);
            }
        }

        private void titulo_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmCompraVenta_Load(object sender, EventArgs e)
        {
            capaDatosM.TraerCriptos(dgvTabla);
            lblCriptoActual.Text = "";
        }

        private void lblCompraVenta_Click(object sender, EventArgs e)
        {

        }

        private void btnCambiarTransaccion_Click(object sender, EventArgs e)
        {
            _compra = !_compra;
            CambiarCompraVenta(_compra);

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
            UsuarioCN capaNegocio = new();

            //TODO: if compra: comprar() else: vender()
        }
    }
}
