using DataAccess;
using System.Data;

namespace Domain.Models
{
    public class ListadoTrabajadoresCorrectivo
    {
        UserDao userDao = new UserDao();
        #region Atributos
        public int Id { get; set; }
        public int IdActividadCorrectiva { get; set; }
        public int IdTrabajador { get; set; }
        public string Descripcion { get; set; }
        public int HorasTrabajadas { get; set; }
        #endregion
        #region Métodos
        public DataTable MostrarListado()
        {
            _ = new DataTable();
            DataTable table = userDao.MostrarListado();
            return table;
        }
        public void AgregarListado(int idActividadCorrectiva, int idTrabajador, string descripcion, double horasTrabajadas)
        {
            userDao.AgregarListado(idActividadCorrectiva, idTrabajador, descripcion, horasTrabajadas);
        }
        public void EditarListadoCorrectivo(int idActividadCorrectiva, int idTrabajador, string descripcion, int horasTrabajadas)
        {
            userDao.EditarListadoCorrectivo(this.Id, idActividadCorrectiva, idTrabajador, descripcion, horasTrabajadas);
        }
        public void EliminarListadoCorrectivo(int id)
        {
            userDao.EliminarListadoCorrectivo(id);
        }
        #endregion
    }
}
