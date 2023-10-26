using DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class ListadoEstados
    {
        UserDao userDao = new UserDao();
        public DataTable MostrarListadoEstados()
        {
            DataTable table = userDao.MostrarListadoEstados();
            return table;
        }
    }
}
