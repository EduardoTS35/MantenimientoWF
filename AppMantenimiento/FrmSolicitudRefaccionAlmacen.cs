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
    public partial class FrmSolicitudRefaccionAlmacen : Form
    {
        AlmacenRefacciones almacen = new AlmacenRefacciones();
        SolicitudRefaccion solicitud = new SolicitudRefaccion();
        public FrmSolicitudRefaccionAlmacen()
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

            DataGridViewButtonColumn btnComprar = new DataGridViewButtonColumn();
            btnComprar.HeaderText = "Comprar";
            btnComprar.Text = "Comprar";
            btnComprar.Name = "Comprar";
            btnComprar.UseColumnTextForButtonValue = true;

            dtgSolicitudes.DataSource = await solicitud.MostrarTop100Solicitudes();

            dtgSolicitudes.Columns[1].HeaderText = "Fecha";
            dtgSolicitudes.Columns[2].HeaderText = "Nombre";
            dtgSolicitudes.Columns[3].HeaderText = "Cantidad";
            dtgSolicitudes.Columns[5].HeaderText = "Refacción";
            dtgSolicitudes.Columns[6].HeaderText = "Maquina";
            dtgSolicitudes.Columns[7].HeaderText = "Descripción de Uso";
            dtgSolicitudes.Columns[8].HeaderText = "Observaciones";

            dtgSolicitudes.Columns.Add(btnAprobar);
            dtgSolicitudes.Columns.Add(btnComprar);
            dtgSolicitudes.Columns[0].Visible = false;
            dtgSolicitudes.Columns[4].Visible = false;
        }

        private async void dtgSolicitudes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dtgSolicitudes.Columns["Aprobar"].Index && e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(dtgSolicitudes.Rows[e.RowIndex].Cells["id"].Value);
                int idRefaccion = Convert.ToInt32(dtgSolicitudes.Rows[e.RowIndex].Cells["idRefaccion"].Value); // Asegúrate de que el nombre de la columna sea correcto
                int cantidadSolicitada = Convert.ToInt32(dtgSolicitudes.Rows[e.RowIndex].Cells["cantidad"].Value); // Cambia "CantidadSolicitada" al nombre correcto

                // Llama al método StockRefaccion para obtener el DataTable con la información de stock
                DataTable stockTable = solicitud.StockRefaccion(idRefaccion);

                if (stockTable.Rows.Count > 0)
                {
                    int stock = Convert.ToInt32(stockTable.Rows[0]["stock"]);

                    if (stock >= cantidadSolicitada)
                    {
                        DialogResult dialogResult = MessageBox.Show("Al realizar el movimiento quedará en existencia: " + (stock - cantidadSolicitada) + " unidades","Mensaje",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                        if (dialogResult == DialogResult.Yes)
                        {
                            solicitud.AprobarSolicitud(id, Usuario.IdTrabajador);
                            almacen.AgregarMovimientoRefaccion(idRefaccion,5,cantidadSolicitada,DateTime.Now, "", id, "",0,0);
                            MessageBox.Show("Se realizó correctamente el movimiento", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            _ = MostrarSolicitudesAsync();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No hay suficiente stock para aprobar la refacción.");
                    }
                }
                else
                {
                    MessageBox.Show("No se pudo obtener la información de stock.");
                }
            }
            if (e.ColumnIndex == dtgSolicitudes.Columns["Comprar"].Index && e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(dtgSolicitudes.Rows[e.RowIndex].Cells["id"].Value);
                int idRefaccion = Convert.ToInt32(dtgSolicitudes.Rows[e.RowIndex].Cells["idRefaccion"].Value); // Asegúrate de que el nombre de la columna sea correcto
                string descripcion = Convert.ToString(dtgSolicitudes.Rows[e.RowIndex].Cells["Refaccion"].Value);
                int cantidadSolicitada = Convert.ToInt32(dtgSolicitudes.Rows[e.RowIndex].Cells["cantidad"].Value); // Cambia "CantidadSolicitada" al nombre correcto

                FrmCreacionCompra frm = new FrmCreacionCompra(id,idRefaccion,descripcion,cantidadSolicitada);
                frm.FormularioBCerrado += FormularioB_FormularioBCerrado;
                frm.ShowDialog();
                
            }
        }

        private async Task IniciarTimerAsync()
        {
            while (Usuario.BoolApp)
            {             
                await Task.Delay(1000); // Espera 1 segundo antes de volver a ejecutarse
            }
            if (Usuario.BoolApp == false)
            {
                
            }
        }
        private async void FormularioB_FormularioBCerrado(object sender, EventArgs e)
        {
            await MostrarSolicitudesAsync();
        }
    }
}
