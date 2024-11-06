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
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
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
            /*
                TODO:
                    si no registro fue existoso:
                        error
                    sino:
                        popup de confirmacion.
                        vvvv
             */


            frmTablaCripto frmTablaCripto = new frmTablaCripto();
            frmTablaCripto.Show();

            Hide();
        }
    }
}
