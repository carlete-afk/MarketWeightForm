using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
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
            lblSaldo.Text = $"Tu saldo es de {UsuarioCE.userMain.Saldo.ToString("F3")} USDT.";
            lblCriptoActual.Text = "";
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
            UsuarioCD capaDatos = new();

            if (_compra)
            {
                try
                {
                    capaDatos.CompraCripto(dgvTabla.CurrentCell.Value.ToString(), UsuarioCE.userMain, Convert.ToDecimal(inputCantidad.Text));

                    MessageBox.Show("Compra realizada con éxito!");

                    inputCantidad.Text = "";
                    capaDatosM.TraerCriptos(dgvTabla);
                    lblSaldo.Text = $"Tu saldo es de {UsuarioCE.userMain.Saldo.ToString("F3")} USDT.";
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error!\n\n" + ex.Message);
                }
            }

            else
            {
                try
                {
                    capaDatos.VenderCripto(dgvTabla.CurrentCell.Value.ToString(), UsuarioCE.userMain, Convert.ToDecimal(inputCantidad.Text));

                    MessageBox.Show("Venta realizada con éxito!");

                    inputCantidad.Text = "";
                    capaDatosU.CriptosDelUsuario(dgvTabla);
                    lblSaldo.Text = $"Tu saldo es de {UsuarioCE.userMain.Saldo.ToString("F3")} USDT.";
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error!\n\n" + ex.Message);
                }
                
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmMenuUsuario frmMenuUsuario = new();
            frmMenuUsuario.Show();
            Close();
        }
    }
}
