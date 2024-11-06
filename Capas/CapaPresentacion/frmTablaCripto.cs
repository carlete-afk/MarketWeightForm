using CapaDatos;
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
    public partial class frmTablaCripto : Form
    {
        public frmTablaCripto()
        {
            InitializeComponent();
        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void btnMostrarCriptos_Click(object sender, EventArgs e)
        {
            MonedaCD cripto1 = new();

            cripto1.TraerCriptos(dgvTabla);
        }

        private void btnMisCriptos_Click(object sender, EventArgs e)
        {
            UsuarioCD cripto1 = new();

            cripto1.CriptosDelUsuario(UsuarioMonedaCE.idUsuario);
        }
    }
}
