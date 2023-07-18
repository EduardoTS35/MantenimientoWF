using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppMantenimiento
{
    public partial class FrmCreadorConsulta : Form
    {
        List<string> columnasPreventivos = new List<string>() { "reg.ID", "reg.IdActividad", "reg.IdMaquina", "reg.IdTrabajador", "reg.FechaProgramada", "reg.FechaRealizacion" };
        List<string> columnasCorrectivos = new List<string>() { "reg.ID", "reg.IdMaquina", "reg.IdTrabajador", "reg.Descripcion", "reg.TiempoParo", "reg.Fecha" };
        List<string> columnasActividad = new List<string>() { "act.IdActividad", "act.NombreActividad", "act.FechaProgramada", "act.Asignada" };
        List<string> columnasMaquina = new List<string>() { "maq.IdArea", "maq.Descripcion", "area.Descripcion" };
        List<string> columnasTrabajador = new List<string>() { "trb.IdTrabajador", "trb.Nombre", "trb.Apellido" };
        List<string> listaChcTablasP = new List<string>() { "Actividades", "Maquinaria - Areas", "Trabajadores"};
        List<string> listaChcTablasC = new List<string>() { "Maquinaria - Areas", "Trabajadores" };
        string Consulta;
        string IdRegistroActividades = "reg";
        string IdRegistroCorrectivo = "reg";
        string IdActividades = "act";
        string IdMaquinas = "maq";
        string IdTrabajadores = "trb";
        string IdAreas = "area";
        public FrmCreadorConsulta()
        {
            InitializeComponent();

        }
        private void AgregarItemsChcTablas()
        {
            chcTablas.Items.Clear();
            if (cmbTablaPrincipal.Text == "Preventivo")
                foreach (var element in listaChcTablasP)
                {
                    chcTablas.Items.Add(element);
                }
            else
                foreach (var element in listaChcTablasC)
                {
                    chcTablas.Items.Add(element);
                }
        }
        private List<string> columnasPreventivosOriginal;
        private List<string> columnasCorrectivosOriginal;

        private void CargarItemsCmb()
        {
            DataGridViewComboBoxColumn column = (DataGridViewComboBoxColumn)dataGridView1.Columns["columna"];

            column.DataSource = null; // Limpiar los datos existentes en la columna

            // Guardar copias originales de las columnas
            columnasPreventivosOriginal = new List<string>(columnasPreventivos);
            columnasCorrectivosOriginal = new List<string>(columnasCorrectivos);

            if (cmbTablaPrincipal.Text == "Preventivo")
            {
                column.DataSource = columnasPreventivos;
                cmbTablaPrincipal.ValueMember = "Preventivo";

                chcTablas.ItemCheck += (sender, e) =>
                {
                    if (e.NewValue == CheckState.Checked)
                    {
                        if (chcTablas.Items[e.Index].ToString() == "Actividades")
                            columnasPreventivos.AddRange(columnasActividad.Except(columnasPreventivos));
                        if (chcTablas.Items[e.Index].ToString() == "Maquinaria - Areas")
                            columnasPreventivos.AddRange(columnasMaquina.Except(columnasPreventivos));
                        if (chcTablas.Items[e.Index].ToString() == "Trabajadores")
                            columnasPreventivos.AddRange(columnasTrabajador.Except(columnasPreventivos));
                    }
                    else if (e.NewValue == CheckState.Unchecked)
                    {
                        if (chcTablas.Items[e.Index].ToString() == "Actividades")
                            columnasPreventivos.RemoveAll(columnasActividad.Contains);
                        if (chcTablas.Items[e.Index].ToString() == "Maquinaria - Areas")
                            columnasPreventivos.RemoveAll(columnasMaquina.Contains);
                        if (chcTablas.Items[e.Index].ToString() == "Trabajadores")
                            columnasPreventivos.RemoveAll(columnasTrabajador.Contains);
                    }

                    column.DataSource = columnasPreventivos.Distinct().ToList();
                };
            }
            else if (cmbTablaPrincipal.Text == "Correctivo")
            {
                column.DataSource = columnasCorrectivos;
                cmbTablaPrincipal.ValueMember = "Correctivo";

                chcTablas.ItemCheck += (sender, e) =>
                {
                    if (e.NewValue == CheckState.Checked)
                    {
                        if (chcTablas.Items[e.Index].ToString() == "Maquinaria - Areas")
                            columnasCorrectivos.AddRange(columnasMaquina.Except(columnasCorrectivos));
                        if (chcTablas.Items[e.Index].ToString() == "Trabajadores")
                            columnasCorrectivos.AddRange(columnasTrabajador.Except(columnasCorrectivos));
                    }
                    else if (e.NewValue == CheckState.Unchecked)
                    {
                        if (chcTablas.Items[e.Index].ToString() == "Maquinaria - Areas")
                            columnasCorrectivos.RemoveAll(columnasMaquina.Contains);
                        if (chcTablas.Items[e.Index].ToString() == "Trabajadores")
                            columnasCorrectivos.RemoveAll(columnasTrabajador.Contains);
                    }

                    column.DataSource = columnasCorrectivos.Distinct().ToList();
                };
            }
        }





        private void AgregarRelacionesTablas()
        {
            if (cmbTablaPrincipal.Text == "Preventivo")
            {
                if (chcTablas.CheckedItems.Contains("Actividades"))
                    Consulta += "INNER JOIN actividades act ON " + IdRegistroActividades + ".idActividad = act.idActividad ";
                if (chcTablas.CheckedItems.Contains("Maquinaria - Areas"))
                {
                    Consulta += "INNER JOIN maquinaria " + IdMaquinas + " ON " + IdRegistroActividades + ".idMaquina = " + IdMaquinas + ".idMaquina ";
                    Consulta += "INNER JOIN area " + IdAreas + " ON " + IdMaquinas + ".idArea = " + IdAreas + ".idArea ";
                }               
                if (chcTablas.CheckedItems.Contains("Trabajadores"))
                    Consulta += "INNER JOIN trabajadores "+IdTrabajadores+" ON " + IdRegistroActividades + ".idTrabajador = "+IdTrabajadores+ ".idTrabajador ";
            }
            else if (cmbTablaPrincipal.Text == "Correctivo")
            {
                if (chcTablas.CheckedItems.Contains("Maquinaria - Areas"))
                {
                    Consulta += "INNER JOIN maquinaria " + IdMaquinas + " ON " + IdRegistroActividades + ".idMaquina = " + IdMaquinas + ".idMaquina ";
                    Consulta += "INNER JOIN area " + IdAreas + " ON " + IdMaquinas + ".idArea = " + IdAreas + ".idArea ";
                }
                if (chcTablas.CheckedItems.Contains("Trabajadores"))
                    Consulta += "INNER JOIN trabajadores " + IdTrabajadores + " ON " + IdRegistroActividades + ".idTrabajador = " + IdTrabajadores + ".idTrabajador ";
            }
        }

        private void GenerarConsulta()
        {
            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["operador"].Value != null)
                    {
                        if (row.Cells["conector"].Value != null)
                        {
                            var column = row.Cells["columna"].Value.ToString();
                            var operador = row.Cells["Operador"].Value.ToString();
                            var valor = row.Cells["valor"].Value.ToString();
                            var conector = row.Cells["conector"].Value.ToString();

                            string lineaConsulta = " " + column + " " + operador + " '" + valor + "' " + conector;
                            Consulta += lineaConsulta;
                        }
                        else if (row.Cells["conector"].Value == null)
                        {
                            var column = row.Cells["columna"].Value.ToString();
                            var operador = row.Cells["Operador"].Value.ToString();
                            var valor = row.Cells["valor"].Value.ToString();
                            string lineaConsulta = " " + column + " " + operador + " '" + valor + "' ";
                            Consulta += lineaConsulta;
                        }

                    }
                }

            }
            catch (Exception)
            {
            }

        }

        private void cmbTablaPrincipal_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarItemsCmb();
            AgregarItemsChcTablas();
        }
        private void chcTablas_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarItemsCmb();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(cmbTablaPrincipal.Text=="Preventivo")
                Consulta = "SELECT *FROM registro_actividades reg ";
            if (cmbTablaPrincipal.Text == "Correctivo")
                Consulta = " SELECT *FROM registro_mantenimiento_correctivo reg ";
            AgregarRelacionesTablas();
            Consulta += " WHERE ";
            GenerarConsulta();
            textBox1.Text = Consulta;
            
        }
    }
}
