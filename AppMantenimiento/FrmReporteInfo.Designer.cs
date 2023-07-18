namespace AppMantenimiento
{
    partial class FrmReporteInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReporteInfo));
            this.lblArea = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblFecha2 = new System.Windows.Forms.Label();
            this.cmbArea = new System.Windows.Forms.ComboBox();
            this.dtpDe = new System.Windows.Forms.DateTimePicker();
            this.dtpA = new System.Windows.Forms.DateTimePicker();
            this.bttAceptar = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(39, 40);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(42, 16);
            this.lblArea.TabIndex = 0;
            this.lblArea.Text = "Área: ";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(39, 91);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(31, 16);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "De: ";
            // 
            // lblFecha2
            // 
            this.lblFecha2.AutoSize = true;
            this.lblFecha2.Location = new System.Drawing.Point(39, 141);
            this.lblFecha2.Name = "lblFecha2";
            this.lblFecha2.Size = new System.Drawing.Size(21, 16);
            this.lblFecha2.TabIndex = 2;
            this.lblFecha2.Text = "a: ";
            // 
            // cmbArea
            // 
            this.cmbArea.FormattingEnabled = true;
            this.cmbArea.Location = new System.Drawing.Point(111, 32);
            this.cmbArea.Name = "cmbArea";
            this.cmbArea.Size = new System.Drawing.Size(154, 24);
            this.cmbArea.TabIndex = 3;
            this.cmbArea.SelectedIndexChanged += new System.EventHandler(this.cmbArea_SelectedIndexChanged);
            // 
            // dtpDe
            // 
            this.dtpDe.Location = new System.Drawing.Point(111, 86);
            this.dtpDe.Name = "dtpDe";
            this.dtpDe.Size = new System.Drawing.Size(200, 22);
            this.dtpDe.TabIndex = 4;
            this.dtpDe.ValueChanged += new System.EventHandler(this.dtpDe_ValueChanged);
            // 
            // dtpA
            // 
            this.dtpA.Location = new System.Drawing.Point(111, 141);
            this.dtpA.Name = "dtpA";
            this.dtpA.Size = new System.Drawing.Size(200, 22);
            this.dtpA.TabIndex = 5;
            this.dtpA.ValueChanged += new System.EventHandler(this.dtpA_ValueChanged);
            // 
            // bttAceptar
            // 
            this.bttAceptar.Location = new System.Drawing.Point(128, 223);
            this.bttAceptar.Name = "bttAceptar";
            this.bttAceptar.Size = new System.Drawing.Size(75, 23);
            this.bttAceptar.TabIndex = 6;
            this.bttAceptar.Text = "Aceptar";
            this.bttAceptar.UseVisualStyleBackColor = true;
            this.bttAceptar.Click += new System.EventHandler(this.bttAceptar_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(42, 187);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(69, 20);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Todos";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // FrmReporteInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 280);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.bttAceptar);
            this.Controls.Add(this.dtpA);
            this.Controls.Add(this.dtpDe);
            this.Controls.Add(this.cmbArea);
            this.Controls.Add(this.lblFecha2);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblArea);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmReporteInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Información del reporte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblFecha2;
        private System.Windows.Forms.ComboBox cmbArea;
        private System.Windows.Forms.DateTimePicker dtpDe;
        private System.Windows.Forms.DateTimePicker dtpA;
        private System.Windows.Forms.Button bttAceptar;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}