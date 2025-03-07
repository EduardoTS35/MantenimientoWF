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
            this.dtpFechaActividad = new System.Windows.Forms.DateTimePicker();
            this.lblArea = new System.Windows.Forms.Label();
            this.cmbFiltroArea = new System.Windows.Forms.ComboBox();
            this.bttGuardarCorrectivo = new System.Windows.Forms.Button();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.nmrTiempoParo = new System.Windows.Forms.NumericUpDown();
            this.lblTrabajador = new System.Windows.Forms.Label();
            this.cmbTrabajadores = new System.Windows.Forms.ComboBox();
            this.lblMaquina = new System.Windows.Forms.Label();
            this.cmbMaquina = new System.Windows.Forms.ComboBox();
            this.grpListadoTrabajador = new System.Windows.Forms.GroupBox();
            this.bttCerrarListado = new System.Windows.Forms.Button();
            this.bttGuardarListado = new System.Windows.Forms.Button();
            this.lblDescListado = new System.Windows.Forms.Label();
            this.txtDescListado = new System.Windows.Forms.TextBox();
            this.lblHrsTrabajadas = new System.Windows.Forms.Label();
            this.nmrHorasTrabajadas = new System.Windows.Forms.NumericUpDown();
            this.lblListadoTrabajador = new System.Windows.Forms.Label();
            this.cmbListadoTrabajadores = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.bttFiltro = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.bttRestablecer = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgActividades)).BeginInit();
            this.grpCorrectivo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrTiempoParo)).BeginInit();
            this.grpListadoTrabajador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrHorasTrabajadas)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgActividades
            // 
            this.dtgActividades.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgActividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dtgActividades, 4);
            this.dtgActividades.Location = new System.Drawing.Point(2, 77);
            this.dtgActividades.Margin = new System.Windows.Forms.Padding(2);
            this.dtgActividades.Name = "dtgActividades";
            this.dtgActividades.RowHeadersWidth = 51;
            this.tableLayoutPanel1.SetRowSpan(this.dtgActividades, 2);
            this.dtgActividades.RowTemplate.Height = 24;
            this.dtgActividades.Size = new System.Drawing.Size(356, 487);
            this.dtgActividades.TabIndex = 1;
            this.dtgActividades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgActividades_CellContentClick);
            // 
            // grpCorrectivo
            // 
            this.grpCorrectivo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.grpCorrectivo, 3);
            this.grpCorrectivo.Controls.Add(this.dtpFechaActividad);
            this.grpCorrectivo.Controls.Add(this.lblArea);
            this.grpCorrectivo.Controls.Add(this.cmbFiltroArea);
            this.grpCorrectivo.Controls.Add(this.bttGuardarCorrectivo);
            this.grpCorrectivo.Controls.Add(this.lblDesc);
            this.grpCorrectivo.Controls.Add(this.txtDesc);
            this.grpCorrectivo.Controls.Add(this.label1);
            this.grpCorrectivo.Controls.Add(this.lblPeriodo);
            this.grpCorrectivo.Controls.Add(this.nmrTiempoParo);
            this.grpCorrectivo.Controls.Add(this.lblTrabajador);
            this.grpCorrectivo.Controls.Add(this.cmbTrabajadores);
            this.grpCorrectivo.Controls.Add(this.lblMaquina);
            this.grpCorrectivo.Controls.Add(this.cmbMaquina);
            this.grpCorrectivo.Location = new System.Drawing.Point(362, 77);
            this.grpCorrectivo.Margin = new System.Windows.Forms.Padding(2);
            this.grpCorrectivo.Name = "grpCorrectivo";
            this.grpCorrectivo.Padding = new System.Windows.Forms.Padding(2);
            this.grpCorrectivo.Size = new System.Drawing.Size(273, 255);
            this.grpCorrectivo.TabIndex = 8;
            this.grpCorrectivo.TabStop = false;
            this.grpCorrectivo.Text = "Actividad Correctiva";
            // 
            // dtpFechaActividad
            // 
            this.dtpFechaActividad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFechaActividad.Location = new System.Drawing.Point(5, 128);
            this.dtpFechaActividad.Name = "dtpFechaActividad";
            this.dtpFechaActividad.Size = new System.Drawing.Size(155, 20);
            this.dtpFechaActividad.TabIndex = 19;
            // 
            // lblArea
            // 
            this.lblArea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(177, 49);
            this.lblArea.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(29, 13);
            this.lblArea.TabIndex = 18;
            this.lblArea.Text = "Área";
            // 
            // cmbFiltroArea
            // 
            this.cmbFiltroArea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFiltroArea.FormattingEnabled = true;
            this.cmbFiltroArea.Location = new System.Drawing.Point(7, 45);
            this.cmbFiltroArea.Margin = new System.Windows.Forms.Padding(2);
            this.cmbFiltroArea.Name = "cmbFiltroArea";
            this.cmbFiltroArea.Size = new System.Drawing.Size(153, 21);
            this.cmbFiltroArea.TabIndex = 17;
            this.cmbFiltroArea.SelectedIndexChanged += new System.EventHandler(this.cmbFiltroArea_SelectedIndexChanged);
            // 
            // bttGuardarCorrectivo
            // 
            this.bttGuardarCorrectivo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bttGuardarCorrectivo.Location = new System.Drawing.Point(62, 222);
            this.bttGuardarCorrectivo.Margin = new System.Windows.Forms.Padding(2);
            this.bttGuardarCorrectivo.Name = "bttGuardarCorrectivo";
            this.bttGuardarCorrectivo.Size = new System.Drawing.Size(138, 25);
            this.bttGuardarCorrectivo.TabIndex = 16;
            this.bttGuardarCorrectivo.Text = "Guardar";
            this.bttGuardarCorrectivo.UseVisualStyleBackColor = true;
            this.bttGuardarCorrectivo.Click += new System.EventHandler(this.bttGuardarCorrectivo_Click);
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(13, 158);
            this.lblDesc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(63, 13);
            this.lblDesc.TabIndex = 15;
            this.lblDesc.Text = "Descripción";
            // 
            // txtDesc
            // 
            this.txtDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDesc.Location = new System.Drawing.Point(12, 183);
            this.txtDesc.Margin = new System.Windows.Forms.Padding(2);
            this.txtDesc.MaxLength = 500;
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(248, 35);
            this.txtDesc.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 132);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Fecha de actividad";
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.Location = new System.Drawing.Point(171, 105);
            this.lblPeriodo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(82, 13);
            this.lblPeriodo.TabIndex = 11;
            this.lblPeriodo.Text = "Tiempo de Paro";
            // 
            // nmrTiempoParo
            // 
            this.nmrTiempoParo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nmrTiempoParo.DecimalPlaces = 2;
            this.nmrTiempoParo.Location = new System.Drawing.Point(7, 101);
            this.nmrTiempoParo.Margin = new System.Windows.Forms.Padding(2);
            this.nmrTiempoParo.Name = "nmrTiempoParo";
            this.nmrTiempoParo.Size = new System.Drawing.Size(151, 20);
            this.nmrTiempoParo.TabIndex = 10;
            // 
            // lblTrabajador
            // 
            this.lblTrabajador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTrabajador.AutoSize = true;
            this.lblTrabajador.Location = new System.Drawing.Point(177, 21);
            this.lblTrabajador.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTrabajador.Name = "lblTrabajador";
            this.lblTrabajador.Size = new System.Drawing.Size(58, 13);
            this.lblTrabajador.TabIndex = 9;
            this.lblTrabajador.Text = "Trabajador";
            // 
            // cmbTrabajadores
            // 
            this.cmbTrabajadores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTrabajadores.FormattingEnabled = true;
            this.cmbTrabajadores.Location = new System.Drawing.Point(7, 17);
            this.cmbTrabajadores.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTrabajadores.Name = "cmbTrabajadores";
            this.cmbTrabajadores.Size = new System.Drawing.Size(153, 21);
            this.cmbTrabajadores.TabIndex = 8;
            // 
            // lblMaquina
            // 
            this.lblMaquina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMaquina.AutoSize = true;
            this.lblMaquina.Location = new System.Drawing.Point(177, 77);
            this.lblMaquina.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaquina.Name = "lblMaquina";
            this.lblMaquina.Size = new System.Drawing.Size(48, 13);
            this.lblMaquina.TabIndex = 3;
            this.lblMaquina.Text = "Maquina";
            // 
            // cmbMaquina
            // 
            this.cmbMaquina.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbMaquina.FormattingEnabled = true;
            this.cmbMaquina.Location = new System.Drawing.Point(7, 73);
            this.cmbMaquina.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMaquina.Name = "cmbMaquina";
            this.cmbMaquina.Size = new System.Drawing.Size(153, 21);
            this.cmbMaquina.TabIndex = 2;
            // 
            // grpListadoTrabajador
            // 
            this.grpListadoTrabajador.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.grpListadoTrabajador, 3);
            this.grpListadoTrabajador.Controls.Add(this.bttCerrarListado);
            this.grpListadoTrabajador.Controls.Add(this.bttGuardarListado);
            this.grpListadoTrabajador.Controls.Add(this.lblDescListado);
            this.grpListadoTrabajador.Controls.Add(this.txtDescListado);
            this.grpListadoTrabajador.Controls.Add(this.lblHrsTrabajadas);
            this.grpListadoTrabajador.Controls.Add(this.nmrHorasTrabajadas);
            this.grpListadoTrabajador.Controls.Add(this.lblListadoTrabajador);
            this.grpListadoTrabajador.Controls.Add(this.cmbListadoTrabajadores);
            this.grpListadoTrabajador.Location = new System.Drawing.Point(362, 336);
            this.grpListadoTrabajador.Margin = new System.Windows.Forms.Padding(2);
            this.grpListadoTrabajador.Name = "grpListadoTrabajador";
            this.grpListadoTrabajador.Padding = new System.Windows.Forms.Padding(2);
            this.grpListadoTrabajador.Size = new System.Drawing.Size(273, 228);
            this.grpListadoTrabajador.TabIndex = 9;
            this.grpListadoTrabajador.TabStop = false;
            this.grpListadoTrabajador.Text = "Listado de Trabajadores";
            // 
            // bttCerrarListado
            // 
            this.bttCerrarListado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttCerrarListado.Enabled = false;
            this.bttCerrarListado.Location = new System.Drawing.Point(161, 181);
            this.bttCerrarListado.Margin = new System.Windows.Forms.Padding(2);
            this.bttCerrarListado.Name = "bttCerrarListado";
            this.bttCerrarListado.Size = new System.Drawing.Size(103, 25);
            this.bttCerrarListado.TabIndex = 18;
            this.bttCerrarListado.Text = "Cerrar Listado";
            this.bttCerrarListado.UseVisualStyleBackColor = true;
            this.bttCerrarListado.Click += new System.EventHandler(this.bttCerrarListado_Click);
            // 
            // bttGuardarListado
            // 
            this.bttGuardarListado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bttGuardarListado.Enabled = false;
            this.bttGuardarListado.Location = new System.Drawing.Point(12, 181);
            this.bttGuardarListado.Margin = new System.Windows.Forms.Padding(2);
            this.bttGuardarListado.Name = "bttGuardarListado";
            this.bttGuardarListado.Size = new System.Drawing.Size(75, 25);
            this.bttGuardarListado.TabIndex = 17;
            this.bttGuardarListado.Text = "Guardar";
            this.bttGuardarListado.UseVisualStyleBackColor = true;
            this.bttGuardarListado.Click += new System.EventHandler(this.bttGuardarListado_Click);
            // 
            // lblDescListado
            // 
            this.lblDescListado.AutoSize = true;
            this.lblDescListado.Location = new System.Drawing.Point(13, 82);
            this.lblDescListado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescListado.Name = "lblDescListado";
            this.lblDescListado.Size = new System.Drawing.Size(63, 13);
            this.lblDescListado.TabIndex = 15;
            this.lblDescListado.Text = "Descripción";
            // 
            // txtDescListado
            // 
            this.txtDescListado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescListado.Location = new System.Drawing.Point(12, 102);
            this.txtDescListado.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescListado.MaxLength = 500;
            this.txtDescListado.Multiline = true;
            this.txtDescListado.Name = "txtDescListado";
            this.txtDescListado.Size = new System.Drawing.Size(248, 75);
            this.txtDescListado.TabIndex = 14;
            // 
            // lblHrsTrabajadas
            // 
            this.lblHrsTrabajadas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHrsTrabajadas.AutoSize = true;
            this.lblHrsTrabajadas.Location = new System.Drawing.Point(171, 56);
            this.lblHrsTrabajadas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHrsTrabajadas.Name = "lblHrsTrabajadas";
            this.lblHrsTrabajadas.Size = new System.Drawing.Size(91, 13);
            this.lblHrsTrabajadas.TabIndex = 11;
            this.lblHrsTrabajadas.Text = "Horas Trabajadas";
            // 
            // nmrHorasTrabajadas
            // 
            this.nmrHorasTrabajadas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nmrHorasTrabajadas.DecimalPlaces = 2;
            this.nmrHorasTrabajadas.Location = new System.Drawing.Point(7, 51);
            this.nmrHorasTrabajadas.Margin = new System.Windows.Forms.Padding(2);
            this.nmrHorasTrabajadas.Name = "nmrHorasTrabajadas";
            this.nmrHorasTrabajadas.Size = new System.Drawing.Size(151, 20);
            this.nmrHorasTrabajadas.TabIndex = 10;
            // 
            // lblListadoTrabajador
            // 
            this.lblListadoTrabajador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblListadoTrabajador.AutoSize = true;
            this.lblListadoTrabajador.Location = new System.Drawing.Point(177, 24);
            this.lblListadoTrabajador.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblListadoTrabajador.Name = "lblListadoTrabajador";
            this.lblListadoTrabajador.Size = new System.Drawing.Size(58, 13);
            this.lblListadoTrabajador.TabIndex = 9;
            this.lblListadoTrabajador.Text = "Trabajador";
            // 
            // cmbListadoTrabajadores
            // 
            this.cmbListadoTrabajadores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbListadoTrabajadores.FormattingEnabled = true;
            this.cmbListadoTrabajadores.Location = new System.Drawing.Point(7, 17);
            this.cmbListadoTrabajadores.Margin = new System.Windows.Forms.Padding(2);
            this.cmbListadoTrabajadores.Name = "cmbListadoTrabajadores";
            this.cmbListadoTrabajadores.Size = new System.Drawing.Size(153, 21);
            this.cmbListadoTrabajadores.TabIndex = 8;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Controls.Add(this.dtpFechaInicio, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtgActividades, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.grpCorrectivo, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.bttFiltro, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.grpListadoTrabajador, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtpFechaFin, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.bttRestablecer, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.130185F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.61618F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.25363F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(637, 566);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpFechaInicio.Location = new System.Drawing.Point(95, 10);
            this.dtpFechaInicio.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(80, 20);
            this.dtpFechaInicio.TabIndex = 19;
            // 
            // bttFiltro
            // 
            this.bttFiltro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bttFiltro.Location = new System.Drawing.Point(365, 5);
            this.bttFiltro.Margin = new System.Windows.Forms.Padding(5);
            this.bttFiltro.Name = "bttFiltro";
            this.bttFiltro.Size = new System.Drawing.Size(80, 33);
            this.bttFiltro.TabIndex = 16;
            this.bttFiltro.Text = "Filtrar";
            this.bttFiltro.UseVisualStyleBackColor = true;
            this.bttFiltro.Click += new System.EventHandler(this.bttFiltro_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(2, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 43);
            this.label2.TabIndex = 9;
            this.label2.Text = "Fecha Inicio";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(182, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 43);
            this.label3.TabIndex = 9;
            this.label3.Text = "Fecha Final";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpFechaFin.Location = new System.Drawing.Point(275, 10);
            this.dtpFechaFin.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(80, 20);
            this.dtpFechaFin.TabIndex = 19;
            // 
            // bttRestablecer
            // 
            this.bttRestablecer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bttRestablecer.Location = new System.Drawing.Point(545, 5);
            this.bttRestablecer.Margin = new System.Windows.Forms.Padding(5);
            this.bttRestablecer.Name = "bttRestablecer";
            this.bttRestablecer.Size = new System.Drawing.Size(87, 33);
            this.bttRestablecer.TabIndex = 16;
            this.bttRestablecer.Text = "Restablecer";
            this.bttRestablecer.UseVisualStyleBackColor = true;
            this.bttRestablecer.Click += new System.EventHandler(this.bttRestablecer_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(2, 43);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 32);
            this.label4.TabIndex = 9;
            this.label4.Text = "Descripcion:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.textBox1, 2);
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(93, 51);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(174, 20);
            this.textBox1.TabIndex = 20;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // FrmMantenimientoCorrectivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(637, 566);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmMantenimientoCorrectivo";
            this.Text = "FrmMantenimientoCorrectivo";
            ((System.ComponentModel.ISupportInitialize)(this.dtgActividades)).EndInit();
            this.grpCorrectivo.ResumeLayout(false);
            this.grpCorrectivo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrTiempoParo)).EndInit();
            this.grpListadoTrabajador.ResumeLayout(false);
            this.grpListadoTrabajador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrHorasTrabajadas)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DateTimePicker dtpFechaActividad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Button bttFiltro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Button bttRestablecer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
    }
}