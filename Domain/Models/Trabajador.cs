using DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Trabajador
    {
        UserDao userDao = new UserDao();
        #region Atributos
        public int IdTrabajador { get; set; }
        public int IdArea { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Puesto { get; set; }
        public string Usuario { get; set; }
        public string Pass { get; set; }
        public int IdRol { get; set; }
        #endregion
        #region Metodos
        public async Task<DataTable> MostrarTrabajadores()
        {
            DataTable table = await Task.FromResult(userDao.MostrarTrabajadores());
            return table;
        }
        public bool Login(string user, string pass)
        {
            return userDao.Login(user, pass);
        }
        #endregion
    }
}
