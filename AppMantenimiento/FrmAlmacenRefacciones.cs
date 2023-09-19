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
    public partial class FrmAlmacenRefacciones : Form
    {
        private class Refaccion
        {
            public string CodigoRefaccion { get; set; }
            public string Descripcion { get; set; }
            public int CantidadTotal { get; set; }
            public string Grupo { get; set; }
        }

        AlmacenRefacciones almacen = new AlmacenRefacciones();
        Refacciones refaccion = new Refacciones();
        
        private List<Refaccion> refaccionesOriginales;
        public FrmAlmacenRefacciones()
        {
            InitializeComponent();
            
        }

        private void bttRegistrarCompra_Click(object sender, EventArgs e)
        {
            FrmSeleccionRefaccion frm= new FrmSeleccionRefaccion();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmSeleccionRefaccion frm = new FrmSeleccionRefaccion();
            frm.ShowDialog();
        }

        private List<Refaccion> ConvertirDataTableALista(DataTable dataTable)
        {
            var refacciones = new List<Refaccion>();

            foreach (DataRow row in dataTable.Rows)
            {
                var refaccion = new Refaccion
                {
                    CodigoRefaccion = row["idRefaccion"].ToString(),
                    Descripcion = row["descripcion"].ToString(),
                    CantidadTotal = Convert.ToInt32(row["total_cantidad"]),
                    Grupo = row["grupo"].ToString()
                };

                refacciones.Add(refaccion);
            }

            return refacciones;
        }


        private async Task CargarRegistrosRefacciones()
        {
            // Elimina todas las columnas existentes en el DataGridView
            dtgRefacciones.Columns.Clear();

            // Obtiene los datos de la maquinaria y los asigna como origen de datos para el DataGridView
            refaccionesOriginales = ConvertirDataTableALista(await almacen.MostrarAlmacenRefaccionesAsync());

            MostrarRefaccionesEnDataGridView(refaccionesOriginales);
        }

        private void MostrarRefaccionesEnDataGridView(List<Refaccion> refacciones)
        {
            // Elimina todas las columnas existentes en el DataGridView
            dtgRefacciones.Columns.Clear();

            // Configura las columnas manualmente
            DataGridViewTextBoxColumn colCodigoRefaccion = new DataGridViewTextBoxColumn();
            colCodigoRefaccion.HeaderText = "Cód. Refacción";
            colCodigoRefaccion.DataPropertyName = "CodigoRefaccion"; // Debe coincidir con la propiedad en la clase Refaccion
            colCodigoRefaccion.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Alinea al centro
            colCodigoRefaccion.FillWeight = 25; // Peso relativo de la columna

            DataGridViewTextBoxColumn colDescripcion = new DataGridViewTextBoxColumn();
            colDescripcion.HeaderText = "Descripción";
            colDescripcion.DataPropertyName = "Descripcion"; // Debe coincidir con la propiedad en la clase Refaccion
            colDescripcion.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Alinea al centro
            colDescripcion.FillWeight = 25; // Peso relativo de la columna

            DataGridViewTextBoxColumn colCantidadTotal = new DataGridViewTextBoxColumn();
            colCantidadTotal.HeaderText = "Cantidad Total";
            colCantidadTotal.DataPropertyName = "CantidadTotal"; // Debe coincidir con la propiedad en la clase Refaccion
            colCantidadTotal.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Alinea al centro
            colCantidadTotal.FillWeight = 25; // Peso relativo de la columna

            DataGridViewTextBoxColumn colGrupo = new DataGridViewTextBoxColumn();
            colGrupo.HeaderText = "Grupo";
            colGrupo.DataPropertyName = "Grupo"; // Debe coincidir con la propiedad en la clase Refaccion
            colGrupo.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Alinea al centro
            colGrupo.FillWeight = 25; // Peso relativo de la columna

            // Agrega las columnas al DataGridView
            dtgRefacciones.Columns.Add(colCodigoRefaccion);
            dtgRefacciones.Columns.Add(colDescripcion);
            dtgRefacciones.Columns.Add(colCantidadTotal);
            dtgRefacciones.Columns.Add(colGrupo);

            // Asigna los datos al DataGridView
            dtgRefacciones.DataSource = refacciones;

            // Establece el modo de ajuste automático al contenido de las celdas
            dtgRefacciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }




        private void RestaurarRegistrosOriginales()
        {
            MostrarRefaccionesEnDataGridView(refaccionesOriginales);
        }

        private void FiltrarPorCodigoRefaccion(string codigoRefaccion)
        {
            var refaccionesFiltradas = refaccionesOriginales
                .Where(r => r.CodigoRefaccion.Contains(codigoRefaccion))
                .ToList();

            MostrarRefaccionesEnDataGridView(refaccionesFiltradas);
        }

        private void FiltrarPorDescripcion(string descripcion)
        {
            var refaccionesFiltradas = refaccionesOriginales
                .Where(r => r.Descripcion.Contains(descripcion))
                .ToList();

            MostrarRefaccionesEnDataGridView(refaccionesFiltradas);
        }

        private void FiltrarPorCantidadTotal(int cantidadTotal)
        {
            var refaccionesFiltradas = refaccionesOriginales
                .Where(r => r.CantidadTotal == cantidadTotal)
                .ToList();

            MostrarRefaccionesEnDataGridView(refaccionesFiltradas);
        }

        private void FiltrarPorGrupo(string grupo)
        {
            var refaccionesFiltradas = refaccionesOriginales
                .Where(r => r.Grupo == grupo)
                .ToList();

            MostrarRefaccionesEnDataGridView(refaccionesFiltradas);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RestaurarRegistrosOriginales();
        }

        private void txtFiltroDesc_TextChanged(object sender, EventArgs e)
        {
            FiltrarPorDescripcion(txtFiltroDesc.Text);
        }

        private void cmbGrupos_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarPorGrupo(cmbGrupos.Text);
        }

        private async void FrmAlmacenRefacciones_Load(object sender, EventArgs e)
        {
            
            cmbGrupos.DataSource = await refaccion.MostrarGruposRefacciones();
            cmbGrupos.DisplayMember = "grupo";
            await CargarRegistrosRefacciones();
        }

        private void dtgRefacciones_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.RowIndex >= 0)
            {
                // Obtener el valor de la celda de cantidad
                if (int.TryParse(e.Value?.ToString(), out int cantidad))
                {
                    // Establecer el color de fondo según el valor de cantidad
                    if (cantidad > 20)
                    {
                        e.CellStyle.BackColor = Color.Green;
                    }
                    else if (cantidad < 3)
                    {
                        e.CellStyle.BackColor = Color.Red;
                    }
                }
            }
        }
    }
}
