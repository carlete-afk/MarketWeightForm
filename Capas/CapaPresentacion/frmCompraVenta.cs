using CapaDatos;
using CapaEntidad;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing.Drawing2D;

namespace CapaPresentacion
{
    public partial class frmCompraVenta : Form
    {
        bool compra = true;
        bool click = false;
        MonedaCD capaDatosM = new();
        UsuarioCD capaDatosU = new();

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
            lblCriptoActual.Text = "";
            capaDatosM.TraerCriptos(dgvTabla);

            dgvTabla.Columns["Cotización"].DefaultCellStyle.Format = "F3";
            dgvTabla.Columns["Cantidad"].DefaultCellStyle.Format = "F3";


            capaDatosU.ActualizarSaldo();
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
            UsuarioCD capaDatos = new();
            string celda = dgvTabla.CurrentCell.Value.ToString();

            if (click && string.IsNullOrWhiteSpace(inputCantidad.Text) == false)
            {
                bool x;
                try
                {
                    if (compra)
                    {
                        x = capaDatos.CompraCripto(celda, UsuarioCE.userMain, Convert.ToDecimal(inputCantidad.Text));
                        capaDatosM.TraerCriptos(dgvTabla);
                    }

                    else
                    {
                        x = capaDatos.VenderCripto(celda, UsuarioCE.userMain, Convert.ToDecimal(inputCantidad.Text));
                        capaDatosU.CriptosDelUsuario(dgvTabla);
                    }

                    if (x) MessageBox.Show("Venta realizada con éxito!");

                    inputCantidad.Text = "";
                    
                    capaDatosU.ActualizarSaldo();
                    lblSaldo.Refresh();
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
