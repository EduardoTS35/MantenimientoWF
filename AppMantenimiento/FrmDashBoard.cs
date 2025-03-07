using Common;
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
    public partial class FrmDashBoard : Form
    {
        Usuario usuario = new Usuario();
        private Form activeForm = null;
        public FrmDashBoard()
        {
            InitializeComponent();
            openChildForm(new FrmTablas());
            Restricciones();
        }
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)

                activeForm.Close();
            activeForm = childForm;
            childForm.Dock = DockStyle.Fill;
            childForm.TopLevel = false;
            childForm.TopMost = true;
            childForm.FormBorderStyle = FormBorderStyle.None;
            pnlContenedor.Controls.Add(childForm);
            pnlContenedor.Tag = childForm;
            childForm.Show();
        }

        private void Restricciones()
        {
            if (Usuario.Puesto == "Gerente")
            {
                actividadesToolStripMenuItem.Visible = false;
                mantenimientoCorrectivoToolStripMenuItem.Visible = false;
                refaccionesToolStripMenuItem.Visible = false;
                maquinariaToolStripMenuItem.Visible = false;
                refaccionesToolStripMenuItem1.Visible = false;
                comprasToolStripMenuItem.Visible = false;
            }
        }

        private void asignaciónDeActividadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmAsignacionActividad());
        }

        private void revisiónDeActividadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmRevision());
        }

        private void agregarActividadCorrectivaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmMantenimientoCorrectivo());
        }

        private void cátalogoActividadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmCatalogoActividades());
        }

        private void bttHome_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmTablas());
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCreadorConsulta frm = new FrmCreadorConsulta();
            frm.ShowDialog();
        }

        private void almacénToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmAlmacenRefacciones());
        }

        private void catálogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmCatalogoRefacciones());
        }

        private void catálogoDeMaquinariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmCatalogoMaquinaria());
        }

        private void solicitarRefacciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Usuario.IdRol == 1 || Usuario.IdRol == 4 || Usuario.IdRol == 5)
            {
                openChildForm(new FrmSolicitudRefaccionAlmacen());
            }
            else
            {
                FrmSeleccionRefaccion frm = new FrmSeleccionRefaccion();
                frm.ShowDialog();
            }
            
        }

        private void reporteGeneralToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmReporteInfo frm = new FrmReporteInfo();
            frm.ShowDialog();
        }

        private void reporteTabajadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReporteInfoFecha frm = new FrmReporteInfoFecha();
            frm.ShowDialog();
        }

        private void autorizarCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmAutorizacionCompra());
        }

        private void reporteCorrectivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Common.Usuario.BoolApp = true;
            FrmReporteInfoFecha frm = new FrmReporteInfoFecha();
            frm.ShowDialog();
        }

        private void comprasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmGenerarReporteRefacciones frm = new FrmGenerarReporteRefacciones(1);
            frm.ShowDialog();
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmDashBoardAlmacen());
        }

        private void historialDeActividadesRealizadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmDetalleActividadesProgramadas());
        }
    }
}
