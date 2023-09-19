namespace AppMantenimiento
{
    partial class FrmCreacionCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCreacionCompra));
            this.label1 = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbProveedor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nmrPrecio = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdSolicitud = new System.Windows.Forms.TextBox();
            this.bttGuardar = new System.Windows.Forms.Button();
            this.nmrCantidad = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmrPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Producto:";
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(143, 95);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.ReadOnly = true;
            this.txtProducto.Size = new System.Drawing.Size(208, 22);
            this.txtProducto.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Proveedor:";
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.Location = new System.Drawing.Point(143, 169);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(208, 24);
            this.cmbProveedor.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Precio: ";
            // 
            // nmrPrecio
            // 
            this.nmrPrecio.DecimalPlaces = 2;
            this.nmrPrecio.Location = new System.Drawing.Point(143, 319);
            this.nmrPrecio.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nmrPrecio.Name = "nmrPrecio";
            this.nmrPrecio.Size = new System.Drawing.Size(208, 22);
            this.nmrPrecio.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "No. Solicitud :";
            // 
            // txtIdSolicitud
            // 
            this.txtIdSolicitud.Location = new System.Drawing.Point(143, 21);
            this.txtIdSolicitud.Name = "txtIdSolicitud";
            this.txtIdSolicitud.ReadOnly = true;
            this.txtIdSolicitud.Size = new System.Drawing.Size(208, 22);
            this.txtIdSolicitud.TabIndex = 1;
            // 
            // bttGuardar
            // 
            this.bttGuardar.Location = new System.Drawing.Point(188, 388);
            this.bttGuardar.Name = "bttGuardar";
            this.bttGuardar.Size = new System.Drawing.Size(75, 23);
            this.bttGuardar.TabIndex = 6;
            this.bttGuardar.Text = "Guardar";
            this.bttGuardar.UseVisualStyleBackColor = true;
            this.bttGuardar.Click += new System.EventHandler(this.bttGuardar_Click);
            // 
            // nmrCantidad
            // 
            this.nmrCantidad.DecimalPlaces = 2;
            this.nmrCantidad.Location = new System.Drawing.Point(143, 245);
            this.nmrCantidad.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nmrCantidad.Name = "nmrCantidad";
            this.nmrCantidad.Size = new System.Drawing.Size(208, 22);
            this.nmrCantidad.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Cantidad:";
            // 
            // FrmCreacionCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 450);
            this.Controls.Add(this.nmrCantidad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bttGuardar);
            this.Controls.Add(this.txtIdSolicitud);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nmrPrecio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbProveedor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmCreacionCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear registro de compra";
            ((System.ComponentModel.ISupportInitialize)(this.nmrPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbProveedor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nmrPrecio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdSolicitud;
        private System.Windows.Forms.Button bttGuardar;
        private System.Windows.Forms.NumericUpDown nmrCantidad;
        private System.Windows.Forms.Label label5;
    }
}