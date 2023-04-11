using DataAccess;
using System.Data;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Area
    {
        UserDao userDao = new UserDao();
        #region Atributos
        public int IdArea { get; set; }
        public string Descripcion { get; set; }
        #endregion
        #region Metodos
        public async Task<DataTable> MostrarAreasAsync()
        {
            DataTable table = await Task.FromResult(userDao.MostrarAreas());
            return table;
        }
        #endregion
    }
}
