namespace AppMantenimiento
{
    partial class FrmMostrarCorrectivo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMostrarCorrectivo));
            this.lblCorrectivo = new System.Windows.Forms.Label();
            this.txtDescCorrectivo = new System.Windows.Forms.TextBox();
            this.lblTiempoParo = new System.Windows.Forms.Label();
            this.txtTiempoParo = new System.Windows.Forms.TextBox();
            this.txtMaquina = new System.Windows.Forms.TextBox();
            this.lblMaquina = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgInvolucrados = new System.Windows.Forms.DataGridView();
            this.lblInvolucrados = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgInvolucrados)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCorrectivo
            // 
            this.lblCorrectivo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCorrectivo.AutoSize = true;
            this.lblCorrectivo.Location = new System.Drawing.Point(27, 65);
            this.lblCorrectivo.Name = "lblCorrectivo";
            this.lblCorrectivo.Size = new System.Drawing.Size(165, 16);
            this.lblCorrectivo.TabIndex = 0;
            this.lblCorrectivo.Text = "Descripción de Correctivo:";
            // 
            // txtDescCorrectivo
            // 
            this.txtDescCorrectivo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescCorrectivo.Location = new System.Drawing.Point(225, 38);
            this.txtDescCorrectivo.Multiline = true;
            this.txtDescCorrectivo.Name = "txtDescCorrectivo";
            this.txtDescCorrectivo.ReadOnly = true;
            this.txtDescCorrectivo.Size = new System.Drawing.Size(370, 71);
            this.txtDescCorrectivo.TabIndex = 1;
            this.txtDescCorrectivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTiempoParo
            // 
            this.lblTiempoParo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTiempoParo.AutoSize = true;
            this.lblTiempoParo.Location = new System.Drawing.Point(84, 168);
            this.lblTiempoParo.Name = "lblTiempoParo";
            this.lblTiempoParo.Size = new System.Drawing.Size(108, 16);
            this.lblTiempoParo.TabIndex = 2;
            this.lblTiempoParo.Text = "Tiempo de Paro:";
            // 
            // txtTiempoParo
            // 
            this.txtTiempoParo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTiempoParo.Location = new System.Drawing.Point(225, 165);
            this.txtTiempoParo.Name = "txtTiempoParo";
            this.txtTiempoParo.ReadOnly = true;
            this.txtTiempoParo.Size = new System.Drawing.Size(370, 22);
            this.txtTiempoParo.TabIndex = 3;
            this.txtTiempoParo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMaquina
            // 
            this.txtMaquina.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaquina.Location = new System.Drawing.Point(225, 126);
            this.txtMaquina.Name = "txtMaquina";
            this.txtMaquina.ReadOnly = true;
            this.txtMaquina.Size = new System.Drawing.Size(370, 22);
            this.txtMaquina.TabIndex = 5;
            this.txtMaquina.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblMaquina
            // 
            this.lblMaquina.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMaquina.AutoSize = true;
            this.lblMaquina.Location = new System.Drawing.Point(130, 129);
            this.lblMaquina.Name = "lblMaquina";
            this.lblMaquina.Size = new System.Drawing.Size(62, 16);
            this.lblMaquina.TabIndex = 4;
            this.lblMaquina.Text = "Maquina:";
            // 
            // txtFecha
            // 
            this.txtFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFecha.Location = new System.Drawing.Point(225, 204);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            this.txtFecha.Size = new System.Drawing.Size(370, 22);
            this.txtFecha.TabIndex = 7;
            this.txtFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Fecha:";
            // 
            // dtgInvolucrados
            // 
            this.dtgInvolucrados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgInvolucrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgInvolucrados.Location = new System.Drawing.Point(225, 243);
            this.dtgInvolucrados.Name = "dtgInvolucrados";
            this.dtgInvolucrados.ReadOnly = true;
            this.dtgInvolucrados.RowHeadersWidth = 51;
            this.dtgInvolucrados.RowTemplate.Height = 24;
            this.dtgInvolucrados.Size = new System.Drawing.Size(370, 150);
            this.dtgInvolucrados.TabIndex = 8;
            // 
            // lblInvolucrados
            // 
            this.lblInvolucrados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInvolucrados.AutoSize = true;
            this.lblInvolucrados.Location = new System.Drawing.Point(105, 310);
            this.lblInvolucrados.Name = "lblInvolucrados";
            this.lblInvolucrados.Size = new System.Drawing.Size(87, 16);
            this.lblInvolucrados.TabIndex = 9;
            this.lblInvolucrados.Text = "Involucrados:";
            // 
            // FrmMostrarCorrectivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 423);
            this.Controls.Add(this.lblInvolucrados);
            this.Controls.Add(this.dtgInvolucrados);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaquina);
            this.Controls.Add(this.lblMaquina);
            this.Controls.Add(this.txtTiempoParo);
            this.Controls.Add(this.lblTiempoParo);
            this.Controls.Add(this.txtDescCorrectivo);
            this.Controls.Add(this.lblCorrectivo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMostrarCorrectivo";
            this.Text = "Resumen Correctivo";
            ((System.ComponentModel.ISupportInitialize)(this.dtgInvolucrados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCorrectivo;
        private System.Windows.Forms.TextBox txtDescCorrectivo;
        private System.Windows.Forms.Label lblTiempoParo;
        private System.Windows.Forms.TextBox txtTiempoParo;
        private System.Windows.Forms.TextBox txtMaquina;
        private System.Windows.Forms.Label lblMaquina;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgInvolucrados;
        private System.Windows.Forms.Label lblInvolucrados;
    }
}