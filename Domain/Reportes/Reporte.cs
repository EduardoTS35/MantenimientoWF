using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Reportes
{
    public class Reporte
    {
        public DateTime reportDate { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public List<ReporteModel> reporteModels { get; set; }

        #region Reporte General
        #endregion
    }
}
