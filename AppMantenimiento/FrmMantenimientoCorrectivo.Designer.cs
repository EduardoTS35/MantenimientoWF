namespace AppMantenimiento
{
    partial class FrmMantenimientoCorrectivo
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
            this.grpCorrectivo = new System.Windows.Forms.GroupBox();
            this.lblMaquina = new System.Windows.Forms.Label();
            this.cmbMaquina = new System.Windows.Forms.ComboBox();
            this.lblTrabajador = new System.Windows.Forms.Label();
            this.cmbTrabajadores = new System.Windows.Forms.ComboBox();
            this.nmrTiempoParo = new System.Windows.Forms.NumericUpDown();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.grpListadoTrabajador = new System.Windows.Forms.GroupBox();
            this.lblDescListado = new System.Windows.Forms.Label();
            this.txtDescListado = new System.Windows.Forms.TextBox();
            this.lblHrsTrabajadas = new System.Windows.Forms.Label();
            this.nmrHorasTrabajadas = new System.Windows.Forms.NumericUpDown();
            this.lblListadoTrabajador = new System.Windows.Forms.Label();
            this.cmbListadoTrabajadores = new System.Windows.Forms.ComboBox();
            this.bttGuardarCorrectivo = new System.Windows.Forms.Button();
            this.bttGuardarListado = new System.Windows.Forms.Button();
            this.lblArea = new System.Windows.Forms.Label();
            this.cmbFiltroArea = new System.Windows.Forms.ComboBox();
            this.bttCerrarListado = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgActividades)).BeginInit();
            this.grpCorrectivo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrTiempoParo)).BeginInit();
            this.grpListadoTrabajador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrHorasTrabajadas)).BeginInit();
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
            this.dtgActividades.Size = new System.Drawing.Size(596, 565);
            this.dtgActividades.TabIndex = 1;
            this.dtgActividades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgActividades_CellContentClick);
            // 
            // grpCorrectivo
            // 
            this.grpCorrectivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpCorrectivo.Controls.Add(this.lblArea);
            this.grpCorrectivo.Controls.Add(this.cmbFiltroArea);
            this.grpCorrectivo.Controls.Add(this.bttGuardarCorrectivo);
            this.grpCorrectivo.Controls.Add(this.lblDesc);
            this.grpCorrectivo.Controls.Add(this.txtDesc);
            this.grpCorrectivo.Controls.Add(this.lblPeriodo);
            this.grpCorrectivo.Controls.Add(this.nmrTiempoParo);
            this.grpCorrectivo.Controls.Add(this.lblTrabajador);
            this.grpCorrectivo.Controls.Add(this.cmbTrabajadores);
            this.grpCorrectivo.Controls.Add(this.lblMaquina);
            this.grpCorrectivo.Controls.Add(this.cmbMaquina);
            this.grpCorrectivo.Location = new System.Drawing.Point(625, 12);
            this.grpCorrectivo.Name = "grpCorrectivo";
            this.grpCorrectivo.Size = new System.Drawing.Size(284, 301);
            this.grpCorrectivo.TabIndex = 8;
            this.grpCorrectivo.TabStop = false;
            this.grpCorrectivo.Text = "Actividad Correctiva";
            // 
            // lblMaquina
            // 
            this.lblMaquina.AutoSize = true;
            this.lblMaquina.Location = new System.Drawing.Point(168, 93);
            this.lblMaquina.Name = "lblMaquina";
            this.lblMaquina.Size = new System.Drawing.Size(59, 16);
            this.lblMaquina.TabIndex = 3;
            this.lblMaquina.Text = "Maquina";
            // 
            // cmbMaquina
            // 
            this.cmbMaquina.FormattingEnabled = true;
            this.cmbMaquina.Location = new System.Drawing.Point(9, 85);
            this.cmbMaquina.Name = "cmbMaquina";
            this.cmbMaquina.Size = new System.Drawing.Size(134, 24);
            this.cmbMaquina.TabIndex = 2;
            // 
            // lblTrabajador
            // 
            this.lblTrabajador.AutoSize = true;
            this.lblTrabajador.Location = new System.Drawing.Point(168, 29);
            this.lblTrabajador.Name = "lblTrabajador";
            this.lblTrabajador.Size = new System.Drawing.Size(75, 16);
            this.lblTrabajador.TabIndex = 9;
            this.lblTrabajador.Text = "Trabajador";
            // 
            // cmbTrabajadores
            // 
            this.cmbTrabajadores.FormattingEnabled = true;
            this.cmbTrabajadores.Location = new System.Drawing.Point(9, 21);
            this.cmbTrabajadores.Name = "cmbTrabajadores";
            this.cmbTrabajadores.Size = new System.Drawing.Size(134, 24);
            this.cmbTrabajadores.TabIndex = 8;
            // 
            // nmrTiempoParo
            // 
            this.nmrTiempoParo.DecimalPlaces = 2;
            this.nmrTiempoParo.Location = new System.Drawing.Point(9, 124);
            this.nmrTiempoParo.Name = "nmrTiempoParo";
            this.nmrTiempoParo.Size = new System.Drawing.Size(134, 22);
            this.nmrTiempoParo.TabIndex = 10;
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.Location = new System.Drawing.Point(160, 130);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(105, 16);
            this.lblPeriodo.TabIndex = 11;
            this.lblPeriodo.Text = "Tiempo de Paro";
            // 
            // txtDesc
            // 
            this.txtDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDesc.Location = new System.Drawing.Point(20, 188);
            this.txtDesc.MaxLength = 500;
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(245, 64);
            this.txtDesc.TabIndex = 14;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(17, 169);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(79, 16);
            this.lblDesc.TabIndex = 15;
            this.lblDesc.Text = "Descripción";
            // 
            // grpListadoTrabajador
            // 
            this.grpListadoTrabajador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpListadoTrabajador.Controls.Add(this.bttCerrarListado);
            this.grpListadoTrabajador.Controls.Add(this.bttGuardarListado);
            this.grpListadoTrabajador.Controls.Add(this.lblDescListado);
            this.grpListadoTrabajador.Controls.Add(this.txtDescListado);
            this.grpListadoTrabajador.Controls.Add(this.lblHrsTrabajadas);
            this.grpListadoTrabajador.Controls.Add(this.nmrHorasTrabajadas);
            this.grpListadoTrabajador.Controls.Add(this.lblListadoTrabajador);
            this.grpListadoTrabajador.Controls.Add(this.cmbListadoTrabajadores);
            this.grpListadoTrabajador.Location = new System.Drawing.Point(625, 319);
            this.grpListadoTrabajador.Name = "grpListadoTrabajador";
            this.grpListadoTrabajador.Size = new System.Drawing.Size(284, 258);
            this.grpListadoTrabajador.TabIndex = 9;
            this.grpListadoTrabajador.TabStop = false;
            this.grpListadoTrabajador.Text = "Listado de Trabajadores";
            // 
            // lblDescListado
            // 
            this.lblDescListado.AutoSize = true;
            this.lblDescListado.Location = new System.Drawing.Point(17, 101);
            this.lblDescListado.Name = "lblDescListado";
            this.lblDescListado.Size = new System.Drawing.Size(79, 16);
            this.lblDescListado.TabIndex = 15;
            this.lblDescListado.Text = "Descripción";
            // 
            // txtDescListado
            // 
            this.txtDescListado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescListado.Location = new System.Drawing.Point(20, 125);
            this.txtDescListado.MaxLength = 500;
            this.txtDescListado.Multiline = true;
            this.txtDescListado.Name = "txtDescListado";
            this.txtDescListado.Size = new System.Drawing.Size(245, 64);
            this.txtDescListado.TabIndex = 14;
            // 
            // lblHrsTrabajadas
            // 
            this.lblHrsTrabajadas.AutoSize = true;
            this.lblHrsTrabajadas.Location = new System.Drawing.Point(160, 69);
            this.lblHrsTrabajadas.Name = "lblHrsTrabajadas";
            this.lblHrsTrabajadas.Size = new System.Drawing.Size(118, 16);
            this.lblHrsTrabajadas.TabIndex = 11;
            this.lblHrsTrabajadas.Text = "Horas Trabajadas";
            // 
            // nmrHorasTrabajadas
            // 
            this.nmrHorasTrabajadas.DecimalPlaces = 2;
            this.nmrHorasTrabajadas.Location = new System.Drawing.Point(9, 63);
            this.nmrHorasTrabajadas.Name = "nmrHorasTrabajadas";
            this.nmrHorasTrabajadas.Size = new System.Drawing.Size(134, 22);
            this.nmrHorasTrabajadas.TabIndex = 10;
            // 
            // lblListadoTrabajador
            // 
            this.lblListadoTrabajador.AutoSize = true;
            this.lblListadoTrabajador.Location = new System.Drawing.Point(168, 29);
            this.lblListadoTrabajador.Name = "lblListadoTrabajador";
            this.lblListadoTrabajador.Size = new System.Drawing.Size(75, 16);
            this.lblListadoTrabajador.TabIndex = 9;
            this.lblListadoTrabajador.Text = "Trabajador";
            // 
            // cmbListadoTrabajadores
            // 
            this.cmbListadoTrabajadores.FormattingEnabled = true;
            this.cmbListadoTrabajadores.Location = new System.Drawing.Point(9, 21);
            this.cmbListadoTrabajadores.Name = "cmbListadoTrabajadores";
            this.cmbListadoTrabajadores.Size = new System.Drawing.Size(134, 24);
            this.cmbListadoTrabajadores.TabIndex = 8;
            // 
            // bttGuardarCorrectivo
            // 
            this.bttGuardarCorrectivo.Location = new System.Drawing.Point(82, 258);
            this.bttGuardarCorrectivo.Name = "bttGuardarCorrectivo";
            this.bttGuardarCorrectivo.Size = new System.Drawing.Size(100, 31);
            this.bttGuardarCorrectivo.TabIndex = 16;
            this.bttGuardarCorrectivo.Text = "Guardar";
            this.bttGuardarCorrectivo.UseVisualStyleBackColor = true;
            this.bttGuardarCorrectivo.Click += new System.EventHandler(this.bttGuardarCorrectivo_Click);
            // 
            // bttGuardarListado
            // 
            this.bttGuardarListado.Enabled = false;
            this.bttGuardarListado.Location = new System.Drawing.Point(20, 207);
            this.bttGuardarListado.Name = "bttGuardarListado";
            this.bttGuardarListado.Size = new System.Drawing.Size(100, 31);
            this.bttGuardarListado.TabIndex = 17;
            this.bttGuardarListado.Text = "Guardar";
            this.bttGuardarListado.UseVisualStyleBackColor = true;
            this.bttGuardarListado.Click += new System.EventHandler(this.bttGuardarListado_Click);
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(168, 59);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(36, 16);
            this.lblArea.TabIndex = 18;
            this.lblArea.Text = "Área";
            // 
            // cmbFiltroArea
            // 
            this.cmbFiltroArea.FormattingEnabled = true;
            this.cmbFiltroArea.Location = new System.Drawing.Point(9, 51);
            this.cmbFiltroArea.Name = "cmbFiltroArea";
            this.cmbFiltroArea.Size = new System.Drawing.Size(134, 24);
            this.cmbFiltroArea.TabIndex = 17;
            this.cmbFiltroArea.SelectedIndexChanged += new System.EventHandler(this.cmbFiltroArea_SelectedIndexChanged);
            // 
            // bttCerrarListado
            // 
            this.bttCerrarListado.Enabled = false;
            this.bttCerrarListado.Location = new System.Drawing.Point(126, 207);
            this.bttCerrarListado.Name = "bttCerrarListado";
            this.bttCerrarListado.Size = new System.Drawing.Size(137, 31);
            this.bttCerrarListado.TabIndex = 18;
            this.bttCerrarListado.Text = "Cerrar Listado";
            this.bttCerrarListado.UseVisualStyleBackColor = true;
            this.bttCerrarListado.Click += new System.EventHandler(this.bttCerrarListado_Click);
            // 
            // FrmMantenimientoCorrectivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(921, 589);
            this.Controls.Add(this.grpListadoTrabajador);
            this.Controls.Add(this.grpCorrectivo);
            this.Controls.Add(this.dtgActividades);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMantenimientoCorrectivo";
            this.Text = "FrmMantenimientoCorrectivo";
            ((System.ComponentModel.ISupportInitialize)(this.dtgActividades)).EndInit();
            this.grpCorrectivo.ResumeLayout(false);
            this.grpCorrectivo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrTiempoParo)).EndInit();
            this.grpListadoTrabajador.ResumeLayout(false);
            this.grpListadoTrabajador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrHorasTrabajadas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgActividades;
        private System.Windows.Forms.GroupBox grpCorrectivo;
        private System.Windows.Forms.Label lblMaquina;
        private System.Windows.Forms.ComboBox cmbMaquina;
        private System.Windows.Forms.Label lblTrabajador;
        private System.Windows.Forms.ComboBox cmbTrabajadores;
        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.NumericUpDown nmrTiempoParo;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.GroupBox grpListadoTrabajador;
        private System.Windows.Forms.Label lblDescListado;
        private System.Windows.Forms.TextBox txtDescListado;
        private System.Windows.Forms.Label lblHrsTrabajadas;
        private System.Windows.Forms.NumericUpDown nmrHorasTrabajadas;
        private System.Windows.Forms.Label lblListadoTrabajador;
        private System.Windows.Forms.ComboBox cmbListadoTrabajadores;
        private System.Windows.Forms.Button bttGuardarCorrectivo;
        private System.Windows.Forms.Button bttGuardarListado;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.ComboBox cmbFiltroArea;
        private System.Windows.Forms.Button bttCerrarListado;
    }
}