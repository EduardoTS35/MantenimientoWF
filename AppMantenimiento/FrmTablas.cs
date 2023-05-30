using Domain.Models;
using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace AppMantenimiento
{
    public partial class FrmTablas : Form
    {
        Actividad actividad = new Actividad();
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
        string fechaDelDia = DateTime.Now.ToString("yyyy-MM-dd");
        DateTime primerDiaMes = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
        DateTime ultimoDiaMes;

        public FrmTablas()
        {
            InitializeComponent();
            tmrResultados.Start();
            ultimoDiaMes = primerDiaMes.AddMonths(1).AddDays(-1);
            _ = MostrarResultados();
            MostrarPreventivoMensual(registro.RegistroPreventivoDashboard(primerDiaMes, ultimoDiaMes));
            MostrarCorrectivoMensual(correctivo.RegistroCorrectivoDashboard(primerDiaMes, ultimoDiaMes));
            MostrarPreventivoVsCorrectivo(correctivo.CorrectivoVsPreventivoDashboard(primerDiaMes, ultimoDiaMes));
            MostrarDatosTrabajadores(registro.MostrarActividadesRealizadas(primerDiaMes, ultimoDiaMes));
            MostrarDatosMaquinaria(correctivo.TiempoParoMaquinaDashboard(primerDiaMes, ultimoDiaMes));
        }
        private async Task MostrarResultados()
        {
            //lblNumPD.Text = await MostrarPreventivosDiarios();
            //lblNumPR.Text = await MostrarPreventivosRealizados();
            //lblNumCR.Text = await MostrarCorrectivosRealizados();
        }

        private async Task<string> MostrarPreventivosDiarios()
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
                this.filtroRegistro.RowFilter = "fechaRealizacion >= '" + fechaDelDia + "'";
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
            this.filtroCorrectivo = resultadosCorrectivo.Tables[0].DefaultView;
            try
            {
                this.filtroCorrectivo.RowFilter = "fecha >= '" + fechaDelDia + "'";
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
            serieDatos.Name = "Trabajadores";
            serieDatos.ChartType = SeriesChartType.Bar;

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

            chrPreventivoVsCorrectivo.Series.Clear();
            Series series = new Series();
            series.ChartType = SeriesChartType.Doughnut;
            DataPoint dataPoint = new DataPoint();
            dataPoint.AxisLabel = "Correctivo";
            dataPoint.YValues = new double[1] { datos[0] };
            dataPoint.LegendText = $"{dataPoint.AxisLabel}: {dataPoint.YValues[0]} ({dataPoint.YValues[0] / (double)datos.Sum():P0})";
            series.Points.Add(dataPoint);
            DataPoint dataPoint2 = new DataPoint();
            dataPoint2.AxisLabel = "Preventivo";
            dataPoint2.YValues = new double[1] { datos[1] };
            dataPoint2.LegendText = $"{dataPoint2.AxisLabel}: {dataPoint2.YValues[0]} ({Math.Round(dataPoint2.YValues[0] / (double)datos.Sum(), 1):P0})";
            series.Points.Add(dataPoint2);
            chrPreventivoVsCorrectivo.Series.Add(series);
            chrPreventivoVsCorrectivo.Titles.Clear();
            chrPreventivoVsCorrectivo.Titles.Add("Horas trabajadas");



        }
        private void MostrarDatosMaquinaria(DataTable tabla)
        {
            chrTiempoParo.Series.Clear();
            Series series = new Series();
            series.ChartType = SeriesChartType.Doughnut;
            series["PieLabelStyle"] = "Inside";
            series["PieLineColor"] = "Black";
            foreach (DataRow row in tabla.Rows)
            {
                string text = row["descripcion"].ToString();
                double num = Convert.ToDouble(row["tiempoParo"]);
                DataPoint dataPoint = new DataPoint();
                dataPoint.Label = text + ": " + Convert.ToString(num);
                dataPoint.YValues = new double[1] { num };
                dataPoint.CustomProperties = "PieLabelStyle=Disabled";
                series.Points.Add(dataPoint);
            }
            chrTiempoParo.Series.Add(series);
            chrTiempoParo.Titles.Clear();
            chrTiempoParo.Titles.Add("Tiempo de paro por maquinaria");
            chrTiempoParo.ChartAreas[0].Area3DStyle.Enable3D = true;
            chrTiempoParo.ChartAreas[0].AxisX.Enabled = AxisEnabled.False;
            chrTiempoParo.ChartAreas[0].AxisY.Enabled = AxisEnabled.False;
            chrTiempoParo.Legends.Add(new Legend("Maquinas"));
            chrTiempoParo.Legends[0].Docking = Docking.Right;
            chrTiempoParo.Legends[0].CustomItems.Clear();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            MostrarPreventivoMensual(registro.RegistroPreventivoDashboard(primerDiaMes, ultimoDiaMes));
            MostrarCorrectivoMensual(correctivo.RegistroCorrectivoDashboard(primerDiaMes, ultimoDiaMes));
            MostrarPreventivoVsCorrectivo(correctivo.CorrectivoVsPreventivoDashboard(primerDiaMes, ultimoDiaMes));
            MostrarDatosTrabajadores(registro.MostrarActividadesRealizadas(primerDiaMes, ultimoDiaMes));
            MostrarDatosMaquinaria(correctivo.TiempoParoMaquinaDashboard(primerDiaMes, ultimoDiaMes));
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            MostrarPreventivoMensual(registro.RegistroPreventivoDashboard(Convert.ToDateTime(fechaDelDia).AddDays(-15.0), Convert.ToDateTime(fechaDelDia).AddDays(1.0)));
            MostrarCorrectivoMensual(correctivo.RegistroCorrectivoDashboard(Convert.ToDateTime(fechaDelDia).AddDays(-15.0), Convert.ToDateTime(fechaDelDia).AddDays(1.0)));
            MostrarPreventivoVsCorrectivo(correctivo.CorrectivoVsPreventivoDashboard(Convert.ToDateTime(fechaDelDia).AddDays(-15.0), Convert.ToDateTime(fechaDelDia).AddDays(1.0)));
            MostrarDatosTrabajadores(registro.MostrarActividadesRealizadas(Convert.ToDateTime(fechaDelDia).AddDays(-15.0), Convert.ToDateTime(fechaDelDia).AddDays(1.0)));
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            MostrarPreventivoMensual(registro.RegistroPreventivoDashboard(Convert.ToDateTime(fechaDelDia).AddDays(-7.0), Convert.ToDateTime(fechaDelDia).AddDays(1.0)));
            MostrarCorrectivoMensual(correctivo.RegistroCorrectivoDashboard(Convert.ToDateTime(fechaDelDia).AddDays(-7.0), Convert.ToDateTime(fechaDelDia).AddDays(1.0)));
            MostrarPreventivoVsCorrectivo(correctivo.CorrectivoVsPreventivoDashboard(Convert.ToDateTime(fechaDelDia).AddDays(-7.0), Convert.ToDateTime(fechaDelDia).AddDays(1.0)));
            MostrarDatosTrabajadores(registro.MostrarActividadesRealizadas(Convert.ToDateTime(fechaDelDia).AddDays(-7.0), Convert.ToDateTime(fechaDelDia).AddDays(1.0)));
        }
    }
}
