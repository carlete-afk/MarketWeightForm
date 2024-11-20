using CapaEntidad;

namespace CapaPresentacion
{
    public partial class frmCompraVenta : Form
    {
        bool compra = true;
        bool click = false;

        public frmCompraVenta()
        {
            InitializeComponent();
        }

        private void CambiarCompraVenta(bool compra)
        {
            if (compra)
            {
                lblCompraVenta.Text = "Comprando";
                btnCambiarTransaccion.Text = "Cambiar a Venta";
                btnConfirmar.Text = "Comprar";
                Global.capaDatosM.TraerCriptos(dgvTabla);
                Global.DgvFormato(dgvTabla, "Cotización", "Cantidad");
            }

            else
            {
                lblCompraVenta.Text = "Vendiendo";
                btnCambiarTransaccion.Text = "Cambiar a Compra";
                btnConfirmar.Text = "Vender";
                Global.capaDatosU.CriptosDelUsuario(dgvTabla);
                Global.DgvFormato(dgvTabla, "Cotización", "Cantidad");
            }
        }

        private void frmCompraVenta_Load(object sender, EventArgs e)
        {
            lblCriptoActual.Text = "";
            Global.capaDatosM.TraerCriptos(dgvTabla);
            Global.DgvFormato(dgvTabla, "Cotización", "Cantidad");

            Global.capaDatosU.ActualizarSaldo();
            lblSaldo.Text = $"Tu saldo es de {UsuarioCE.userMain.Saldo:F3} USDT.";
            dgvTabla.ClearSelection();
        }

        private void btnCambiarTransaccion_Click(object sender, EventArgs e)
        {
            compra = !compra;
            CambiarCompraVenta(compra);

        }

        private void dgvTabla_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex > -1)
            {
                click = true;
                lblCriptoActual.Text = dgvTabla.CurrentCell.Value.ToString();
            }

            else
            {
                dgvTabla.ClearSelection();
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string celda = dgvTabla.CurrentCell.Value.ToString();

            if (click && string.IsNullOrWhiteSpace(inputCantidad.Text) == false)
            {
                bool x;
                try
                {
                    if (compra)
                    {
                        x = Global.capaDatosU.CompraCripto(celda, UsuarioCE.userMain, Convert.ToDecimal(inputCantidad.Text));
                        Global.capaDatosM.TraerCriptos(dgvTabla);
                        Global.DgvFormato(dgvTabla, "Cotización", "Cantidad");
                    }

                    else
                    {
                        x = Global.capaDatosU.VenderCripto(celda, UsuarioCE.userMain, Convert.ToDecimal(inputCantidad.Text));
                        Global.capaDatosU.CriptosDelUsuario(dgvTabla);
                        Global.DgvFormato(dgvTabla, "Cotización", "Cantidad");
                    }

                    if (x) MessageBox.Show("Venta realizada con éxito!");

                    inputCantidad.Text = "";

                    Global.capaDatosU.ActualizarSaldo();
                    lblSaldo.Refresh();
                    lblCriptoActual.Refresh();
                }

                catch (Exception ex)
                {
                    MessageBox.Show($"Cantidad: {inputCantidad.Text}\nCelda: {celda}\n\n" + ex.Message, "Error!");
                }
            }

            else
            {
                MessageBox.Show("Recuerda:\n\n Selecciona una cripto en la tabla.\nEstablece el monto que vas a comprar/vender.", "Error!");
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
