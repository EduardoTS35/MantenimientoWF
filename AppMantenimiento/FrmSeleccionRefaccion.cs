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
    public partial class FrmSeleccionRefaccion : Form
    {
        private Refacciones refacciones = new Refacciones();
        private bool filtroDesc = false;
        private DataTable originalDataTable;
        public FrmSeleccionRefaccion()
        {
            InitializeComponent();
            _ = InitializeAsync();
        }

        private async Task InitializeAsync()
        {
            // Cargar todos los datos de manera asíncrona
            originalDataTable = await refacciones.MostrarRefaccionesAsync();

            // Luego, muestra los grupos en el ComboBox de manera asíncrona
            await MostrarGruposAsync();

            // Configura la tabla de datos
            ConfigureDataGridView();
        }

        private async Task MostrarGruposAsync()
        {
            cmbGrupo.DataSource = await refacciones.MostrarGruposRefacciones();
            cmbGrupo.DisplayMember = "grupo";
        }

        private void ConfigureDataGridView()
        {
            dtgRefacciones.Columns.Clear();

            DataGridViewButtonColumn btnSeleccionar = new DataGridViewButtonColumn();
            btnSeleccionar.HeaderText = "Seleccionar";
            btnSeleccionar.Text = "Seleccionar";
            btnSeleccionar.Name = "Seleccionar";
            btnSeleccionar.UseColumnTextForButtonValue = true;

            dtgRefacciones.DataSource = originalDataTable;

            dtgRefacciones.Columns[0].HeaderText = "Cód. Refacción";
            dtgRefacciones.Columns[1].HeaderText = "Grupo";
            dtgRefacciones.Columns[2].HeaderText = "Descripción";
            dtgRefacciones.Columns[3].HeaderText = "Unidad";
            dtgRefacciones.Columns[4].HeaderText = "Máquina";

            dtgRefacciones.Columns.Add(btnSeleccionar);

            dtgRefacciones.Columns[1].Visible = false;
            dtgRefacciones.Columns[5].Visible = false;
            dtgRefacciones.Columns[6].Visible = false;
            dtgRefacciones.Columns[7].Visible = false;
            dtgRefacciones.Columns[8].Visible = false;
        }

        private void Filtrado()
        {
            string filtroDescripcion = txtDesc.Text;
            string filtroGrupo = cmbGrupo.Text;

            DataView dv = originalDataTable.DefaultView;

            if (!string.IsNullOrWhiteSpace(filtroDescripcion))
            {
                dv.RowFilter = $"descripcion LIKE '%{filtroDescripcion}%'";
            }
            else if (!string.IsNullOrWhiteSpace(filtroGrupo))
            {
                dv.RowFilter = $"grupo = '{filtroGrupo}'";
            }
            else
            {
                dv.RowFilter = string.Empty; // No hay filtros, mostrar todos los datos
            }

            dtgRefacciones.DataSource = dv;
        }



        private void dtgRefacciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == dtgRefacciones.Columns["Seleccionar"].Index && e.RowIndex >= 0)
                {
                    refacciones.idRefaccion = (int)dtgRefacciones.Rows[e.RowIndex].Cells["idRefaccion"].Value;
                    refacciones.grupo = dtgRefacciones.Rows[e.RowIndex].Cells["grupo"].Value.ToString();
                    refacciones.descripcion = dtgRefacciones.Rows[e.RowIndex].Cells["descripcion"].Value.ToString();
                    refacciones.unidad = dtgRefacciones.Rows[e.RowIndex].Cells["unidad"].Value.ToString();
                    refacciones.maquina = dtgRefacciones.Rows[e.RowIndex].Cells["maquina"].Value.ToString();
                    FrmSolicitudRefaccion frm = new FrmSolicitudRefaccion(refacciones.idRefaccion, refacciones.grupo, refacciones.descripcion, refacciones.unidad, refacciones.maquina);
                    frm.ShowDialog();
                    this.Close();
                }
            }
            catch
            {
            }

        }

        private void txtDesc_TextChanged(object sender, EventArgs e)
        {
            if (cmbGrupo.SelectedIndex > 0)
            {
                cmbGrupo.Text = "";
            }
            filtroDesc = true;
            Filtrado();
        }

        private void cmbGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtDesc.Text != "")
                txtDesc.Clear();
            filtroDesc = false;
            Filtrado();
        }

        private void bttLimpiar_Click(object sender, EventArgs e)
        {
            DataView dv = (DataView)dtgRefacciones.DataSource;
            dv.RowFilter = string.Empty;
            dtgRefacciones.DataSource = dv;

            // Restaurar valores por defecto en los elementos de filtrado
            txtDesc.Text = string.Empty;
            cmbGrupo.SelectedIndex = -1;
        }
    }
}
