namespace AppMantenimiento
{
    partial class FrmAsignacionActividad
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
            this.lblTrabajador = new System.Windows.Forms.Label();
            this.cmbTrabajadores = new System.Windows.Forms.ComboBox();
            this.grpFiltros = new System.Windows.Forms.GroupBox();
            this.rdbSinAsignar = new System.Windows.Forms.RadioButton();
            this.rdbAsignadas = new System.Windows.Forms.RadioButton();
            this.bttEliminarFiltro = new System.Windows.Forms.Button();
            this.lblMaquina = new System.Windows.Forms.Label();
            this.cmbMaquina = new System.Windows.Forms.ComboBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.cmbFiltroArea = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgActividades)).BeginInit();
            this.grpOrden.SuspendLayout();
            this.grpFiltros.SuspendLayout();
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
            this.dtgActividades.Size = new System.Drawing.Size(611, 426);
            this.dtgActividades.TabIndex = 0;
            this.dtgActividades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgActividades_CellContentClick);
            // 
            // grpOrden
            // 
            this.grpOrden.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpOrden.AutoSize = true;
            this.grpOrden.Controls.Add(this.lblTrabajador);
            this.grpOrden.Controls.Add(this.cmbTrabajadores);
            this.grpOrden.Location = new System.Drawing.Point(629, 12);
            this.grpOrden.Name = "grpOrden";
            this.grpOrden.Size = new System.Drawing.Size(284, 73);
            this.grpOrden.TabIndex = 6;
            this.grpOrden.TabStop = false;
            this.grpOrden.Text = "Selección de Trabajador";
            // 
            // lblTrabajador
            // 
            this.lblTrabajador.AutoSize = true;
            this.lblTrabajador.Location = new System.Drawing.Point(6, 28);
            this.lblTrabajador.Name = "lblTrabajador";
            this.lblTrabajador.Size = new System.Drawing.Size(78, 16);
            this.lblTrabajador.TabIndex = 7;
            this.lblTrabajador.Text = "Trabajador:";
            // 
            // cmbTrabajadores
            // 
            this.cmbTrabajadores.FormattingEnabled = true;
            this.cmbTrabajadores.Location = new System.Drawing.Point(114, 28);
            this.cmbTrabajadores.Name = "cmbTrabajadores";
            this.cmbTrabajadores.Size = new System.Drawing.Size(134, 24);
            this.cmbTrabajadores.TabIndex = 6;
            // 
            // grpFiltros
            // 
            this.grpFiltros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpFiltros.Controls.Add(this.rdbSinAsignar);
            this.grpFiltros.Controls.Add(this.rdbAsignadas);
            this.grpFiltros.Controls.Add(this.bttEliminarFiltro);
            this.grpFiltros.Controls.Add(this.lblMaquina);
            this.grpFiltros.Controls.Add(this.cmbMaquina);
            this.grpFiltros.Controls.Add(this.lblArea);
            this.grpFiltros.Controls.Add(this.cmbFiltroArea);
            this.grpFiltros.Location = new System.Drawing.Point(629, 91);
            this.grpFiltros.Name = "grpFiltros";
            this.grpFiltros.Size = new System.Drawing.Size(284, 258);
            this.grpFiltros.TabIndex = 7;
            this.grpFiltros.TabStop = false;
            this.grpFiltros.Text = "Filtros";
            // 
            // rdbSinAsignar
            // 
            this.rdbSinAsignar.AutoSize = true;
            this.rdbSinAsignar.Location = new System.Drawing.Point(132, 118);
            this.rdbSinAsignar.Name = "rdbSinAsignar";
            this.rdbSinAsignar.Size = new System.Drawing.Size(96, 20);
            this.rdbSinAsignar.TabIndex = 6;
            this.rdbSinAsignar.TabStop = true;
            this.rdbSinAsignar.Text = "Sin Asignar";
            this.rdbSinAsignar.UseVisualStyleBackColor = true;
            this.rdbSinAsignar.CheckedChanged += new System.EventHandler(this.rdbSinAsignar_CheckedChanged);
            // 
            // rdbAsignadas
            // 
            this.rdbAsignadas.AutoSize = true;
            this.rdbAsignadas.Location = new System.Drawing.Point(9, 118);
            this.rdbAsignadas.Name = "rdbAsignadas";
            this.rdbAsignadas.Size = new System.Drawing.Size(93, 20);
            this.rdbAsignadas.TabIndex = 5;
            this.rdbAsignadas.TabStop = true;
            this.rdbAsignadas.Text = "Asignadas";
            this.rdbAsignadas.UseVisualStyleBackColor = true;
            this.rdbAsignadas.CheckedChanged += new System.EventHandler(this.rdbAsignadas_CheckedChanged);
            // 
            // bttEliminarFiltro
            // 
            this.bttEliminarFiltro.Location = new System.Drawing.Point(9, 159);
            this.bttEliminarFiltro.Name = "bttEliminarFiltro";
            this.bttEliminarFiltro.Size = new System.Drawing.Size(250, 28);
            this.bttEliminarFiltro.TabIndex = 4;
            this.bttEliminarFiltro.Text = "Eliminar Filtro";
            this.bttEliminarFiltro.UseVisualStyleBackColor = true;
            this.bttEliminarFiltro.Click += new System.EventHandler(this.bttEliminarFiltro_Click);
            // 
            // lblMaquina
            // 
            this.lblMaquina.AutoSize = true;
            this.lblMaquina.Location = new System.Drawing.Point(136, 67);
            this.lblMaquina.Name = "lblMaquina";
            this.lblMaquina.Size = new System.Drawing.Size(59, 16);
            this.lblMaquina.TabIndex = 3;
            this.lblMaquina.Text = "Maquina";
            // 
            // cmbMaquina
            // 
            this.cmbMaquina.FormattingEnabled = true;
            this.cmbMaquina.Location = new System.Drawing.Point(9, 64);
            this.cmbMaquina.Name = "cmbMaquina";
            this.cmbMaquina.Size = new System.Drawing.Size(121, 24);
            this.cmbMaquina.TabIndex = 2;
            this.cmbMaquina.SelectedIndexChanged += new System.EventHandler(this.cmbMaquina_SelectedIndexChanged);
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(136, 24);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(36, 16);
            this.lblArea.TabIndex = 1;
            this.lblArea.Text = "Área";
            // 
            // cmbFiltroArea
            // 
            this.cmbFiltroArea.FormattingEnabled = true;
            this.cmbFiltroArea.Location = new System.Drawing.Point(9, 21);
            this.cmbFiltroArea.Name = "cmbFiltroArea";
            this.cmbFiltroArea.Size = new System.Drawing.Size(121, 24);
            this.cmbFiltroArea.TabIndex = 0;
            this.cmbFiltroArea.SelectedIndexChanged += new System.EventHandler(this.cmbFiltroArea_SelectedIndexChanged);
            // 
            // FrmAsignacionActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(921, 450);
            this.Controls.Add(this.grpFiltros);
            this.Controls.Add(this.grpOrden);
            this.Controls.Add(this.dtgActividades);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAsignacionActividad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAgregarPreventivo";
            ((System.ComponentModel.ISupportInitialize)(this.dtgActividades)).EndInit();
            this.grpOrden.ResumeLayout(false);
            this.grpOrden.PerformLayout();
            this.grpFiltros.ResumeLayout(false);
            this.grpFiltros.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgActividades;
        private System.Windows.Forms.GroupBox grpOrden;
        private System.Windows.Forms.GroupBox grpFiltros;
        private System.Windows.Forms.ComboBox cmbFiltroArea;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblMaquina;
        private System.Windows.Forms.ComboBox cmbMaquina;
        private System.Windows.Forms.Button bttEliminarFiltro;
        private System.Windows.Forms.RadioButton rdbSinAsignar;
        private System.Windows.Forms.RadioButton rdbAsignadas;
        private System.Windows.Forms.Label lblTrabajador;
        private System.Windows.Forms.ComboBox cmbTrabajadores;
    }
}