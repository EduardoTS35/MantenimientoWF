using Domain.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace AppMantenimiento
{
    public partial class FrmTablas : Form
    {
        RegistroActividad registro = new RegistroActividad();
        RegistroCorrectivo correctivo = new RegistroCorrectivo();
        //DataSet Actividades

        //Fechas
        string fechaDelDia = DateTime.Now.ToString("yyyy-MM-dd");
        DateTime primerDiaMes = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
        DateTime ultimoDiaMes;
        List<string[]> mecanicos = new List<string[]>
            {
                new string[] { "Isaac", "Cuatecatl" },
                new string[] { "Filemon", "Fuentes" },
                new string[] { "Manuel", "Romero" },
                new string[] { "David", "Gonzales" },
                new string[] { "Victor", "Merino" },
                new string[] { "Ricardo", "Lopez" },
                new string[] { "Nicolas", "Castillo" }
                // Agrega más nombres de mecánicos si es necesario
            };

        List<string[]> electricos = new List<string[]>
            {
                new string[] { "Angel", "Gomez" },
                new string[] { "Isidro", "Jordan" },
            };
        int[] areas = { 1, 2, 3, 4 };
        float hrsRealizadasPreventivo;

        public FrmTablas()
        {
            InitializeComponent();
            tmrResultados.Start();
            ultimoDiaMes = primerDiaMes.AddMonths(1).AddDays(-1);
            try
            {
                //MostrarPreventivoVsCorrectivo(correctivo.CorrectivoVsPreventivoDashboard(primerDiaMes, ultimoDiaMes));
                //MostrarCorrectivoArea(correctivo.ObtenerCorrectivoAreaFecha(primerDiaMes, ultimoDiaMes, areas));
                //MostrarPorcentajePorDescripcionMaquina(correctivo.ObtenerCorrectivoAreaFecha(primerDiaMes, ultimoDiaMes, areas));
                //MostrarPreventivoArea(registro.ObtenerPreventivoAreaFecha(primerDiaMes, ultimoDiaMes, areas));
                //MostrarMantoSistemaP(registro.ObtenerPreventivoAreaFecha(primerDiaMes, ultimoDiaMes, areas));
            }
            catch {
            }
            
        }

        private void MostrarPreventivoVsCorrectivo(float[] datos)
        {
            
            chrCorrectivoVsPreventivo.ChartAreas[0].AxisX.Minimum = 0;
            chrCorrectivoVsPreventivo.ChartAreas[0].AxisY.Maximum = 0;

            chrCorrectivoVsPreventivo.Series.Clear();
            Series series = new Series();
            series.ChartType = SeriesChartType.Doughnut;

            DataPoint dataPoint = new DataPoint();
            dataPoint.AxisLabel = "Correctivo";
            dataPoint.YValues = new double[1] { datos[0] };
            double total = datos[0] + datos[1];
            double porcentajeCorrectivo = datos[0] / total;
            dataPoint.LegendText = $"{dataPoint.AxisLabel}: {Math.Round(datos[0], 1)} ({porcentajeCorrectivo:P0})";
            series.Points.Add(dataPoint);

            DataPoint dataPoint2 = new DataPoint();
            dataPoint2.AxisLabel = "Preventivo";
            dataPoint2.YValues = new double[1] { datos[1] };
            double porcentajePreventivo = datos[1] / total;
            dataPoint2.LegendText = $"{dataPoint2.AxisLabel}: {Math.Round(datos[1], 1)} ({porcentajePreventivo:P0})";
            series.Points.Add(dataPoint2);

            chrCorrectivoVsPreventivo.Series.Add(series);
            chrCorrectivoVsPreventivo.Titles.Clear();
            chrCorrectivoVsPreventivo.Titles.Add("Horas trabajadas");
        }
        private void MostrarRealizadoVSProgramado(float[] datos, double programado)
        {
            chrRealizadoVSPlaneado.ChartAreas[0].AxisX.Minimum = 0;
            chrRealizadoVSPlaneado.ChartAreas[0].AxisY.Maximum = 0;

            chrRealizadoVSPlaneado.Series.Clear();
            Series series = new Series();
            series.ChartType = SeriesChartType.Doughnut;

            DataPoint dataPoint = new DataPoint();
            dataPoint.AxisLabel = "Programado";
            dataPoint.YValues = new double[1] { programado };
            double total = programado + datos[1];
            double porcentajeCorrectivo = programado / total;
            dataPoint.LegendText = $"{dataPoint.AxisLabel}: {Math.Round(programado, 1)} ({porcentajeCorrectivo:P0})";
            series.Points.Add(dataPoint);

            DataPoint dataPoint2 = new DataPoint();
            dataPoint2.AxisLabel = "Realizado";
            dataPoint2.YValues = new double[1] { datos[1] };
            double porcentajePreventivo = datos[1] / total;
            dataPoint2.LegendText = $"{dataPoint2.AxisLabel}: {Math.Round(datos[1], 1)} ({porcentajePreventivo:P0})";
            series.Points.Add(dataPoint2);

            chrRealizadoVSPlaneado.Series.Add(series);
            chrRealizadoVSPlaneado.Titles.Clear();
            chrRealizadoVSPlaneado.Titles.Add("Horas trabajadas");
        }
        private void MostrarPreventivoArea(DataTable table)
        {
            chrMantoAreaP.ChartAreas[0].AxisX.Minimum = 0;
            chrMantoAreaP.ChartAreas[0].AxisY.Maximum = 0;
            double porcentajeElectrico = GetPorcentajeMantenimientoPreventivo(table, electricos);
            double porcentajeMecanico = GetPorcentajeMantenimientoPreventivo(table, mecanicos);

            // Agregar los porcentajes al gráfico
            chrMantoAreaP.Series.Clear();
            Series series = chrMantoAreaP.Series.Add("Porcentaje Mantenimiento Preventivo");
            series.ChartType = SeriesChartType.Doughnut;

            DataPoint dataPointElectrico = series.Points.Add(porcentajeElectrico);
            dataPointElectrico.AxisLabel = "Eléctrico";
            dataPointElectrico.LegendText = $"{dataPointElectrico.AxisLabel}: {dataPointElectrico.YValues[0]:F2}%";

            DataPoint dataPointMecanico = series.Points.Add(porcentajeMecanico);
            dataPointMecanico.AxisLabel = "Mecánico";
            dataPointMecanico.LegendText = $"{dataPointMecanico.AxisLabel}: {dataPointMecanico.YValues[0]:F2}%";

            // Personalizar el gráfico
            chrMantoAreaP.ChartAreas[0].AxisY.Minimum = 0;
            chrMantoAreaP.ChartAreas[0].AxisY.Maximum = 100;
            chrMantoAreaP.ChartAreas[0].AxisY.Interval = 10;
            chrMantoAreaP.ChartAreas[0].AxisY.Title = "Porcentaje";
            chrMantoAreaP.ChartAreas[0].AxisX.Title = "Área";
            chrMantoAreaP.Titles.Clear();
            chrMantoAreaP.Titles.Add("Mantenimiento Preventivo por Área");
        }
        private double GetPorcentajeMantenimientoPreventivo(DataTable dataTable, List<string[]> trabajadores)
        {
            int totalActividades = dataTable.Rows.Count;
            int actividadesMantenimiento = 0;

            foreach (DataRow row in dataTable.Rows)
            {
                string nombre = row["nombre"].ToString();
                string apellido = row["apellido"].ToString();

                if (trabajadores.Any(t => t[0] == nombre && t[1] == apellido))
                {
                    actividadesMantenimiento++;
                }
            }

            double porcentaje = (double)actividadesMantenimiento / totalActividades * 100;
            return porcentaje;
        }
        private List<string> GetDescripcionesMaquina(DataTable dataTable)
        {
            List<string> descripcionesMaquina = new List<string>();

            foreach (DataRow row in dataTable.Rows)
            {
                string descripcion = row[11].ToString();

                if (!string.IsNullOrEmpty(descripcion) && !descripcionesMaquina.Contains(descripcion))
                {
                    descripcionesMaquina.Add(descripcion);
                }
            }

            return descripcionesMaquina;
        }
        private void MostrarMantoSistemaP(DataTable table)
        {
            chrMantoSistemaP.ChartAreas[0].AxisX.Minimum = 0;
            chrMantoSistemaP.ChartAreas[0].AxisY.Maximum = 0;
            List<string> descripcionesMaquina = GetDescripcionesMaquina(table);

            // Calcular el porcentaje de mantenimiento preventivo por descripción de máquina
            Dictionary<string, double> porcentajes = GetPorcentajesMantenimientoPreventivo(table, descripcionesMaquina);

            // Agregar los porcentajes al gráfico
            chrMantoSistemaP.Series.Clear();
            Series series = chrMantoSistemaP.Series.Add("Porcentaje Mantenimiento");
            series.ChartType = SeriesChartType.Doughnut;

            // Personalizar la paleta de colores
            string[] colores = {
                "#FF6384", "#36A2EB", "#FFCE56", "#4BC0C0", "#9966FF",
                "#FF9F40", "#5A7A9C", "#9BC53D", "#FF6B6B", "#6C757D",
                "#A4C639", "#00587A", "#FFC300", "#FF5733", "#8B78E6",
                "#34B1BF", "#FFCB2B", "#B84B9E", "#2A6049", "#A363D4"
            };
            int colorIndex = 0;

            foreach (var kvp in porcentajes)
            {
                DataPoint dataPoint = series.Points.Add(kvp.Value);
                dataPoint.AxisLabel = kvp.Key;
                dataPoint.Color = ColorTranslator.FromHtml(colores[colorIndex]);
                dataPoint.LegendText = $"{dataPoint.AxisLabel}: {dataPoint.YValues[0]:F1}%";

                colorIndex++;
                if (colorIndex >= colores.Length)
                {
                    colorIndex = 0;
                }
            }

            // Personalizar el gráfico
            chrMantoSistemaP.ChartAreas[0].AxisY.Minimum = 0;
            chrMantoSistemaP.ChartAreas[0].AxisY.Maximum = 100;
            chrMantoSistemaP.ChartAreas[0].AxisY.Interval = 10;
            chrMantoSistemaP.ChartAreas[0].AxisY.Title = "Porcentaje";
            chrMantoSistemaP.ChartAreas[0].AxisX.Title = "Descripción de Máquina";
            chrMantoSistemaP.ChartAreas[0].AxisX.Interval = 1;
            chrMantoSistemaP.Series[0]["PieLabelStyle"] = "Disabled";
            // Ocultar etiquetas dentro de la gráfica


            chrMantoSistemaP.Titles.Clear();
            chrMantoSistemaP.Titles.Add("Mantenimiento Preventivo por Sistema");
        }
        private Dictionary<string, double> GetPorcentajesMantenimientoPreventivo(DataTable dataTable, List<string> descripcionesMaquina)
        {
            Dictionary<string, double> porcentajes = new Dictionary<string, double>();

            foreach (string descripcion in descripcionesMaquina)
            {
                int totalActividades = dataTable.Rows.Count;
                int actividadesMantenimiento = 0;

                foreach (DataRow row in dataTable.Rows)
                {
                    string descripcionMaquina = row[11].ToString();

                    if (descripcionMaquina == descripcion)
                    {
                        actividadesMantenimiento++;
                    }
                }

                double porcentaje = (double)actividadesMantenimiento / totalActividades * 100;
                porcentajes.Add(descripcion, porcentaje);
            }

            return porcentajes;
        }
        private void MostrarCorrectivoArea(DataTable table)
        {
            chrMantoAreaC.ChartAreas[0].AxisX.Minimum = 0;
            chrMantoAreaC.ChartAreas[0].AxisY.Maximum = 0;
            double porcentajeElectrico = GetPorcentajeMantenimientoCorrectivo(table, electricos);
            double porcentajeMecanico = GetPorcentajeMantenimientoCorrectivo(table, mecanicos);

            // Agregar los porcentajes al gráfico
            chrMantoAreaC.Series.Clear();
            Series series = chrMantoAreaC.Series.Add("Porcentaje Mantenimiento Correctivo");
            series.ChartType = SeriesChartType.Doughnut;

            // Personalizar la paleta de colores
            series.Palette = ChartColorPalette.BrightPastel;

            DataPoint dpElectrico = series.Points.Add(porcentajeElectrico);
            dpElectrico.AxisLabel = "Eléctrico";
            dpElectrico.LegendText = $"{dpElectrico.AxisLabel}: {dpElectrico.YValues[0]:F2}%";

            DataPoint dpMecanico = series.Points.Add(porcentajeMecanico);
            dpMecanico.AxisLabel = "Mecánico";
            dpMecanico.LegendText = $"{dpMecanico.AxisLabel}: {dpMecanico.YValues[0]:F2}%";

            // Personalizar el gráfico
            chrMantoAreaC.ChartAreas[0].AxisY.Minimum = 0;
            chrMantoAreaC.ChartAreas[0].AxisY.Maximum = 100;
            chrMantoAreaC.ChartAreas[0].AxisY.Interval = 10;
            chrMantoAreaC.ChartAreas[0].AxisY.Title = "Porcentaje";
            chrMantoAreaC.ChartAreas[0].AxisX.Title = "Área";
            chrMantoAreaC.Titles.Clear();
            chrMantoAreaC.Titles.Add("Mantenimiento Correctivo por Área");
        }

        private double GetPorcentajeMantenimientoCorrectivo(DataTable dataTable, List<string[]> trabajadores)
        {
            int totalActividades = dataTable.Rows.Count;
            int actividadesMantenimiento = 0;

            foreach (DataRow row in dataTable.Rows)
            {
                string nombre = row["nombre"].ToString();
                string apellido = row["apellido"].ToString();

                if (trabajadores.Any(t => t[0] == nombre && t[1] == apellido))
                {
                    actividadesMantenimiento++;
                }
            }

            double porcentaje = (double)actividadesMantenimiento / totalActividades * 100;
            return porcentaje;
        }
        private void MostrarPorcentajePorDescripcionMaquina(DataTable table)
        {
            chrMantoSistemaC.ChartAreas[0].AxisX.Minimum = 0;
            chrMantoSistemaC.ChartAreas[0].AxisY.Maximum = 0;
            Dictionary<string, int> porcentajePorDescripcion = new Dictionary<string, int>();

            foreach (DataRow row in table.Rows)
            {
                string descripcionMaquina = row[8].ToString();

                if (porcentajePorDescripcion.ContainsKey(descripcionMaquina))
                {
                    porcentajePorDescripcion[descripcionMaquina]++;
                }
                else
                {
                    porcentajePorDescripcion.Add(descripcionMaquina, 1);
                }
            }

            int totalRegistros = table.Rows.Count;

            chrMantoSistemaC.Series.Clear();
            Series series = new Series();
            series.ChartType = SeriesChartType.Doughnut;

            foreach (KeyValuePair<string, int> kvp in porcentajePorDescripcion)
            {
                string descripcionMaquina = kvp.Key;
                int cantidad = kvp.Value;
                float porcentaje = (cantidad / (float)totalRegistros) * 100;

                DataPoint dataPoint = new DataPoint();
                dataPoint.AxisLabel = descripcionMaquina;
                dataPoint.YValues = new double[1] { cantidad };
                dataPoint.LegendText = $"{dataPoint.AxisLabel}: {dataPoint.YValues[0]}";
                dataPoint.LegendText += $" ({porcentaje:F1}%)";
                series.Points.Add(dataPoint);
            }

            chrMantoSistemaC.Series.Add(series);
            chrMantoSistemaC.Titles.Clear();
            chrMantoSistemaC.Titles.Add("Mantenimiento Correctivo por Sistema");
            chrMantoSistemaC.Series[0]["PieLabelStyle"] = "Disabled";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            MostrarPreventivoVsCorrectivo(correctivo.CorrectivoVsPreventivoDashboard(primerDiaMes, ultimoDiaMes));
            MostrarCorrectivoArea(correctivo.ObtenerCorrectivoAreaFecha(primerDiaMes, ultimoDiaMes, areas));
            MostrarPorcentajePorDescripcionMaquina(correctivo.ObtenerCorrectivoAreaFecha(primerDiaMes, ultimoDiaMes, areas));
            MostrarPreventivoArea(registro.ObtenerPreventivoAreaFecha(primerDiaMes, ultimoDiaMes, areas));
            MostrarMantoSistemaP(registro.ObtenerPreventivoAreaFecha(primerDiaMes, ultimoDiaMes, areas));
            MostrarRealizadoVSProgramado(correctivo.CorrectivoVsPreventivoDashboard(primerDiaMes, ultimoDiaMes), registro.TiempoRegistrosProgramadosFecha(primerDiaMes, ultimoDiaMes));
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            MostrarPreventivoVsCorrectivo(correctivo.CorrectivoVsPreventivoDashboard(Convert.ToDateTime(fechaDelDia).AddDays(-15.0), Convert.ToDateTime(fechaDelDia).AddDays(1.0)));
            MostrarCorrectivoArea(correctivo.ObtenerCorrectivoAreaFecha(Convert.ToDateTime(fechaDelDia).AddDays(-15.0), Convert.ToDateTime(fechaDelDia).AddDays(1.0), areas));
            MostrarPorcentajePorDescripcionMaquina(correctivo.ObtenerCorrectivoAreaFecha(Convert.ToDateTime(fechaDelDia).AddDays(-15.0), Convert.ToDateTime(fechaDelDia).AddDays(1.0), areas));
            MostrarPreventivoArea(registro.ObtenerPreventivoAreaFecha(Convert.ToDateTime(fechaDelDia).AddDays(-15.0), Convert.ToDateTime(fechaDelDia).AddDays(1.0), areas));
            MostrarMantoSistemaP(registro.ObtenerPreventivoAreaFecha(Convert.ToDateTime(fechaDelDia).AddDays(-15.0), Convert.ToDateTime(fechaDelDia).AddDays(1.0), areas));
            MostrarRealizadoVSProgramado(correctivo.CorrectivoVsPreventivoDashboard(Convert.ToDateTime(fechaDelDia).AddDays(-15.0), Convert.ToDateTime(fechaDelDia).AddDays(1.0)),registro.TiempoRegistrosProgramadosFecha(Convert.ToDateTime(fechaDelDia).AddDays(-15.0), Convert.ToDateTime(fechaDelDia).AddDays(1.0)));
        }

        private void FrmTablas_Load(object sender, EventArgs e)
        {

        }
    }
}
