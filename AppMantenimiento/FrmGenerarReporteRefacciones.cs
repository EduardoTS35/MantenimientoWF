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
    public partial class FrmGenerarReporteRefacciones : Form
    {
        int idReporte = 0;
        public FrmGenerarReporteRefacciones(int idReporte)
        {
            InitializeComponent();
            this.idReporte = idReporte;
        }

        private void bttAceptar_Click(object sender, EventArgs e)
        {
            if (idReporte == 1)
            {
                FrmReporteCompras frm = new FrmReporteCompras(dtpDe.Value, dtpA.Value);
                frm.Show();
                this.Close();
            }
        }
    }
}
