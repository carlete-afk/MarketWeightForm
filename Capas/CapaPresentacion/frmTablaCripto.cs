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
        UsuarioCD capaDatosU = new();
        MonedaCD capaDatosM = new();

        public frmTablaCripto()
        {
            InitializeComponent();
        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void btnMostrarCriptos_Click(object sender, EventArgs e)
        {
            capaDatosM.TraerCriptos(dgvTabla);
        }

        private void btnMisCriptos_Click(object sender, EventArgs e)
        {
            capaDatosU.CriptosDelUsuario(dgvTabla);
        }

        private void btnBuscarCripto_Click(object sender, EventArgs e)
        {

        }

        private void inputSearch_TextChanged(object sender, EventArgs e)
        {
            capaDatosM.BuscarCriptos(inputSearch.Text, dgvTabla);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmMenuUsuario frmMenuUsuario = new();
            frmMenuUsuario.Show();
            Close();
        }

        private void frmTablaCripto_Load(object sender, EventArgs e)
        {
            capaDatosM.TraerCriptos(dgvTabla);
            dgvTabla.Columns["Cotización"].DefaultCellStyle.Format = "F3";
            dgvTabla.Columns["Cantidad"].DefaultCellStyle.Format = "F3";
        }
    }
}
