using Domain.Models;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppMantenimiento
{
    public partial class FrmRevision : Form
    {
        Area area = new Area();
        Maquina maquina = new Maquina();
        Trabajador trabajador = new Trabajador();
        Actividad actividad = new Actividad();
        RegistroActividad registro = new RegistroActividad();
        DataSet resultadosRegistro = new DataSet();
        DataView mifiltroRegistro;
        DateTime fecha = new DateTime();
        bool fechaDe = false;
        bool filtroTrabajador=false;
        public FrmRevision()
        {
            InitializeComponent();
            Task.Run(async () =>
            {
                await MostrarActividades();
            }).GetAwaiter().GetResult();
            Task.Run(async () =>
            {
                await MostrarTrabajadores();
            }).GetAwaiter().GetResult();
            Task.Run(async () =>
            {
                await MostrarAreaAsync();
            }).GetAwaiter().GetResult();
        }
        private async Task MostrarActividades()
        {
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            resultadosRegistro.Tables.Add(await registro.MostrarRegistroAsync());
            this.mifiltroRegistro = ((DataTable)resultadosRegistro.Tables[0]).DefaultView;
            dtgActividades.DataSource = mifiltroRegistro;
            //Columnas Visibles
            dtgActividades.Columns[12].HeaderText = "Nombre de Actividad";
            dtgActividades.Columns[12].Visible = true;
            dtgActividades.Columns[14].HeaderText = "Descripción de Actividad";
            dtgActividades.Columns[15].Visible = true;
            dtgActividades.Columns[15].HeaderText = "Tiempo";
            dtgActividades.Columns[16].Visible = true;
            dtgActividades.Columns[16].HeaderText = "Periodo";
            dtgActividades.Columns[14].Visible = true;
            dtgActividades.Columns[26].HeaderText = "Área";
            dtgActividades.Columns[26].Visible = true;
            dtgActividades.Columns[21].HeaderText = "Maquina";
            dtgActividades.Columns[21].Visible = true;
            dtgActividades.Columns[5].HeaderText = "Fecha Programada";
            dtgActividades.Columns[5].Visible = true;

            //Columnas a ocultar
            dtgActividades.Columns[0].Visible = false;
            dtgActividades.Columns[1].Visible = false;
            dtgActividades.Columns[2].Visible = false;
            dtgActividades.Columns[4].Visible = false;
            dtgActividades.Columns[6].Visible = false;
            dtgActividades.Columns[7].Visible = false;
            dtgActividades.Columns[8].Visible = false;
            dtgActividades.Columns[9].Visible = false;
            dtgActividades.Columns[11].Visible = false;
            dtgActividades.Columns[10].Visible = false;
            dtgActividades.Columns[3].Visible = false;
            dtgActividades.Columns[13].Visible = false;
            dtgActividades.Columns[17].Visible = false;

            dtgActividades.Columns[18].Visible = false;
            dtgActividades.Columns[19].Visible = false;
            dtgActividades.Columns[20].Visible = false;
            dtgActividades.Columns[22].Visible = false;
            dtgActividades.Columns[23].Visible = false;
            dtgActividades.Columns[24].Visible = false;
            dtgActividades.Columns[25].Visible = false;
            // Crear la columna de botones

            buttonColumn.Name = "Revisar";
            buttonColumn.Text = "Revisar";
            buttonColumn.UseColumnTextForButtonValue = true;

            // Agregar la columna al control DataGridView
            dtgActividades.Columns.Add(buttonColumn);
        }
        private int currentPage = 0; // Variable para realizar el seguimiento de la página actual

        private void PrintDataGridView()
        {
            PrintDocument doc = new PrintDocument();
            doc.DefaultPageSettings.Landscape = true;
            doc.PrinterSettings.PrinterName = "Microsoft Print to PDF";

            doc.PrintPage += delegate (object ev, PrintPageEventArgs ep)
            {
                const int DGV_ALTO = 35;
                int left = ep.MarginBounds.Left, top = ep.MarginBounds.Top;

                // Imprimir las columnas mostradas en el DataGridView en la primera página
                if (currentPage == 0)
                {
                    foreach (DataGridViewColumn col in dtgActividades.Columns)
                    {
                        if (col.Visible && col.Index != 14)
                        {
                            string text = col.HeaderText;
                            int textWidth = (int)ep.Graphics.MeasureString(text, new Font("Segoe UI", 16, FontStyle.Bold)).Width;
                            col.Width = Math.Max(col.Width, textWidth + 20);

                            ep.Graphics.DrawString(text, new Font("Segoe UI", 16, FontStyle.Bold), Brushes.DeepSkyBlue, left, top);
                            left += col.Width;

                            if (col.Index < dtgActividades.ColumnCount - 1)
                                ep.Graphics.DrawLine(Pens.Gray, left - 5, top, left - 5, top + 43 + (dtgActividades.RowCount - 1) * DGV_ALTO);
                        }
                    }

                    left = ep.MarginBounds.Left;
                    ep.Graphics.FillRectangle(Brushes.Black, left, top + 40, ep.MarginBounds.Right - left, 3);
                    top += 43;
                }

                // Imprimir las filas del DataGridView en la página actual
                while (currentPage < dtgActividades.RowCount - 1)
                {
                    DataGridViewRow row = dtgActividades.Rows[currentPage];
                    left = ep.MarginBounds.Left;

                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Visible)
                        {
                            string text = Convert.ToString(cell.Value);
                            int textWidth = (int)ep.Graphics.MeasureString(text, new Font("Segoe UI", 13)).Width;
                            if (textWidth > cell.OwningColumn.Width - 10)
                            {
                                float ratio = (float)(cell.OwningColumn.Width - 10) / textWidth;
                                ep.Graphics.DrawString(text, new Font("Segoe UI", 13 * ratio), Brushes.Black, left, top + 4);
                            }
                            else
                            {
                                ep.Graphics.DrawString(text, new Font("Segoe UI", 13), Brushes.Black, left, top + 4);
                            }

                            left += cell.OwningColumn.Width;
                        }
                    }

                    top += DGV_ALTO;
                    ep.Graphics.DrawLine(Pens.Gray, ep.MarginBounds.Left, top, ep.MarginBounds.Right, top);

                    currentPage++;

                    // Verificar si se necesita otra página para imprimir más filas
                    if (top + DGV_ALTO > ep.MarginBounds.Bottom)
                    {
                        ep.HasMorePages = true;
                        break;
                    }
                }
            };

            doc.Print();
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
        private async Task MostrarTrabajadores()
        {
            cmbTrabajadores.DataSource = await trabajador.MostrarTrabajadores();
            cmbTrabajadores.DisplayMember = "nombre";
            cmbTrabajadores.ValueMember = "idTrabajador";
        }

        private void ReasignarActividad(int idActividad,int idMaquina, int idTrabajador, DateTime fechaProgramada,DateTime fechaRealizacion, string notas, int idTrabajadorSupervisor)
        {
            registro.AgregarRegistro(registro.IdOrden, idActividad, idMaquina, idTrabajador,fechaProgramada, fechaRealizacion, notas, idTrabajadorSupervisor);
        }

        private void cmbFiltroArea_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            try
            {
                _ = MostrarMaquinariaArea(Convert.ToInt32(cmbFiltroArea.SelectedValue));
                this.mifiltroRegistro.RowFilter = "idArea = " + cmbFiltroArea.SelectedValue + "";
            }
            catch (Exception) { }
        }

        private void cmbMaquina_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.mifiltroRegistro.RowFilter = "idMaquina = " + cmbMaquina.SelectedValue + "";
            }
            catch (Exception) { }
        }

        private void cmbTrabajadores_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                filtroTrabajador = true;
                this.mifiltroRegistro.RowFilter = "idTrabajador = " + cmbTrabajadores.SelectedValue + "";
            }
            catch (Exception) { }
        }
        private void bttQuitarFiltro_Click(object sender, EventArgs e)
        {
            try
            {
                mifiltroRegistro.RowFilter = null;
                filtroTrabajador=false;
            }
            catch (Exception) { }
        }

        private void bttImprimir_Click(object sender, EventArgs e)
        {
            PrintDataGridView();
        }

        private void dtgActividades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            fecha = DateTime.Now;
            if (e.ColumnIndex == dtgActividades.Columns["Revisar"].Index && e.RowIndex >= 0)
            {
                if (txtNotas.Text == "")
                {
                    DialogResult dialogResult = MessageBox.Show("¿Estás seguro de continuar sin notas?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)
                    {
                        //Registro de Actividades
                        registro.Id = (int)dtgActividades.Rows[e.RowIndex].Cells["id"].Value;
                        registro.IdOrden = dtgActividades.Rows[e.RowIndex].Cells["idOrden"].Value.ToString();
                        registro.IdActividad = (int)dtgActividades.Rows[e.RowIndex].Cells["IdActividad"].Value;
                        registro.IdMaquina = (int)dtgActividades.Rows[e.RowIndex].Cells["IdMaquina"].Value;
                        registro.IdTrabajador = (int)dtgActividades.Rows[e.RowIndex].Cells["IdTrabajador"].Value;
                        registro.FechaProgramada = Convert.ToDateTime(dtgActividades.Rows[e.RowIndex].Cells["FechaProgramada"].Value);

                        if (chcFechaSeleccionada.Checked)
                            registro.FechaRealizacion = dtpFechaRealizacion.Value;
                        else
                            registro.FechaRealizacion = fecha.Date;

                        registro.Notas = txtNotas.Text;
                        registro.IdTrabajadorSupervisor = 1;
                        registro.EditarRegistro(registro.IdOrden, registro.IdActividad, registro.IdMaquina, registro.IdTrabajador,
                            registro.FechaProgramada, (DateTime)registro.FechaRealizacion, registro.Notas, (int)registro.IdTrabajadorSupervisor);
                        //Actividades 
                        actividad.IdActividad = (int)dtgActividades.Rows[e.RowIndex].Cells["idActividad"].Value;
                        actividad.IdArea = (int)dtgActividades.Rows[e.RowIndex].Cells["idArea"].Value;
                        actividad.IdMaquina = (int)dtgActividades.Rows[e.RowIndex].Cells["idMaquina"].Value;
                        actividad.NombreActividad = dtgActividades.Rows[e.RowIndex].Cells["nombreActividad"].Value.ToString();
                        actividad.RecursoHumano = (int)dtgActividades.Rows[e.RowIndex].Cells["recursoHumano"].Value;
                        actividad.Descripcion = dtgActividades.Rows[e.RowIndex].Cells["descripcion"].Value.ToString();
                        actividad.Tiempo = Convert.ToDouble(dtgActividades.Rows[e.RowIndex].Cells["tiempo"].Value);
                        actividad.Periodo = (int)dtgActividades.Rows[e.RowIndex].Cells["periodo"].Value;

                        if (chcFechaSeleccionada.Checked)
                            actividad.FechaProgramada = dtpFechaRealizacion.Value.AddDays(actividad.Periodo);
                        else
                            actividad.FechaProgramada = fecha.AddDays(actividad.Periodo);

                        actividad.Asignada = 1;
                        actividad.EditarActividad(actividad.IdArea, actividad.IdMaquina, actividad.NombreActividad,
                            actividad.RecursoHumano, actividad.Descripcion, actividad.Tiempo, actividad.Periodo,
                            actividad.FechaProgramada, actividad.Asignada);
                        ReasignarActividad(actividad.IdActividad,actividad.IdMaquina,registro.IdTrabajador,actividad.FechaProgramada,
                            Convert.ToDateTime("2000-01-01"),"",0);
                        MessageBox.Show("Actividad revisada exitosamente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DataGridViewRow row = dtgActividades.Rows[e.RowIndex];

                        // Eliminar el registro del DataGridView
                        dtgActividades.Rows.Remove(row);
                        txtNotas.Clear();
                    }
                }
                else
                {
                    //Registro de Actividades
                    registro.Id = (int)dtgActividades.Rows[e.RowIndex].Cells["id"].Value;
                    registro.IdOrden = dtgActividades.Rows[e.RowIndex].Cells["idOrden"].Value.ToString();
                    registro.IdActividad = (int)dtgActividades.Rows[e.RowIndex].Cells["IdActividad"].Value;
                    registro.IdMaquina = (int)dtgActividades.Rows[e.RowIndex].Cells["IdMaquina"].Value;
                    registro.IdTrabajador = (int)dtgActividades.Rows[e.RowIndex].Cells["IdTrabajador"].Value;
                    registro.FechaProgramada = Convert.ToDateTime(dtgActividades.Rows[e.RowIndex].Cells["FechaProgramada"].Value);
                    
                    if (chcFechaSeleccionada.Checked)
                        registro.FechaRealizacion = dtpFechaRealizacion.Value;
                    else
                        registro.FechaRealizacion = fecha.Date;

                    registro.Notas = txtNotas.Text;
                    registro.IdTrabajadorSupervisor = trabajador.IdTrabajador;
                    registro.EditarRegistro(registro.IdOrden, registro.IdActividad, registro.IdMaquina, registro.IdTrabajador,
                        registro.FechaProgramada, (DateTime)registro.FechaRealizacion, registro.Notas, (int)registro.IdTrabajadorSupervisor);
                    //Actividades 
                    actividad.IdActividad = (int)dtgActividades.Rows[e.RowIndex].Cells["idActividad"].Value;
                    actividad.IdArea = (int)dtgActividades.Rows[e.RowIndex].Cells["idArea"].Value;
                    actividad.IdMaquina = (int)dtgActividades.Rows[e.RowIndex].Cells["idMaquina"].Value;
                    actividad.NombreActividad = dtgActividades.Rows[e.RowIndex].Cells["nombreActividad"].Value.ToString();
                    actividad.RecursoHumano = (int)dtgActividades.Rows[e.RowIndex].Cells["recursoHumano"].Value;
                    actividad.Descripcion = dtgActividades.Rows[e.RowIndex].Cells["descripcion"].Value.ToString();
                    actividad.Tiempo = Convert.ToDouble(dtgActividades.Rows[e.RowIndex].Cells["tiempo"].Value);
                    actividad.Periodo = (int)dtgActividades.Rows[e.RowIndex].Cells["periodo"].Value;

                    if (chcFechaSeleccionada.Checked)
                        actividad.FechaProgramada = dtpFechaRealizacion.Value.AddDays(actividad.Periodo);
                    else
                        actividad.FechaProgramada = fecha.AddDays(actividad.Periodo);


                    actividad.Asignada = 0;
                    actividad.EditarActividad(actividad.IdArea, actividad.IdMaquina, actividad.NombreActividad,
                        actividad.RecursoHumano, actividad.Descripcion, actividad.Tiempo, actividad.Periodo,
                        actividad.FechaProgramada, actividad.Asignada);
                    MessageBox.Show("Actividad revisada exitosamente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataGridViewRow row = dtgActividades.Rows[e.RowIndex];

                    // Eliminar el registro del DataGridView
                    dtgActividades.Rows.Remove(row);
                    txtNotas.Clear();
                }
            }
        }
        private void dtpDe_ValueChanged(object sender, EventArgs e)
        {
            fechaDe = true;
        }

        private void dtpA_ValueChanged(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Deseas usar el filtro de fechas en conjunto con trabajador?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult==DialogResult.Yes)
            {
                try
                {
                    this.mifiltroRegistro.RowFilter = "fechaProgramada >= '" + dtpDe.Value.ToString() + "' and fechaProgramada<='" + dtpA.Value.ToString() + "' and idTrabajador=" + cmbTrabajadores.SelectedValue + "";
                }
                catch (Exception) { }
            }
            else
            {
                try
                {
                    mifiltroRegistro.RowFilter = null;
                    filtroTrabajador = false;
                    this.mifiltroRegistro.RowFilter = "fechaProgramada >= '" + dtpDe.Value.ToString() + "' and fechaProgramada<='" + dtpA.Value.ToString() + "'";
                }
                catch (Exception) { }
            }
        }

        private void chcFechaSeleccionada_CheckedChanged(object sender, EventArgs e)
        {
            if(chcFechaSeleccionada.Checked)
            {
                dtpFechaRealizacion.Enabled = true;
            }
            else
                dtpFechaRealizacion.Enabled=false;
        }
    }
}
