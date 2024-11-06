namespace CapaPresentacion
{
    partial class frmTablaCripto
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
            dgvTabla = new DataGridView();
            btnMostrarCriptos = new Button();
            btnBuscarCripto = new Button();
            btnMisCriptos = new Button();
            lblNombreCripto = new Label();
            inputEmail = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvTabla).BeginInit();
            SuspendLayout();
            // 
            // dgvTabla
            // 
            dgvTabla.BackgroundColor = Color.LightSteelBlue;
            dgvTabla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTabla.Location = new Point(171, 12);
            dgvTabla.Name = "dgvTabla";
            dgvTabla.Size = new Size(617, 426);
            dgvTabla.TabIndex = 0;
            // 
            // btnMostrarCriptos
            // 
            btnMostrarCriptos.Location = new Point(12, 12);
            btnMostrarCriptos.Name = "btnMostrarCriptos";
            btnMostrarCriptos.Size = new Size(153, 45);
            btnMostrarCriptos.TabIndex = 1;
            btnMostrarCriptos.Text = "Mostrar todas las criptomonedas";
            btnMostrarCriptos.UseVisualStyleBackColor = true;
            btnMostrarCriptos.Click += btnMostrarCriptos_Click;
            // 
            // btnBuscarCripto
            // 
            btnBuscarCripto.Location = new Point(12, 393);
            btnBuscarCripto.Name = "btnBuscarCripto";
            btnBuscarCripto.Size = new Size(153, 45);
            btnBuscarCripto.TabIndex = 2;
            btnBuscarCripto.Text = "Buscar Criptomonedas";
            btnBuscarCripto.UseVisualStyleBackColor = true;
            // 
            // btnMisCriptos
            // 
            btnMisCriptos.Location = new Point(12, 63);
            btnMisCriptos.Name = "btnMisCriptos";
            btnMisCriptos.Size = new Size(153, 45);
            btnMisCriptos.TabIndex = 3;
            btnMisCriptos.Text = "Mostrar mis criptomonedas";
            btnMisCriptos.UseVisualStyleBackColor = true;
            btnMisCriptos.Click += btnMisCriptos_Click;
            // 
            // lblNombreCripto
            // 
            lblNombreCripto.AutoSize = true;
            lblNombreCripto.Font = new Font("Microsoft Tai Le", 12F);
            lblNombreCripto.ForeColor = Color.White;
            lblNombreCripto.Location = new Point(12, 333);
            lblNombreCripto.Name = "lblNombreCripto";
            lblNombreCripto.Size = new Size(68, 21);
            lblNombreCripto.TabIndex = 20;
            lblNombreCripto.Text = "Nombre";
            lblNombreCripto.Click += lblEmail_Click;
            // 
            // inputEmail
            // 
            inputEmail.Font = new Font("Microsoft Tai Le", 12F);
            inputEmail.Location = new Point(12, 359);
            inputEmail.Name = "inputEmail";
            inputEmail.Size = new Size(153, 28);
            inputEmail.TabIndex = 19;
            // 
            // frmTablaCripto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(800, 450);
            Controls.Add(lblNombreCripto);
            Controls.Add(inputEmail);
            Controls.Add(btnMisCriptos);
            Controls.Add(btnBuscarCripto);
            Controls.Add(btnMostrarCriptos);
            Controls.Add(dgvTabla);
            Name = "frmTablaCripto";
            Text = "Tabla Principal";
            ((System.ComponentModel.ISupportInitialize)dgvTabla).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvTabla;
        private Button btnMostrarCriptos;
        private Button btnBuscarCripto;
        private Button btnMisCriptos;
        private Label lblNombreCripto;
        private TextBox inputEmail;
    }
}