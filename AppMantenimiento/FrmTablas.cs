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
    public partial class FrmTablas : Form
    {
        Actividad actividad= new Actividad();
        RegistroActividad registro = new RegistroActividad();
        RegistroCorrectivo correctivo = new RegistroCorrectivo();
        //DataSet Actividades
        DataSet resultadosActividades = new DataSet();
        DataView filtroActidivades;
        //DataSet Registro Actividades
        DataSet resultadosRegistro = new DataSet();
        DataView filtroRegistro;
        //DataSet Correctivos
        DataSet resultadosCorrectivo = new DataSet();
        DataView filtroCorrectivo;
        //Fechas
        string fechaDelDia= DateTime.Now.ToString("yyyy-MM-dd");
        DateTime primerDiaMes = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddMonths(-1);
        DateTime ultimoDiaMes;

        public FrmTablas()
        {
            InitializeComponent();
            tmrResultados.Start();
            ultimoDiaMes = primerDiaMes.AddMonths(1).AddDays(-1);
            MostrarPreventivoMensual(registro.RegistroPreventivoDashboard(primerDiaMes, ultimoDiaMes));
            MostrarCorrectivoMensual(correctivo.RegistroCorrectivoDashboard(primerDiaMes, ultimoDiaMes));
            MostrarPreventivoVsCorrectivo(correctivo.CorrectivoVsPreventivoDashboard(primerDiaMes, ultimoDiaMes));
            MostrarDatosTrabajadores(registro.MostrarActividadesRealizadas(primerDiaMes, ultimoDiaMes));
        }
        private async Task MostrarResultados()
        {
            lblNumPD.Text= await MostrarPreventivosDiarios();
            lblNumPR.Text= await MostrarPreventivosRealizados();
            lblNumCR.Text = await MostrarCorrectivosRealizados();
        }

        private async Task <string> MostrarPreventivosDiarios()
        {
            string numPreventivo;
            resultadosActividades.Tables.Clear();
            resultadosActividades.Tables.Add(await actividad.MostrarActividadesAsync());
            this.filtroActidivades = ((DataTable)resultadosActividades.Tables[0]).DefaultView;
            try
            {
                this.filtroActidivades.RowFilter = "fechaProgramada = '" + fechaDelDia + "'";
            }
            catch (Exception) { }
            numPreventivo = Convert.ToString(filtroActidivades.Count);
            return numPreventivo;
        }
        private async Task<string> MostrarPreventivosRealizados()
        {
            string numPreventivosRealizados;
            resultadosRegistro.Tables.Clear();
            resultadosRegistro.Tables.Add(await registro.MostrarRegistroAsync());
            this.filtroRegistro = ((DataTable)resultadosRegistro.Tables[0]).DefaultView;
            try
            {
                this.filtroRegistro.RowFilter = "fechaRealizacion = '" + fechaDelDia + "'";
            }
            catch (Exception) { }
            numPreventivosRealizados = Convert.ToString(filtroRegistro.Count);
            return numPreventivosRealizados;
        }
        private async Task<string> MostrarCorrectivosRealizados()
        {
            string numCorrectivosRealizados;
            resultadosCorrectivo.Tables.Clear();
            resultadosCorrectivo.Tables.Add(await correctivo.MostrarCorrectivoAsync());
            this.filtroCorrectivo = ((DataTable)resultadosCorrectivo.Tables[0]).DefaultView;
            try
            {
                this.filtroCorrectivo.RowFilter = "fecha = '" + fechaDelDia + "'";
            }
            catch (Exception) { }
            numCorrectivosRealizados = Convert.ToString(filtroCorrectivo.Count);
            return numCorrectivosRealizados;
        }
        private void MostrarDatosTrabajadores(DataTable tabla)
        {
            // Limpiamos los datos previamente agregados al chart
            chrTrabajadores.Series.Clear();

            // Creamos una nueva serie de datos para el chart
            Series serieDatos = new Series();
            serieDatos.ChartType = SeriesChartType.Bar;

            // Añadimos los datos a la serie
            foreach (DataRow fila in tabla.Rows)
            {
                string nombre = fila["nombre"].ToString();
                int total = Convert.ToInt32(fila["totalActividades"]);
                int cumplimiento = Convert.ToInt32(fila["actividadesRealizadas"]);
                int porcentaje = (cumplimiento * 100) / total;

                DataPoint punto = new DataPoint();
                punto.AxisLabel = nombre;
                punto.YValues = new double[] { porcentaje };
                serieDatos.Points.Add(punto);
            }

            // Agregamos la serie al chart
            chrTrabajadores.Series.Add(serieDatos);

            // Configuramos el chart
            chrTrabajadores.Titles.Clear();
            chrTrabajadores.Titles.Add("Porcentaje de cumplimiento");
            chrTrabajadores.ChartAreas[0].AxisX.Interval = 1;
            chrTrabajadores.ChartAreas[0].AxisY.Minimum = 0;
            chrTrabajadores.ChartAreas[0].AxisY.Maximum = 100;
            chrTrabajadores.ChartAreas[0].AxisY.Interval = 10;
        }

        private void MostrarPreventivoMensual(DataTable dt)
        {
            chrPreventivoMensual.Series.Clear();
            chrPreventivoMensual.Titles.Clear();
            chrPreventivoMensual.Titles.Add("Actividades preventivas por mes");

            Series series = new Series();
            series.Name = "Actividades preventivas";
            series.ChartType = SeriesChartType.StackedBar;

            foreach (DataRow row in dt.Rows)
            {
                int conteo = Convert.ToInt32(row["conteo"]);
                DateTime fecha = Convert.ToDateTime(row["fecha"]);
                series.Points.AddXY(fecha.ToString("yyyy-MM-dd"), conteo);
            }

            chrPreventivoMensual.Series.Add(series);
            chrPreventivoMensual.ChartAreas[0].AxisX.Interval = 1;
            chrPreventivoMensual.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
        }
        private void MostrarCorrectivoMensual(DataTable dt)
        {
            chrCorrectivoMensual.Series.Clear();
            chrCorrectivoMensual.Titles.Clear();
            chrCorrectivoMensual.Titles.Add("Actividades correctivas por mes");

            Series series = new Series();
            series.Name = "Correctivos";
            series.ChartType = SeriesChartType.StackedBar;

            foreach (DataRow row in dt.Rows)
            {
                int conteo = Convert.ToInt32(row["conteo"]);
                DateTime fecha = Convert.ToDateTime(row["fecha"]);
                series.Points.AddXY(fecha.ToString("yyyy-MM-dd"), conteo);
            }

            chrCorrectivoMensual.Series.Add(series);
            chrCorrectivoMensual.ChartAreas[0].AxisX.Interval = 1;
            chrCorrectivoMensual.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
        }
        private void MostrarPreventivoVsCorrectivo(float[] datos)
        {
            // Limpiamos los datos previamente agregados al chart
            chrPreventivoVsCorrectivo.Series.Clear();

            // Creamos una nueva serie de datos para el chart
            Series serieDatos = new Series();
            serieDatos.ChartType = SeriesChartType.Doughnut;

            // Añadimos los datos a la serie
            DataPoint puntoCorrectivo = new DataPoint();
            puntoCorrectivo.AxisLabel = "Correctivo";
            puntoCorrectivo.YValues = new double[] { datos[0] };
            puntoCorrectivo.LegendText = string.Format("{0}: {1} ({2:P0})", puntoCorrectivo.AxisLabel, puntoCorrectivo.YValues[0], puntoCorrectivo.YValues[0] / datos.Sum());
            serieDatos.Points.Add(puntoCorrectivo);

            DataPoint puntoPreventivo = new DataPoint();
            puntoPreventivo.AxisLabel = "Preventivo";
            puntoPreventivo.YValues = new double[] { datos[1] };
            puntoPreventivo.LegendText = string.Format("{0}: {1} ({2:P0})", puntoPreventivo.AxisLabel, puntoPreventivo.YValues[0], puntoPreventivo.YValues[0] / datos.Sum());
            serieDatos.Points.Add(puntoPreventivo);

            // Agregamos la serie al chart
            chrPreventivoVsCorrectivo.Series.Add(serieDatos);

            // Configuramos el chart
            chrPreventivoVsCorrectivo.Titles.Clear();
            chrPreventivoVsCorrectivo.Titles.Add("Horas trabajadas");

            // Configurar el formato de las etiquetas
            chrPreventivoVsCorrectivo.Series[0].Label = "#VALX";
        }



        private async void tmrResultados_Tick(object sender, EventArgs e)
        {
            await MostrarResultados();
        }
    }
}
