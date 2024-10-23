namespace MarketWeightForm
{
    partial class frmInicioSesion
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.botton_IniciarSesion = new System.Windows.Forms.Button();
            this.button_Registrarse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(35, 47);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(443, 35);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(35, 123);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(443, 35);
            this.textBox2.TabIndex = 1;
            // 
            // botton_IniciarSesion
            // 
            this.botton_IniciarSesion.Location = new System.Drawing.Point(337, 221);
            this.botton_IniciarSesion.Name = "botton_IniciarSesion";
            this.botton_IniciarSesion.Size = new System.Drawing.Size(141, 35);
            this.botton_IniciarSesion.TabIndex = 2;
            this.botton_IniciarSesion.Text = "Iniciar Sesion";
            this.botton_IniciarSesion.UseVisualStyleBackColor = true;
            // 
            // button_Registrarse
            // 
            this.button_Registrarse.Location = new System.Drawing.Point(35, 221);
            this.button_Registrarse.Name = "button_Registrarse";
            this.button_Registrarse.Size = new System.Drawing.Size(141, 35);
            this.button_Registrarse.TabIndex = 3;
            this.button_Registrarse.Text = "Registrarse";
            this.button_Registrarse.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Contraseña";
            // 
            // frmInicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 287);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Registrarse);
            this.Controls.Add(this.botton_IniciarSesion);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "frmInicioSesion";
            this.Text = "Inicio Sesion";
            this.Load += new System.EventHandler(this.frmInicioSesion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button botton_IniciarSesion;
        private System.Windows.Forms.Button button_Registrarse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}