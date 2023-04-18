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
        #endregion
    }
}
