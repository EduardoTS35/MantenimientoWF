namespace AppMantenimiento
{
    partial class FrmTablas
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend11 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend12 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tmrResultados = new System.Windows.Forms.Timer(this.components);
            this.grpFechas = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.grpSistema = new System.Windows.Forms.GroupBox();
            this.chrMantoSistemaP = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chrMantoSistemaC = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chrMantoAreaP = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chrMantoAreaC = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chrRealizadoVSPlaneado = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chrCorrectivoVsPreventivo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.grpFechas.SuspendLayout();
            this.grpSistema.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrMantoSistemaP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrMantoSistemaC)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrMantoAreaP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrMantoAreaC)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrRealizadoVSPlaneado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrCorrectivoVsPreventivo)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrResultados
            // 
            this.tmrResultados.Interval = 3000;
            // 
            // grpFechas
            // 
            this.grpFechas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpFechas.Controls.Add(this.radioButton2);
            this.grpFechas.Controls.Add(this.radioButton1);
            this.grpFechas.Location = new System.Drawing.Point(12, 12);
            this.grpFechas.Name = "grpFechas";
            this.grpFechas.Size = new System.Drawing.Size(1212, 49);
            this.grpFechas.TabIndex = 5;
            this.grpFechas.TabStop = false;
            this.grpFechas.Text = "Periodo";
            // 
            // radioButton2
            // 
            this.radioButton2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(537, 0);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(88, 20);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Quincenal";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(46, 21);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(79, 20);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Mensual";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // grpSistema
            // 
            this.grpSistema.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSistema.Controls.Add(this.chrMantoSistemaP);
            this.grpSistema.Controls.Add(this.chrMantoSistemaC);
            this.grpSistema.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSistema.Location = new System.Drawing.Point(513, 516);
            this.grpSistema.Name = "grpSistema";
            this.grpSistema.Size = new System.Drawing.Size(711, 188);
            this.grpSistema.TabIndex = 13;
            this.grpSistema.TabStop = false;
            this.grpSistema.Text = "Mantenimiento por Sistema";
            // 
            // chrMantoSistemaP
            // 
            this.chrMantoSistemaP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea7.Name = "ChartArea1";
            this.chrMantoSistemaP.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chrMantoSistemaP.Legends.Add(legend7);
            this.chrMantoSistemaP.Location = new System.Drawing.Point(667, 17);
            this.chrMantoSistemaP.Name = "chrMantoSistemaP";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            this.chrMantoSistemaP.Series.Add(series7);
            this.chrMantoSistemaP.Size = new System.Drawing.Size(35, 153);
            this.chrMantoSistemaP.TabIndex = 3;
            this.chrMantoSistemaP.Text = "chart4";
            // 
            // chrMantoSistemaC
            // 
            this.chrMantoSistemaC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            chartArea8.Name = "ChartArea1";
            this.chrMantoSistemaC.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.chrMantoSistemaC.Legends.Add(legend8);
            this.chrMantoSistemaC.Location = new System.Drawing.Point(22, 17);
            this.chrMantoSistemaC.Name = "chrMantoSistemaC";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series8.Legend = "Legend1";
            series8.Name = "Series1";
            this.chrMantoSistemaC.Series.Add(series8);
            this.chrMantoSistemaC.Size = new System.Drawing.Size(633, 153);
            this.chrMantoSistemaC.TabIndex = 2;
            this.chrMantoSistemaC.Text = "chart5";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.chrMantoAreaP);
            this.groupBox1.Controls.Add(this.chrMantoAreaC);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(513, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(711, 443);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mantenimiento por Área";
            // 
            // chrMantoAreaP
            // 
            this.chrMantoAreaP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            chartArea9.Name = "ChartArea1";
            this.chrMantoAreaP.ChartAreas.Add(chartArea9);
            legend9.Name = "Legend1";
            this.chrMantoAreaP.Legends.Add(legend9);
            this.chrMantoAreaP.Location = new System.Drawing.Point(22, 27);
            this.chrMantoAreaP.Margin = new System.Windows.Forms.Padding(30);
            this.chrMantoAreaP.Name = "chrMantoAreaP";
            this.chrMantoAreaP.Padding = new System.Windows.Forms.Padding(30, 0, 30, 0);
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series9.Legend = "Legend1";
            series9.Name = "Series1";
            this.chrMantoAreaP.Series.Add(series9);
            this.chrMantoAreaP.Size = new System.Drawing.Size(633, 397);
            this.chrMantoAreaP.TabIndex = 21;
            this.chrMantoAreaP.Text = "chart3";
            // 
            // chrMantoAreaC
            // 
            this.chrMantoAreaC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea10.Name = "ChartArea1";
            this.chrMantoAreaC.ChartAreas.Add(chartArea10);
            legend10.Name = "Legend1";
            this.chrMantoAreaC.Legends.Add(legend10);
            this.chrMantoAreaC.Location = new System.Drawing.Point(667, 27);
            this.chrMantoAreaC.Margin = new System.Windows.Forms.Padding(30);
            this.chrMantoAreaC.Name = "chrMantoAreaC";
            this.chrMantoAreaC.Padding = new System.Windows.Forms.Padding(30, 0, 30, 0);
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series10.Legend = "Legend1";
            series10.Name = "Series1";
            this.chrMantoAreaC.Series.Add(series10);
            this.chrMantoAreaC.Size = new System.Drawing.Size(35, 397);
            this.chrMantoAreaC.TabIndex = 23;
            this.chrMantoAreaC.Text = "chart2";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.chrRealizadoVSPlaneado);
            this.groupBox2.Controls.Add(this.chrCorrectivoVsPreventivo);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(12, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(490, 637);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Estadística General";
            // 
            // chrRealizadoVSPlaneado
            // 
            this.chrRealizadoVSPlaneado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea11.Name = "ChartArea1";
            this.chrRealizadoVSPlaneado.ChartAreas.Add(chartArea11);
            legend11.Name = "Legend1";
            this.chrRealizadoVSPlaneado.Legends.Add(legend11);
            this.chrRealizadoVSPlaneado.Location = new System.Drawing.Point(6, 466);
            this.chrRealizadoVSPlaneado.Name = "chrRealizadoVSPlaneado";
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series11.Legend = "Legend1";
            series11.Name = "Series1";
            this.chrRealizadoVSPlaneado.Series.Add(series11);
            this.chrRealizadoVSPlaneado.Size = new System.Drawing.Size(481, 153);
            this.chrRealizadoVSPlaneado.TabIndex = 23;
            this.chrRealizadoVSPlaneado.Text = "chart5";
            // 
            // chrCorrectivoVsPreventivo
            // 
            this.chrCorrectivoVsPreventivo.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.TopRight;
            chartArea12.Name = "ChartArea1";
            this.chrCorrectivoVsPreventivo.ChartAreas.Add(chartArea12);
            this.chrCorrectivoVsPreventivo.Dock = System.Windows.Forms.DockStyle.Top;
            legend12.Name = "Legend1";
            this.chrCorrectivoVsPreventivo.Legends.Add(legend12);
            this.chrCorrectivoVsPreventivo.Location = new System.Drawing.Point(3, 19);
            this.chrCorrectivoVsPreventivo.Margin = new System.Windows.Forms.Padding(30);
            this.chrCorrectivoVsPreventivo.Name = "chrCorrectivoVsPreventivo";
            this.chrCorrectivoVsPreventivo.Padding = new System.Windows.Forms.Padding(30, 0, 30, 0);
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series12.Legend = "Legend1";
            series12.Name = "Series1";
            this.chrCorrectivoVsPreventivo.Series.Add(series12);
            this.chrCorrectivoVsPreventivo.Size = new System.Drawing.Size(484, 406);
            this.chrCorrectivoVsPreventivo.TabIndex = 22;
            this.chrCorrectivoVsPreventivo.Text = "chart1";
            // 
            // FrmTablas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1239, 744);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpSistema);
            this.Controls.Add(this.grpFechas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTablas";
            this.Text = "FrmCharts";
            this.Load += new System.EventHandler(this.FrmTablas_Load);
            this.grpFechas.ResumeLayout(false);
            this.grpFechas.PerformLayout();
            this.grpSistema.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chrMantoSistemaP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrMantoSistemaC)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chrMantoAreaP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrMantoAreaC)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chrRealizadoVSPlaneado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrCorrectivoVsPreventivo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer tmrResultados;
        private System.Windows.Forms.GroupBox grpFechas;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox grpSistema;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrMantoSistemaP;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrMantoSistemaC;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrMantoAreaP;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrMantoAreaC;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrCorrectivoVsPreventivo;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrRealizadoVSPlaneado;
    }
}