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
            dtgMaquinaria.DataSource = maquina.MostrarMaquinaria();
        }
        private void GuardarMaquinaria(int idArea, string descripcion, string modelo, int fabricacion, string marca)
        {
            maquina.AgregarMaquina(idArea, descripcion, modelo, fabricacion, marca);
        }
        private void EliminarMaquina(int idMaquina)
        {
            maquina.EliminarMaquina(idMaquina);
        }
        #endregion

        private void bttGuardar_Click(object sender, EventArgs e)
        {
            GuardarMaquinaria((int)cmbArea.SelectedValue, txtDescripcion.Text, txtModelo.Text, Convert.ToInt16(mskFabricacion.Text), txtMarca.Text);
            MessageBox.Show("Maquina registrada exitosamente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
