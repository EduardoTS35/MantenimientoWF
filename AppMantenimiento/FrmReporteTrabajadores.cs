using Domain.Models;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace AppMantenimiento
{
    public partial class FrmReporteTrabajadores : Form
    {
        RegistroActividad registro = new RegistroActividad();
        public FrmReporteTrabajadores(DateTime fechaInicio, DateTime fechaFin)
        {
            
            InitializeComponent();
            lblPeriodo.Text += fechaInicio.ToString() + " a " + fechaFin.ToString();
            MostrarDatosAsignacion(registro.MostrarActividadesRealizadas(fechaInicio, fechaFin));
            MostrarDatosTrabajadores(registro.MostrarActividadesRealizadas(fechaInicio, fechaFin));
            MostrarDatosPorcentaje(registro.MostrarActividadesRealizadas(fechaInicio, fechaFin));
        }
        private void MostrarDatosEnChart(DataTable tabla, Chart chart, string titulo, string[] nombresSeries, string nombreEjeY, string barLabelStyle)
        {
            // Limpiamos los datos previamente agregados al chart
            chart.Series.Clear();

            // Configuramos el chart
            chart.Titles.Clear();
            chart.Titles.Add(new Title(titulo, Docking.Top, new Font("Arial", 14, FontStyle.Bold), Color.Black));
            chart.ChartAreas[0].AxisX.Interval = 1;
            chart.ChartAreas[0].AxisX.MajorGrid.Enabled = false; // Quitamos la cuadrícula del fondo


            // Añadimos las series y los datos a cada serie
            foreach (string nombreSerie in nombresSeries)
            {
                Series serieDatos = new Series();
                serieDatos.Name = nombreSerie;
                serieDatos.ChartType = SeriesChartType.Column;

                foreach (DataRow fila in tabla.Rows)
                {
                    string nombre = fila["nombre"].ToString();
                    int valor = Convert.ToInt32(fila[nombreSerie]);
                    DataPoint punto = new DataPoint();
                    punto.AxisLabel = nombre;
                    punto.YValues = new double[] { valor };
                    serieDatos.Points.Add(punto);
                }

                // Agregamos la serie al chart
                chart.Series.Add(serieDatos);

                foreach (DataPoint punto in serieDatos.Points)
                {
                    punto.Label = punto.YValues[0].ToString(); // Agregamos el valor numérico como etiqueta
                    punto.LabelForeColor = Color.Black;
                    punto.Font = new Font("Arial", 12, FontStyle.Bold);
                }
            }

            // Ajustamos la escala del eje Y al valor más alto
            double valorMaximo = tabla.AsEnumerable().Max(row => nombresSeries.Sum(nombre => Convert.ToInt32(row[nombre])));
            chart.ChartAreas[0].AxisY.Maximum = valorMaximo + 10; // Añadimos 10 para dar espacio
        }

        private void MostrarDatosTrabajadores(DataTable tabla)
        {
            string[] nombresSeries = { "TiempoEsperado", "TiempoRealizado" };
            MostrarDatosEnChart(tabla, chrTrabajadores, "Tiempo de Trabajo", nombresSeries, "Tiempo Esperado", "Top");
        }

        private void MostrarDatosAsignacion(DataTable tabla)
        {
            string[] nombresSeries = { "TotalActividades", "ActividadesRealizadas" };
            MostrarDatosEnChart(tabla, chart1, "Actividades", nombresSeries, "Total Actividades", "Top");
        }

        private void MostrarDatosPorcentaje(DataTable tabla)
        {
            string[] nombresSeries = { "PorcentajeCumplimiento" };
            MostrarDatosEnChart(tabla, chart2, "Porcentaje de Cumplimiento", nombresSeries, "Porcentaje Cumplimiento", "Top");
        }
    }
}
