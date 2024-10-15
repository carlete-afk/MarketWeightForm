namespace MarketWeightForm
{
    partial class Form2
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
            this.Nombre_TB = new System.Windows.Forms.TextBox();
            this.Mail_TB = new System.Windows.Forms.TextBox();
            this.Apellido_TB = new System.Windows.Forms.TextBox();
            this.Contraseña_TB = new System.Windows.Forms.TextBox();
            this.label_Email = new System.Windows.Forms.Label();
            this.label_Nombre = new System.Windows.Forms.Label();
            this.label_apellido = new System.Windows.Forms.Label();
            this.label_contrasena = new System.Windows.Forms.Label();
            this.button_Agregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Nombre_TB
            // 
            this.Nombre_TB.Location = new System.Drawing.Point(165, 50);
            this.Nombre_TB.Multiline = true;
            this.Nombre_TB.Name = "Nombre_TB";
            this.Nombre_TB.Size = new System.Drawing.Size(192, 22);
            this.Nombre_TB.TabIndex = 0;
            this.Nombre_TB.TextChanged += new System.EventHandler(this.Nombre_TB_TextChanged);
            // 
            // Mail_TB
            // 
            this.Mail_TB.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mail_TB.Location = new System.Drawing.Point(165, 188);
            this.Mail_TB.Name = "Mail_TB";
            this.Mail_TB.Size = new System.Drawing.Size(192, 22);
            this.Mail_TB.TabIndex = 1;
            this.Mail_TB.TextChanged += new System.EventHandler(this.Mail_TB_TextChanged);
            // 
            // Apellido_TB
            // 
            this.Apellido_TB.Location = new System.Drawing.Point(165, 119);
            this.Apellido_TB.Multiline = true;
            this.Apellido_TB.Name = "Apellido_TB";
            this.Apellido_TB.Size = new System.Drawing.Size(192, 22);
            this.Apellido_TB.TabIndex = 2;
            this.Apellido_TB.TextChanged += new System.EventHandler(this.Apellido_TB_TextChanged);
            // 
            // Contraseña_TB
            // 
            this.Contraseña_TB.Location = new System.Drawing.Point(165, 261);
            this.Contraseña_TB.Multiline = true;
            this.Contraseña_TB.Name = "Contraseña_TB";
            this.Contraseña_TB.Size = new System.Drawing.Size(192, 22);
            this.Contraseña_TB.TabIndex = 3;
            this.Contraseña_TB.TextChanged += new System.EventHandler(this.Contraseña_TB_TextChanged);
            // 
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.Location = new System.Drawing.Point(106, 192);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(32, 13);
            this.label_Email.TabIndex = 4;
            this.label_Email.Text = "Email";
            // 
            // label_Nombre
            // 
            this.label_Nombre.AutoSize = true;
            this.label_Nombre.Location = new System.Drawing.Point(94, 53);
            this.label_Nombre.Name = "label_Nombre";
            this.label_Nombre.Size = new System.Drawing.Size(44, 13);
            this.label_Nombre.TabIndex = 5;
            this.label_Nombre.Text = "Nombre";
            // 
            // label_apellido
            // 
            this.label_apellido.AutoSize = true;
            this.label_apellido.Location = new System.Drawing.Point(94, 122);
            this.label_apellido.Name = "label_apellido";
            this.label_apellido.Size = new System.Drawing.Size(44, 13);
            this.label_apellido.TabIndex = 6;
            this.label_apellido.Text = "Apellido";
            // 
            // label_contrasena
            // 
            this.label_contrasena.AutoSize = true;
            this.label_contrasena.Location = new System.Drawing.Point(77, 264);
            this.label_contrasena.Name = "label_contrasena";
            this.label_contrasena.Size = new System.Drawing.Size(61, 13);
            this.label_contrasena.TabIndex = 7;
            this.label_contrasena.Text = "Contraseña";
            // 
            // button_Agregar
            // 
            this.button_Agregar.Location = new System.Drawing.Point(529, 146);
            this.button_Agregar.Name = "button_Agregar";
            this.button_Agregar.Size = new System.Drawing.Size(157, 46);
            this.button_Agregar.TabIndex = 8;
            this.button_Agregar.Text = "Registrarse";
            this.button_Agregar.UseVisualStyleBackColor = true;
            this.button_Agregar.Click += new System.EventHandler(this.button_Agregar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Agregar);
            this.Controls.Add(this.label_contrasena);
            this.Controls.Add(this.label_apellido);
            this.Controls.Add(this.label_Nombre);
            this.Controls.Add(this.label_Email);
            this.Controls.Add(this.Contraseña_TB);
            this.Controls.Add(this.Apellido_TB);
            this.Controls.Add(this.Mail_TB);
            this.Controls.Add(this.Nombre_TB);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Nombre_TB;
        private System.Windows.Forms.TextBox Mail_TB;
        private System.Windows.Forms.TextBox Apellido_TB;
        private System.Windows.Forms.TextBox Contraseña_TB;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.Label label_Nombre;
        private System.Windows.Forms.Label label_apellido;
        private System.Windows.Forms.Label label_contrasena;
        private System.Windows.Forms.Button button_Agregar;
    }
}