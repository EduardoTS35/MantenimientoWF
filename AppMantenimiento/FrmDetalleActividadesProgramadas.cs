using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain.Models;

namespace AppMantenimiento
{
    public partial class FrmDetalleActividadesProgramadas : Form
    {
        private RegistroActividad actividad = new RegistroActividad();
        DataTable dt = new DataTable();

        public FrmDetalleActividadesProgramadas()
        {
            InitializeComponent();
            _ = MostrarActividadesAsync();
        }
        private async Task MostrarActividadesAsync()
        {
            // Eliminar todas las columnas existentes
            dtgActividades.Columns.Clear();

            // Configurar las columnas deseadas y ocultar las no deseadas
            await ConfigurarColumnasAsync(DateTime.Now.AddDays(-60), DateTime.Now);
        }

        private async Task ConfigurarColumnasAsync(DateTime fechaInicio, DateTime fechaFin)
        {
            dt = await actividad.MostrarRegistroAsync(fechaInicio, fechaFin);
            dtgActividades.DataSource = dt;

            dtgActividades.Columns[26].HeaderText = "Area";
            dtgActividades.Columns[26].Visible = true;
            dtgActividades.Columns[21].HeaderText = "Maquina";
            dtgActividades.Columns[21].Visible = true;
            dtgActividades.Columns[5].HeaderText = "Fecha Programada";
            dtgActividades.Columns[5].Visible = true;
            dtgActividades.Columns[6].HeaderText = "Fecha Relizacion";
            dtgActividades.Columns[6].Visible = true;
            dtgActividades.Columns[12].HeaderText = "Nombre Actividad";
            dtgActividades.Columns[12].Visible = true;
            dtgActividades.Columns[14].HeaderText = "Desc.";
            dtgActividades.Columns[14].Visible = true;
            dtgActividades.Columns[15].HeaderText = "Tiempo";
            dtgActividades.Columns[15].Visible = true;
            dtgActividades.Columns[29].HeaderText = "Trabajador Asignado";
            dtgActividades.Columns[29].Visible = true;

            dtgActividades.Columns[0].Visible = false;
            dtgActividades.Columns[1].Visible = false;
            dtgActividades.Columns[2].Visible = false;
            dtgActividades.Columns[3].Visible = false;
            dtgActividades.Columns[4].Visible = false;
            dtgActividades.Columns[7].Visible = false;
            dtgActividades.Columns[8].Visible = false;

            dtgActividades.Columns[9].Visible = false;
            dtgActividades.Columns[10].Visible = false;
            dtgActividades.Columns[11].Visible = false;
            dtgActividades.Columns[13].Visible = false;
            dtgActividades.Columns[16].Visible = false;
            dtgActividades.Columns[17].Visible = false;
            dtgActividades.Columns[18].Visible = false;
            dtgActividades.Columns[19].Visible = false;
            dtgActividades.Columns[20].Visible = false;
            dtgActividades.Columns[22].Visible = false;
            dtgActividades.Columns[23].Visible = false;
            dtgActividades.Columns[24].Visible = false;
            dtgActividades.Columns[25].Visible = false;
            dtgActividades.Columns[27].Visible = false;
            dtgActividades.Columns[28].Visible = false;
            dtgActividades.Columns[30].Visible = false;
            dtgActividades.Columns[31].Visible = false;
            dtgActividades.Columns[32].Visible = false;
            dtgActividades.Columns[33].Visible = false;
            dtgActividades.Columns[34].Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (dtgActividades.DataSource is DataTable dt)
            {
                string filtro = textBox1.Text.Trim();

                if (string.IsNullOrEmpty(filtro))
                {
                    dt.DefaultView.RowFilter = ""; // Mostrar todo si no hay filtro
                }
                else
                {
                    // Filtrar por Área, Máquina o Descripción (columnas visibles)
                    dt.DefaultView.RowFilter = string.Format(
                        "[nombreActividad] LIKE '%{0}%' OR [descripcion] LIKE '%{0}%' OR [descripcion1] LIKE '%{0}%' OR [descripcion2] LIKE '%{0}%'", filtro);
                }
            }
        }

        private void bttFiltro_Click(object sender, EventArgs e)
        {
            dt.Clear();
            dtgActividades.Columns.Clear();
            _ = ConfigurarColumnasAsync(dtpFechaInicio.Value, dtpFechaFin.Value);
        }

        private void bttRestablecer_Click(object sender, EventArgs e)
        {
            dt.Clear();
            dtgActividades.Columns.Clear();
            textBox1.Clear();
            _ = ConfigurarColumnasAsync(DateTime.Now.AddDays(-60), DateTime.Now);
        }
    }
}
