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
            MonedaCD capaDatos = new();

            capaDatos.TraerCriptos(dgvTabla);
        }

        private void btnMisCriptos_Click(object sender, EventArgs e)
        {
            UsuarioCD capaDatos = new();

            capaDatos.CriptosDelUsuario(dgvTabla);
        }

        private void btnBuscarCripto_Click(object sender, EventArgs e)
        {

        }

        private void inputSearch_TextChanged(object sender, EventArgs e)
        {
            MonedaCD capaDatos = new();

            capaDatos.BuscarCriptos(inputSearch.Text, dgvTabla);
        }
    }
}
