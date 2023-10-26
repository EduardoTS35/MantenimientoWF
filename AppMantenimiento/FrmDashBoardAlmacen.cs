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
    public partial class FrmDashBoardAlmacen : Form
    {
        AlmacenRefacciones almacen = new AlmacenRefacciones();
        ListadoEstados estados = new ListadoEstados();
        DateTime fechaInicial = DateTime.Now.AddDays(-7);
        DateTime fechaFinal = DateTime.Now;
        public FrmDashBoardAlmacen()
        {
            InitializeComponent();
            MostrarEstados();
        }
        private void CargarGrupos()
        {

        }
        
        private void MostrarResumenGrupos()
        {
            
        }
        private void MostrarEstados()
        {
            cmbHistorial.DataSource = estados.MostrarListadoEstados();
            cmbHistorial.DisplayMember = "descripcion";
            cmbHistorial.ValueMember = "idStatus";
        }
        private void MostrarHistorial(int idStatus)
        {
            dtgHistorial.DataSource = almacen.MostrarHistorial(fechaInicial, fechaFinal, idStatus);

            dtgHistorial.Columns[0].HeaderText = "No. Serial";
            dtgHistorial.Columns[1].HeaderText = "No.Refacción";
            dtgHistorial.Columns[2].HeaderText = "Refacción";
            dtgHistorial.Columns[3].HeaderText = "Estado";
            dtgHistorial.Columns[4].HeaderText = "Fecha Movimiento";
            dtgHistorial.Columns[5].HeaderText = "Cantidad";
            dtgHistorial.Columns[6].HeaderText = "Proveedor";
            dtgHistorial.Columns[7].HeaderText = "Precio";
        }

        private void FrmDashBoardAlmacen_Load(object sender, EventArgs e)
        {
            MostrarHistorial((int)cmbHistorial.SelectedValue);
        }

        private void cmbHistorial_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarHistorial((int)cmbHistorial.SelectedValue);
        }
    }
}
