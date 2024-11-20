using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }

        private void resetInputs()
        {
            inputNombre.Text = "";
            inputApellido.Text = "";
            inputMail.Text = "";
            inputPassword.Text = "";
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal frmMenuPrincipal = new();
            frmMenuPrincipal.Show();

            Close();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            bool x;
            UsuarioCN capaNegocio = new();

            if (!string.IsNullOrWhiteSpace(inputApellido.Text) &&
                !string.IsNullOrWhiteSpace(inputPassword.Text) &&
                !string.IsNullOrWhiteSpace(inputNombre.Text) &&
                !string.IsNullOrWhiteSpace(inputMail.Text)
                )
            {
                x = Global.capaDatosU.UsuarioRegistro(capaNegocio.CrearUsuario(
                        inputNombre.Text,
                        inputApellido.Text,
                        inputMail.Text,
                        inputPassword.Text,
                        0
                ));

                if (x)
                {
                    frmMenuUsuario frmMenuUsuario = new();
                    frmMenuUsuario.Show();
                    Close();

                }

                else resetInputs();

            }

            else
            {
                MessageBox.Show("Completa todos los campos!");
                resetInputs();
            }
        }
    }
}
