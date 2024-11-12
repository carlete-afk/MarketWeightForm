using CapaNegocio;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void titulo_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Hide();
            frmMenuPrincipal frmMenuPrincipal = new();

            frmMenuPrincipal.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UsuarioCN capaNegocio = new();

            bool x = capaNegocio.EstablecerUsuarioDelLogin(inputEmail.Text, inputPassword.Text);

            if (x)
            {
                //frmTablaCripto frmTablaCripto = new frmTablaCripto();
                //frmTablaCripto.Show();

                frmCompraVenta frmCompraVenta = new();

                frmCompraVenta.Show();

                Hide();
            }

            else
            {
                resetInputs();
                MessageBox.Show("Error! Email o contraseña invalido, intente nuevamente.");
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
