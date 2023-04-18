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

        public FrmTablas()
        {
            InitializeComponent();
            tmrResultados.Start();
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

        private async void tmrResultados_Tick(object sender, EventArgs e)
        {
            await MostrarResultados();
        }
    }
}
