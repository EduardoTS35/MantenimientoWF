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
            this.grpIndicadores = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblNumCR = new System.Windows.Forms.Label();
            this.lblCorrectivo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblNumPR = new System.Windows.Forms.Label();
            this.lblPreventivoR = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNumPD = new System.Windows.Forms.Label();
            this.lblPreventivoD = new System.Windows.Forms.Label();
            this.grpTablas = new System.Windows.Forms.GroupBox();
            this.pnlChartCorrectivoVSPreventivo = new System.Windows.Forms.Panel();
            this.chrPreventivoVsCorrectivo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlChartCorrectivoMensual = new System.Windows.Forms.Panel();
            this.chrCorrectivoMensual = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlChrPreventivoMensual = new System.Windows.Forms.Panel();
            this.chrPreventivoMensual = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.grpTrabajadores = new System.Windows.Forms.GroupBox();
            this.chrTrabajadores = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tmrResultados = new System.Windows.Forms.Timer(this.components);
            this.grpFechas = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.grpIndicadores.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grpTablas.SuspendLayout();
            this.pnlChartCorrectivoVSPreventivo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrPreventivoVsCorrectivo)).BeginInit();
            this.pnlChartCorrectivoMensual.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrCorrectivoMensual)).BeginInit();
            this.pnlChrPreventivoMensual.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrPreventivoMensual)).BeginInit();
            this.grpTrabajadores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrTrabajadores)).BeginInit();
            this.grpFechas.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpIndicadores
            // 
            this.grpIndicadores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpIndicadores.Controls.Add(this.panel3);
            this.grpIndicadores.Controls.Add(this.panel2);
            this.grpIndicadores.Controls.Add(this.panel1);
            this.grpIndicadores.Location = new System.Drawing.Point(12, 12);
            this.grpIndicadores.Name = "grpIndicadores";
            this.grpIndicadores.Size = new System.Drawing.Size(968, 148);
            this.grpIndicadores.TabIndex = 0;
            this.grpIndicadores.TabStop = false;
            this.grpIndicadores.Text = "Indicadores";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblNumCR);
            this.panel3.Controls.Add(this.lblCorrectivo);
            this.panel3.Location = new System.Drawing.Point(721, 21);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 1;
            // 
            // lblNumCR
            // 
            this.lblNumCR.AutoSize = true;
            this.lblNumCR.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumCR.Location = new System.Drawing.Point(76, 39);
            this.lblNumCR.Name = "lblNumCR";
            this.lblNumCR.Size = new System.Drawing.Size(46, 32);
            this.lblNumCR.TabIndex = 2;
            this.lblNumCR.Text = "10";
            this.lblNumCR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCorrectivo
            // 
            this.lblCorrectivo.AutoSize = true;
            this.lblCorrectivo.Location = new System.Drawing.Point(6, 4);
            this.lblCorrectivo.Name = "lblCorrectivo";
            this.lblCorrectivo.Size = new System.Drawing.Size(147, 16);
            this.lblCorrectivo.TabIndex = 1;
            this.lblCorrectivo.Text = "Correctivos Realizados";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblNumPR);
            this.panel2.Controls.Add(this.lblPreventivoR);
            this.panel2.Location = new System.Drawing.Point(365, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 1;
            // 
            // lblNumPR
            // 
            this.lblNumPR.AutoSize = true;
            this.lblNumPR.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumPR.Location = new System.Drawing.Point(70, 39);
            this.lblNumPR.Name = "lblNumPR";
            this.lblNumPR.Size = new System.Drawing.Size(46, 32);
            this.lblNumPR.TabIndex = 2;
            this.lblNumPR.Text = "10";
            this.lblNumPR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPreventivoR
            // 
            this.lblPreventivoR.AutoSize = true;
            this.lblPreventivoR.Location = new System.Drawing.Point(6, 5);
            this.lblPreventivoR.Name = "lblPreventivoR";
            this.lblPreventivoR.Size = new System.Drawing.Size(150, 16);
            this.lblPreventivoR.TabIndex = 1;
            this.lblPreventivoR.Text = "Preventivos Realizados";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblNumPD);
            this.panel1.Controls.Add(this.lblPreventivoD);
            this.panel1.Location = new System.Drawing.Point(29, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 0;
            // 
            // lblNumPD
            // 
            this.lblNumPD.AutoSize = true;
            this.lblNumPD.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumPD.Location = new System.Drawing.Point(68, 42);
            this.lblNumPD.Name = "lblNumPD";
            this.lblNumPD.Size = new System.Drawing.Size(46, 32);
            this.lblNumPD.TabIndex = 1;
            this.lblNumPD.Text = "10";
            this.lblNumPD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPreventivoD
            // 
            this.lblPreventivoD.AutoSize = true;
            this.lblPreventivoD.Location = new System.Drawing.Point(6, 8);
            this.lblPreventivoD.Name = "lblPreventivoD";
            this.lblPreventivoD.Size = new System.Drawing.Size(122, 16);
            this.lblPreventivoD.TabIndex = 0;
            this.lblPreventivoD.Text = "Preventivos del día";
            // 
            // grpTablas
            // 
            this.grpTablas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpTablas.Controls.Add(this.pnlChartCorrectivoVSPreventivo);
            this.grpTablas.Controls.Add(this.pnlChartCorrectivoMensual);
            this.grpTablas.Controls.Add(this.pnlChrPreventivoMensual);
            this.grpTablas.Location = new System.Drawing.Point(12, 223);
            this.grpTablas.Name = "grpTablas";
            this.grpTablas.Size = new System.Drawing.Size(608, 401);
            this.grpTablas.TabIndex = 1;
            this.grpTablas.TabStop = false;
            this.grpTablas.Text = "Gráficos";
            // 
            // pnlChartCorrectivoVSPreventivo
            // 
            this.pnlChartCorrectivoVSPreventivo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlChartCorrectivoVSPreventivo.AutoSize = true;
            this.pnlChartCorrectivoVSPreventivo.Controls.Add(this.chrPreventivoVsCorrectivo);
            this.pnlChartCorrectivoVSPreventivo.Location = new System.Drawing.Point(16, 224);
            this.pnlChartCorrectivoVSPreventivo.Name = "pnlChartCorrectivoVSPreventivo";
            this.pnlChartCorrectivoVSPreventivo.Size = new System.Drawing.Size(584, 174);
            this.pnlChartCorrectivoVSPreventivo.TabIndex = 4;
            // 
            // chrPreventivoVsCorrectivo
            // 
            chartArea1.Name = "ChartArea1";
            this.chrPreventivoVsCorrectivo.ChartAreas.Add(chartArea1);
            this.chrPreventivoVsCorrectivo.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chrPreventivoVsCorrectivo.Legends.Add(legend1);
            this.chrPreventivoVsCorrectivo.Location = new System.Drawing.Point(0, 0);
            this.chrPreventivoVsCorrectivo.Name = "chrPreventivoVsCorrectivo";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chrPreventivoVsCorrectivo.Series.Add(series1);
            this.chrPreventivoVsCorrectivo.Size = new System.Drawing.Size(584, 174);
            this.chrPreventivoVsCorrectivo.TabIndex = 2;
            this.chrPreventivoVsCorrectivo.Text = "chart3";
            // 
            // pnlChartCorrectivoMensual
            // 
            this.pnlChartCorrectivoMensual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlChartCorrectivoMensual.Controls.Add(this.chrCorrectivoMensual);
            this.pnlChartCorrectivoMensual.Location = new System.Drawing.Point(242, 18);
            this.pnlChartCorrectivoMensual.Name = "pnlChartCorrectivoMensual";
            this.pnlChartCorrectivoMensual.Size = new System.Drawing.Size(358, 200);
            this.pnlChartCorrectivoMensual.TabIndex = 3;
            // 
            // chrCorrectivoMensual
            // 
            chartArea2.Name = "ChartArea1";
            this.chrCorrectivoMensual.ChartAreas.Add(chartArea2);
            this.chrCorrectivoMensual.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chrCorrectivoMensual.Legends.Add(legend2);
            this.chrCorrectivoMensual.Location = new System.Drawing.Point(0, 0);
            this.chrCorrectivoMensual.Name = "chrCorrectivoMensual";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chrCorrectivoMensual.Series.Add(series2);
            this.chrCorrectivoMensual.Size = new System.Drawing.Size(358, 200);
            this.chrCorrectivoMensual.TabIndex = 0;
            this.chrCorrectivoMensual.Text = "chrCorrectivo";
            // 
            // pnlChrPreventivoMensual
            // 
            this.pnlChrPreventivoMensual.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlChrPreventivoMensual.AutoSize = true;
            this.pnlChrPreventivoMensual.Controls.Add(this.chrPreventivoMensual);
            this.pnlChrPreventivoMensual.Location = new System.Drawing.Point(16, 18);
            this.pnlChrPreventivoMensual.Name = "pnlChrPreventivoMensual";
            this.pnlChrPreventivoMensual.Size = new System.Drawing.Size(220, 200);
            this.pnlChrPreventivoMensual.TabIndex = 2;
            // 
            // chrPreventivoMensual
            // 
            chartArea3.Name = "ChartArea1";
            this.chrPreventivoMensual.ChartAreas.Add(chartArea3);
            this.chrPreventivoMensual.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.chrPreventivoMensual.Legends.Add(legend3);
            this.chrPreventivoMensual.Location = new System.Drawing.Point(0, 0);
            this.chrPreventivoMensual.Name = "chrPreventivoMensual";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chrPreventivoMensual.Series.Add(series3);
            this.chrPreventivoMensual.Size = new System.Drawing.Size(220, 200);
            this.chrPreventivoMensual.TabIndex = 0;
            this.chrPreventivoMensual.Text = "chart1";
            // 
            // grpTrabajadores
            // 
            this.grpTrabajadores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpTrabajadores.Controls.Add(this.chrTrabajadores);
            this.grpTrabajadores.Location = new System.Drawing.Point(626, 223);
            this.grpTrabajadores.Name = "grpTrabajadores";
            this.grpTrabajadores.Size = new System.Drawing.Size(354, 401);
            this.grpTrabajadores.TabIndex = 4;
            this.grpTrabajadores.TabStop = false;
            this.grpTrabajadores.Text = "Trabajadores";
            // 
            // chrTrabajadores
            // 
            chartArea4.Name = "ChartArea1";
            this.chrTrabajadores.ChartAreas.Add(chartArea4);
            this.chrTrabajadores.Dock = System.Windows.Forms.DockStyle.Fill;
            legend4.Name = "Legend1";
            this.chrTrabajadores.Legends.Add(legend4);
            this.chrTrabajadores.Location = new System.Drawing.Point(3, 18);
            this.chrTrabajadores.Name = "chrTrabajadores";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chrTrabajadores.Series.Add(series4);
            this.chrTrabajadores.Size = new System.Drawing.Size(348, 380);
            this.chrTrabajadores.TabIndex = 1;
            this.chrTrabajadores.Text = "chrTravajadores";
            // 
            // tmrResultados
            // 
            this.tmrResultados.Interval = 3000;
            this.tmrResultados.Tick += new System.EventHandler(this.tmrResultados_Tick);
            // 
            // grpFechas
            // 
            this.grpFechas.Controls.Add(this.radioButton3);
            this.grpFechas.Controls.Add(this.radioButton2);
            this.grpFechas.Controls.Add(this.radioButton1);
            this.grpFechas.Location = new System.Drawing.Point(12, 168);
            this.grpFechas.Name = "grpFechas";
            this.grpFechas.Size = new System.Drawing.Size(965, 49);
            this.grpFechas.TabIndex = 5;
            this.grpFechas.TabStop = false;
            this.grpFechas.Text = "Periodo";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(441, 21);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(82, 20);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Semanal";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(242, 21);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(88, 20);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Quincenal";
            this.radioButton2.UseVisualStyleBackColor = true;
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
            // 
            // FrmTablas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(992, 636);
            this.Controls.Add(this.grpFechas);
            this.Controls.Add(this.grpTrabajadores);
            this.Controls.Add(this.grpTablas);
            this.Controls.Add(this.grpIndicadores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTablas";
            this.Text = "FrmCharts";
            this.grpIndicadores.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpTablas.ResumeLayout(false);
            this.grpTablas.PerformLayout();
            this.pnlChartCorrectivoVSPreventivo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chrPreventivoVsCorrectivo)).EndInit();
            this.pnlChartCorrectivoMensual.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chrCorrectivoMensual)).EndInit();
            this.pnlChrPreventivoMensual.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chrPreventivoMensual)).EndInit();
            this.grpTrabajadores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chrTrabajadores)).EndInit();
            this.grpFechas.ResumeLayout(false);
            this.grpFechas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpIndicadores;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grpTablas;
        private System.Windows.Forms.GroupBox grpTrabajadores;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrCorrectivoMensual;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrPreventivoMensual;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrTrabajadores;
        private System.Windows.Forms.Label lblCorrectivo;
        private System.Windows.Forms.Label lblPreventivoR;
        private System.Windows.Forms.Label lblPreventivoD;
        private System.Windows.Forms.Label lblNumCR;
        private System.Windows.Forms.Label lblNumPR;
        private System.Windows.Forms.Label lblNumPD;
        private System.Windows.Forms.Timer tmrResultados;
        private System.Windows.Forms.Panel pnlChartCorrectivoMensual;
        private System.Windows.Forms.Panel pnlChrPreventivoMensual;
        private System.Windows.Forms.Panel pnlChartCorrectivoVSPreventivo;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrPreventivoVsCorrectivo;
        private System.Windows.Forms.GroupBox grpFechas;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}