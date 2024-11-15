namespace CapaPresentacion
{
    partial class frmRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistro));
            titulo = new Label();
            inputNombre = new TextBox();
            lblNombre = new Label();
            lblEmail = new Label();
            inputMail = new TextBox();
            btnRegistro = new Button();
            pictureBox1 = new PictureBox();
            lblPassword = new Label();
            inputPassword = new TextBox();
            lblApellido = new Label();
            inputApellido = new TextBox();
            btnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // titulo
            // 
            titulo.AutoSize = true;
            titulo.Font = new Font("Sitka Small", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titulo.ForeColor = Color.White;
            titulo.Location = new Point(33, 44);
            titulo.Name = "titulo";
            titulo.Size = new Size(245, 71);
            titulo.TabIndex = 1;
            titulo.Text = "Registro";
            titulo.Click += titulo_Click;
            // 
            // inputNombre
            // 
            inputNombre.Font = new Font("Microsoft Tai Le", 12F);
            inputNombre.Location = new Point(33, 172);
            inputNombre.Name = "inputNombre";
            inputNombre.Size = new Size(200, 28);
            inputNombre.TabIndex = 2;
            inputNombre.TextChanged += inputNombre_TextChanged;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Microsoft Tai Le", 12F);
            lblNombre.ForeColor = Color.White;
            lblNombre.Location = new Point(33, 146);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(68, 21);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre";
            lblNombre.Click += label1_Click;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Microsoft Tai Le", 12F);
            lblEmail.ForeColor = Color.White;
            lblEmail.Location = new Point(33, 238);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(54, 21);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "E-mail";
            lblEmail.Click += label2_Click;
            // 
            // inputMail
            // 
            inputMail.Font = new Font("Microsoft Tai Le", 12F);
            inputMail.Location = new Point(33, 264);
            inputMail.Name = "inputMail";
            inputMail.Size = new Size(200, 28);
            inputMail.TabIndex = 4;
            // 
            // btnRegistro
            // 
            btnRegistro.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegistro.Location = new Point(296, 337);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size = new Size(159, 37);
            btnRegistro.TabIndex = 10;
            btnRegistro.Text = "Registrate";
            btnRegistro.UseVisualStyleBackColor = true;
            btnRegistro.Click += btnRegistro_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(502, 89);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(252, 285);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Microsoft Tai Le", 12F);
            lblPassword.ForeColor = Color.White;
            lblPassword.Location = new Point(255, 238);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(89, 21);
            lblPassword.TabIndex = 15;
            lblPassword.Text = "Contraseña";
            // 
            // inputPassword
            // 
            inputPassword.Font = new Font("Microsoft Tai Le", 12F);
            inputPassword.Location = new Point(255, 264);
            inputPassword.Name = "inputPassword";
            inputPassword.PasswordChar = '●';
            inputPassword.Size = new Size(200, 28);
            inputPassword.TabIndex = 14;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Microsoft Tai Le", 12F);
            lblApellido.ForeColor = Color.White;
            lblApellido.Location = new Point(255, 146);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(67, 21);
            lblApellido.TabIndex = 17;
            lblApellido.Text = "Apellido";
            // 
            // inputApellido
            // 
            inputApellido.Font = new Font("Microsoft Tai Le", 12F);
            inputApellido.Location = new Point(255, 172);
            inputApellido.Name = "inputApellido";
            inputApellido.Size = new Size(200, 28);
            inputApellido.TabIndex = 16;
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Sitka Text", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVolver.Location = new Point(12, 409);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(114, 29);
            btnVolver.TabIndex = 26;
            btnVolver.Text = "Volver al Menu";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // frmRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVolver);
            Controls.Add(lblApellido);
            Controls.Add(inputApellido);
            Controls.Add(lblPassword);
            Controls.Add(inputPassword);
            Controls.Add(pictureBox1);
            Controls.Add(btnRegistro);
            Controls.Add(lblEmail);
            Controls.Add(inputMail);
            Controls.Add(lblNombre);
            Controls.Add(inputNombre);
            Controls.Add(titulo);
            Name = "frmRegistro";
            Text = "MarketWeight";
            Load += frmRegistro_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titulo;
        private TextBox inputNombre;
        private Label lblNombre;
        private Label lblEmail;
        private TextBox inputMail;
        private Button btnRegistro;
        private PictureBox pictureBox1;
        private Label lblPassword;
        private TextBox inputPassword;
        private Label lblApellido;
        private TextBox inputApellido;
        private Button btnVolver;
    }
}