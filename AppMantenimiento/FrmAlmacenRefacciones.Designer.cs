namespace AppMantenimiento
{
    partial class FrmAlmacenRefacciones
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.bttRegistrarCompra = new System.Windows.Forms.Button();
            this.bttSolicitudes = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Refacción = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRefacciones)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgRefacciones
            // 
            this.dtgRefacciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgRefacciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgRefacciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Refacción,
            this.Cantidad});
            this.dtgRefacciones.Location = new System.Drawing.Point(12, 54);
            this.dtgRefacciones.Name = "dtgRefacciones";
            this.dtgRefacciones.RowHeadersWidth = 51;
            this.dtgRefacciones.RowTemplate.Height = 24;
            this.dtgRefacciones.Size = new System.Drawing.Size(569, 500);
            this.dtgRefacciones.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(9, 21);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(144, 16);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "Productos en almacén:";
            // 
            // bttRegistrarCompra
            // 
            this.bttRegistrarCompra.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bttRegistrarCompra.Location = new System.Drawing.Point(669, 54);
            this.bttRegistrarCompra.Name = "bttRegistrarCompra";
            this.bttRegistrarCompra.Size = new System.Drawing.Size(133, 45);
            this.bttRegistrarCompra.TabIndex = 9;
            this.bttRegistrarCompra.Text = "Registrar Compra";
            this.bttRegistrarCompra.UseVisualStyleBackColor = true;
            this.bttRegistrarCompra.Click += new System.EventHandler(this.bttRegistrarCompra_Click);
            // 
            // bttSolicitudes
            // 
            this.bttSolicitudes.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bttSolicitudes.Location = new System.Drawing.Point(669, 376);
            this.bttSolicitudes.Name = "bttSolicitudes";
            this.bttSolicitudes.Size = new System.Drawing.Size(133, 45);
            this.bttSolicitudes.TabIndex = 10;
            this.bttSolicitudes.Text = "Solicitudes";
            this.bttSolicitudes.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.Location = new System.Drawing.Point(669, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 45);
            this.button1.TabIndex = 11;
            this.button1.Text = "Registrar Salida";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Refacción
            // 
            this.Refacción.HeaderText = "Refaccion";
            this.Refacción.MinimumWidth = 6;
            this.Refacción.Name = "Refacción";
            this.Refacción.Width = 125;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 125;
            // 
            // FrmAlmacenRefacciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(922, 592);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bttSolicitudes);
            this.Controls.Add(this.bttRegistrarCompra);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dtgRefacciones);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAlmacenRefacciones";
            this.Text = "FrmAlmacenRefacciones";
            ((System.ComponentModel.ISupportInitialize)(this.dtgRefacciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgRefacciones;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button bttRegistrarCompra;
        private System.Windows.Forms.Button bttSolicitudes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Refacción;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
    }
}