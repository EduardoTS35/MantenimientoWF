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
    public partial class FrmReporteCompras : Form
    {
        AlmacenRefacciones almacen = new AlmacenRefacciones();
        DateTime fechaInicio;
        DateTime fechaFin;
        DataTable originalData;
        public FrmReporteCompras(DateTime fechaInicio, DateTime fechaFin)
        {
            InitializeComponent();
            this.fechaInicio = fechaInicio;
            this.fechaFin = fechaFin;
        }


        private void FrmReporteCompras_Load(object sender, EventArgs e)
        {
            MostrarDetalleMovimientos();
        }
        private void MostrarLineaDeTiempo()
        {
            _ = new DataTable();
            _ = almacen.MostrarHistorial(fechaInicio, fechaFin, 1);
            chrGastoLineaTiempo.ChartAreas[0].AxisX.Minimum = 0;
            chrGastoLineaTiempo.ChartAreas[0].AxisY.Maximum = 0;

            chrGastoLineaTiempo.Series.Clear();
            Series series = new Series();
            series.ChartType = SeriesChartType.Line;
        }
        private void MostrarBarrasGrupoRefacciones()
        {

        }
        private void MostrarSumatoriaElementos()
        {

        }
        private void MostrarDetalleMovimientos()
        {
            dtgMovimientos.DataSource = almacen.MostrarMovimientosFecha(fechaInicio, fechaFin);
            dtgMovimientos.Columns[2].HeaderText = "Desc. Refacción";
            dtgMovimientos.Columns[4].HeaderText = "Desc. Estatus";
            dtgMovimientos.Columns[5].HeaderText = "Fecha de Movimiento";
            dtgMovimientos.Columns[6].HeaderText = "Cantidad";
            dtgMovimientos.Columns[7].HeaderText = "Proveedor";
            dtgMovimientos.Columns[10].HeaderText = "Precio";

            //Ocultar columnas
            dtgMovimientos.Columns[0].Visible = false;
            dtgMovimientos.Columns[1].Visible = false;
            dtgMovimientos.Columns[3].Visible = false;
            dtgMovimientos.Columns[8].Visible = false;
            dtgMovimientos.Columns[9].Visible = false;
        }
    }
}
