using Domain.Models;
using System;
using System.Data;
using System.Drawing;
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
        }
        private void MostrarDatosTrabajadores(DataTable tabla)
        {
            // Limpiamos los datos previamente agregados al chart
            chrTrabajadores.Series.Clear();

            // Creamos una nueva serie de datos para el chart
            Series serieDatos = new Series();
            serieDatos.Name = "Trabajadores";
            serieDatos.ChartType = SeriesChartType.Column;

            // Añadimos los datos a la serie
            foreach (DataRow fila in tabla.Rows)
            {
                string nombre = fila["nombre"].ToString();
                int porcentaje = Convert.ToInt32(fila["PorcentajeCumplimiento"]);
                DataPoint punto = new DataPoint();
                punto.AxisLabel = nombre;
                punto.YValues = new double[] { porcentaje };
                serieDatos.Points.Add(punto);
            }

            // Agregamos la serie al chart
            chrTrabajadores.Series.Add(serieDatos);

            // Configuramos el chart
            chrTrabajadores.Titles.Clear();
            chrTrabajadores.Titles.Add(new Title("Porcentaje de Cumplimiento", Docking.Top, new Font("Arial", 14, FontStyle.Bold), Color.Black));
            chrTrabajadores.ChartAreas[0].AxisX.Interval = 1;
            chrTrabajadores.ChartAreas[0].AxisY.Minimum = 0;
            chrTrabajadores.ChartAreas[0].AxisY.Maximum = 100;
            chrTrabajadores.ChartAreas[0].AxisY.Interval = 10;

            // Asignamos colores personalizados a las barras
            Color[] colores = new Color[] { Color.FromArgb(60, 120, 200), Color.FromArgb(90, 180, 255), Color.FromArgb(120, 150, 255) };
            for (int i = 0; i < serieDatos.Points.Count; i++)
            {
                DataPoint punto = serieDatos.Points[i];
                punto.Color = colores[i % colores.Length];
            }
        }

        private void MostrarDatosAsignacion(DataTable tabla)
        {
            // Limpiamos los datos previamente agregados al chart
            chart1.Series.Clear();

            // Creamos una nueva serie de datos para el chart
            Series serieDatos = new Series();
            serieDatos.Name = "Trabajadores";
            serieDatos.ChartType = SeriesChartType.Column;

            // Añadimos los datos a la serie
            foreach (DataRow fila in tabla.Rows)
            {
                string nombre = fila["nombre"].ToString();
                int totalActividades = Convert.ToInt32(fila["TotalActividades"]);
                DataPoint punto = new DataPoint();
                punto.AxisLabel = nombre;
                punto.YValues = new double[] { totalActividades };
                serieDatos.Points.Add(punto);
            }

            // Agregamos la serie al chart
            chart1.Series.Add(serieDatos);

            // Configuramos el chart
            chart1.Titles.Clear();
            chart1.Titles.Add(new Title("Total de Actividades", Docking.Top, new Font("Arial", 14, FontStyle.Bold), Color.Black));
            chart1.ChartAreas[0].AxisX.Interval = 1;
            chart1.ChartAreas[0].AxisY.Minimum = 0;
            chart1.ChartAreas[0].AxisY.Maximum = 100;
            chart1.ChartAreas[0].AxisY.Interval = 10;

            // Asignamos colores personalizados a las barras
            Color[] colores = new Color[] { Color.FromArgb(60, 120, 200), Color.FromArgb(90, 180, 255), Color.FromArgb(120, 150, 255) };
            for (int i = 0; i < serieDatos.Points.Count; i++)
            {
                DataPoint punto = serieDatos.Points[i];
                punto.Color = colores[i % colores.Length];
            }
        }


    }
}
