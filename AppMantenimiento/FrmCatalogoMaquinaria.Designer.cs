namespace AppMantenimiento
{
    partial class FrmCatalogoMaquinaria
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
            this.cmbArea = new System.Windows.Forms.ComboBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.mskFabricacion = new System.Windows.Forms.MaskedTextBox();
            this.lblMaquina = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bttGuardar = new System.Windows.Forms.Button();
            this.dtgMaquinaria = new System.Windows.Forms.DataGridView();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMaquinaria)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbArea
            // 
            this.cmbArea.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cmbArea.FormattingEnabled = true;
            this.cmbArea.Location = new System.Drawing.Point(688, 361);
            this.cmbArea.Name = "cmbArea";
            this.cmbArea.Size = new System.Drawing.Size(177, 24);
            this.cmbArea.TabIndex = 8;
            // 
            // txtMarca
            // 
            this.txtMarca.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtMarca.Location = new System.Drawing.Point(688, 141);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(177, 22);
            this.txtMarca.TabIndex = 7;
            this.txtMarca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtModelo
            // 
            this.txtModelo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtModelo.Location = new System.Drawing.Point(688, 251);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(177, 22);
            this.txtModelo.TabIndex = 10;
            this.txtModelo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mskFabricacion
            // 
            this.mskFabricacion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.mskFabricacion.Location = new System.Drawing.Point(688, 473);
            this.mskFabricacion.Mask = "0000";
            this.mskFabricacion.Name = "mskFabricacion";
            this.mskFabricacion.Size = new System.Drawing.Size(177, 22);
            this.mskFabricacion.TabIndex = 11;
            this.mskFabricacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mskFabricacion.ValidatingType = typeof(int);
            // 
            // lblMaquina
            // 
            this.lblMaquina.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblMaquina.AutoSize = true;
            this.lblMaquina.Location = new System.Drawing.Point(594, 254);
            this.lblMaquina.Name = "lblMaquina";
            this.lblMaquina.Size = new System.Drawing.Size(53, 16);
            this.lblMaquina.TabIndex = 13;
            this.lblMaquina.Text = "Modelo";
            // 
            // lblArea
            // 
            this.lblArea.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(594, 34);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(79, 16);
            this.lblArea.TabIndex = 12;
            this.lblArea.Text = "Descripción";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(594, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Marca";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(594, 468);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 32);
            this.label3.TabIndex = 17;
            this.label3.Text = "Año de\r\n Fabricación";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(594, 365);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Área";
            // 
            // bttGuardar
            // 
            this.bttGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttGuardar.Location = new System.Drawing.Point(676, 553);
            this.bttGuardar.Name = "bttGuardar";
            this.bttGuardar.Size = new System.Drawing.Size(173, 54);
            this.bttGuardar.TabIndex = 18;
            this.bttGuardar.Text = "Guardar";
            this.bttGuardar.UseVisualStyleBackColor = true;
            this.bttGuardar.Click += new System.EventHandler(this.bttGuardar_Click);
            // 
            // dtgMaquinaria
            // 
            this.dtgMaquinaria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgMaquinaria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMaquinaria.Location = new System.Drawing.Point(12, 12);
            this.dtgMaquinaria.Name = "dtgMaquinaria";
            this.dtgMaquinaria.ReadOnly = true;
            this.dtgMaquinaria.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dtgMaquinaria.RowTemplate.Height = 24;
            this.dtgMaquinaria.Size = new System.Drawing.Size(556, 595);
            this.dtgMaquinaria.TabIndex = 1;
            this.dtgMaquinaria.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgMaquinaria_CellContentClick);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtDescripcion.Location = new System.Drawing.Point(688, 31);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(177, 22);
            this.txtDescripcion.TabIndex = 6;
            this.txtDescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FrmCatalogoMaquinaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(921, 619);
            this.Controls.Add(this.bttGuardar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMaquina);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.mskFabricacion);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.cmbArea);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.dtgMaquinaria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCatalogoMaquinaria";
            this.Text = "FrmCatalogoMaquinaria";
            this.Load += new System.EventHandler(this.FrmCatalogoMaquinaria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgMaquinaria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbArea;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.MaskedTextBox mskFabricacion;
        private System.Windows.Forms.Label lblMaquina;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bttGuardar;
        private System.Windows.Forms.DataGridView dtgMaquinaria;
        private System.Windows.Forms.TextBox txtDescripcion;
    }
}