using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaEntidad;

namespace CapaPresentacion
{
    public partial class frmMenuUsuario : Form
    {
        public frmMenuUsuario()
        {
            InitializeComponent();
        }

        private void MenuUsuario_Load(object sender, EventArgs e)
        {
            UsuarioCD capaDatos = new();

            titulo.Text = $"Buen día {UsuarioCE.userMain.Nombre}!";
            capaDatos.ActualizarSaldo();
            lblSaldo.Text = $"Tu saldo es de {UsuarioCE.userMain.Saldo:F3} USDT.";
        }

        private void btnCompraVenta_Click(object sender, EventArgs e)
        {
            frmCompraVenta frmCompraVenta = new();
            frmCompraVenta.Show();
            Close();
        }

        private void btnTransferir_Click(object sender, EventArgs e)
        {
            frmTransferencia frmTransferencia = new();
            frmTransferencia.Show();
            Close();
        }

        private void btnTablaCripto_Click(object sender, EventArgs e)
        {
            frmTablaCripto frmTablaCripto = new();
            frmTablaCripto.Show();
            Close();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal frmMenuPrincipal = new();
            frmMenuPrincipal.Show();
            Close();
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            frmHistorialUsuario frmHistorialUsuario = new();
            frmHistorialUsuario.Show();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmDepositoUsuario frmDepositoUsuario = new();
            frmDepositoUsuario.Show();
            Close();
        }
    }
}
