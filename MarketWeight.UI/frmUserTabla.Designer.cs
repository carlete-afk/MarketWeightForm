namespace MarketWeightForm.MarketWeight.UI
{
    partial class frmUserTabla
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
            this.dgvObtenerUsuarios = new System.Windows.Forms.DataGridView();
            this.btnMostrarMonedas = new System.Windows.Forms.Button();
            this.textBoxCondicion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObtenerUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvObtenerUsuarios
            // 
            this.dgvObtenerUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObtenerUsuarios.Location = new System.Drawing.Point(57, 92);
            this.dgvObtenerUsuarios.Name = "dgvObtenerUsuarios";
            this.dgvObtenerUsuarios.Size = new System.Drawing.Size(680, 317);
            this.dgvObtenerUsuarios.TabIndex = 0;
            this.dgvObtenerUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMostrarUsuarios);
            // 
            // btnMostrarMonedas
            // 
            this.btnMostrarMonedas.Location = new System.Drawing.Point(536, 31);
            this.btnMostrarMonedas.Name = "btnMostrarMonedas";
            this.btnMostrarMonedas.Size = new System.Drawing.Size(90, 42);
            this.btnMostrarMonedas.TabIndex = 1;
            this.btnMostrarMonedas.Text = "Mostrar Criptomonedas";
            this.btnMostrarMonedas.UseVisualStyleBackColor = true;
            this.btnMostrarMonedas.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxCondicion
            // 
            this.textBoxCondicion.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCondicion.Location = new System.Drawing.Point(294, 43);
            this.textBoxCondicion.Name = "textBoxCondicion";
            this.textBoxCondicion.Size = new System.Drawing.Size(211, 23);
            this.textBoxCondicion.TabIndex = 2;
            this.textBoxCondicion.Text = "Ingesa la condición aquí";
            this.textBoxCondicion.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(184, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Condición";
            // 
            // frmUserTabla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCondicion);
            this.Controls.Add(this.btnMostrarMonedas);
            this.Controls.Add(this.dgvObtenerUsuarios);
            this.Name = "frmUserTabla";
            this.Text = "frmObtenerUsuarios";
            this.Load += new System.EventHandler(this.frmObtenerUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvObtenerUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvObtenerUsuarios;
        private System.Windows.Forms.Button btnMostrarMonedas;
        private System.Windows.Forms.TextBox textBoxCondicion;
        private System.Windows.Forms.Label label1;
    }
}