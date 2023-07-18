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
            this.bttAgregar = new System.Windows.Forms.Button();
            this.grpFiltros = new System.Windows.Forms.GroupBox();
            this.bttEliminarFiltro = new System.Windows.Forms.Button();
            this.lblArea = new System.Windows.Forms.Label();
            this.dtgRefacciones = new System.Windows.Forms.DataGridView();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.grpFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRefacciones)).BeginInit();
            this.SuspendLayout();
            // 
            // bttAgregar
            // 
            this.bttAgregar.Location = new System.Drawing.Point(12, 12);
            this.bttAgregar.Name = "bttAgregar";
            this.bttAgregar.Size = new System.Drawing.Size(250, 28);
            this.bttAgregar.TabIndex = 12;
            this.bttAgregar.Text = "Agregar Refacción";
            this.bttAgregar.UseVisualStyleBackColor = true;
            this.bttAgregar.Click += new System.EventHandler(this.bttAgregar_Click);
            // 
            // grpFiltros
            // 
            this.grpFiltros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpFiltros.Controls.Add(this.txtNombre);
            this.grpFiltros.Controls.Add(this.bttEliminarFiltro);
            this.grpFiltros.Controls.Add(this.lblArea);
            this.grpFiltros.Location = new System.Drawing.Point(598, 56);
            this.grpFiltros.Name = "grpFiltros";
            this.grpFiltros.Size = new System.Drawing.Size(271, 459);
            this.grpFiltros.TabIndex = 11;
            this.grpFiltros.TabStop = false;
            this.grpFiltros.Text = "Filtros";
            // 
            // bttEliminarFiltro
            // 
            this.bttEliminarFiltro.Location = new System.Drawing.Point(6, 412);
            this.bttEliminarFiltro.Name = "bttEliminarFiltro";
            this.bttEliminarFiltro.Size = new System.Drawing.Size(250, 28);
            this.bttEliminarFiltro.TabIndex = 4;
            this.bttEliminarFiltro.Text = "Eliminar Filtro";
            this.bttEliminarFiltro.UseVisualStyleBackColor = true;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(136, 52);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(56, 16);
            this.lblArea.TabIndex = 1;
            this.lblArea.Text = "Nombre";
            // 
            // dtgRefacciones
            // 
            this.dtgRefacciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgRefacciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgRefacciones.Location = new System.Drawing.Point(12, 56);
            this.dtgRefacciones.Name = "dtgRefacciones";
            this.dtgRefacciones.RowHeadersWidth = 51;
            this.dtgRefacciones.RowTemplate.Height = 24;
            this.dtgRefacciones.Size = new System.Drawing.Size(580, 459);
            this.dtgRefacciones.TabIndex = 10;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(9, 52);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(121, 22);
            this.txtNombre.TabIndex = 5;
            // 
            // FrmCatalogoRefacciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 527);
            this.Controls.Add(this.bttAgregar);
            this.Controls.Add(this.grpFiltros);
            this.Controls.Add(this.dtgRefacciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCatalogoRefacciones";
            this.Text = "FrmCatalogoRefacciones";
            this.grpFiltros.ResumeLayout(false);
            this.grpFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRefacciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttAgregar;
        private System.Windows.Forms.GroupBox grpFiltros;
        private System.Windows.Forms.Button bttEliminarFiltro;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.DataGridView dtgRefacciones;
        private System.Windows.Forms.TextBox txtNombre;
    }
}