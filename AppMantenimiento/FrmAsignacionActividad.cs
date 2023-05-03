using Domain.Models;
using System;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppMantenimiento
{
    public partial class FrmAsignacionActividad : Form
    {
        Trabajador trabajador = new Trabajador();
        Area area = new Area();
        Actividad actividad = new Actividad();
        Maquina maquina = new Maquina();
        RegistroActividad registro = new RegistroActividad();
        //DataSet Actividades
        DataSet resultados = new DataSet();
        DataView mifiltro;
        DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
        DataGridViewButtonColumn desasignarColumn = new DataGridViewButtonColumn();
        public FrmAsignacionActividad()
        {
            InitializeComponent();
            Task.Run(async () =>
            {
                await MostrarActividades();
            }).GetAwaiter().GetResult();
            Task.Run(async () =>
            {
                await MostrarTrabajadores();
            }).GetAwaiter().GetResult();
            Task.Run(async () =>
            {
                await MostrarAreaAsync();
            }).GetAwaiter().GetResult();
        }
        #region Métodos
        private async Task MostrarActividades()
        {
            resultados.Tables.Add(await actividad.MostrarActividadesAsync());
            this.mifiltro = ((DataTable)resultados.Tables[0]).DefaultView;
            dtgActividades.DataSource = mifiltro;
            //Columnas Visibles
            dtgActividades.Columns[3].HeaderText = "Nombre de Actividad";
            dtgActividades.Columns[3].Visible = true;
            dtgActividades.Columns[5].HeaderText = "Descripción";
            dtgActividades.Columns[5].Visible = true;
            dtgActividades.Columns[11].HeaderText = "Área";
            dtgActividades.Columns[11].Visible = true;
            dtgActividades.Columns[14].HeaderText = "Maquina";
            dtgActividades.Columns[14].Visible = true;
            dtgActividades.Columns[7].HeaderText = "Periodo";
            dtgActividades.Columns[7].Visible = true;
            dtgActividades.Columns[8].HeaderText = "Fecha Programada";
            dtgActividades.Columns[8].Visible = true;
            dtgActividades.Columns[9].HeaderText = "Asignada";
            dtgActividades.Columns[9].Visible = true;
            dtgActividades.Columns[10].HeaderText = "Desasignar";
            dtgActividades.Columns[10].Visible = true;
            //Columnas a ocultar
            dtgActividades.Columns[0].Visible = false;
            dtgActividades.Columns[1].Visible = false;
            dtgActividades.Columns[2].Visible = false;
            dtgActividades.Columns[4].Visible = false;
            dtgActividades.Columns[6].Visible = false;
            dtgActividades.Columns[10].Visible = false;
            dtgActividades.Columns[12].Visible = false;
            dtgActividades.Columns[13].Visible = false;
            dtgActividades.Columns[15].Visible = false;
            dtgActividades.Columns[16].Visible = false;
            dtgActividades.Columns[17].Visible = false;
            // Crear la columna de botones

            buttonColumn.Name = "Asignar";
            buttonColumn.Text = "Asignar";
            buttonColumn.UseColumnTextForButtonValue = true;

            desasignarColumn.Name = "Desasignar";
            desasignarColumn.Text = "Desasignar";
            desasignarColumn.UseColumnTextForButtonValue = true;

            // Agregar la columna al control DataGridView
            dtgActividades.Columns.Add(buttonColumn);
            dtgActividades.Columns.Add(desasignarColumn);
        }
        private async Task MostrarAreaAsync()
        {
            cmbFiltroArea.DataSource = await area.MostrarAreasAsync();
            cmbFiltroArea.DisplayMember = "descripcion";
            cmbFiltroArea.ValueMember = "idArea";
        }
        private async Task MostrarMaquinariaArea(int idArea)
        {
            cmbMaquina.DataSource = await maquina.MostrarMaquinariaArea(idArea);
            cmbMaquina.DisplayMember = "descripcion";
            cmbMaquina.ValueMember = "idMaquina";
        }
        private async Task MostrarTrabajadores()
        {
            cmbTrabajadores.DataSource = await trabajador.MostrarTrabajadores();
            cmbTrabajadores.DisplayMember = "nombre";
            cmbTrabajadores.ValueMember = "idTrabajador";
        }
        #endregion

        #region Eventos


        private void cmbFiltroArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                _ = MostrarMaquinariaArea(Convert.ToInt32(cmbFiltroArea.SelectedValue));
                this.mifiltro.RowFilter = "idArea = " + cmbFiltroArea.SelectedValue + "";
            }
            catch (Exception) { }

        }

        private void cmbMaquina_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.mifiltro.RowFilter = "idMaquina = " + cmbMaquina.SelectedValue + "";
            }
            catch (Exception) { }

        }
        private void rdbAsignadas_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbAsignadas.Checked)
            {
                try
                {
                    this.mifiltro.RowFilter = "asignada = 1";
                }
                catch (Exception) { }
            }
        }

        private void rdbSinAsignar_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbSinAsignar.Checked)
            {
                try
                {
                    this.mifiltro.RowFilter = "asignada = 0";
                }
                catch (Exception) { }
            }
        }
        private void bttEliminarFiltro_Click(object sender, EventArgs e)
        {
            mifiltro.RowFilter = null;
        }

        private void dtgActividades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dtgActividades.Columns["Asignar"].Index && e.RowIndex >= 0)
            {
                if (cmbTrabajadores.Text != "")
                {
                    if ((int)dtgActividades.Rows[e.RowIndex].Cells["asignada"].Value == 0)
                    {
                        actividad.IdActividad = (int)dtgActividades.Rows[e.RowIndex].Cells["idActividad"].Value;
                        actividad.IdArea = (int)dtgActividades.Rows[e.RowIndex].Cells["idArea"].Value;
                        actividad.IdMaquina = (int)dtgActividades.Rows[e.RowIndex].Cells["idMaquina"].Value;
                        actividad.NombreActividad = dtgActividades.Rows[e.RowIndex].Cells["nombreActividad"].Value.ToString();
                        actividad.RecursoHumano = (int)dtgActividades.Rows[e.RowIndex].Cells["recursoHumano"].Value;
                        actividad.Descripcion = dtgActividades.Rows[e.RowIndex].Cells["descripcion"].Value.ToString();
                        actividad.Tiempo = Convert.ToDouble(dtgActividades.Rows[e.RowIndex].Cells["tiempo"].Value);
                        actividad.Periodo = (int)dtgActividades.Rows[e.RowIndex].Cells["periodo"].Value;
                        actividad.FechaProgramada = (DateTime)dtgActividades.Rows[e.RowIndex].Cells["fechaProgramada"].Value;
                        actividad.Asignada = 1;
                        actividad.EditarActividad(actividad.IdArea, actividad.IdMaquina, actividad.NombreActividad,
                            actividad.RecursoHumano, actividad.Descripcion, actividad.Tiempo, actividad.Periodo,
                            actividad.FechaProgramada, actividad.Asignada);
                        registro.AgregarRegistro("1", actividad.IdActividad, actividad.IdMaquina, (int)cmbTrabajadores.SelectedValue, actividad.FechaProgramada, Convert.ToDateTime("01/01/2000"), "", 0);
                        dtgActividades.Rows[e.RowIndex].Cells[e.ColumnIndex].ReadOnly = true;
                        dtgActividades.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Gray;
                        dtgActividades.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.White;
                        MessageBox.Show("Actividad asignada exitosamente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DataGridViewRow row = dtgActividades.Rows[e.RowIndex];
                        dtgActividades.Rows.Remove(row);
                    }
                    else
                        MessageBox.Show("Esta actividad ya se ecnuentra asignada.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Por favor selecciona una tarea.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            if (e.ColumnIndex == dtgActividades.Columns["Desasignar"].Index && e.RowIndex >= 0)
            {
                actividad.IdActividad = (int)dtgActividades.Rows[e.RowIndex].Cells["idActividad"].Value;
                actividad.IdArea = (int)dtgActividades.Rows[e.RowIndex].Cells["idArea"].Value;
                actividad.IdMaquina = (int)dtgActividades.Rows[e.RowIndex].Cells["idMaquina"].Value;
                actividad.NombreActividad = dtgActividades.Rows[e.RowIndex].Cells["nombreActividad"].Value.ToString();
                actividad.RecursoHumano = (int)dtgActividades.Rows[e.RowIndex].Cells["recursoHumano"].Value;
                actividad.Descripcion = dtgActividades.Rows[e.RowIndex].Cells["descripcion"].Value.ToString();
                actividad.Tiempo = Convert.ToDouble(dtgActividades.Rows[e.RowIndex].Cells["tiempo"].Value);
                actividad.Periodo = (int)dtgActividades.Rows[e.RowIndex].Cells["periodo"].Value;
                actividad.FechaProgramada = (DateTime)dtgActividades.Rows[e.RowIndex].Cells["fechaProgramada"].Value;
                actividad.Asignada = 0;
                actividad.EditarActividad(actividad.IdArea, actividad.IdMaquina, actividad.NombreActividad,
                    actividad.RecursoHumano, actividad.Descripcion, actividad.Tiempo, actividad.Periodo,
                    actividad.FechaProgramada, actividad.Asignada);
                registro.EliminarRegistro(actividad.IdActividad);
                dtgActividades.Rows[e.RowIndex].Cells[e.ColumnIndex].ReadOnly = true;
                dtgActividades.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Gray;
                dtgActividades.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.White;
                MessageBox.Show("Actividad desasignada exitosamente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataGridViewRow row = dtgActividades.Rows[e.RowIndex];
                dtgActividades.Rows.Remove(row);
                //Método desasignar
            }
        }
        #endregion

    }
}
