namespace AppMantenimiento
{
    partial class FrmChilCatalogoRefacciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChilCatalogoRefacciones));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.lblNombreActividad = new System.Windows.Forms.Label();
            this.txtNombreActividad = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.nmrPrecio = new System.Windows.Forms.NumericUpDown();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.lblRecuersoH = new System.Windows.Forms.Label();
            this.nmrPeriodo = new System.Windows.Forms.NumericUpDown();
            this.nmrRH = new System.Windows.Forms.NumericUpDown();
            this.lblUnidad = new System.Windows.Forms.Label();
            this.txtUnidad = new System.Windows.Forms.TextBox();
            this.bttGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmrPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrPeriodo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrRH)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(80, 29);
            this.lblTitulo.TabIndex = 17;
            this.lblTitulo.Text = "Titulo";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(339, 136);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(79, 16);
            this.lblDesc.TabIndex = 21;
            this.lblDesc.Text = "Descripción";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(17, 130);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(300, 22);
            this.txtDesc.TabIndex = 20;
            this.txtDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNombreActividad
            // 
            this.lblNombreActividad.AutoSize = true;
            this.lblNombreActividad.Location = new System.Drawing.Point(339, 68);
            this.lblNombreActividad.Name = "lblNombreActividad";
            this.lblNombreActividad.Size = new System.Drawing.Size(115, 16);
            this.lblNombreActividad.TabIndex = 19;
            this.lblNombreActividad.Text = "Nombre Actividad";
            // 
            // txtNombreActividad
            // 
            this.txtNombreActividad.Location = new System.Drawing.Point(17, 62);
            this.txtNombreActividad.Name = "txtNombreActividad";
            this.txtNombreActividad.Size = new System.Drawing.Size(300, 22);
            this.txtNombreActividad.TabIndex = 18;
            this.txtNombreActividad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(339, 204);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(46, 16);
            this.lblPrecio.TabIndex = 23;
            this.lblPrecio.Text = "Precio";
            // 
            // nmrPrecio
            // 
            this.nmrPrecio.DecimalPlaces = 2;
            this.nmrPrecio.Location = new System.Drawing.Point(17, 198);
            this.nmrPrecio.Name = "nmrPrecio";
            this.nmrPrecio.Size = new System.Drawing.Size(300, 22);
            this.nmrPrecio.TabIndex = 22;
            this.nmrPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.Location = new System.Drawing.Point(339, 340);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(54, 16);
            this.lblPeriodo.TabIndex = 27;
            this.lblPeriodo.Text = "Máximo";
            // 
            // lblRecuersoH
            // 
            this.lblRecuersoH.AutoSize = true;
            this.lblRecuersoH.Location = new System.Drawing.Point(339, 272);
            this.lblRecuersoH.Name = "lblRecuersoH";
            this.lblRecuersoH.Size = new System.Drawing.Size(50, 16);
            this.lblRecuersoH.TabIndex = 26;
            this.lblRecuersoH.Text = "Mínimo";
            // 
            // nmrPeriodo
            // 
            this.nmrPeriodo.Location = new System.Drawing.Point(17, 334);
            this.nmrPeriodo.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nmrPeriodo.Name = "nmrPeriodo";
            this.nmrPeriodo.Size = new System.Drawing.Size(300, 22);
            this.nmrPeriodo.TabIndex = 25;
            this.nmrPeriodo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nmrRH
            // 
            this.nmrRH.Location = new System.Drawing.Point(17, 266);
            this.nmrRH.Name = "nmrRH";
            this.nmrRH.Size = new System.Drawing.Size(300, 22);
            this.nmrRH.TabIndex = 24;
            this.nmrRH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblUnidad
            // 
            this.lblUnidad.AutoSize = true;
            this.lblUnidad.Location = new System.Drawing.Point(339, 408);
            this.lblUnidad.Name = "lblUnidad";
            this.lblUnidad.Size = new System.Drawing.Size(51, 16);
            this.lblUnidad.TabIndex = 29;
            this.lblUnidad.Text = "Unidad";
            // 
            // txtUnidad
            // 
            this.txtUnidad.Location = new System.Drawing.Point(17, 402);
            this.txtUnidad.Name = "txtUnidad";
            this.txtUnidad.Size = new System.Drawing.Size(300, 22);
            this.txtUnidad.TabIndex = 28;
            this.txtUnidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bttGuardar
            // 
            this.bttGuardar.Location = new System.Drawing.Point(166, 474);
            this.bttGuardar.Name = "bttGuardar";
            this.bttGuardar.Size = new System.Drawing.Size(173, 23);
            this.bttGuardar.TabIndex = 30;
            this.bttGuardar.Text = "Guardar";
            this.bttGuardar.UseVisualStyleBackColor = true;
            // 
            // FrmChilCatalogoRefacciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 532);
            this.Controls.Add(this.bttGuardar);
            this.Controls.Add(this.lblUnidad);
            this.Controls.Add(this.txtUnidad);
            this.Controls.Add(this.lblPeriodo);
            this.Controls.Add(this.lblRecuersoH);
            this.Controls.Add(this.nmrPeriodo);
            this.Controls.Add(this.nmrRH);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.nmrPrecio);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.lblNombreActividad);
            this.Controls.Add(this.txtNombreActividad);
            this.Controls.Add(this.lblTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmChilCatalogoRefacciones";
            this.Text = "Refacciones";
            ((System.ComponentModel.ISupportInitialize)(this.nmrPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrPeriodo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrRH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label lblNombreActividad;
        private System.Windows.Forms.TextBox txtNombreActividad;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.NumericUpDown nmrPrecio;
        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.Label lblRecuersoH;
        private System.Windows.Forms.NumericUpDown nmrPeriodo;
        private System.Windows.Forms.NumericUpDown nmrRH;
        private System.Windows.Forms.Label lblUnidad;
        private System.Windows.Forms.TextBox txtUnidad;
        private System.Windows.Forms.Button bttGuardar;
    }
}