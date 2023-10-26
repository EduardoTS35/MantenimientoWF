namespace AppMantenimiento
{
    partial class FrmGenerarReporteRefacciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGenerarReporteRefacciones));
            this.bttAceptar = new System.Windows.Forms.Button();
            this.dtpA = new System.Windows.Forms.DateTimePicker();
            this.dtpDe = new System.Windows.Forms.DateTimePicker();
            this.lblFecha2 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bttAceptar
            // 
            this.bttAceptar.Location = new System.Drawing.Point(159, 189);
            this.bttAceptar.Name = "bttAceptar";
            this.bttAceptar.Size = new System.Drawing.Size(83, 31);
            this.bttAceptar.TabIndex = 16;
            this.bttAceptar.Text = "Aceptar";
            this.bttAceptar.UseVisualStyleBackColor = true;
            this.bttAceptar.Click += new System.EventHandler(this.bttAceptar_Click);
            // 
            // dtpA
            // 
            this.dtpA.Location = new System.Drawing.Point(123, 92);
            this.dtpA.Name = "dtpA";
            this.dtpA.Size = new System.Drawing.Size(200, 20);
            this.dtpA.TabIndex = 15;
            // 
            // dtpDe
            // 
            this.dtpDe.Location = new System.Drawing.Point(123, 37);
            this.dtpDe.Name = "dtpDe";
            this.dtpDe.Size = new System.Drawing.Size(200, 20);
            this.dtpDe.TabIndex = 14;
            // 
            // lblFecha2
            // 
            this.lblFecha2.AutoSize = true;
            this.lblFecha2.Location = new System.Drawing.Point(51, 92);
            this.lblFecha2.Name = "lblFecha2";
            this.lblFecha2.Size = new System.Drawing.Size(19, 13);
            this.lblFecha2.TabIndex = 13;
            this.lblFecha2.Text = "a: ";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(51, 42);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(27, 13);
            this.lblFecha.TabIndex = 12;
            this.lblFecha.Text = "De: ";
            // 
            // FrmGenerarReporteRefacciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 257);
            this.Controls.Add(this.bttAceptar);
            this.Controls.Add(this.dtpA);
            this.Controls.Add(this.dtpDe);
            this.Controls.Add(this.lblFecha2);
            this.Controls.Add(this.lblFecha);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmGenerarReporteRefacciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generar Reporte General";
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