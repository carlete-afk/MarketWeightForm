namespace CapaPresentacion
{
    partial class frmDepositoUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDepositoUsuario));
            btnVolver = new Button();
            lblMonto = new Label();
            inputMonto = new TextBox();
            pictureBox1 = new PictureBox();
            btnDepositar = new Button();
            titulo = new Label();
            lblSaldo = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Sitka Text", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVolver.Location = new Point(32, 396);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(114, 29);
            btnVolver.TabIndex = 33;
            btnVolver.Text = "Volver al Menu";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Font = new Font("Microsoft Tai Le", 12F);
            lblMonto.ForeColor = Color.White;
            lblMonto.Location = new Point(145, 171);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(56, 21);
            lblMonto.TabIndex = 32;
            lblMonto.Text = "Monto";
            // 
            // inputMonto
            // 
            inputMonto.Font = new Font("Microsoft Tai Le", 12F);
            inputMonto.Location = new Point(145, 197);
            inputMonto.Name = "inputMonto";
            inputMonto.Size = new Size(222, 28);
            inputMonto.TabIndex = 31;
            inputMonto.TextChanged += inputMonto_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(516, 124);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(252, 285);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            // 
            // btnDepositar
            // 
            btnDepositar.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDepositar.Location = new Point(172, 269);
            btnDepositar.Name = "btnDepositar";
            btnDepositar.Size = new Size(159, 37);
            btnDepositar.TabIndex = 29;
            btnDepositar.Text = "Confirmar";
            btnDepositar.UseVisualStyleBackColor = true;
            btnDepositar.Click += btnDepositar_Click;
            // 
            // titulo
            // 
            titulo.AutoSize = true;
            titulo.Font = new Font("Sitka Small", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titulo.ForeColor = Color.White;
            titulo.Location = new Point(12, 9);
            titulo.Name = "titulo";
            titulo.Size = new Size(280, 71);
            titulo.TabIndex = 26;
            titulo.Text = "Depositar";
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Font = new Font("Microsoft Tai Le", 12F);
            lblSaldo.ForeColor = Color.White;
            lblSaldo.Location = new Point(25, 93);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(121, 21);
            lblSaldo.TabIndex = 34;
            lblSaldo.Text = "Tu saldo es de 0";
            lblSaldo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmDepositoUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(800, 450);
            Controls.Add(lblSaldo);
            Controls.Add(btnVolver);
            Controls.Add(lblMonto);
            Controls.Add(inputMonto);
            Controls.Add(pictureBox1);
            Controls.Add(btnDepositar);
            Controls.Add(titulo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmDepositoUsuario";
            Text = "MarketWeight";
            Load += frmDepositoUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVolver;
        private Label lblMonto;
        private TextBox inputMonto;
        private PictureBox pictureBox1;
        private Button btnDepositar;
        private Label titulo;
        private Label lblSaldo;
    }
}