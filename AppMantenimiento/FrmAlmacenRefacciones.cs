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
    public partial class FrmAlmacenRefacciones : Form
    {
        public FrmAlmacenRefacciones()
        {
            InitializeComponent();
            CargarRegistrosRefacciones();
        }

        private void bttRegistrarCompra_Click(object sender, EventArgs e)
        {
            FrmChildAlmRefEntradaSalida frm= new FrmChildAlmRefEntradaSalida();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmChildAlmRefEntradaSalida frm = new FrmChildAlmRefEntradaSalida();
            frm.ShowDialog();
        }
        private void CargarRegistrosRefacciones()
        {
            // Simulación de datos de refacciones (puedes reemplazar esto con tus propios datos)
            var refacciones = new[]
            {
                new { Nombre = "Refaccion 1", Cantidad = 5 },
                new { Nombre = "Refaccion 2", Cantidad = 8 },
                new { Nombre = "Refaccion 3", Cantidad = 3 },
                new { Nombre = "Refaccion 4", Cantidad = 12 },
                new { Nombre = "Refaccion 5", Cantidad = 2 },
                new { Nombre = "Refaccion 6", Cantidad = 7 },
                new { Nombre = "Refaccion 7", Cantidad = 15 },
                new { Nombre = "Refaccion 8", Cantidad = 4 },
                new { Nombre = "Refaccion 9", Cantidad = 9 },
                new { Nombre = "Refaccion 10", Cantidad = 6 }
            };

            // Limpiar filas existentes en el DataGridView
            dtgRefacciones.Rows.Clear();

            // Agregar cada registro de refacción al DataGridView
            foreach (var refaccion in refacciones)
            {
                int rowIndex = dtgRefacciones.Rows.Add();
                dtgRefacciones.Rows[rowIndex].Cells[0].Value = refaccion.Nombre;
                dtgRefacciones.Rows[rowIndex].Cells[1].Value = refaccion.Cantidad;

                // Colorear la celda de la cantidad en rojo si es baja, de lo contrario, en verde
                if (refaccion.Cantidad <= 5)
                    dtgRefacciones.Rows[rowIndex].Cells["Cantidad"].Style.ForeColor = Color.Red;
                else
                    dtgRefacciones.Rows[rowIndex].Cells["Cantidad"].Style.ForeColor = Color.Green;
            }
        }
    }
}
