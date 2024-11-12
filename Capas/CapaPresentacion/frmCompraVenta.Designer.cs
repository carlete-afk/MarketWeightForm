namespace CapaPresentacion
{
    partial class frmCompraVenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCambiarTransaccion = new Button();
            dgvTabla = new DataGridView();
            lblCompraVenta = new Label();
            lblCantidad = new Label();
            inputCantidad = new TextBox();
            btnConfirmar = new Button();
            label1 = new Label();
            lblCriptoActual = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTabla).BeginInit();
            SuspendLayout();
            // 
            // btnCambiarTransaccion
            // 
            btnCambiarTransaccion.Font = new Font("Sitka Text", 9.749999F);
            btnCambiarTransaccion.Location = new Point(12, 167);
            btnCambiarTransaccion.Name = "btnCambiarTransaccion";
            btnCambiarTransaccion.Size = new Size(135, 30);
            btnCambiarTransaccion.TabIndex = 18;
            btnCambiarTransaccion.Text = "Cambiar a Venta";
            btnCambiarTransaccion.UseVisualStyleBackColor = true;
            btnCambiarTransaccion.Click += btnCambiarTransaccion_Click;
            // 
            // dgvTabla
            // 
            dgvTabla.AllowUserToAddRows = false;
            dgvTabla.AllowUserToDeleteRows = false;
            dgvTabla.BackgroundColor = Color.LightSteelBlue;
            dgvTabla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTabla.Location = new Point(342, 12);
            dgvTabla.Name = "dgvTabla";
            dgvTabla.ReadOnly = true;
            dgvTabla.Size = new Size(446, 426);
            dgvTabla.TabIndex = 19;
            dgvTabla.CellMouseClick += dgvTabla_CellMouseClick;
            // 
            // lblCompraVenta
            // 
            lblCompraVenta.AutoSize = true;
            lblCompraVenta.Font = new Font("Sitka Small", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCompraVenta.ForeColor = Color.White;
            lblCompraVenta.Location = new Point(2, 12);
            lblCompraVenta.Name = "lblCompraVenta";
            lblCompraVenta.Size = new Size(324, 71);
            lblCompraVenta.TabIndex = 20;
            lblCompraVenta.Text = "Comprando";
            lblCompraVenta.Click += lblCompraVenta_Click;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Microsoft Tai Le", 12F);
            lblCantidad.ForeColor = Color.White;
            lblCantidad.Location = new Point(10, 294);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(72, 21);
            lblCantidad.TabIndex = 26;
            lblCantidad.Text = "Cantidad";
            // 
            // inputCantidad
            // 
            inputCantidad.Font = new Font("Microsoft Tai Le", 12F);
            inputCantidad.Location = new Point(88, 291);
            inputCantidad.Name = "inputCantidad";
            inputCantidad.Size = new Size(179, 28);
            inputCantidad.TabIndex = 25;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Font = new Font("Sitka Text", 14.2499981F);
            btnConfirmar.Location = new Point(12, 388);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(157, 50);
            btnConfirmar.TabIndex = 27;
            btnConfirmar.Text = "Comprar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Tai Le", 12F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 232);
            label1.Name = "label1";
            label1.Size = new Size(218, 21);
            label1.TabIndex = 28;
            label1.Text = "Selecciona la cripto en la tabla";
            // 
            // lblCriptoActual
            // 
            lblCriptoActual.AutoSize = true;
            lblCriptoActual.Font = new Font("Sitka Small", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCriptoActual.ForeColor = Color.White;
            lblCriptoActual.Location = new Point(3, 79);
            lblCriptoActual.Name = "lblCriptoActual";
            lblCriptoActual.Size = new Size(54, 71);
            lblCriptoActual.TabIndex = 29;
            lblCriptoActual.Text = "1";
            lblCriptoActual.Click += label2_Click;
            // 
            // frmCompraVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(800, 450);
            Controls.Add(lblCriptoActual);
            Controls.Add(label1);
            Controls.Add(btnConfirmar);
            Controls.Add(lblCantidad);
            Controls.Add(inputCantidad);
            Controls.Add(lblCompraVenta);
            Controls.Add(dgvTabla);
            Controls.Add(btnCambiarTransaccion);
            Name = "frmCompraVenta";
            Text = "frmCompraVenta";
            Load += frmCompraVenta_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTabla).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCambiarTransaccion;
        private DataGridView dgvTabla;
        private Label lblCompraVenta;
        private Label lblCantidad;
        private TextBox inputCantidad;
        private Button btnConfirmar;
        private Label label1;
        private Label lblCriptoActual;
    }
}