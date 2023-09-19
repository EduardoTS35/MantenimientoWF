using System;
using System.Windows.Forms;
using Common;

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
            if(Common.Usuario.BoolApp == true)
            {
                FrmReporteCorrectivo frm = new FrmReporteCorrectivo(dtpDe.Value, dtpA.Value);
                frm.Show();
                this.Close();
                Usuario.BoolApp = false;
            }
            else
            {
                FrmReporteTrabajadores frm = new FrmReporteTrabajadores(dtpDe.Value, dtpA.Value);
                frm.Show();
                this.Close();
            }
            
        }
    }
}
