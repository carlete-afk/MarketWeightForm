using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaDatos;

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

        private void titulo_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void inputNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Hide();
            frmMenuPrincipal frmMenuPrincipal = new();

            frmMenuPrincipal.Show();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            MetodosUsuario user1 = new();

            UsuarioCD userCD = new UsuarioCD();

            bool x = userCD.UsuarioRegistro(user1.CrearUsuario(inputNombre.Text, inputApellido.Text, inputMail.Text, inputPassword.Text, 0));

            if(x)
            {
                frmTablaCripto frmTablaCripto = new frmTablaCripto();
                frmTablaCripto.Show();
                Hide();
            }
            else
                resetInputs();

        }

        private void frmRegistro_Load(object sender, EventArgs e)
        {

        }
    }
}
