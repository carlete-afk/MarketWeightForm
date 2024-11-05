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
            titulo = new Label();
            inputNombre = new TextBox();
            lblNombre = new Label();
            lblEmail = new Label();
            inputMail = new TextBox();
            lblApellido = new Label();
            inputApellido = new TextBox();
            lblPassword = new Label();
            inputPassword = new TextBox();
            btnRegistro = new Button();
            SuspendLayout();
            // 
            // titulo
            // 
            titulo.AutoSize = true;
            titulo.Font = new Font("Sitka Small", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titulo.ForeColor = Color.White;
            titulo.Location = new Point(270, 46);
            titulo.Name = "titulo";
            titulo.Size = new Size(245, 71);
            titulo.TabIndex = 1;
            titulo.Text = "Registro";
            titulo.Click += titulo_Click;
            // 
            // inputNombre
            // 
            inputNombre.Font = new Font("Microsoft Tai Le", 12F);
            inputNombre.Location = new Point(127, 177);
            inputNombre.Name = "inputNombre";
            inputNombre.Size = new Size(179, 28);
            inputNombre.TabIndex = 2;
            inputNombre.TextChanged += inputNombre_TextChanged;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Microsoft Tai Le", 12F);
            lblNombre.ForeColor = Color.White;
            lblNombre.Location = new Point(127, 151);
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
            lblEmail.Location = new Point(127, 253);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(68, 21);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "Nombre";
            lblEmail.Click += label2_Click;
            // 
            // inputMail
            // 
            inputMail.Font = new Font("Microsoft Tai Le", 12F);
            inputMail.Location = new Point(127, 279);
            inputMail.Name = "inputMail";
            inputMail.Size = new Size(179, 28);
            inputMail.TabIndex = 4;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Microsoft Tai Le", 12F);
            lblApellido.ForeColor = Color.White;
            lblApellido.Location = new Point(470, 151);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(68, 21);
            lblApellido.TabIndex = 7;
            lblApellido.Text = "Nombre";
            // 
            // inputApellido
            // 
            inputApellido.Font = new Font("Microsoft Tai Le", 12F);
            inputApellido.Location = new Point(470, 177);
            inputApellido.Name = "inputApellido";
            inputApellido.Size = new Size(179, 28);
            inputApellido.TabIndex = 6;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Microsoft Tai Le", 12F);
            lblPassword.ForeColor = Color.White;
            lblPassword.Location = new Point(470, 253);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(68, 21);
            lblPassword.TabIndex = 9;
            lblPassword.Text = "Nombre";
            // 
            // inputPassword
            // 
            inputPassword.Font = new Font("Microsoft Tai Le", 12F);
            inputPassword.Location = new Point(470, 279);
            inputPassword.Name = "inputPassword";
            inputPassword.Size = new Size(179, 28);
            inputPassword.TabIndex = 8;
            // 
            // btnRegistro
            // 
            btnRegistro.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegistro.Location = new Point(300, 360);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size = new Size(159, 37);
            btnRegistro.TabIndex = 10;
            btnRegistro.Text = "Registrate";
            btnRegistro.UseVisualStyleBackColor = true;
            // 
            // frmRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegistro);
            Controls.Add(lblPassword);
            Controls.Add(inputPassword);
            Controls.Add(lblApellido);
            Controls.Add(inputApellido);
            Controls.Add(lblEmail);
            Controls.Add(inputMail);
            Controls.Add(lblNombre);
            Controls.Add(inputNombre);
            Controls.Add(titulo);
            Name = "frmRegistro";
            Text = "Registro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titulo;
        private TextBox inputNombre;
        private Label lblNombre;
        private Label lblEmail;
        private TextBox inputMail;
        private Label lblApellido;
        private TextBox inputApellido;
        private Label lblPassword;
        private TextBox inputPassword;
        private Button btnRegistro;
    }
}