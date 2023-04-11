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
    public partial class FrmMostrarCorrectivo : Form
    {
        ListadoTrabajadoresCorrectivo listado= new ListadoTrabajadoresCorrectivo();
        DataSet resultadosRegistro = new DataSet();
        DataView mifiltroRegistro;
        public FrmMostrarCorrectivo(RegistroCorrectivo correctivo)
        {
            InitializeComponent();
            txtDescCorrectivo.Text = correctivo.Descripcion;
            txtMaquina.Text = correctivo.DescMaquina;
            txtFecha.Text = correctivo.Fecha.ToString();
            txtTiempoParo.Text = Convert.ToString(correctivo.TiempoParo);
            resultadosRegistro.Tables.Add(listado.MostrarListado());
            this.mifiltroRegistro = ((DataTable)resultadosRegistro.Tables[0]).DefaultView;
            dtgInvolucrados.DataSource = mifiltroRegistro;
            try
            {
                this.mifiltroRegistro.RowFilter = "idActividadCorrectiva = " + correctivo.Id + "";
            }
            catch (Exception) { }
            dtgInvolucrados.Columns[13].HeaderText = "Nombre";
            dtgInvolucrados.Columns[13].Visible = true;
            dtgInvolucrados.Columns[14].HeaderText = "Apellido";
            dtgInvolucrados.Columns[14].Visible = true;
            dtgInvolucrados.Columns[3].HeaderText = "Descripción";
            dtgInvolucrados.Columns[3].Visible = true;
            dtgInvolucrados.Columns[4].HeaderText = "Horas Trabajadas";
            dtgInvolucrados.Columns[4].Visible = true;

            dtgInvolucrados.Columns[0].Visible = false;
            dtgInvolucrados.Columns[1].Visible = false;
            dtgInvolucrados.Columns[2].Visible = false;
            dtgInvolucrados.Columns[5].Visible = false;
            dtgInvolucrados.Columns[6].Visible = false;
            dtgInvolucrados.Columns[7].Visible = false;
            dtgInvolucrados.Columns[8].Visible = false;
            dtgInvolucrados.Columns[9].Visible = false;
            dtgInvolucrados.Columns[10].Visible = false;
            dtgInvolucrados.Columns[11].Visible = false;
            dtgInvolucrados.Columns[12].Visible = false;
            dtgInvolucrados.Columns[15].Visible = false;
            dtgInvolucrados.Columns[16].Visible = false;
            dtgInvolucrados.Columns[17].Visible = false;
            dtgInvolucrados.Columns[18].Visible = false;
        }
    }
}
