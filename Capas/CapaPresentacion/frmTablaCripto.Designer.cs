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
            lblBusqueda = new Label();
            inputSearch = new TextBox();
            pictureBox1 = new PictureBox();
            btnVolver = new Button();
            titulo = new Label();
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
            dgvTabla.Location = new Point(171, 88);
            dgvTabla.Name = "dgvTabla";
            dgvTabla.ReadOnly = true;
            dgvTabla.RowHeadersVisible = false;
            dgvTabla.Size = new Size(617, 350);
            dgvTabla.TabIndex = 0;
            // 
            // btnMostrarCriptos
            // 
            btnMostrarCriptos.Location = new Point(12, 312);
            btnMostrarCriptos.Name = "btnMostrarCriptos";
            btnMostrarCriptos.Size = new Size(153, 27);
            btnMostrarCriptos.TabIndex = 1;
            btnMostrarCriptos.Text = "Mostrar Todo";
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
            // lblBusqueda
            // 
            lblBusqueda.AutoSize = true;
            lblBusqueda.Font = new Font("Microsoft Tai Le", 12F);
            lblBusqueda.ForeColor = Color.White;
            lblBusqueda.Location = new Point(458, 54);
            lblBusqueda.Name = "lblBusqueda";
            lblBusqueda.Size = new Size(144, 21);
            lblBusqueda.TabIndex = 20;
            lblBusqueda.Text = "Busca la cripto aquí";
            lblBusqueda.Click += lblEmail_Click;
            // 
            // inputSearch
            // 
            inputSearch.Font = new Font("Microsoft Tai Le", 12F);
            inputSearch.Location = new Point(608, 47);
            inputSearch.Name = "inputSearch";
            inputSearch.Size = new Size(180, 28);
            inputSearch.TabIndex = 19;
            inputSearch.TextChanged += inputSearch_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(12, 88);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(153, 167);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
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
            // titulo
            // 
            titulo.AutoSize = true;
            titulo.Font = new Font("Sitka Small", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titulo.ForeColor = Color.White;
            titulo.Location = new Point(12, 9);
            titulo.Name = "titulo";
            titulo.Size = new Size(419, 71);
            titulo.TabIndex = 27;
            titulo.Text = "Criptomonedas";
            // 
            // frmTablaCripto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(800, 450);
            Controls.Add(titulo);
            Controls.Add(btnVolver);
            Controls.Add(pictureBox1);
            Controls.Add(lblBusqueda);
            Controls.Add(inputSearch);
            Controls.Add(btnMisCriptos);
            Controls.Add(btnMostrarCriptos);
            Controls.Add(dgvTabla);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmTablaCripto";
            Text = "MarketWeight";
            Load += frmTablaCripto_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTabla).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvTabla;
        private Button btnMostrarCriptos;
        private Button btnMisCriptos;
        private Label lblBusqueda;
        private TextBox inputSearch;
        private PictureBox pictureBox1;
        private Button btnVolver;
        private Label titulo;
    }
}