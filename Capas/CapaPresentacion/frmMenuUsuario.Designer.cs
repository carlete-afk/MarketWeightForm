namespace CapaPresentacion
{
    partial class frmMenuUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuUsuario));
            titulo = new Label();
            pictureBox1 = new PictureBox();
            btnTransferir = new Button();
            btnCompraVenta = new Button();
            btnTablaCripto = new Button();
            btnCerrarSesion = new Button();
            btnHistorial = new Button();
            lblSaldo = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // titulo
            // 
            titulo.AutoSize = true;
            titulo.Font = new Font("Sitka Small", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titulo.ForeColor = Color.White;
            titulo.Location = new Point(12, 32);
            titulo.Name = "titulo";
            titulo.Size = new Size(274, 71);
            titulo.TabIndex = 1;
            titulo.Text = "Buen día!";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(507, 114);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(252, 285);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // btnTransferir
            // 
            btnTransferir.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTransferir.Location = new Point(12, 210);
            btnTransferir.Name = "btnTransferir";
            btnTransferir.Size = new Size(206, 37);
            btnTransferir.TabIndex = 5;
            btnTransferir.Text = "Transferir";
            btnTransferir.UseVisualStyleBackColor = true;
            btnTransferir.Click += btnTransferir_Click;
            // 
            // btnCompraVenta
            // 
            btnCompraVenta.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCompraVenta.Location = new Point(12, 167);
            btnCompraVenta.Name = "btnCompraVenta";
            btnCompraVenta.Size = new Size(206, 37);
            btnCompraVenta.TabIndex = 4;
            btnCompraVenta.Text = "Comprar y Vender";
            btnCompraVenta.UseVisualStyleBackColor = true;
            btnCompraVenta.Click += btnCompraVenta_Click;
            // 
            // btnTablaCripto
            // 
            btnTablaCripto.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTablaCripto.Location = new Point(249, 167);
            btnTablaCripto.Name = "btnTablaCripto";
            btnTablaCripto.Size = new Size(206, 37);
            btnTablaCripto.TabIndex = 7;
            btnTablaCripto.Text = "Criptomonedas";
            btnTablaCripto.UseVisualStyleBackColor = true;
            btnTablaCripto.Click += btnTablaCripto_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCerrarSesion.Location = new Point(138, 341);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(206, 37);
            btnCerrarSesion.TabIndex = 8;
            btnCerrarSesion.Text = "Cerrar Sesión";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // btnHistorial
            // 
            btnHistorial.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHistorial.Location = new Point(249, 210);
            btnHistorial.Name = "btnHistorial";
            btnHistorial.Size = new Size(206, 37);
            btnHistorial.TabIndex = 9;
            btnHistorial.Text = "Mi Historial";
            btnHistorial.UseVisualStyleBackColor = true;
            btnHistorial.Click += btnHistorial_Click;
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Font = new Font("Microsoft Tai Le", 12F);
            lblSaldo.ForeColor = Color.White;
            lblSaldo.Location = new Point(12, 114);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(121, 21);
            lblSaldo.TabIndex = 32;
            lblSaldo.Text = "Tu saldo es de 0";
            lblSaldo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 253);
            button1.Name = "button1";
            button1.Size = new Size(206, 37);
            button1.TabIndex = 33;
            button1.Text = "Depositar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmMenuUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(lblSaldo);
            Controls.Add(btnHistorial);
            Controls.Add(btnCerrarSesion);
            Controls.Add(btnTablaCripto);
            Controls.Add(pictureBox1);
            Controls.Add(btnTransferir);
            Controls.Add(btnCompraVenta);
            Controls.Add(titulo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmMenuUsuario";
            Text = "MarketWeight";
            Load += MenuUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titulo;
        private PictureBox pictureBox1;
        private Button btnTransferir;
        private Button btnCompraVenta;
        private Button btnTablaCripto;
        private Button btnCerrarSesion;
        private Button btnHistorial;
        private Label lblSaldo;
        private Button button1;
    }
}