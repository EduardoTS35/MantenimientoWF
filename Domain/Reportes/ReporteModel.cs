using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Reportes
{
    public class ReporteModel
    {
        #region Actividades
        public int IdActividad { get; set; }
        public int IdArea { get; set; }
        public int IdMaquina { get; set; }
        public string NombreActividad { get; set; }
        public int RecursoHumano { get; set; }
        public string Descripcion { get; set; }
        public double Tiempo { get; set; }
        public int Periodo { get; set; }
        public DateTime FechaProgramada { get; set; }
        public int Asignada { get; set; }
        #endregion
        #region RegistroActividades
        public int IdRegistroActividades { get; set; }
        public string IdOrden { get; set; }
        public int IdActividadRegistroActividades { get; set; }
        public int IdMaquinaRegistroActividades { get; set; }
        public int IdTrabajadorRegistroActividades { get; set; }
        public DateTime FechaProgramadaRegistroActividades { get; set; }
        public DateTime? FechaRealizacion { get; set; }
        public string Notas { get; set; }
        public int? IdTrabajadorSupervisor { get; set; }
        #endregion
        #region Correctivos
        public int IdCorrectivo { get; set; }
        public int IdMaquinaCorrectivo { get; set; }
        public string DescMaquina { get; set; }
        public int IdTrabajadorCorrectivo { get; set; }
        public double TiempoParo { get; set; }
        public string DescripcionCorrectivo { get; set; }
        public DateTime Fecha { get; set; }
        #endregion
        #region Listado Correctivo
        public int IdActividadCorrectiva { get; set; }
        public int IdTrabajadorListadoCorrectivo { get; set; }
        public string DescripcionListadoCorrectivo { get; set; }
        public int HorasTrabajadas { get; set; }
        #endregion
        #region Trabajadores
        public int IdTrabajador { get; set; }
        public int IdAreaTrabajador { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        #endregion
    }
}
