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
            this.bttRegistrarCompra = new System.Windows.Forms.Button();
            this.bttSolicitudes = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFiltroDesc = new System.Windows.Forms.TextBox();
            this.cmbGrupos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRefacciones)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgRefacciones
            // 
            this.dtgRefacciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgRefacciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dtgRefacciones, 4);
            this.dtgRefacciones.Location = new System.Drawing.Point(3, 3);
            this.dtgRefacciones.Name = "dtgRefacciones";
            this.dtgRefacciones.RowHeadersWidth = 51;
            this.tableLayoutPanel1.SetRowSpan(this.dtgRefacciones, 2);
            this.dtgRefacciones.RowTemplate.Height = 24;
            this.dtgRefacciones.Size = new System.Drawing.Size(916, 461);
            this.dtgRefacciones.TabIndex = 1;
            this.dtgRefacciones.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtgRefacciones_CellFormatting_1);
            // 
            // bttRegistrarCompra
            // 
            this.bttRegistrarCompra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bttRegistrarCompra.Location = new System.Drawing.Point(233, 470);
            this.bttRegistrarCompra.Name = "bttRegistrarCompra";
            this.bttRegistrarCompra.Size = new System.Drawing.Size(224, 57);
            this.bttRegistrarCompra.TabIndex = 9;
            this.bttRegistrarCompra.Text = "Registrar Compra";
            this.bttRegistrarCompra.UseVisualStyleBackColor = true;
            this.bttRegistrarCompra.Click += new System.EventHandler(this.bttRegistrarCompra_Click);
            // 
            // bttSolicitudes
            // 
            this.bttSolicitudes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bttSolicitudes.Location = new System.Drawing.Point(693, 470);
            this.bttSolicitudes.Name = "bttSolicitudes";
            this.bttSolicitudes.Size = new System.Drawing.Size(226, 57);
            this.bttSolicitudes.TabIndex = 10;
            this.bttSolicitudes.Text = "Solicitudes";
            this.bttSolicitudes.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(463, 470);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 57);
            this.button1.TabIndex = 11;
            this.button1.Text = "Registrar Salida";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.button2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.bttRegistrarCompra, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.bttSolicitudes, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.dtgRefacciones, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 56);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.98725F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.36364F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.72727F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(922, 536);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbGrupos);
            this.panel1.Controls.Add(this.txtFiltroDesc);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(922, 56);
            this.panel1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre: ";
            // 
            // txtFiltroDesc
            // 
            this.txtFiltroDesc.Location = new System.Drawing.Point(92, 16);
            this.txtFiltroDesc.Name = "txtFiltroDesc";
            this.txtFiltroDesc.Size = new System.Drawing.Size(213, 22);
            this.txtFiltroDesc.TabIndex = 1;
            this.txtFiltroDesc.TextChanged += new System.EventHandler(this.txtFiltroDesc_TextChanged);
            // 
            // cmbGrupos
            // 
            this.cmbGrupos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbGrupos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrupos.FormattingEnabled = true;
            this.cmbGrupos.Location = new System.Drawing.Point(617, 15);
            this.cmbGrupos.Name = "cmbGrupos";
            this.cmbGrupos.Size = new System.Drawing.Size(213, 24);
            this.cmbGrupos.TabIndex = 2;
            this.cmbGrupos.SelectedIndexChanged += new System.EventHandler(this.cmbGrupos_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(564, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Grupo:";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(3, 470);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(224, 57);
            this.button2.TabIndex = 12;
            this.button2.Text = "Restaurar Datos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmAlmacenRefacciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(922, 592);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAlmacenRefacciones";
            this.Text = "FrmAlmacenRefacciones";
            this.Load += new System.EventHandler(this.FrmAlmacenRefacciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgRefacciones)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgRefacciones;
        private System.Windows.Forms.Button bttRegistrarCompra;
        private System.Windows.Forms.Button bttSolicitudes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFiltroDesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbGrupos;
        private System.Windows.Forms.Button button2;
    }
}