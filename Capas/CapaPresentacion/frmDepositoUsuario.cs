using CapaEntidad;
using System.Data.Common;

namespace CapaPresentacion
{
    public partial class frmDepositoUsuario : Form
    {
        public frmDepositoUsuario()
        {
            InitializeComponent();
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            bool x;

            try
            {
                decimal monto = Convert.ToDecimal(inputMonto.Text);
                if (!string.IsNullOrWhiteSpace(inputMonto.Text) && monto > 0)
                {
                    x = Global.capaDatosU.IngresarDinero(UsuarioCE.userMain, Convert.ToDecimal(inputMonto.Text));

                    if (x)
                        MessageBox.Show("El depósito se ha realizado correctamente", "Depósito Completado");

                    Global.capaDatosU.ActualizarSaldo();
                    lblSaldo.Text = $"Tu saldo es de {UsuarioCE.userMain.Saldo:F3} USDT.";
                }

                else
                {
                    MessageBox.Show("Ingresa un número mayor a 0.");
                    inputMonto.Text = "";
                }
            }

            catch (FormatException)
            {
                MessageBox.Show("Ingresa un número mayor a 0.");
                inputMonto.Text = "";
            }

            catch (DbException ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmMenuUsuario frmMenuUsuario = new();
            frmMenuUsuario.Show();

            Close();
        }

        private void frmDepositoUsuario_Load(object sender, EventArgs e)
        {
            Global.capaDatosU.ActualizarSaldo();
            lblSaldo.Text = $"Tu saldo es de {UsuarioCE.userMain.Saldo:F3} USDT.";
        }

        private void inputMonto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
