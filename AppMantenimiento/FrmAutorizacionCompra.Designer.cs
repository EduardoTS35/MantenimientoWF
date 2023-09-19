namespace AppMantenimiento
{
    partial class FrmAutorizacionCompra
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
            this.dtgSolicitudes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSolicitudes)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgSolicitudes
            // 
            this.dtgSolicitudes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgSolicitudes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSolicitudes.Location = new System.Drawing.Point(12, 12);
            this.dtgSolicitudes.Name = "dtgSolicitudes";
            this.dtgSolicitudes.RowHeadersWidth = 51;
            this.dtgSolicitudes.RowTemplate.Height = 24;
            this.dtgSolicitudes.Size = new System.Drawing.Size(1062, 657);
            this.dtgSolicitudes.TabIndex = 4;
            this.dtgSolicitudes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgSolicitudes_CellContentClick);
            // 
            // FrmAutorizacionCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 681);
            this.Controls.Add(this.dtgSolicitudes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAutorizacionCompra";
            ((System.ComponentModel.ISupportInitialize)(this.dtgSolicitudes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgSolicitudes;
    }
}