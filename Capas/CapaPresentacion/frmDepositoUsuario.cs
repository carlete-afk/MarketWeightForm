using CapaDatos;
using CapaEntidad;
using System.Data.Common;
using System.Reflection.Metadata;

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
            UsuarioCD capaDatos = new();

            try
            {
                decimal monto = Convert.ToDecimal(inputMonto.Text);
                if (!string.IsNullOrWhiteSpace(inputMonto.Text) && monto > 0)
                {
                    capaDatos.IngresarDinero(UsuarioCE.userMain, Convert.ToDecimal(inputMonto.Text));
                    MessageBox.Show("El depósito se ha realizado correrectamente", "Depósito completado");
                    capaDatos.ActualizarSaldo();
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
            UsuarioCD capaDatos = new();
            capaDatos.ActualizarSaldo();
            lblSaldo.Text = $"Tu saldo es de {UsuarioCE.userMain.Saldo:F3} USDT.";
        }
    }
}
