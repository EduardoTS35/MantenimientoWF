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
    public partial class FrmSolicitudRefaccion : Form
    {
        Area area = new Area();
        Maquina maquina = new Maquina();
        Refacciones refacciones = new Refacciones();
        SolicitudRefaccion formato = new SolicitudRefaccion();
        DateTime fecha = new DateTime();
        public FrmSolicitudRefaccion(int idRefaccion, string grupo, string descripcion, string unidad, string maquina)
        {
            InitializeComponent();
            _ = MostrarAreaAsync();
            txtRefaccion.Text = descripcion;
            refacciones.idRefaccion = idRefaccion;
            MostrarStock();
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

        private void MostrarStock()
        {
            comboBox1.DataSource = formato.StockRefaccion(refacciones.idRefaccion);
            comboBox1.DisplayMember = "stock";
        }

        private void cmbFiltroArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                _ = MostrarMaquinariaArea((int)cmbFiltroArea.SelectedValue);
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private void bttSolicitar_Click(object sender, EventArgs e)
        {
            try
            {
                fecha= DateTime.Now;
                formato.AgregarSolicitud(fecha, (int)nmtCantidad.Value, refacciones.idRefaccion, (int)cmbMaquina.SelectedValue, txtDescUso.Text, 1, 0, txtObservaciones.Text);
                MessageBox.Show("Solicitud registrada exitosamente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}
