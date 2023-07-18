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
    public partial class FrmReporteInfo : Form
    {
        Area area= new Area();
        bool areaSeleccionada = false;
        bool dtpDeSeleccionado;
        bool dtpASeleccionado;
        int[] areas = { 1, 2, 3, 4 };
        
        public FrmReporteInfo()
        {
            InitializeComponent();
            MostrarAreaAsync();
        }
        private async Task MostrarAreaAsync()
        {
            cmbArea.DataSource = await area.MostrarAreasAsync();
            cmbArea.DisplayMember = "descripcion";
            cmbArea.ValueMember = "idArea";
        }

        private void bttAceptar_Click(object sender, EventArgs e)
        {
            if (areaSeleccionada && dtpDeSeleccionado && dtpASeleccionado)
            {
                int[] selectedAreas = new int[] { (int)cmbArea.SelectedValue };
                FrmReporte frm = new FrmReporte(dtpDe.Value, dtpA.Value, selectedAreas, cmbArea.Text);
                frm.Show();
                this.Close();
            }

            else if (areaSeleccionada==false )
                MessageBox.Show("Por favor selecciona un area", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            else if (dtpDeSeleccionado==false)
                MessageBox.Show("Por favor selecciona un valor en la primera opción de fechas", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            else if(dtpASeleccionado ==false)
                MessageBox.Show("Por favor selecciona un valor en la segunda opción de fechas", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        }

        private void cmbArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            areaSeleccionada = true;
        }

        private void dtpDe_ValueChanged(object sender, EventArgs e)
        {
            dtpDeSeleccionado = true;
        }

        private void dtpA_ValueChanged(object sender, EventArgs e)
        {
            dtpASeleccionado = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (areaSeleccionada && dtpDeSeleccionado)
            {
                FrmReporte frm = new FrmReporte(dtpDe.Value, dtpA.Value, areas, cmbArea.Text);
                frm.Show();
                this.Close();
            }
        }
    }
}
