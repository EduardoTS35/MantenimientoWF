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
    public partial class FrmCatalogoRefacciones : Form
    {
        Refacciones refacciones = new Refacciones();
        bool cargarTodo = false;
        bool editar = false;
        public FrmCatalogoRefacciones()
        {
            InitializeComponent();
            _ = MostrarGruposAsync();
            _ = LoadInitialDataAsync();
        }
        #region Métodos
        private async Task LoadInitialDataAsync()
        {
            dtgRefacciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtgRefacciones.Columns.Clear();

            DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn();
            btnEditar.HeaderText = "Editar";
            btnEditar.Text = "Editar";
            btnEditar.Name = "Editar";
            btnEditar.UseColumnTextForButtonValue = true;

            DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn();
            btnEliminar.HeaderText = "Eliminar";
            btnEliminar.Text = "Eliminar";
            btnEliminar.Name = "Eliminar";
            btnEliminar.UseColumnTextForButtonValue = true;

            dtgRefacciones.DataSource = await refacciones.MostrarTop100Refacciones();

            ConfigureColumnHeaders();

            dtgRefacciones.Columns.Add(btnEliminar);
            dtgRefacciones.Columns.Add(btnEditar);

            dtgRefacciones.Columns[1].Visible = false;
            dtgRefacciones.Columns[6].Visible = false;

            await LoadRemainingDataAsync();
        }

        private void ConfigureColumnHeaders()
        {
            dtgRefacciones.Columns[0].HeaderText = "Cód. Refacción";
            dtgRefacciones.Columns[1].HeaderText = "Grupo";
            dtgRefacciones.Columns[2].HeaderText = "Descripción";
            dtgRefacciones.Columns[3].HeaderText = "Unidad";
            dtgRefacciones.Columns[4].HeaderText = "Máquina";
            dtgRefacciones.Columns[5].HeaderText = "Precio";
            dtgRefacciones.Columns[6].HeaderText = "Proveedor";
            dtgRefacciones.Columns[7].HeaderText = "Máximo";
            dtgRefacciones.Columns[8].HeaderText = "Mínimo";
            dtgRefacciones.Columns[9].HeaderText = "Moneda";
        }

        private async Task LoadRemainingDataAsync()
        {
            dtgRefacciones.DataSource = await refacciones.MostrarRefaccionesAsync();
            // You might want to refresh the DataGridView to update the data displayed
            dtgRefacciones.Refresh();
        }
        private async Task MostrarGruposAsync()
        {
            cmbGrupo.DataSource = await refacciones.MostrarGruposRefacciones();
            cmbGrupo.DisplayMember = "grupo";
        }

        private bool ValidarCampos()
        {
            if (txtDesc.Text != "" & txtMaquina.Text!="" & txtUnidad.Text!="" & mskPrecio.Text!="")
                return true;
            else return false;
        }

        private void LimpiarDatos()
        {
            editar = false;
            txtDesc.Clear();
            txtMaquina.Clear();
            txtUnidad.Clear();
            mskPrecio.Clear();
            mskMax.Clear();
            mskMin.Clear();
        }

        #endregion

        private void bttGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if(editar == false)
                {
                    if (ValidarCampos())
                    {
                        refacciones.AgregarRefaccion(cmbGrupo.Text, txtDesc.Text, txtUnidad.Text, txtMaquina.Text, Convert.ToDouble(mskPrecio.Text), "NULL", Convert.ToInt16(mskMax.Text), Convert.ToInt16(mskMin.Text), cmbMoneda.Text);
                        MessageBox.Show("Refacción registrada exitosamente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarDatos();
                    }
                    else
                    {
                        DialogResult dialogResult = MessageBox.Show("¿Estás seguro de continuar sin todos los campos?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (dialogResult == DialogResult.Yes)
                        {
                            if (txtDesc.Text == "")
                                MessageBox.Show("Por favor introduce el nombre de la refacción.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else
                            {
                                refacciones.AgregarRefaccion(cmbGrupo.Text, txtDesc.Text, txtUnidad.Text, txtMaquina.Text, Convert.ToDouble(mskPrecio.Text), "NULL", Convert.ToInt16(mskMax.Text), Convert.ToInt16(mskMin.Text), cmbMoneda.Text);
                                MessageBox.Show("Refacción registrada exitosamente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LimpiarDatos();
                            }
                        }
                    }
                }
                else
                {
                    if (ValidarCampos())
                    {
                        refacciones.EditarRefaccion(refacciones.idRefaccion,cmbGrupo.Text, txtDesc.Text, txtUnidad.Text, txtMaquina.Text, Convert.ToDouble(mskPrecio.Text),"", Convert.ToInt16(mskMax.Text), Convert.ToInt16(mskMin.Text), cmbMoneda.Text);
                        MessageBox.Show("Refacción editada exitosamente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarDatos();
                    }
                    else
                    {
                        DialogResult dialogResult = MessageBox.Show("¿Estás seguro de continuar sin todos los campos?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (dialogResult == DialogResult.Yes)
                        {
                            if (txtDesc.Text == "")
                                MessageBox.Show("Por favor introduce el nombre de la refacción.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else
                            {
                                refacciones.EditarRefaccion(refacciones.idRefaccion, cmbGrupo.Text, txtDesc.Text, txtUnidad.Text, txtMaquina.Text, Convert.ToDouble(mskPrecio.Text), "", Convert.ToInt16(mskMax.Text), Convert.ToInt16(mskMin.Text), cmbMoneda.Text);
                                MessageBox.Show("Refacción editada exitosamente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LimpiarDatos();
                            }
                        }
                    }
                }

                _ = LoadInitialDataAsync();
            }
            catch
            {
                MessageBox.Show("Intente más tarde nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bttCargarRefacciones_Click(object sender, EventArgs e)
        {
            cargarTodo = true;
            _ = LoadInitialDataAsync();
            cargarTodo = false;
        }

        private void dtgRefacciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dtgRefacciones.Columns["Eliminar"].Index && e.RowIndex >= 0)
            {
                refacciones.idRefaccion = (int)dtgRefacciones.Rows[e.RowIndex].Cells["idRefaccion"].Value;
                refacciones.EliminarRefaccion(refacciones.idRefaccion);
                _ = LoadInitialDataAsync();
                MessageBox.Show("Refacción eliminada exitosamente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (e.ColumnIndex == dtgRefacciones.Columns["Editar"].Index && e.RowIndex >= 0)
            {
                refacciones.idRefaccion = (int)dtgRefacciones.Rows[e.RowIndex].Cells["idRefaccion"].Value;
                cmbGrupo.Text = dtgRefacciones.Rows[e.RowIndex].Cells["grupo"].Value.ToString();
                txtDesc.Text = dtgRefacciones.Rows[e.RowIndex].Cells["descripcion"].Value.ToString();
                txtUnidad.Text = dtgRefacciones.Rows[e.RowIndex].Cells["unidad"].Value.ToString();
                txtMaquina.Text = dtgRefacciones.Rows[e.RowIndex].Cells["maquina"].Value.ToString();
                mskPrecio.Text = dtgRefacciones.Rows[e.RowIndex].Cells["precio"].Value.ToString();
                mskMax.Text = dtgRefacciones.Rows[e.RowIndex].Cells["max"].Value.ToString();
                mskMin.Text = dtgRefacciones.Rows[e.RowIndex].Cells["min"].Value.ToString();
                cmbMoneda.SelectedValue = dtgRefacciones.Rows[e.RowIndex].Cells["moneda"].Value.ToString();
                editar = true;
            }
        }

        private void bttLimpiarDatos_Click(object sender, EventArgs e)
        {
            txtDesc.Clear();
            txtMaquina.Clear();
            txtUnidad.Clear();
            mskPrecio.Clear();
        }
    }
}
