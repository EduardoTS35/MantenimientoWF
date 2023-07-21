namespace AppMantenimiento
{
    partial class FrmCatalogoRefacciones
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
            this.dtgMaquinaria = new System.Windows.Forms.DataGridView();
            this.cmbGrupo = new System.Windows.Forms.ComboBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblMaquina = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblUnidad = new System.Windows.Forms.Label();
            this.lblGrupo = new System.Windows.Forms.Label();
            this.mskFabricacion = new System.Windows.Forms.MaskedTextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.bttGuardar = new System.Windows.Forms.Button();
            this.bttLimpiarDatos = new System.Windows.Forms.Button();
            this.txtMaquina = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMaquinaria)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgMaquinaria
            // 
            this.dtgMaquinaria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgMaquinaria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMaquinaria.Location = new System.Drawing.Point(12, 46);
            this.dtgMaquinaria.Name = "dtgMaquinaria";
            this.dtgMaquinaria.ReadOnly = true;
            this.dtgMaquinaria.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dtgMaquinaria.RowTemplate.Height = 24;
            this.dtgMaquinaria.Size = new System.Drawing.Size(824, 618);
            this.dtgMaquinaria.TabIndex = 19;
            // 
            // cmbGrupo
            // 
            this.cmbGrupo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cmbGrupo.FormattingEnabled = true;
            this.cmbGrupo.Location = new System.Drawing.Point(956, 51);
            this.cmbGrupo.Name = "cmbGrupo";
            this.cmbGrupo.Size = new System.Drawing.Size(177, 24);
            this.cmbGrupo.TabIndex = 29;
            // 
            // lblPrecio
            // 
            this.lblPrecio.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(862, 504);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(46, 16);
            this.lblPrecio.TabIndex = 28;
            this.lblPrecio.Text = "Precio";
            // 
            // lblMaquina
            // 
            this.lblMaquina.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblMaquina.AutoSize = true;
            this.lblMaquina.Location = new System.Drawing.Point(862, 390);
            this.lblMaquina.Name = "lblMaquina";
            this.lblMaquina.Size = new System.Drawing.Size(59, 16);
            this.lblMaquina.TabIndex = 27;
            this.lblMaquina.Text = "Maquina";
            // 
            // lblDesc
            // 
            this.lblDesc.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(862, 169);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(75, 16);
            this.lblDesc.TabIndex = 26;
            this.lblDesc.Text = "Descipción";
            // 
            // lblUnidad
            // 
            this.lblUnidad.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblUnidad.AutoSize = true;
            this.lblUnidad.Location = new System.Drawing.Point(862, 279);
            this.lblUnidad.Name = "lblUnidad";
            this.lblUnidad.Size = new System.Drawing.Size(51, 16);
            this.lblUnidad.TabIndex = 25;
            this.lblUnidad.Text = "Unidad";
            // 
            // lblGrupo
            // 
            this.lblGrupo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.Location = new System.Drawing.Point(862, 59);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(44, 16);
            this.lblGrupo.TabIndex = 24;
            this.lblGrupo.Text = "Grupo";
            // 
            // mskFabricacion
            // 
            this.mskFabricacion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.mskFabricacion.Location = new System.Drawing.Point(956, 498);
            this.mskFabricacion.Mask = "999999";
            this.mskFabricacion.Name = "mskFabricacion";
            this.mskFabricacion.Size = new System.Drawing.Size(177, 22);
            this.mskFabricacion.TabIndex = 23;
            this.mskFabricacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mskFabricacion.ValidatingType = typeof(int);
            // 
            // txtModelo
            // 
            this.txtModelo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtModelo.Location = new System.Drawing.Point(956, 276);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(177, 22);
            this.txtModelo.TabIndex = 22;
            this.txtModelo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMarca
            // 
            this.txtMarca.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtMarca.Location = new System.Drawing.Point(956, 166);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(177, 22);
            this.txtMarca.TabIndex = 20;
            this.txtMarca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bttGuardar
            // 
            this.bttGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttGuardar.Location = new System.Drawing.Point(856, 610);
            this.bttGuardar.Name = "bttGuardar";
            this.bttGuardar.Size = new System.Drawing.Size(131, 54);
            this.bttGuardar.TabIndex = 30;
            this.bttGuardar.Text = "Guardar";
            this.bttGuardar.UseVisualStyleBackColor = true;
            // 
            // bttLimpiarDatos
            // 
            this.bttLimpiarDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttLimpiarDatos.Location = new System.Drawing.Point(1002, 610);
            this.bttLimpiarDatos.Name = "bttLimpiarDatos";
            this.bttLimpiarDatos.Size = new System.Drawing.Size(131, 54);
            this.bttLimpiarDatos.TabIndex = 31;
            this.bttLimpiarDatos.Text = "Limpiar Datos";
            this.bttLimpiarDatos.UseVisualStyleBackColor = true;
            // 
            // txtMaquina
            // 
            this.txtMaquina.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtMaquina.Location = new System.Drawing.Point(956, 384);
            this.txtMaquina.Name = "txtMaquina";
            this.txtMaquina.Size = new System.Drawing.Size(177, 22);
            this.txtMaquina.TabIndex = 32;
            this.txtMaquina.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FrmCatalogoRefacciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 689);
            this.Controls.Add(this.txtMaquina);
            this.Controls.Add(this.bttLimpiarDatos);
            this.Controls.Add(this.bttGuardar);
            this.Controls.Add(this.cmbGrupo);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblMaquina);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblUnidad);
            this.Controls.Add(this.lblGrupo);
            this.Controls.Add(this.mskFabricacion);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.dtgMaquinaria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCatalogoRefacciones";
            this.Text = "FrmCatalogoRefacciones";
            ((System.ComponentModel.ISupportInitialize)(this.dtgMaquinaria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgMaquinaria;
        private System.Windows.Forms.ComboBox cmbGrupo;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblMaquina;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblUnidad;
        private System.Windows.Forms.Label lblGrupo;
        private System.Windows.Forms.MaskedTextBox mskFabricacion;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Button bttGuardar;
        private System.Windows.Forms.Button bttLimpiarDatos;
        private System.Windows.Forms.TextBox txtMaquina;
    }
}