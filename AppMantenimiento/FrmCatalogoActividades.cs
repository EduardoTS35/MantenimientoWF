using Domain.Models;
using Microsoft.Win32;
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
    public partial class FrmCatalogoActividades : Form
    {
        Area area = new Area();
        Actividad actividad = new Actividad();
        Maquina maquina = new Maquina();
        //DataSet Actividades
        DataSet resultados = new DataSet();
        DataView mifiltro;
        DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
        DataGridViewButtonColumn buttonBorrar = new DataGridViewButtonColumn();
        public FrmCatalogoActividades()
        {
            InitializeComponent();
            Task.Run(async () =>
            {
                await MostrarActividades();
            }).GetAwaiter().GetResult();
            Task.Run(async () =>
            {
                await MostrarAreaAsync();
            }).GetAwaiter().GetResult();
            InitializeComponent();
            
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
            dtgActividades.Columns[9].HeaderText = "Editar";
            dtgActividades.Columns[9].Visible = true;
            dtgActividades.Columns[10].HeaderText = "Eliminar";
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

            buttonColumn.Name = "Editar";
            buttonColumn.Text = "Editar";
            buttonColumn.UseColumnTextForButtonValue = true;
            buttonBorrar.Name = "Eliminar";
            buttonBorrar.Text = "Eliminar";
            buttonBorrar.UseColumnTextForButtonValue = true;

            // Agregar la columna al control DataGridView
            dtgActividades.Columns.Add(buttonColumn);
            dtgActividades.Columns.Add(buttonBorrar);
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
        private void AgregarEditarActividad()
        {
            FrmChildCatalogoActividades frm = new FrmChildCatalogoActividades(actividad);
            frm.ShowDialog();
        }

        #endregion

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
                this.mifiltro.RowFilter = "idMaquina = " + cmbMaquina.SelectedValue + " and idArea = "+ cmbFiltroArea.SelectedValue +"";
            }
            catch (Exception) { }
        }

        private void bttEliminarFiltro_Click(object sender, EventArgs e)
        {
            try
            {
                this.mifiltro.RowFilter = null;
            }
            catch (Exception) { }
        }

        private void bttAgregar_Click(object sender, EventArgs e)
        {
            actividad.IdActividad = 0;
            AgregarEditarActividad();
        }

        private void dtgActividades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           //Agregar edición de actividades
        }
    }
}
