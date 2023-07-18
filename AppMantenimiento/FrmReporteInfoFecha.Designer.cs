namespace AppMantenimiento
{
    partial class FrmReporteInfoFecha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReporteInfoFecha));
            this.bttAceptar = new System.Windows.Forms.Button();
            this.dtpA = new System.Windows.Forms.DateTimePicker();
            this.dtpDe = new System.Windows.Forms.DateTimePicker();
            this.lblFecha2 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bttAceptar
            // 
            this.bttAceptar.Location = new System.Drawing.Point(152, 193);
            this.bttAceptar.Name = "bttAceptar";
            this.bttAceptar.Size = new System.Drawing.Size(83, 31);
            this.bttAceptar.TabIndex = 11;
            this.bttAceptar.Text = "Aceptar";
            this.bttAceptar.UseVisualStyleBackColor = true;
            this.bttAceptar.Click += new System.EventHandler(this.bttAceptar_Click);
            // 
            // dtpA
            // 
            this.dtpA.Location = new System.Drawing.Point(116, 96);
            this.dtpA.Name = "dtpA";
            this.dtpA.Size = new System.Drawing.Size(200, 22);
            this.dtpA.TabIndex = 10;
            // 
            // dtpDe
            // 
            this.dtpDe.Location = new System.Drawing.Point(116, 41);
            this.dtpDe.Name = "dtpDe";
            this.dtpDe.Size = new System.Drawing.Size(200, 22);
            this.dtpDe.TabIndex = 9;
            // 
            // lblFecha2
            // 
            this.lblFecha2.AutoSize = true;
            this.lblFecha2.Location = new System.Drawing.Point(44, 96);
            this.lblFecha2.Name = "lblFecha2";
            this.lblFecha2.Size = new System.Drawing.Size(21, 16);
            this.lblFecha2.TabIndex = 8;
            this.lblFecha2.Text = "a: ";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(44, 46);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(31, 16);
            this.lblFecha.TabIndex = 7;
            this.lblFecha.Text = "De: ";
            // 
            // FrmReporteInfoFecha
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(375, 257);
            this.Controls.Add(this.bttAceptar);
            this.Controls.Add(this.dtpA);
            this.Controls.Add(this.dtpDe);
            this.Controls.Add(this.lblFecha2);
            this.Controls.Add(this.lblFecha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmReporteInfoFecha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Información del reporte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttAceptar;
        private System.Windows.Forms.DateTimePicker dtpA;
        private System.Windows.Forms.DateTimePicker dtpDe;
        private System.Windows.Forms.Label lblFecha2;
        private System.Windows.Forms.Label lblFecha;
    }
}