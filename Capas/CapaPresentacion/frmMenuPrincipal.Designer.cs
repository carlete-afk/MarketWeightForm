namespace CapaPresentacion
{
    partial class frmMenuPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            titulo = new Label();
            btnLogin = new Button();
            pictureBox1 = new PictureBox();
            btnRegistro = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // titulo
            // 
            titulo.AutoSize = true;
            titulo.Font = new Font("Sitka Small", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titulo.ForeColor = Color.White;
            titulo.Location = new Point(58, 139);
            titulo.Name = "titulo";
            titulo.Size = new Size(394, 71);
            titulo.TabIndex = 0;
            titulo.Text = "MarketWeight";
            titulo.Click += label1_Click;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(265, 263);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(159, 37);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Iniciar Sesion";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(502, 89);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(252, 285);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // btnRegistro
            // 
            btnRegistro.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegistro.Location = new Point(58, 263);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size = new Size(159, 37);
            btnRegistro.TabIndex = 1;
            btnRegistro.Text = "Registrate";
            btnRegistro.UseVisualStyleBackColor = true;
            btnRegistro.Click += btnRegistro_Click;
            // 
            // frmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(btnLogin);
            Controls.Add(btnRegistro);
            Controls.Add(titulo);
            Name = "frmMenuPrincipal";
            Text = "MarketWeight";
            Load += MenuPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titulo;
        private Button btnLogin;
        private PictureBox pictureBox1;
        private Button btnRegistro;
    }
}
