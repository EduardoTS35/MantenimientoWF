using DataAccess;
using System;
using System.Data;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Actividad
    {
        UserDao userDao = new UserDao();
        #region Atributos
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

        #region Métodos
        public async Task<DataTable> MostrarActividadesAsync()
        {
            DataTable table = await Task.FromResult(userDao.MostrarActividades());
            return table;
        }
        public bool AgregarActividad(int idArea, int idMaquina, string nombreActividad, int recursoHumano,
            string descripcion, double tiempo, int periodo, DateTime fechaProgramada, int asignada)
        {
            userDao.AgregarActividad(idArea, idMaquina, nombreActividad, recursoHumano,
                descripcion, tiempo, periodo, fechaProgramada, asignada);
            return true;
        }
        public bool EditarActividad(int idArea, int idMaquina, string nombreActividad, int recursoHumano,
            string descripcion, double tiempo, int periodo, DateTime fechaProgramada, int asignada)
        {
            userDao.EditarActividad(this.IdActividad, idArea, idMaquina, nombreActividad, recursoHumano,
                descripcion, tiempo, periodo, fechaProgramada, asignada);
            return true;
        }
        public bool EliminarActividad(int id)
        {
            userDao.EliminarActividad(id);
            return true;
        }
        #endregion
    }
}
