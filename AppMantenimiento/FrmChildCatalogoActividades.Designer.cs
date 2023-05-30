namespace AppMantenimiento
{
    partial class FrmChildCatalogoActividades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChildCatalogoActividades));
            this.txtNombreActividad = new System.Windows.Forms.TextBox();
            this.lblNombreActividad = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.cmbArea = new System.Windows.Forms.ComboBox();
            this.cmbMaquina = new System.Windows.Forms.ComboBox();
            this.lblMaquina = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.nmrRH = new System.Windows.Forms.NumericUpDown();
            this.nmrPeriodo = new System.Windows.Forms.NumericUpDown();
            this.nmrTiempo = new System.Windows.Forms.NumericUpDown();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.lblRecuersoH = new System.Windows.Forms.Label();
            this.dtpFechaProgramada = new System.Windows.Forms.DateTimePicker();
            this.lblFechaProgramada = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.bttGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmrRH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrPeriodo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrTiempo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombreActividad
            // 
            this.txtNombreActividad.Location = new System.Drawing.Point(51, 55);
            this.txtNombreActividad.Name = "txtNombreActividad";
            this.txtNombreActividad.Size = new System.Drawing.Size(300, 22);
            this.txtNombreActividad.TabIndex = 0;
            this.txtNombreActividad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNombreActividad
            // 
            this.lblNombreActividad.AutoSize = true;
            this.lblNombreActividad.Location = new System.Drawing.Point(378, 58);
            this.lblNombreActividad.Name = "lblNombreActividad";
            this.lblNombreActividad.Size = new System.Drawing.Size(115, 16);
            this.lblNombreActividad.TabIndex = 1;
            this.lblNombreActividad.Text = "Nombre Actividad";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(378, 127);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(79, 16);
            this.lblDesc.TabIndex = 3;
            this.lblDesc.Text = "Descripción";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(51, 100);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(300, 71);
            this.txtDesc.TabIndex = 2;
            this.txtDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbArea
            // 
            this.cmbArea.FormattingEnabled = true;
            this.cmbArea.Location = new System.Drawing.Point(51, 194);
            this.cmbArea.Name = "cmbArea";
            this.cmbArea.Size = new System.Drawing.Size(300, 24);
            this.cmbArea.TabIndex = 4;
            this.cmbArea.SelectedIndexChanged += new System.EventHandler(this.cmbArea_SelectedIndexChanged);
            // 
            // cmbMaquina
            // 
            this.cmbMaquina.FormattingEnabled = true;
            this.cmbMaquina.Location = new System.Drawing.Point(51, 241);
            this.cmbMaquina.Name = "cmbMaquina";
            this.cmbMaquina.Size = new System.Drawing.Size(300, 24);
            this.cmbMaquina.TabIndex = 5;
            // 
            // lblMaquina
            // 
            this.lblMaquina.AutoSize = true;
            this.lblMaquina.Location = new System.Drawing.Point(378, 245);
            this.lblMaquina.Name = "lblMaquina";
            this.lblMaquina.Size = new System.Drawing.Size(59, 16);
            this.lblMaquina.TabIndex = 7;
            this.lblMaquina.Text = "Maquina";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(378, 198);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(36, 16);
            this.lblArea.TabIndex = 6;
            this.lblArea.Text = "Área";
            // 
            // nmrRH
            // 
            this.nmrRH.Location = new System.Drawing.Point(51, 288);
            this.nmrRH.Name = "nmrRH";
            this.nmrRH.Size = new System.Drawing.Size(300, 22);
            this.nmrRH.TabIndex = 8;
            this.nmrRH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nmrPeriodo
            // 
            this.nmrPeriodo.Location = new System.Drawing.Point(51, 333);
            this.nmrPeriodo.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nmrPeriodo.Name = "nmrPeriodo";
            this.nmrPeriodo.Size = new System.Drawing.Size(300, 22);
            this.nmrPeriodo.TabIndex = 9;
            this.nmrPeriodo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nmrTiempo
            // 
            this.nmrTiempo.DecimalPlaces = 2;
            this.nmrTiempo.Location = new System.Drawing.Point(51, 378);
            this.nmrTiempo.Name = "nmrTiempo";
            this.nmrTiempo.Size = new System.Drawing.Size(300, 22);
            this.nmrTiempo.TabIndex = 10;
            this.nmrTiempo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Location = new System.Drawing.Point(378, 381);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(54, 16);
            this.lblTiempo.TabIndex = 13;
            this.lblTiempo.Text = "Tiempo";
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.Location = new System.Drawing.Point(378, 336);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(55, 16);
            this.lblPeriodo.TabIndex = 12;
            this.lblPeriodo.Text = "Periodo";
            // 
            // lblRecuersoH
            // 
            this.lblRecuersoH.AutoSize = true;
            this.lblRecuersoH.Location = new System.Drawing.Point(378, 291);
            this.lblRecuersoH.Name = "lblRecuersoH";
            this.lblRecuersoH.Size = new System.Drawing.Size(112, 16);
            this.lblRecuersoH.TabIndex = 11;
            this.lblRecuersoH.Text = "Recurso Humano";
            // 
            // dtpFechaProgramada
            // 
            this.dtpFechaProgramada.Location = new System.Drawing.Point(51, 423);
            this.dtpFechaProgramada.Name = "dtpFechaProgramada";
            this.dtpFechaProgramada.Size = new System.Drawing.Size(300, 22);
            this.dtpFechaProgramada.TabIndex = 14;
            // 
            // lblFechaProgramada
            // 
            this.lblFechaProgramada.AutoSize = true;
            this.lblFechaProgramada.Location = new System.Drawing.Point(378, 426);
            this.lblFechaProgramada.Name = "lblFechaProgramada";
            this.lblFechaProgramada.Size = new System.Drawing.Size(124, 16);
            this.lblFechaProgramada.TabIndex = 15;
            this.lblFechaProgramada.Text = "Fecha Programada";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(48, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(80, 29);
            this.lblTitulo.TabIndex = 16;
            this.lblTitulo.Text = "Titulo";
            // 
            // bttGuardar
            // 
            this.bttGuardar.Location = new System.Drawing.Point(178, 484);
            this.bttGuardar.Name = "bttGuardar";
            this.bttGuardar.Size = new System.Drawing.Size(173, 23);
            this.bttGuardar.TabIndex = 17;
            this.bttGuardar.Text = "Guardar";
            this.bttGuardar.UseVisualStyleBackColor = true;
            this.bttGuardar.Click += new System.EventHandler(this.bttGuardar_Click);
            // 
            // FrmChildCatalogoActividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 532);
            this.Controls.Add(this.bttGuardar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblFechaProgramada);
            this.Controls.Add(this.dtpFechaProgramada);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.lblPeriodo);
            this.Controls.Add(this.lblRecuersoH);
            this.Controls.Add(this.nmrTiempo);
            this.Controls.Add(this.nmrPeriodo);
            this.Controls.Add(this.nmrRH);
            this.Controls.Add(this.lblMaquina);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.cmbMaquina);
            this.Controls.Add(this.cmbArea);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.lblNombreActividad);
            this.Controls.Add(this.txtNombreActividad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmChildCatalogoActividades";
            this.Text = "Actividad";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmChildCatalogoActividades_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.nmrRH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrPeriodo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrTiempo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreActividad;
        private System.Windows.Forms.Label lblNombreActividad;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.ComboBox cmbArea;
        private System.Windows.Forms.ComboBox cmbMaquina;
        private System.Windows.Forms.Label lblMaquina;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.NumericUpDown nmrRH;
        private System.Windows.Forms.NumericUpDown nmrPeriodo;
        private System.Windows.Forms.NumericUpDown nmrTiempo;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.Label lblRecuersoH;
        private System.Windows.Forms.DateTimePicker dtpFechaProgramada;
        private System.Windows.Forms.Label lblFechaProgramada;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button bttGuardar;
    }
}