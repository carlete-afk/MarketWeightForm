namespace CapaPresentacion
{
    partial class frmHistorialUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHistorialUsuario));
            btnVolver = new Button();
            pictureBox1 = new PictureBox();
            lblBusqueda = new Label();
            inputSearch = new TextBox();
            dgvTabla = new DataGridView();
            titulo = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTabla).BeginInit();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Sitka Text", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVolver.Location = new Point(12, 409);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(114, 29);
            btnVolver.TabIndex = 31;
            btnVolver.Text = "Volver al Menu";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(12, 88);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(153, 167);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            // 
            // lblBusqueda
            // 
            lblBusqueda.AutoSize = true;
            lblBusqueda.Font = new Font("Microsoft Tai Le", 12F);
            lblBusqueda.ForeColor = Color.White;
            lblBusqueda.Location = new Point(453, 56);
            lblBusqueda.Name = "lblBusqueda";
            lblBusqueda.Size = new Size(144, 21);
            lblBusqueda.TabIndex = 29;
            lblBusqueda.Text = "Busca la cripto aquí";
            // 
            // inputSearch
            // 
            inputSearch.Font = new Font("Microsoft Tai Le", 12F);
            inputSearch.Location = new Point(608, 49);
            inputSearch.Name = "inputSearch";
            inputSearch.Size = new Size(180, 28);
            inputSearch.TabIndex = 28;
            inputSearch.TextChanged += inputSearch_TextChanged;
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
            dgvTabla.TabIndex = 27;
            // 
            // titulo
            // 
            titulo.AutoSize = true;
            titulo.Font = new Font("Sitka Small", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titulo.ForeColor = Color.White;
            titulo.Location = new Point(12, 9);
            titulo.Name = "titulo";
            titulo.Size = new Size(365, 71);
            titulo.TabIndex = 32;
            titulo.Text = "Movimientos";
            // 
            // frmHistorialUsuario
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
            Controls.Add(dgvTabla);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmHistorialUsuario";
            Text = "MarketWeight";
            Load += frmHistorialUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTabla).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVolver;
        private PictureBox pictureBox1;
        private Label lblBusqueda;
        private TextBox inputSearch;
        private DataGridView dgvTabla;
        private Label titulo;
    }
}