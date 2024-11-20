using CapaNegocio;

namespace CapaPresentacion
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        public void resetInputs()
        {
            inputEmail.Text = "";
            inputPassword.Text = "";
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal frmMenuPrincipal = new();
            frmMenuPrincipal.Show();

            Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UsuarioCN capaNegocio = new();

            bool x = capaNegocio.EstablecerUsuarioDelLogin(inputEmail.Text, inputPassword.Text);

            if (x)
            {
                frmMenuUsuario frmMenuUsuario = new frmMenuUsuario();
                frmMenuUsuario.Show();
                Close();
            }

            else
            {
                resetInputs();
                MessageBox.Show("Email o contraseña invalido, intente nuevamente.", "Error!");
            }
        }
    }
}
