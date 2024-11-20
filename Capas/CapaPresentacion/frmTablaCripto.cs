namespace CapaPresentacion
{
    public partial class frmTablaCripto : Form
    {

        public frmTablaCripto()
        {
            InitializeComponent();
        }

        private void btnMostrarCriptos_Click(object sender, EventArgs e)
        {
            Global.capaDatosM.TraerCriptos(dgvTabla);
            Global.DgvFormato(dgvTabla, "Cotización", "Cantidad");
        }

        private void btnMisCriptos_Click(object sender, EventArgs e)
        {
            Global.capaDatosU.CriptosDelUsuario(dgvTabla);
            Global.DgvFormato(dgvTabla, "Cotización", "Cantidad");
        }

        private void inputSearch_TextChanged(object sender, EventArgs e)
        {
            Global.capaDatosM.BuscarCriptos(inputSearch.Text, dgvTabla);
            Global.DgvFormato(dgvTabla, "Cotización", "Cantidad");
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmMenuUsuario frmMenuUsuario = new();
            frmMenuUsuario.Show();
            Close();
        }

        private void frmTablaCripto_Load(object sender, EventArgs e)
        {
            Global.capaDatosM.TraerCriptos(dgvTabla);
            Global.DgvFormato(dgvTabla, "Cotización", "Cantidad");
        }
    }
}
