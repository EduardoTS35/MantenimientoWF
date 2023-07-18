namespace AppMantenimiento
{
    partial class FrmChildAlmRefEntradaSalida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChildAlmRefEntradaSalida));
            this.grpOrden = new System.Windows.Forms.GroupBox();
            this.lblTrabajador = new System.Windows.Forms.Label();
            this.cmbTrabajadores = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bttEliminarFiltro = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grpOrden.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpOrden
            // 
            this.grpOrden.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpOrden.AutoSize = true;
            this.grpOrden.Controls.Add(this.bttEliminarFiltro);
            this.grpOrden.Controls.Add(this.textBox1);
            this.grpOrden.Controls.Add(this.label1);
            this.grpOrden.Controls.Add(this.lblTrabajador);
            this.grpOrden.Controls.Add(this.cmbTrabajadores);
            this.grpOrden.Location = new System.Drawing.Point(12, 72);
            this.grpOrden.Name = "grpOrden";
            this.grpOrden.Size = new System.Drawing.Size(489, 366);
            this.grpOrden.TabIndex = 7;
            this.grpOrden.TabStop = false;
            this.grpOrden.Text = "Selección de Producto";
            // 
            // lblTrabajador
            // 
            this.lblTrabajador.AutoSize = true;
            this.lblTrabajador.Location = new System.Drawing.Point(13, 55);
            this.lblTrabajador.Name = "lblTrabajador";
            this.lblTrabajador.Size = new System.Drawing.Size(64, 16);
            this.lblTrabajador.TabIndex = 7;
            this.lblTrabajador.Text = "Producto:";
            // 
            // cmbTrabajadores
            // 
            this.cmbTrabajadores.FormattingEnabled = true;
            this.cmbTrabajadores.Location = new System.Drawing.Point(130, 47);
            this.cmbTrabajadores.Name = "cmbTrabajadores";
            this.cmbTrabajadores.Size = new System.Drawing.Size(264, 24);
            this.cmbTrabajadores.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Cantidad:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(130, 153);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(264, 22);
            this.textBox1.TabIndex = 9;
            // 
            // bttEliminarFiltro
            // 
            this.bttEliminarFiltro.Location = new System.Drawing.Point(121, 296);
            this.bttEliminarFiltro.Name = "bttEliminarFiltro";
            this.bttEliminarFiltro.Size = new System.Drawing.Size(250, 28);
            this.bttEliminarFiltro.TabIndex = 10;
            this.bttEliminarFiltro.Text = "Guardar Movimiento";
            this.bttEliminarFiltro.UseVisualStyleBackColor = true;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 22);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(161, 22);
            this.lblTitulo.TabIndex = 9;
            this.lblTitulo.Text = "Entradas o Salidas";
            // 
            // FrmChildAlmRefEntradaSalida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 450);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.grpOrden);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmChildAlmRefEntradaSalida";
            this.Text = "Refacciones";
            this.grpOrden.ResumeLayout(false);
            this.grpOrden.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpOrden;
        private System.Windows.Forms.Label lblTrabajador;
        private System.Windows.Forms.ComboBox cmbTrabajadores;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttEliminarFiltro;
        private System.Windows.Forms.Label lblTitulo;
    }
}