using CapaNegocio;

namespace CapaPresentacion
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            frmRegistro formRegistro = new();
            formRegistro.Show();

            Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmLogin formLogin = new();
            formLogin.Show();

            Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsuarioCN capaNegocio = new();

            capaNegocio.EstablecerUsuarioDelLogin("admin", "admin");
            frmMenuUsuario frmMenuUsuario = new frmMenuUsuario();
            frmMenuUsuario.Show();
            Hide();
        }
    }
}
