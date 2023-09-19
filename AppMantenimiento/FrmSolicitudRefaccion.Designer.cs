namespace AppMantenimiento
{
    partial class FrmSolicitudRefaccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSolicitudRefaccion));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblRefaccion = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblMaquina = new System.Windows.Forms.Label();
            this.lblDescUso = new System.Windows.Forms.Label();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.cmbMaquina = new System.Windows.Forms.ComboBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.cmbFiltroArea = new System.Windows.Forms.ComboBox();
            this.nmtCantidad = new System.Windows.Forms.NumericUpDown();
            this.txtDescUso = new System.Windows.Forms.TextBox();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.bttSolicitar = new System.Windows.Forms.Button();
            this.txtRefaccion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nmtCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(224, 20);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Solicitud de Refacciones:";
            // 
            // lblRefaccion
            // 
            this.lblRefaccion.AutoSize = true;
            this.lblRefaccion.Location = new System.Drawing.Point(12, 73);
            this.lblRefaccion.Name = "lblRefaccion";
            this.lblRefaccion.Size = new System.Drawing.Size(74, 16);
            this.lblRefaccion.TabIndex = 0;
            this.lblRefaccion.Text = "Refacción: ";
            // 
            // lblCantidad
            // 
            this.lblCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(14, 370);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(67, 16);
            this.lblCantidad.TabIndex = 0;
            this.lblCantidad.Text = "Cantidad: ";
            // 
            // lblMaquina
            // 
            this.lblMaquina.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMaquina.AutoSize = true;
            this.lblMaquina.Location = new System.Drawing.Point(13, 271);
            this.lblMaquina.Name = "lblMaquina";
            this.lblMaquina.Size = new System.Drawing.Size(65, 16);
            this.lblMaquina.TabIndex = 0;
            this.lblMaquina.Text = "Maquina: ";
            // 
            // lblDescUso
            // 
            this.lblDescUso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescUso.AutoSize = true;
            this.lblDescUso.Location = new System.Drawing.Point(383, 73);
            this.lblDescUso.Name = "lblDescUso";
            this.lblDescUso.Size = new System.Drawing.Size(129, 16);
            this.lblDescUso.TabIndex = 0;
            this.lblDescUso.Text = "Descripción de Uso:";
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Location = new System.Drawing.Point(383, 271);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(102, 16);
            this.lblObservaciones.TabIndex = 0;
            this.lblObservaciones.Text = "Observaciones:";
            // 
            // cmbMaquina
            // 
            this.cmbMaquina.FormattingEnabled = true;
            this.cmbMaquina.Location = new System.Drawing.Point(92, 263);
            this.cmbMaquina.Name = "cmbMaquina";
            this.cmbMaquina.Size = new System.Drawing.Size(216, 24);
            this.cmbMaquina.TabIndex = 3;
            // 
            // lblArea
            // 
            this.lblArea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(14, 172);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(36, 16);
            this.lblArea.TabIndex = 20;
            this.lblArea.Text = "Área";
            this.lblArea.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbFiltroArea
            // 
            this.cmbFiltroArea.FormattingEnabled = true;
            this.cmbFiltroArea.Location = new System.Drawing.Point(92, 169);
            this.cmbFiltroArea.Name = "cmbFiltroArea";
            this.cmbFiltroArea.Size = new System.Drawing.Size(216, 24);
            this.cmbFiltroArea.TabIndex = 2;
            this.cmbFiltroArea.SelectedIndexChanged += new System.EventHandler(this.cmbFiltroArea_SelectedIndexChanged);
            // 
            // nmtCantidad
            // 
            this.nmtCantidad.Location = new System.Drawing.Point(105, 366);
            this.nmtCantidad.Name = "nmtCantidad";
            this.nmtCantidad.Size = new System.Drawing.Size(203, 22);
            this.nmtCantidad.TabIndex = 4;
            // 
            // txtDescUso
            // 
            this.txtDescUso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescUso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescUso.Location = new System.Drawing.Point(386, 114);
            this.txtDescUso.Multiline = true;
            this.txtDescUso.Name = "txtDescUso";
            this.txtDescUso.Size = new System.Drawing.Size(280, 84);
            this.txtDescUso.TabIndex = 5;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtObservaciones.Location = new System.Drawing.Point(386, 312);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(280, 84);
            this.txtObservaciones.TabIndex = 6;
            // 
            // bttSolicitar
            // 
            this.bttSolicitar.Location = new System.Drawing.Point(252, 450);
            this.bttSolicitar.Name = "bttSolicitar";
            this.bttSolicitar.Size = new System.Drawing.Size(153, 23);
            this.bttSolicitar.TabIndex = 21;
            this.bttSolicitar.Text = "Crear Solicitud";
            this.bttSolicitar.UseVisualStyleBackColor = true;
            this.bttSolicitar.Click += new System.EventHandler(this.bttSolicitar_Click);
            // 
            // txtRefaccion
            // 
            this.txtRefaccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRefaccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRefaccion.Location = new System.Drawing.Point(92, 52);
            this.txtRefaccion.Multiline = true;
            this.txtRefaccion.Name = "txtRefaccion";
            this.txtRefaccion.ReadOnly = true;
            this.txtRefaccion.Size = new System.Drawing.Size(216, 55);
            this.txtRefaccion.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(448, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "En stock:\r\n";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(542, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(124, 24);
            this.comboBox1.TabIndex = 24;
            // 
            // FrmSolicitudRefaccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 501);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRefaccion);
            this.Controls.Add(this.bttSolicitar);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.txtDescUso);
            this.Controls.Add(this.nmtCantidad);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.cmbFiltroArea);
            this.Controls.Add(this.cmbMaquina);
            this.Controls.Add(this.lblObservaciones);
            this.Controls.Add(this.lblDescUso);
            this.Controls.Add(this.lblMaquina);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblRefaccion);
            this.Controls.Add(this.lblTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(700, 497);
            this.Name = "FrmSolicitudRefaccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Solicitud Refacción";
            ((System.ComponentModel.ISupportInitialize)(this.nmtCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblRefaccion;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblMaquina;
        private System.Windows.Forms.Label lblDescUso;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.ComboBox cmbMaquina;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.ComboBox cmbFiltroArea;
        private System.Windows.Forms.NumericUpDown nmtCantidad;
        private System.Windows.Forms.TextBox txtDescUso;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Button bttSolicitar;
        private System.Windows.Forms.TextBox txtRefaccion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}