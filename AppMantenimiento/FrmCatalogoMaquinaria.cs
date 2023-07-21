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
    public partial class FrmCatalogoMaquinaria : Form
    {
        Maquina maquina = new Maquina();
        Area area = new Area();
        bool seleccion=false;
        public FrmCatalogoMaquinaria()
        {
            InitializeComponent();
        }

        private void FrmCatalogoMaquinaria_Load(object sender, EventArgs e)
        {
            MostrarMaquinaria();
            _ = MostrarAreas();
        }
        #region Métodos
        private async Task MostrarAreas()
        {
            cmbArea.DataSource = await area.MostrarAreasAsync();
            cmbArea.DisplayMember = "descripcion";
            cmbArea.ValueMember = "idArea";
        }
        private void MostrarMaquinaria()
        {
            // Elimina todas las columnas existentes en el DataGridView
            dtgMaquinaria.Columns.Clear();

            // Agrega un botón de eliminar en cada fila
            DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn();
            btnEliminar.HeaderText = "Eliminar";
            btnEliminar.Text = "Eliminar";
            btnEliminar.Name = "Eliminar";
            btnEliminar.UseColumnTextForButtonValue = true;

            // Obtiene los datos de la maquinaria y los asigna como origen de datos para el DataGridView
            dtgMaquinaria.DataSource = maquina.MostrarMaquinaria();

            // Configura los encabezados de columna
            dtgMaquinaria.Columns[0].HeaderText = "Cód. Maquina";
            dtgMaquinaria.Columns[7].HeaderText = "Área";
            dtgMaquinaria.Columns[2].HeaderText = "Nombre";
            dtgMaquinaria.Columns[3].HeaderText = "Modelo";
            dtgMaquinaria.Columns[4].HeaderText = "Año de Fabricación";
            dtgMaquinaria.Columns[5].HeaderText = "Núm. Serie";

            // Añade la columna de botón de eliminar al final
            dtgMaquinaria.Columns.Add(btnEliminar);

            // Oculta las columnas que no deseas mostrar
            dtgMaquinaria.Columns[1].Visible = false;
            dtgMaquinaria.Columns[6].Visible = false;
        }

        private void GuardarMaquinaria(int idArea, string descripcion, string modelo, int fabricacion, string marca)
        {
            maquina.AgregarMaquina(idArea, descripcion, modelo, fabricacion, marca);
        }

        private void LimpiarCampos()
        {
            txtDescripcion.Clear();
            txtMarca.Clear();
            txtModelo.Clear();
            mskFabricacion.Clear();
        }
        #endregion

        private void bttGuardar_Click(object sender, EventArgs e)
        {
            GuardarMaquinaria((int)cmbArea.SelectedValue, txtDescripcion.Text, txtModelo.Text, Convert.ToInt16(mskFabricacion.Text), txtMarca.Text);
            MessageBox.Show("Maquina registrada exitosamente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MostrarMaquinaria();
            LimpiarCampos();
        }

        private void dtgMaquinaria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dtgMaquinaria.Columns["Eliminar"].Index && e.RowIndex >= 0)
            {
                maquina.IdMaquina = (int)dtgMaquinaria.Rows[e.RowIndex].Cells["idMaquina"].Value;
                maquina.EliminarMaquina(maquina.IdMaquina);
                MostrarMaquinaria();
                MessageBox.Show("Maquina eliminada exitosamente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
