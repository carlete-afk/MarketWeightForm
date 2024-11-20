namespace CapaPresentacion
{
    public partial class frmHistorialUsuario : Form
    {
        public frmHistorialUsuario()
        {
            InitializeComponent();
        }

        private void frmHistorialUsuario_Load(object sender, EventArgs e)
        {
            inputSearch.Text = "";

            Global.capaDatosU.HistorialUsuario(inputSearch.Text, dgvTabla);
            Global.DgvFormato(dgvTabla, "Cantidad");
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmMenuUsuario frmMenuUsuario = new();
            frmMenuUsuario.Show();
            Close();
        }

        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            Close();
            frmMenuUsuario frmMenuUsuario = new();
            frmMenuUsuario.Show();
        }

        private void inputSearch_TextChanged(object sender, EventArgs e)
        {
            Global.capaDatosU.HistorialUsuario(inputSearch.Text, dgvTabla);
            Global.DgvFormato(dgvTabla, "Cantidad");
        }
    }
}
