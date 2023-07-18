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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tmrResultados = new System.Windows.Forms.Timer(this.components);
            this.grpFechas = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.grpMecanicoElectrico = new System.Windows.Forms.GroupBox();
            this.chrMantoAreaP = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chrMantoAreaC = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.grpSistema = new System.Windows.Forms.GroupBox();
            this.chrMantoSistemaP = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chrMantoSistemaC = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chrCorrectivoVsPreventivo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpFechas.SuspendLayout();
            this.grpMecanicoElectrico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrMantoAreaP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrMantoAreaC)).BeginInit();
            this.grpSistema.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrMantoSistemaP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrMantoSistemaC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrCorrectivoVsPreventivo)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.grpFechas.Controls.Add(this.radioButton3);
            this.grpFechas.Controls.Add(this.radioButton2);
            this.grpFechas.Controls.Add(this.radioButton1);
            this.grpFechas.Location = new System.Drawing.Point(12, 12);
            this.grpFechas.Name = "grpFechas";
            this.grpFechas.Size = new System.Drawing.Size(1212, 49);
            this.grpFechas.TabIndex = 5;
            this.grpFechas.TabStop = false;
            this.grpFechas.Text = "Periodo";
            // 
            // radioButton3
            // 
            this.radioButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(914, 21);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(84, 21);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Semanal";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(482, 21);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(93, 21);
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
            this.radioButton1.Size = new System.Drawing.Size(82, 21);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Mensual";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // grpMecanicoElectrico
            // 
            this.grpMecanicoElectrico.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpMecanicoElectrico.Controls.Add(this.chrMantoAreaP);
            this.grpMecanicoElectrico.Controls.Add(this.chrMantoAreaC);
            this.grpMecanicoElectrico.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMecanicoElectrico.Location = new System.Drawing.Point(549, 67);
            this.grpMecanicoElectrico.Name = "grpMecanicoElectrico";
            this.grpMecanicoElectrico.Size = new System.Drawing.Size(675, 321);
            this.grpMecanicoElectrico.TabIndex = 12;
            this.grpMecanicoElectrico.TabStop = false;
            this.grpMecanicoElectrico.Text = "Mantenimiento por Área";
            // 
            // chrMantoAreaP
            // 
            this.chrMantoAreaP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chrMantoAreaP.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chrMantoAreaP.Legends.Add(legend1);
            this.chrMantoAreaP.Location = new System.Drawing.Point(12, 21);
            this.chrMantoAreaP.Name = "chrMantoAreaP";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chrMantoAreaP.Series.Add(series1);
            this.chrMantoAreaP.Size = new System.Drawing.Size(657, 284);
            this.chrMantoAreaP.TabIndex = 1;
            this.chrMantoAreaP.Text = "chart3";
            // 
            // chrMantoAreaC
            // 
            this.chrMantoAreaC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.chrMantoAreaC.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chrMantoAreaC.Legends.Add(legend2);
            this.chrMantoAreaC.Location = new System.Drawing.Point(-13, 21);
            this.chrMantoAreaC.Name = "chrMantoAreaC";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chrMantoAreaC.Series.Add(series2);
            this.chrMantoAreaC.Size = new System.Drawing.Size(19, 284);
            this.chrMantoAreaC.TabIndex = 0;
            this.chrMantoAreaC.Text = "chart2";
            // 
            // grpSistema
            // 
            this.grpSistema.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSistema.Controls.Add(this.chrMantoSistemaP);
            this.grpSistema.Controls.Add(this.chrMantoSistemaC);
            this.grpSistema.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSistema.Location = new System.Drawing.Point(12, 394);
            this.grpSistema.Name = "grpSistema";
            this.grpSistema.Size = new System.Drawing.Size(1212, 257);
            this.grpSistema.TabIndex = 13;
            this.grpSistema.TabStop = false;
            this.grpSistema.Text = "Mantenimiento por Sistema";
            // 
            // chrMantoSistemaP
            // 
            this.chrMantoSistemaP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea3.Name = "ChartArea1";
            this.chrMantoSistemaP.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chrMantoSistemaP.Legends.Add(legend3);
            this.chrMantoSistemaP.Location = new System.Drawing.Point(648, 17);
            this.chrMantoSistemaP.Name = "chrMantoSistemaP";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chrMantoSistemaP.Series.Add(series3);
            this.chrMantoSistemaP.Size = new System.Drawing.Size(558, 234);
            this.chrMantoSistemaP.TabIndex = 3;
            this.chrMantoSistemaP.Text = "chart4";
            // 
            // chrMantoSistemaC
            // 
            this.chrMantoSistemaC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            chartArea4.Name = "ChartArea1";
            this.chrMantoSistemaC.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chrMantoSistemaC.Legends.Add(legend4);
            this.chrMantoSistemaC.Location = new System.Drawing.Point(-4, 17);
            this.chrMantoSistemaC.Name = "chrMantoSistemaC";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chrMantoSistemaC.Series.Add(series4);
            this.chrMantoSistemaC.Size = new System.Drawing.Size(636, 234);
            this.chrMantoSistemaC.TabIndex = 2;
            this.chrMantoSistemaC.Text = "chart5";
            // 
            // chrCorrectivoVsPreventivo
            // 
            this.chrCorrectivoVsPreventivo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea5.Name = "ChartArea1";
            this.chrCorrectivoVsPreventivo.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chrCorrectivoVsPreventivo.Legends.Add(legend5);
            this.chrCorrectivoVsPreventivo.Location = new System.Drawing.Point(6, 21);
            this.chrCorrectivoVsPreventivo.Name = "chrCorrectivoVsPreventivo";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chrCorrectivoVsPreventivo.Series.Add(series5);
            this.chrCorrectivoVsPreventivo.Size = new System.Drawing.Size(519, 284);
            this.chrCorrectivoVsPreventivo.TabIndex = 14;
            this.chrCorrectivoVsPreventivo.Text = "chart1";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.chrCorrectivoVsPreventivo);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(531, 321);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mantenimiento por Área";
            // 
            // FrmTablas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1239, 744);
            this.Controls.Add(this.grpSistema);
            this.Controls.Add(this.grpMecanicoElectrico);
            this.Controls.Add(this.grpFechas);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTablas";
            this.Text = "FrmCharts";
            this.grpFechas.ResumeLayout(false);
            this.grpFechas.PerformLayout();
            this.grpMecanicoElectrico.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chrMantoAreaP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrMantoAreaC)).EndInit();
            this.grpSistema.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chrMantoSistemaP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrMantoSistemaC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrCorrectivoVsPreventivo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer tmrResultados;
        private System.Windows.Forms.GroupBox grpFechas;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox grpMecanicoElectrico;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrMantoAreaP;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrMantoAreaC;
        private System.Windows.Forms.GroupBox grpSistema;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrMantoSistemaP;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrMantoSistemaC;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrCorrectivoVsPreventivo;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}