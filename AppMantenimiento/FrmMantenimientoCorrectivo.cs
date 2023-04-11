using Domain.Models;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppMantenimiento
{
    public partial class FrmMantenimientoCorrectivo : Form
    {
        public RegistroCorrectivo correctivo = new RegistroCorrectivo();
        Area area = new Area();
        Maquina maquina = new Maquina();
        Trabajador trabajador = new Trabajador();
        ListadoTrabajadoresCorrectivo listado = new ListadoTrabajadoresCorrectivo();
        DataGridViewButtonColumn buttonSeleccionar = new DataGridViewButtonColumn();
        DataGridViewButtonColumn buttonMostrar = new DataGridViewButtonColumn();
        DataGridViewButtonColumn buttonEliminar = new DataGridViewButtonColumn();
        bool buttonsAdd=false;
        public FrmMantenimientoCorrectivo()
        {
            InitializeComponent();
            MostrarActividades();
            Task.Run(async () =>
            {
                await MostrarTrabajadores();
            }).GetAwaiter().GetResult();
            Task.Run(async () =>
            {
                await MostrarAreaAsync();
            }).GetAwaiter().GetResult();
        }
        #region Metodos
        private void MostrarActividades()
        {
            // Eliminar todas las columnas existentes
            dtgActividades.Columns.Clear();

            // Configurar las columnas deseadas y ocultar las no deseadas
            ConfigurarColumnas();

            // Agregar las columnas de botones al control DataGridView si aún no se han agregado
            dtgActividades.Columns.Add(buttonSeleccionar);
            dtgActividades.Columns.Add(buttonEliminar);
            dtgActividades.Columns.Add(buttonMostrar);
        }

        private void ConfigurarColumnas()
        {
            dtgActividades.DataSource = correctivo.MostrarCorrectivo();

            dtgActividades.Columns[13].HeaderText = "Área";
            dtgActividades.Columns[13].Visible = true;
            dtgActividades.Columns[8].HeaderText = "Maquina";
            dtgActividades.Columns[8].Visible = true;
            dtgActividades.Columns[4].HeaderText = "Descripción";
            dtgActividades.Columns[4].Visible = true;
            dtgActividades.Columns[5].HeaderText = "Fecha";
            dtgActividades.Columns[5].Visible = true;

            dtgActividades.Columns[0].Visible = false;
            dtgActividades.Columns[1].Visible = false;
            dtgActividades.Columns[2].Visible = false;
            dtgActividades.Columns[3].Visible = false;
            dtgActividades.Columns[6].Visible = false;
            dtgActividades.Columns[7].Visible = false;
            dtgActividades.Columns[9].Visible = false;
            dtgActividades.Columns[10].Visible = false;
            dtgActividades.Columns[11].Visible = false;
            dtgActividades.Columns[12].Visible = false;
            dtgActividades.Columns[14].Visible = false;
            dtgActividades.Columns[15].Visible = false;
            dtgActividades.Columns[16].Visible = false;
            dtgActividades.Columns[17].Visible = false;
            dtgActividades.Columns[18].Visible = false;
            dtgActividades.Columns[19].Visible = false;
            dtgActividades.Columns[20].Visible = false;
            dtgActividades.Columns[21].Visible = false;

            buttonSeleccionar.Name = "Seleccionar";
            buttonSeleccionar.Text = "Seleccionar";

            buttonEliminar.Name = "Eliminar";
            buttonEliminar.Text = "Eliminar";

            buttonMostrar.Name = "Mostrar";
            buttonMostrar.Text = "Mostrar";
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
            cmbListadoTrabajadores.DataSource = await trabajador.MostrarTrabajadores();
            cmbListadoTrabajadores.DisplayMember = "nombre";
            cmbListadoTrabajadores.ValueMember = "idTrabajador";
        }
        #endregion

        private void bttGuardarCorrectivo_Click(object sender, EventArgs e)
        {
            try
            {
                correctivo.AgregarCorrectivo((int)cmbMaquina.SelectedValue, (int)cmbTrabajadores.SelectedValue,
                                (double)nmrTiempoParo.Value, txtDesc.Text, DateTime.Now);
                MessageBox.Show("Actividad registrada correctamente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MostrarActividades();

            }
            catch (Exception) { }

        }
        private void cmbFiltroArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                _ = MostrarMaquinariaArea(Convert.ToInt32(cmbFiltroArea.SelectedValue));
            }
            catch (Exception) { }
        }
        private void dtgActividades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dtgActividades.Columns["Seleccionar"].Index && e.RowIndex >= 0)
            {
                correctivo.Id = (int)dtgActividades.Rows[e.RowIndex].Cells["id"].Value;
                bttGuardarListado.Enabled = true;
            }
            else if (e.ColumnIndex == dtgActividades.Columns["Eliminar"].Index && e.RowIndex >= 0)
            {
                correctivo.Id = (int)dtgActividades.Rows[e.RowIndex].Cells["id"].Value;
                listado.EliminarListadoCorrectivo(correctivo.Id);
                correctivo.EliminarCorrectivo(correctivo.Id);
                
                MessageBox.Show("Actividad eliminada correctamente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MostrarActividades();
            }
            else if (e.ColumnIndex == dtgActividades.Columns["Mostrar"].Index && e.RowIndex >= 0)
            {
                correctivo.Id = (int)dtgActividades.Rows[e.RowIndex].Cells["id"].Value;
                correctivo.Descripcion = dtgActividades.Rows[e.RowIndex].Cells["descripcion"].Value.ToString();
                correctivo.TiempoParo = Convert.ToDouble(dtgActividades.Rows[e.RowIndex].Cells["tiempoParo"].Value);
                correctivo.DescMaquina = dtgActividades.Rows[e.RowIndex].Cells[11].Value.ToString();
                correctivo.Fecha = Convert.ToDateTime(dtgActividades.Rows[e.RowIndex].Cells[8].Value);
                FrmMostrarCorrectivo frm = new FrmMostrarCorrectivo(correctivo);
                frm.Show();
            }
        }

        private void bttGuardarListado_Click(object sender, EventArgs e)
        {
            listado.AgregarListado(correctivo.Id, (int)cmbListadoTrabajadores.SelectedValue, txtDescListado.Text, (int)nmrHorasTrabajadas.Value);
            MessageBox.Show("Trabajador asignado correctamente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bttCerrarListado.Enabled = true;
        }

        private void bttCerrarListado_Click(object sender, EventArgs e)
        {
            correctivo.Id = 0;
            bttGuardarListado.Enabled=false;
            bttCerrarListado.Enabled = false;
            txtDescListado.Clear();
            nmrHorasTrabajadas.Value = 0;
        }
    }
}
