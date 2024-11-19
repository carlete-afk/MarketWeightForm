using CapaDatos;
using CapaEntidad;
using System.Data.Common;

namespace CapaPresentacion
{
    public partial class frmTransferencia : Form
    {
        bool x = false;

        public frmTransferencia()
        {
            InitializeComponent();
        }

        private void ResetInputs()
        {
            inputCantidad.Text = "";
            inputEmail.Text = "";
        }

        private void frmTransferencia_Load(object sender, EventArgs e)
        {
            lblCriptoActual.Text = "";
            UsuarioCD capaDatos = new();
            capaDatos.CriptosDelUsuario(dgvTabla);
            dgvTabla.Columns["Cotización"].DefaultCellStyle.Format = "F3";
            dgvTabla.Columns["Cantidad"].DefaultCellStyle.Format = "F3";
            dgvTabla.ClearSelection();
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
            {
                x = true;
                lblCriptoActual.Text = dgvTabla.CurrentCell.Value.ToString();
            }

            else
                dgvTabla.ClearSelection();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            UsuarioCD capaDatos = new();
            bool y;

            try
            {
                if (x == false || string.IsNullOrWhiteSpace(inputCantidad.Text) || string.IsNullOrWhiteSpace(inputEmail.Text) || Convert.ToDecimal(inputCantidad.Text) <= 0)
                {
                    MessageBox.Show("Recuerda:\nSelecciona una cripto en la tabla.\nColoca un email válido.\nEstablecer el monto.\nEl monto tiene que ser mayor a cero", "Error!");
                }

                else
                {
                    y = capaDatos.TransferirCripto(dgvTabla.CurrentCell.Value.ToString(), UsuarioCE.userMain, Convert.ToDecimal(inputCantidad.Text), inputEmail.Text);

                    if (y) MessageBox.Show("Transferencia realizada correctamente!");
                    ResetInputs();
                }
            }

            catch (DbException ex)
            {
                MessageBox.Show("Error!\n\n" + ex.Message);
            }

            finally
            {
                capaDatos.CriptosDelUsuario(dgvTabla);
                dgvTabla.ClearSelection();
            }
        }

        private void dgvTabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
