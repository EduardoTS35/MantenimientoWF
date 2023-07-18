using System;
using System.Windows.Forms;

namespace AppMantenimiento
{
    public partial class FrmReporteInfoFecha : Form
    {
        public FrmReporteInfoFecha()
        {
            InitializeComponent();
        }

        private void bttAceptar_Click(object sender, EventArgs e)
        {
            FrmReporteTrabajadores frm = new FrmReporteTrabajadores(dtpDe.Value, dtpA.Value);
            frm.Show();
            this.Close();
        }
    }
}
