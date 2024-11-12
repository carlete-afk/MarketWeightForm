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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTablaCripto));
            dgvTabla = new DataGridView();
            btnMostrarCriptos = new Button();
            btnMisCriptos = new Button();
            lblNombreCripto = new Label();
            inputSearch = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvTabla).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvTabla
            // 
            dgvTabla.AllowUserToAddRows = false;
            dgvTabla.AllowUserToDeleteRows = false;
            dgvTabla.BackgroundColor = Color.LightSteelBlue;
            dgvTabla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTabla.Location = new Point(171, 12);
            dgvTabla.Name = "dgvTabla";
            dgvTabla.ReadOnly = true;
            dgvTabla.Size = new Size(617, 426);
            dgvTabla.TabIndex = 0;
            // 
            // btnMostrarCriptos
            // 
            btnMostrarCriptos.Location = new Point(12, 312);
            btnMostrarCriptos.Name = "btnMostrarCriptos";
            btnMostrarCriptos.Size = new Size(153, 27);
            btnMostrarCriptos.TabIndex = 1;
            btnMostrarCriptos.Text = "Mostrar Todas";
            btnMostrarCriptos.UseVisualStyleBackColor = true;
            btnMostrarCriptos.Click += btnMostrarCriptos_Click;
            // 
            // btnMisCriptos
            // 
            btnMisCriptos.Location = new Point(12, 277);
            btnMisCriptos.Name = "btnMisCriptos";
            btnMisCriptos.Size = new Size(153, 29);
            btnMisCriptos.TabIndex = 3;
            btnMisCriptos.Text = "Mis Criptos";
            btnMisCriptos.UseVisualStyleBackColor = true;
            btnMisCriptos.Click += btnMisCriptos_Click;
            // 
            // lblNombreCripto
            // 
            lblNombreCripto.AutoSize = true;
            lblNombreCripto.Font = new Font("Microsoft Tai Le", 12F);
            lblNombreCripto.ForeColor = Color.White;
            lblNombreCripto.Location = new Point(12, 200);
            lblNombreCripto.Name = "lblNombreCripto";
            lblNombreCripto.Size = new Size(78, 21);
            lblNombreCripto.TabIndex = 20;
            lblNombreCripto.Text = "Búsqueda";
            lblNombreCripto.Click += lblEmail_Click;
            // 
            // inputSearch
            // 
            inputSearch.Font = new Font("Microsoft Tai Le", 12F);
            inputSearch.Location = new Point(12, 226);
            inputSearch.Name = "inputSearch";
            inputSearch.Size = new Size(153, 28);
            inputSearch.TabIndex = 19;
            inputSearch.TextChanged += inputSearch_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(9, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(153, 167);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // frmTablaCripto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(lblNombreCripto);
            Controls.Add(inputSearch);
            Controls.Add(btnMisCriptos);
            Controls.Add(btnMostrarCriptos);
            Controls.Add(dgvTabla);
            Name = "frmTablaCripto";
            Text = "Tabla Principal";
            ((System.ComponentModel.ISupportInitialize)dgvTabla).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvTabla;
        private Button btnMostrarCriptos;
        private Button btnMisCriptos;
        private Label lblNombreCripto;
        private TextBox inputSearch;
        private PictureBox pictureBox1;
    }
}