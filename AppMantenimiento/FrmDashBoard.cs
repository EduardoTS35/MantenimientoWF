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
        private Form activeForm = null;
        public FrmDashBoard()
        {
            InitializeComponent();
            openChildForm(new FrmTablas());
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

        private void reporteGeneralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReporteInfo frm= new FrmReporteInfo();
            frm.ShowDialog();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCreadorConsulta frm = new FrmCreadorConsulta();
            frm.ShowDialog();
        }

        private void reporteTrabajadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReporteInfoFecha frm = new FrmReporteInfoFecha();
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
    }
}
