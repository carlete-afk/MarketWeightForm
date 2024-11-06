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
            /*
                TODO:
                    si login no fue existoso:
                        error.
                    sino:
                        vvvv
             */

            frmTablaCripto frmTablaCripto = new frmTablaCripto();
            frmTablaCripto.Show();

            Hide();
        }
    }
}
