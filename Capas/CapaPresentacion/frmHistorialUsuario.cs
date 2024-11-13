using CapaDatos;
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
    public partial class frmHistorialUsuario : Form
    {
        public frmHistorialUsuario()
        {
            InitializeComponent();
        }

        private void frmHistorialUsuario_Load(object sender, EventArgs e)
        {
            inputSearch.Text = "";

            UsuarioCD capaDatos = new();
            capaDatos.HistorialUsuario(inputSearch.Text, dgvTabla);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmMenuUsuario frmMenuUsuario = new();
            frmMenuUsuario.Show();
            Close();
        }

        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            Close();
            frmMenuUsuario frmMenuUsuario = new();
            frmMenuUsuario.Show();
        }

        private void inputSearch_TextChanged(object sender, EventArgs e)
        {
            UsuarioCD capaDatos = new();
            capaDatos.HistorialUsuario(inputSearch.Text, dgvTabla);
        }
    }
}
