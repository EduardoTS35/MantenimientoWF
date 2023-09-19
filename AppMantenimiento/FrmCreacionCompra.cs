using Common;
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
    public partial class FrmCreacionCompra : Form
    {
        public event EventHandler FormularioBCerrado;

        Proveedores proveedores = new Proveedores();
        AlmacenRefacciones almacen = new AlmacenRefacciones();
        SolicitudRefaccion solicitud = new SolicitudRefaccion();

        int idRefaccion;
        int status = 1;
        
        public FrmCreacionCompra(int idSolicitud, int idRefaccion, string descripcion, int cantidad)
        {
            InitializeComponent();
            Usuario.BoolApp = true;
            this.idRefaccion = idRefaccion;
            MostrarLeyendas(idSolicitud, descripcion, cantidad);
            MostrarProveedores();
        }
        #region Metodos
        public void MostrarProveedores()
        {
            cmbProveedor.DataSource = proveedores.MostrarProveedores();
            cmbProveedor.DisplayMember = "nombre";    
            cmbProveedor.ValueMember = "id";
        }
        public void MostrarLeyendas(int idSolicitud, string descripcion, int cantidad)
        {
            if (idSolicitud > 0)
                txtIdSolicitud.Text = idSolicitud.ToString();
            else
                txtIdSolicitud.Text = "N/A";

            txtProducto.Text = descripcion;
            nmrCantidad.Value = cantidad;
        }
        public bool ValidarInformacion()
        {
            if(cmbProveedor.Text != "" & nmrCantidad.Value != 0 & nmrPrecio.Value!=0)
                return true;
            else
                return false;

        }

        #endregion

        private void bttGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarInformacion())
            {
                almacen.AgregarMovimientoRefaccion(this.idRefaccion, status, (int)nmrCantidad.Value, DateTime.Now, Convert.ToString(cmbProveedor.SelectedValue), Convert.ToInt16(txtIdSolicitud.Text), "", (double)nmrPrecio.Value, 0);
                solicitud.AprobarSolicitud(Convert.ToInt16(txtIdSolicitud.Text), Common.Usuario.IdTrabajador);
                MessageBox.Show("Se realizó correctamente el movimiento", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormularioBCerrado?.Invoke(this, EventArgs.Empty);
                this.Close();
            }
        }
    }
}
