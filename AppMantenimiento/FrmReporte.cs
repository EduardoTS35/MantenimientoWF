using Microsoft.VisualBasic.PowerPacks.Printing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace AppMantenimiento
{
    public partial class FrmReporte : Form
    {
        private Form activeForm = null;
        public FrmReporte(DateTime fechaInicio, DateTime fechaFin,int[] idArea, string descArea)
        {
            InitializeComponent();
            lblTitulo.Text = "Análisis del mantenimiento área: " + descArea;
            lblPeriodo.Text = "De: "+fechaInicio+" a "+fechaFin+"";
            openChildForm(new FrmReporteKevlar1(fechaInicio,fechaFin,idArea));

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
            pnlContainer.Controls.Add(childForm);
            pnlContainer.Tag = childForm;
            childForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            printDocument1.DefaultPageSettings.Landscape = true;
            printPreviewDialog1.ShowDialog();
        }

        private void Imprimir(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(pnlContainer.Width, pnlContainer.Height);
            pnlContainer.DrawToBitmap(bm, new Rectangle(0, 0, pnlContainer.Width, pnlContainer.Height));
            e.Graphics.DrawImage(bm, e.MarginBounds.Left, e.MarginBounds.Top);
        }
    }
}
