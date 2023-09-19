using Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace AppMantenimiento
{
    public partial class FrmReporteCorrectivo : Form
    {
        RegistroCorrectivo registro = new RegistroCorrectivo();
        public FrmReporteCorrectivo(DateTime fechaInicio, DateTime fechaFin)
        {
            InitializeComponent();
            lblPeriodo.Text = "Periodo: "+fechaInicio.ToString()+" a "+fechaFin.ToString();
            MostrarGraficaActividades(registro.ReporteCorrectivo(fechaInicio, fechaFin));
            MostrarGraficaTiempo(registro.ReporteCorrectivo(fechaInicio, fechaFin));

        }

        private void MostrarGraficaActividades(DataTable dataTable)
        {
            // Limpiar la gráfica
            chrActividadesRealizadas.Series.Clear();

            // Crear una serie para la gráfica de barras
            Series series = chrActividadesRealizadas.Series.Add("Actividades Realizadas");
            series.ChartType = SeriesChartType.Column;

            // Agregar los datos del DataTable a la serie
            foreach (DataRow row in dataTable.Rows)
            {
                string nombre = Convert.ToString(row["nombre"]);
                int actividadesRealizadas = Convert.ToInt32(row["totalActividades"]);
                series.Points.AddXY(nombre, actividadesRealizadas);
            }

            // Configurar etiquetas y título
            chrActividadesRealizadas.ChartAreas[0].AxisX.Title = "Trabajador";
            chrActividadesRealizadas.ChartAreas[0].AxisY.Title = "Actividades Realizadas";
            chrActividadesRealizadas.Titles.Add("Actividades Realizadas por Trabajador");
        }
        private void MostrarGraficaTiempo(DataTable dataTable)
        {
            // Limpiar la gráfica
            chrTiempoCorrectivo.Series.Clear();

            // Crear una serie para la gráfica de barras
            Series series = chrTiempoCorrectivo.Series.Add("Tiempo Realizado");
            series.ChartType = SeriesChartType.Column;

            // Agregar los datos del DataTable a la serie
            foreach (DataRow row in dataTable.Rows)
            {
                string nombre = Convert.ToString(row["nombre"]);
                int actividadesRealizadas = Convert.ToInt32(row["totalTiempo"]);
                series.Points.AddXY(nombre, actividadesRealizadas);
            }

            // Configurar etiquetas y título
            chrTiempoCorrectivo.ChartAreas[0].AxisX.Title = "Trabajador";
            chrTiempoCorrectivo.ChartAreas[0].AxisY.Title = "Tiempo Realizado";
            chrTiempoCorrectivo.Titles.Add("Tiempo Realizado por el Trabajador");
        }
    }
}
