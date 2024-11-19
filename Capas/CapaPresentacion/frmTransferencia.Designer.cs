namespace CapaPresentacion
{
    partial class frmTransferencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTransferencia));
            lblCompraVenta = new Label();
            lblCantidad = new Label();
            inputCantidad = new TextBox();
            lblEmail = new Label();
            inputEmail = new TextBox();
            dgvTabla = new DataGridView();
            btnConfirmar = new Button();
            btnVolver = new Button();
            lblCriptoActual = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTabla).BeginInit();
            SuspendLayout();
            // 
            // lblCompraVenta
            // 
            lblCompraVenta.AutoSize = true;
            lblCompraVenta.Font = new Font("Sitka Small", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCompraVenta.ForeColor = Color.White;
            lblCompraVenta.Location = new Point(8, 12);
            lblCompraVenta.Name = "lblCompraVenta";
            lblCompraVenta.Size = new Size(384, 71);
            lblCompraVenta.TabIndex = 21;
            lblCompraVenta.Text = "Transfiriendo";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Microsoft Tai Le", 12F);
            lblCantidad.ForeColor = Color.White;
            lblCantidad.Location = new Point(67, 147);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(72, 21);
            lblCantidad.TabIndex = 28;
            lblCantidad.Text = "Cantidad";
            // 
            // inputCantidad
            // 
            inputCantidad.Font = new Font("Microsoft Tai Le", 12F);
            inputCantidad.Location = new Point(67, 171);
            inputCantidad.Name = "inputCantidad";
            inputCantidad.Size = new Size(248, 28);
            inputCantidad.TabIndex = 27;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Microsoft Tai Le", 12F);
            lblEmail.ForeColor = Color.White;
            lblEmail.Location = new Point(67, 223);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(190, 21);
            lblEmail.TabIndex = 26;
            lblEmail.Text = "Email de la cuenta destino";
            // 
            // inputEmail
            // 
            inputEmail.Font = new Font("Microsoft Tai Le", 12F);
            inputEmail.Location = new Point(67, 247);
            inputEmail.Name = "inputEmail";
            inputEmail.Size = new Size(248, 28);
            inputEmail.TabIndex = 25;
            // 
            // dgvTabla
            // 
            dgvTabla.AllowUserToAddRows = false;
            dgvTabla.AllowUserToDeleteRows = false;
            dgvTabla.BackgroundColor = Color.LightSteelBlue;
            dgvTabla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTabla.Location = new Point(401, 12);
            dgvTabla.Name = "dgvTabla";
            dgvTabla.ReadOnly = true;
            dgvTabla.RowHeadersVisible = false;
            dgvTabla.Size = new Size(387, 426);
            dgvTabla.TabIndex = 31;
            dgvTabla.CellContentClick += dgvTabla_CellContentClick;
            dgvTabla.CellMouseClick += dgvTabla_CellMouseClick;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConfirmar.Location = new Point(103, 334);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(179, 37);
            btnConfirmar.TabIndex = 32;
            btnConfirmar.Text = "Enviar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Sitka Text", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVolver.Location = new Point(12, 409);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(114, 29);
            btnVolver.TabIndex = 33;
            btnVolver.Text = "Volver al Menu";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // lblCriptoActual
            // 
            lblCriptoActual.AutoSize = true;
            lblCriptoActual.Font = new Font("Sitka Small", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCriptoActual.ForeColor = Color.White;
            lblCriptoActual.Location = new Point(12, 83);
            lblCriptoActual.Name = "lblCriptoActual";
            lblCriptoActual.Size = new Size(156, 48);
            lblCriptoActual.TabIndex = 34;
            lblCriptoActual.Text = "ejemplo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Tai Le", 12F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(85, 310);
            label1.Name = "label1";
            label1.Size = new Size(218, 21);
            label1.TabIndex = 35;
            label1.Text = "Selecciona la cripto en la tabla";
            // 
            // frmTransferencia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(lblCriptoActual);
            Controls.Add(btnVolver);
            Controls.Add(btnConfirmar);
            Controls.Add(dgvTabla);
            Controls.Add(lblCantidad);
            Controls.Add(inputCantidad);
            Controls.Add(lblEmail);
            Controls.Add(inputEmail);
            Controls.Add(lblCompraVenta);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmTransferencia";
            Text = "MarketWeight";
            Load += frmTransferencia_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTabla).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCompraVenta;
        private Label lblCantidad;
        private TextBox inputCantidad;
        private Label lblEmail;
        private TextBox inputEmail;
        private DataGridView dgvTabla;
        private Button btnConfirmar;
        private Button btnVolver;
        private Label lblCriptoActual;
        private Label label1;
    }
}