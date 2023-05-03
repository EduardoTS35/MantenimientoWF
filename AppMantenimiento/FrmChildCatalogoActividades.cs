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
    public partial class FrmChildCatalogoActividades : Form
    {
        Actividad actividad = new Actividad();
        Area area = new Area();
        Maquina maquina = new Maquina();
        public FrmChildCatalogoActividades(Actividad actividad)
        {
            this.actividad = actividad;
            InitializeComponent();
            #region CmbArea
            Task.Run(async () =>
            {
                await MostrarAreaAsync();
            }).GetAwaiter().GetResult();
            #endregion
            #region CmbMaquina
            Task.Run(async () =>
            {
                await MostrarMaquinaria();
            }).GetAwaiter().GetResult();
            #endregion
            if (actividad.IdActividad == 0)
                lblTitulo.Text = "Agregar Actividad";
            else
            {
                lblTitulo.Text = "Editar Actividad";
                txtNombreActividad.Text = actividad.NombreActividad;
                txtDesc.Text = actividad.Descripcion;
                cmbArea.SelectedValue = actividad.IdArea;
                cmbMaquina.SelectedValue= actividad.IdMaquina;
                nmrRH.Value = actividad.RecursoHumano;
                nmrPeriodo.Value = actividad.Periodo;
                nmrTiempo.Value= (decimal)actividad.Tiempo;
                dtpFechaProgramada.Value = actividad.FechaProgramada;
            }               
        }
        private async Task MostrarAreaAsync()
        {
            cmbArea.DataSource = await area.MostrarAreasAsync();
            cmbArea.DisplayMember = "descripcion";
            cmbArea.ValueMember = "idArea";
        }
        private async Task MostrarMaquinaria()
        {
            cmbMaquina.DataSource = await maquina.MostrarMaquinariaAsync();
            cmbMaquina.DisplayMember = "descripcion";
            cmbMaquina.ValueMember = "idMaquina";
        }
        private async Task MostrarMaquinariaArea(int idArea)
        {
            cmbMaquina.DataSource = await maquina.MostrarMaquinariaArea(idArea);
            cmbMaquina.DisplayMember = "descripcion";
            cmbMaquina.ValueMember = "idMaquina";
        }
        private void bttGuardar_Click(object sender, EventArgs e)
        {
            if (actividad.IdActividad == 0)
            {
                actividad.AgregarActividad((int)cmbArea.SelectedValue,(int)cmbMaquina.SelectedValue,txtNombreActividad.Text,
                    (int)nmrRH.Value,txtDesc.Text,(double)nmrTiempo.Value,(int)nmrPeriodo.Value,dtpFechaProgramada.Value,0);
                MessageBox.Show("Actividad agregada exitosamente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                actividad.EditarActividad((int)cmbArea.SelectedValue, (int)cmbMaquina.SelectedValue, txtNombreActividad.Text,
                    (int)nmrRH.Value, txtDesc.Text, (double)nmrTiempo.Value, (int)nmrPeriodo.Value, dtpFechaProgramada.Value, 0);
                MessageBox.Show("Actividad editada exitosamente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cmbArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (actividad.IdActividad == 0)
            {
                try
                {
                    _ = MostrarMaquinariaArea(Convert.ToInt32(cmbArea.SelectedValue));
                }
                catch { }
            }
           
        }

        private void FrmChildCatalogoActividades_FormClosed(object sender, FormClosedEventArgs e)
        {
            actividad=null;
        }
    }
}
