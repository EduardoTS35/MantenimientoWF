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
    public partial class FrmAutorizacionCompra : Form
    {
        AlmacenRefacciones almacen = new AlmacenRefacciones();
        int statusAprobado = 3;
        int statusDenegado = 2;
        public FrmAutorizacionCompra()
        {
            InitializeComponent();
            _ = MostrarSolicitudesAsync();
        }
        private async Task MostrarSolicitudesAsync()
        {
            dtgSolicitudes.Columns.Clear();

            DataGridViewButtonColumn btnAprobar = new DataGridViewButtonColumn();
            btnAprobar.HeaderText = "Aprobar";
            btnAprobar.Text = "Aprobar";
            btnAprobar.Name = "Aprobar";
            btnAprobar.UseColumnTextForButtonValue = true;

            DataGridViewButtonColumn btnRechazar = new DataGridViewButtonColumn();
            btnRechazar.HeaderText = "Rechazar";
            btnRechazar.Text = "Rechazar";
            btnRechazar.Name = "Rechazar";
            btnRechazar.UseColumnTextForButtonValue = true;

            dtgSolicitudes.DataSource = await almacen.MostrarAlmacenRefaccionesAsync(1,0);

            dtgSolicitudes.Columns[0].HeaderText = "No. Serial";
            dtgSolicitudes.Columns[1].HeaderText = "Fecha";
            dtgSolicitudes.Columns[6].HeaderText = "Proveedor";
            dtgSolicitudes.Columns[2].HeaderText = "No.Refacción";
            dtgSolicitudes.Columns[3].HeaderText = "Refacción";
            dtgSolicitudes.Columns[4].HeaderText = "Cantidad";
            dtgSolicitudes.Columns[7].HeaderText = "Precio";         
            dtgSolicitudes.Columns[8].HeaderText = "No.Solicitud";

            dtgSolicitudes.Columns[5].Visible = false;

            dtgSolicitudes.Columns.Add(btnAprobar);
            dtgSolicitudes.Columns.Add(btnRechazar);
        }

        private void dtgSolicitudes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dtgSolicitudes.Rows[e.RowIndex].Cells["idSerial"].Value);
            DateTime fecha = Convert.ToDateTime(dtgSolicitudes.Rows[e.RowIndex].Cells["Fecha"].Value);
            int idSolicitud = Convert.ToInt32(dtgSolicitudes.Rows[e.RowIndex].Cells["idSolicitud"].Value);
            int idRefaccion = Convert.ToInt32(dtgSolicitudes.Rows[e.RowIndex].Cells["idRefaccion"].Value); // Asegúrate de que el nombre de la columna sea correcto
            int cantidadSolicitada = Convert.ToInt32(dtgSolicitudes.Rows[e.RowIndex].Cells["cantidad"].Value); // Cambia "CantidadSolicitada" al nombre correcto
            string idProveedor = Convert.ToString(dtgSolicitudes.Rows[e.RowIndex].Cells["idProveedor"].Value);
            double precio = Convert.ToDouble(dtgSolicitudes.Rows[e.RowIndex].Cells["precio"].Value);
            if (e.ColumnIndex == dtgSolicitudes.Columns["Aprobar"].Index && e.RowIndex >= 0)
            {
                
                almacen.AgregarMovimientoRefaccion(idRefaccion, statusAprobado, cantidadSolicitada, DateTime.Now, idProveedor, idSolicitud, "", precio,0);
                almacen.EditarMovimientoRefaccion(id, idRefaccion, 1, cantidadSolicitada, fecha ,1);
                MessageBox.Show("Se realizó correctamente el movimiento", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _ = MostrarSolicitudesAsync();
            }
            else if (e.ColumnIndex == dtgSolicitudes.Columns["Denegar"].Index && e.RowIndex >= 0)
            {
                almacen.AgregarMovimientoRefaccion(idRefaccion, statusDenegado, cantidadSolicitada, DateTime.Now, idProveedor, idSolicitud, "", precio,0);
                almacen.EditarMovimientoRefaccion(id, idRefaccion, 1, cantidadSolicitada, fecha, 1);
                MessageBox.Show("Se denego correctamente la compra", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _ = MostrarSolicitudesAsync();
            }
        }
    }
}
