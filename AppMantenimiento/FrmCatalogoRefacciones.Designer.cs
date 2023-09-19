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
            this.dtgRefacciones = new System.Windows.Forms.DataGridView();
            this.cmbGrupo = new System.Windows.Forms.ComboBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblMaquina = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblUnidad = new System.Windows.Forms.Label();
            this.lblGrupo = new System.Windows.Forms.Label();
            this.mskPrecio = new System.Windows.Forms.MaskedTextBox();
            this.txtUnidad = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.bttGuardar = new System.Windows.Forms.Button();
            this.bttLimpiarDatos = new System.Windows.Forms.Button();
            this.txtMaquina = new System.Windows.Forms.TextBox();
            this.bttCargarRefacciones = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mskMax = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mskMin = new System.Windows.Forms.MaskedTextBox();
            this.lblMoneda = new System.Windows.Forms.Label();
            this.cmbMoneda = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRefacciones)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgRefacciones
            // 
            this.dtgRefacciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgRefacciones.ColumnHeadersHeight = 29;
            this.dtgRefacciones.Location = new System.Drawing.Point(12, 46);
            this.dtgRefacciones.Name = "dtgRefacciones";
            this.dtgRefacciones.ReadOnly = true;
            this.dtgRefacciones.RowHeadersWidth = 51;
            this.dtgRefacciones.RowTemplate.Height = 24;
            this.dtgRefacciones.Size = new System.Drawing.Size(824, 618);
            this.dtgRefacciones.TabIndex = 19;
            this.dtgRefacciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgRefacciones_CellContentClick);
            // 
            // cmbGrupo
            // 
            this.cmbGrupo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cmbGrupo.FormattingEnabled = true;
            this.cmbGrupo.Location = new System.Drawing.Point(964, 28);
            this.cmbGrupo.Name = "cmbGrupo";
            this.cmbGrupo.Size = new System.Drawing.Size(177, 24);
            this.cmbGrupo.TabIndex = 29;
            // 
            // lblPrecio
            // 
            this.lblPrecio.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(872, 336);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(46, 16);
            this.lblPrecio.TabIndex = 28;
            this.lblPrecio.Text = "Precio";
            // 
            // lblMaquina
            // 
            this.lblMaquina.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblMaquina.AutoSize = true;
            this.lblMaquina.Location = new System.Drawing.Point(866, 261);
            this.lblMaquina.Name = "lblMaquina";
            this.lblMaquina.Size = new System.Drawing.Size(59, 16);
            this.lblMaquina.TabIndex = 27;
            this.lblMaquina.Text = "Maquina";
            // 
            // lblDesc
            // 
            this.lblDesc.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(858, 111);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(75, 16);
            this.lblDesc.TabIndex = 26;
            this.lblDesc.Text = "Descipción";
            // 
            // lblUnidad
            // 
            this.lblUnidad.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblUnidad.AutoSize = true;
            this.lblUnidad.Location = new System.Drawing.Point(870, 186);
            this.lblUnidad.Name = "lblUnidad";
            this.lblUnidad.Size = new System.Drawing.Size(51, 16);
            this.lblUnidad.TabIndex = 25;
            this.lblUnidad.Text = "Unidad";
            // 
            // lblGrupo
            // 
            this.lblGrupo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.Location = new System.Drawing.Point(873, 36);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(44, 16);
            this.lblGrupo.TabIndex = 24;
            this.lblGrupo.Text = "Grupo";
            // 
            // mskPrecio
            // 
            this.mskPrecio.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.mskPrecio.Location = new System.Drawing.Point(960, 330);
            this.mskPrecio.Mask = "999999";
            this.mskPrecio.Name = "mskPrecio";
            this.mskPrecio.Size = new System.Drawing.Size(177, 22);
            this.mskPrecio.TabIndex = 23;
            this.mskPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mskPrecio.ValidatingType = typeof(int);
            // 
            // txtUnidad
            // 
            this.txtUnidad.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtUnidad.Location = new System.Drawing.Point(960, 180);
            this.txtUnidad.Name = "txtUnidad";
            this.txtUnidad.Size = new System.Drawing.Size(177, 22);
            this.txtUnidad.TabIndex = 22;
            this.txtUnidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDesc
            // 
            this.txtDesc.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtDesc.Location = new System.Drawing.Point(960, 105);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(177, 22);
            this.txtDesc.TabIndex = 20;
            this.txtDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.bttGuardar.Click += new System.EventHandler(this.bttGuardar_Click);
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
            this.bttLimpiarDatos.Click += new System.EventHandler(this.bttLimpiarDatos_Click);
            // 
            // txtMaquina
            // 
            this.txtMaquina.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtMaquina.Location = new System.Drawing.Point(960, 255);
            this.txtMaquina.Name = "txtMaquina";
            this.txtMaquina.Size = new System.Drawing.Size(177, 22);
            this.txtMaquina.TabIndex = 32;
            this.txtMaquina.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bttCargarRefacciones
            // 
            this.bttCargarRefacciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bttCargarRefacciones.Location = new System.Drawing.Point(659, 12);
            this.bttCargarRefacciones.Name = "bttCargarRefacciones";
            this.bttCargarRefacciones.Size = new System.Drawing.Size(177, 28);
            this.bttCargarRefacciones.TabIndex = 33;
            this.bttCargarRefacciones.Text = "Cargar ";
            this.bttCargarRefacciones.UseVisualStyleBackColor = true;
            this.bttCargarRefacciones.Click += new System.EventHandler(this.bttCargarRefacciones_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(868, 411);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 35;
            this.label1.Text = "Máximo";
            // 
            // mskMax
            // 
            this.mskMax.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.mskMax.Location = new System.Drawing.Point(960, 405);
            this.mskMax.Mask = "999999";
            this.mskMax.Name = "mskMax";
            this.mskMax.Size = new System.Drawing.Size(177, 22);
            this.mskMax.TabIndex = 34;
            this.mskMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mskMax.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(870, 486);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 37;
            this.label2.Text = "Minimo";
            // 
            // mskMin
            // 
            this.mskMin.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.mskMin.Location = new System.Drawing.Point(960, 480);
            this.mskMin.Mask = "999999";
            this.mskMin.Name = "mskMin";
            this.mskMin.Size = new System.Drawing.Size(177, 22);
            this.mskMin.TabIndex = 36;
            this.mskMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mskMin.ValidatingType = typeof(int);
            // 
            // lblMoneda
            // 
            this.lblMoneda.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblMoneda.AutoSize = true;
            this.lblMoneda.Location = new System.Drawing.Point(870, 561);
            this.lblMoneda.Name = "lblMoneda";
            this.lblMoneda.Size = new System.Drawing.Size(57, 16);
            this.lblMoneda.TabIndex = 39;
            this.lblMoneda.Text = "Moneda";
            // 
            // cmbMoneda
            // 
            this.cmbMoneda.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cmbMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMoneda.FormattingEnabled = true;
            this.cmbMoneda.Items.AddRange(new object[] {
            "MXN",
            "USD",
            "CAD",
            "EUR"});
            this.cmbMoneda.Location = new System.Drawing.Point(964, 553);
            this.cmbMoneda.Name = "cmbMoneda";
            this.cmbMoneda.Size = new System.Drawing.Size(177, 24);
            this.cmbMoneda.TabIndex = 40;
            // 
            // FrmCatalogoRefacciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 689);
            this.Controls.Add(this.cmbMoneda);
            this.Controls.Add(this.lblMoneda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mskMin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mskMax);
            this.Controls.Add(this.bttCargarRefacciones);
            this.Controls.Add(this.txtMaquina);
            this.Controls.Add(this.bttLimpiarDatos);
            this.Controls.Add(this.bttGuardar);
            this.Controls.Add(this.cmbGrupo);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblMaquina);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblUnidad);
            this.Controls.Add(this.lblGrupo);
            this.Controls.Add(this.mskPrecio);
            this.Controls.Add(this.txtUnidad);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.dtgRefacciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCatalogoRefacciones";
            this.Text = "FrmCatalogoRefacciones";
            ((System.ComponentModel.ISupportInitialize)(this.dtgRefacciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgRefacciones;
        private System.Windows.Forms.ComboBox cmbGrupo;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblMaquina;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblUnidad;
        private System.Windows.Forms.Label lblGrupo;
        private System.Windows.Forms.MaskedTextBox mskPrecio;
        private System.Windows.Forms.TextBox txtUnidad;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Button bttGuardar;
        private System.Windows.Forms.Button bttLimpiarDatos;
        private System.Windows.Forms.TextBox txtMaquina;
        private System.Windows.Forms.Button bttCargarRefacciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskMax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mskMin;
        private System.Windows.Forms.Label lblMoneda;
        private System.Windows.Forms.ComboBox cmbMoneda;
    }
}