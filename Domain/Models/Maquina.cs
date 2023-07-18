using DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Maquina
    {
        UserDao userDao = new UserDao();
        #region Atributos
        public int IdMaquina { get; set; }
        public string IdArea { get; set; }
        public int Descripcion { get; set; }
        public string Modelo { get; set; }
        public int FechaFabricacion { get; set; }
        public string NumeroSerie { get; set; }
        #endregion
        #region Metodos
        public async Task<DataTable> MostrarMaquinariaAsync()
        {
            DataTable table = await Task.FromResult(userDao.MostrarMaquinas());
            return table;
        }
        public async Task<DataTable> MostrarMaquinariaArea(int id)
        {
            DataTable table = await Task.FromResult(userDao.MostrarMaquinasArea(id));
            return table;
        }
        public DataTable MostrarMaquinaria()
        {
            _ = new DataTable();
            DataTable table = userDao.MostrarMaquinas();
            return table;
        }
        public void AgregarMaquina(int idArea, string descripcion, string modelo, int fabricacion, string marca)
        {
            userDao.AgregarMaquina(idArea, descripcion, modelo, fabricacion, marca);
        }
        public void EliminarMaquina(int idMaquina)
        {
            userDao.EliminarMaquina(idMaquina);
        }
        #endregion
    }
}
