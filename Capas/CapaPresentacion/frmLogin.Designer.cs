namespace CapaPresentacion
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            lblPassword = new Label();
            inputPassword = new TextBox();
            pictureBox1 = new PictureBox();
            btnLogin = new Button();
            lblEmail = new Label();
            inputEmail = new TextBox();
            titulo = new Label();
            btnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Microsoft Tai Le", 12F);
            lblPassword.ForeColor = Color.White;
            lblPassword.Location = new Point(271, 169);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(89, 21);
            lblPassword.TabIndex = 24;
            lblPassword.Text = "Contraseña";
            // 
            // inputPassword
            // 
            inputPassword.Font = new Font("Microsoft Tai Le", 12F);
            inputPassword.Location = new Point(271, 195);
            inputPassword.Name = "inputPassword";
            inputPassword.Size = new Size(179, 28);
            inputPassword.TabIndex = 23;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(496, 85);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(252, 285);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(162, 266);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(159, 37);
            btnLogin.TabIndex = 21;
            btnLogin.Text = "Entrar";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Microsoft Tai Le", 12F);
            lblEmail.ForeColor = Color.White;
            lblEmail.Location = new Point(43, 169);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(54, 21);
            lblEmail.TabIndex = 18;
            lblEmail.Text = "E-mail";
            lblEmail.Click += lblNombre_Click;
            // 
            // inputEmail
            // 
            inputEmail.Font = new Font("Microsoft Tai Le", 12F);
            inputEmail.Location = new Point(43, 195);
            inputEmail.Name = "inputEmail";
            inputEmail.Size = new Size(179, 28);
            inputEmail.TabIndex = 17;
            // 
            // titulo
            // 
            titulo.AutoSize = true;
            titulo.Font = new Font("Sitka Small", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titulo.ForeColor = Color.White;
            titulo.Location = new Point(43, 38);
            titulo.Name = "titulo";
            titulo.Size = new Size(385, 71);
            titulo.TabIndex = 16;
            titulo.Text = "Iniciar Sesión";
            titulo.Click += titulo_Click;
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Sitka Text", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVolver.Location = new Point(12, 409);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(114, 29);
            btnVolver.TabIndex = 25;
            btnVolver.Text = "Volver al Menu";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVolver);
            Controls.Add(lblPassword);
            Controls.Add(inputPassword);
            Controls.Add(pictureBox1);
            Controls.Add(btnLogin);
            Controls.Add(lblEmail);
            Controls.Add(inputEmail);
            Controls.Add(titulo);
            Name = "frmLogin";
            Text = "MarketWeight";
            Load += frmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPassword;
        private TextBox inputPassword;
        private PictureBox pictureBox1;
        private Button btnLogin;
        private Label lblEmail;
        private TextBox inputEmail;
        private Label titulo;
        private Button btnVolver;
    }
}