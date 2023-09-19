using DataAccess;
using System;
using System.Data;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class RegistroCorrectivo
    {
        UserDao userDao = new UserDao();
        #region Atributos
        public int Id { get; set; }
        public int IdMaquina { get; set; }
        public string DescMaquina { get; set; }
        public int IdTrabajador { get; set; }
        public double TiempoParo { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        #endregion
        #region Métodos
        public async Task<DataTable> MostrarCorrectivoAsync()
        {
            DataTable table = await Task.FromResult(userDao.MostrarCorrectivos());
            return table;
        }
        public DataTable MostrarCorrectivo()
        {
            _ = new DataTable();
            DataTable table = userDao.MostrarCorrectivos();
            return table;
        }
        public void AgregarCorrectivo(int idMaquina, int idTrabajador, double tiempoParo,
                string descripcion, DateTime fecha)
        {
            userDao.AgregarCorrectivo(idMaquina, idTrabajador, tiempoParo, descripcion, fecha);
        }
        public void EditarCorrectivo(int idMaquina, int idTrabajador, double tiempoParo,
                string descripcion, DateTime fecha)
        {
            userDao.EditarCorrectivo(this.Id, idMaquina, idTrabajador, tiempoParo, descripcion, fecha);
        }
        public void EliminarCorrectivo(int id)
        {
            userDao.EliminarCorrectivo(id);
        }
        #region Indicadores
        public DataTable RegistroCorrectivoDashboard(DateTime fechaInicio, DateTime fechaFin)
        {
            _ = new DataTable();
            DataTable table = userDao.RegistroCorrectivoDashboard(fechaInicio,fechaFin);
            return table;
        }
        public float[] CorrectivoVsPreventivoDashboard(DateTime fechaInicio, DateTime fechaFin)
        {
            _ = new float[2];
            float[] array = userDao.CorrectivoVsPreventivoDashboard(fechaInicio, fechaFin);
            return array;
        }
        public DataTable TiempoParoMaquinaDashboard(DateTime fechaInicio, DateTime fechaFin)
        {
            _ = new DataTable();
            DataTable table = userDao.TiempoParoMaquinaDashboard(fechaInicio, fechaFin);
            return table;
        }
        public float[] CorrectivoVsPreventivoArea(DateTime fechaInicio, DateTime fechaFin, int[] idArea)
        {
            _ = new float[2];
            float[] array = userDao.CorrectivoVsPreventivoArea(fechaInicio, fechaFin, idArea);
            return array;
        }
        public DataTable ObtenerCorrectivoAreaFecha(DateTime fechaInicio, DateTime fechaFin, int[] idArea)
        {
            _ = new DataTable();
            DataTable table = userDao.ObtenerCorrectivoAreaFecha(fechaInicio, fechaFin, idArea);
            return table;
        }

        public DataTable CorrectivosFecha(DateTime fechaInicio, DateTime fechaFin)
        {
            _ = new DataTable();
            DataTable table = userDao.ObtenerCorrectivosFecha(fechaInicio, fechaFin);
            return table;
        }
        public DataTable ReporteCorrectivo(DateTime fechaInicio, DateTime fechaFin)
        {
            _ = new DataTable();
            DataTable table = userDao.ReporteCorrectivo(fechaInicio, fechaFin);
            return table;
        }
        #endregion
        #endregion
    }
}
