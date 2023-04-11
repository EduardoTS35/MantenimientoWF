namespace AppMantenimiento
{
    partial class FrmRevision
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
            this.dtgActividades = new System.Windows.Forms.DataGridView();
            this.grpOrden = new System.Windows.Forms.GroupBox();
            this.bttQuitarFiltro = new System.Windows.Forms.Button();
            this.bttImprimir = new System.Windows.Forms.Button();
            this.lblMaquina = new System.Windows.Forms.Label();
            this.cmbMaquina = new System.Windows.Forms.ComboBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.cmbFiltroArea = new System.Windows.Forms.ComboBox();
            this.lblTrabajador = new System.Windows.Forms.Label();
            this.cmbTrabajadores = new System.Windows.Forms.ComboBox();
            this.grpNotas = new System.Windows.Forms.GroupBox();
            this.txtNotas = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgActividades)).BeginInit();
            this.grpOrden.SuspendLayout();
            this.grpNotas.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgActividades
            // 
            this.dtgActividades.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgActividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgActividades.Location = new System.Drawing.Point(12, 12);
            this.dtgActividades.Name = "dtgActividades";
            this.dtgActividades.RowHeadersWidth = 51;
            this.dtgActividades.RowTemplate.Height = 24;
            this.dtgActividades.Size = new System.Drawing.Size(580, 426);
            this.dtgActividades.TabIndex = 1;
            this.dtgActividades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgActividades_CellContentClick);
            // 
            // grpOrden
            // 
            this.grpOrden.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpOrden.AutoSize = true;
            this.grpOrden.Controls.Add(this.bttQuitarFiltro);
            this.grpOrden.Controls.Add(this.bttImprimir);
            this.grpOrden.Controls.Add(this.lblMaquina);
            this.grpOrden.Controls.Add(this.cmbMaquina);
            this.grpOrden.Controls.Add(this.lblArea);
            this.grpOrden.Controls.Add(this.cmbFiltroArea);
            this.grpOrden.Controls.Add(this.lblTrabajador);
            this.grpOrden.Controls.Add(this.cmbTrabajadores);
            this.grpOrden.Location = new System.Drawing.Point(598, 12);
            this.grpOrden.Name = "grpOrden";
            this.grpOrden.Size = new System.Drawing.Size(278, 251);
            this.grpOrden.TabIndex = 7;
            this.grpOrden.TabStop = false;
            this.grpOrden.Text = "Filtros";
            // 
            // bttQuitarFiltro
            // 
            this.bttQuitarFiltro.Location = new System.Drawing.Point(150, 173);
            this.bttQuitarFiltro.Name = "bttQuitarFiltro";
            this.bttQuitarFiltro.Size = new System.Drawing.Size(100, 31);
            this.bttQuitarFiltro.TabIndex = 13;
            this.bttQuitarFiltro.Text = "Quitar Filtro";
            this.bttQuitarFiltro.UseVisualStyleBackColor = true;
            this.bttQuitarFiltro.Click += new System.EventHandler(this.bttQuitarFiltro_Click);
            // 
            // bttImprimir
            // 
            this.bttImprimir.Location = new System.Drawing.Point(25, 173);
            this.bttImprimir.Name = "bttImprimir";
            this.bttImprimir.Size = new System.Drawing.Size(100, 31);
            this.bttImprimir.TabIndex = 12;
            this.bttImprimir.Text = "Imprimir";
            this.bttImprimir.UseVisualStyleBackColor = true;
            this.bttImprimir.Click += new System.EventHandler(this.bttImprimir_Click);
            // 
            // lblMaquina
            // 
            this.lblMaquina.AutoSize = true;
            this.lblMaquina.Location = new System.Drawing.Point(22, 109);
            this.lblMaquina.Name = "lblMaquina";
            this.lblMaquina.Size = new System.Drawing.Size(59, 16);
            this.lblMaquina.TabIndex = 11;
            this.lblMaquina.Text = "Maquina";
            // 
            // cmbMaquina
            // 
            this.cmbMaquina.FormattingEnabled = true;
            this.cmbMaquina.Location = new System.Drawing.Point(130, 106);
            this.cmbMaquina.Name = "cmbMaquina";
            this.cmbMaquina.Size = new System.Drawing.Size(134, 24);
            this.cmbMaquina.TabIndex = 10;
            this.cmbMaquina.SelectedIndexChanged += new System.EventHandler(this.cmbMaquina_SelectedIndexChanged);
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(22, 66);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(36, 16);
            this.lblArea.TabIndex = 9;
            this.lblArea.Text = "Área";
            // 
            // cmbFiltroArea
            // 
            this.cmbFiltroArea.FormattingEnabled = true;
            this.cmbFiltroArea.Location = new System.Drawing.Point(130, 63);
            this.cmbFiltroArea.Name = "cmbFiltroArea";
            this.cmbFiltroArea.Size = new System.Drawing.Size(134, 24);
            this.cmbFiltroArea.TabIndex = 8;
            this.cmbFiltroArea.SelectedIndexChanged += new System.EventHandler(this.cmbFiltroArea_SelectedIndexChanged);
            // 
            // lblTrabajador
            // 
            this.lblTrabajador.AutoSize = true;
            this.lblTrabajador.Location = new System.Drawing.Point(22, 28);
            this.lblTrabajador.Name = "lblTrabajador";
            this.lblTrabajador.Size = new System.Drawing.Size(78, 16);
            this.lblTrabajador.TabIndex = 7;
            this.lblTrabajador.Text = "Trabajador:";
            // 
            // cmbTrabajadores
            // 
            this.cmbTrabajadores.FormattingEnabled = true;
            this.cmbTrabajadores.Location = new System.Drawing.Point(130, 28);
            this.cmbTrabajadores.Name = "cmbTrabajadores";
            this.cmbTrabajadores.Size = new System.Drawing.Size(134, 24);
            this.cmbTrabajadores.TabIndex = 6;
            this.cmbTrabajadores.SelectedIndexChanged += new System.EventHandler(this.cmbTrabajadores_SelectedIndexChanged);
            // 
            // grpNotas
            // 
            this.grpNotas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpNotas.AutoSize = true;
            this.grpNotas.Controls.Add(this.txtNotas);
            this.grpNotas.Location = new System.Drawing.Point(598, 269);
            this.grpNotas.Name = "grpNotas";
            this.grpNotas.Size = new System.Drawing.Size(278, 169);
            this.grpNotas.TabIndex = 8;
            this.grpNotas.TabStop = false;
            this.grpNotas.Text = "Notas";
            // 
            // txtNotas
            // 
            this.txtNotas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNotas.Location = new System.Drawing.Point(19, 50);
            this.txtNotas.MaxLength = 500;
            this.txtNotas.Multiline = true;
            this.txtNotas.Name = "txtNotas";
            this.txtNotas.Size = new System.Drawing.Size(245, 98);
            this.txtNotas.TabIndex = 13;
            // 
            // FrmRevision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(881, 450);
            this.Controls.Add(this.grpNotas);
            this.Controls.Add(this.grpOrden);
            this.Controls.Add(this.dtgActividades);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRevision";
            this.Text = "FrmRevision";
            ((System.ComponentModel.ISupportInitialize)(this.dtgActividades)).EndInit();
            this.grpOrden.ResumeLayout(false);
            this.grpOrden.PerformLayout();
            this.grpNotas.ResumeLayout(false);
            this.grpNotas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgActividades;
        private System.Windows.Forms.GroupBox grpOrden;
        private System.Windows.Forms.Label lblTrabajador;
        private System.Windows.Forms.ComboBox cmbTrabajadores;
        private System.Windows.Forms.Label lblMaquina;
        private System.Windows.Forms.ComboBox cmbMaquina;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.ComboBox cmbFiltroArea;
        private System.Windows.Forms.Button bttImprimir;
        private System.Windows.Forms.GroupBox grpNotas;
        private System.Windows.Forms.TextBox txtNotas;
        private System.Windows.Forms.Button bttQuitarFiltro;
    }
}