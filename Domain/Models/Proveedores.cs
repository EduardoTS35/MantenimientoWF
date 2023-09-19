using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace Domain.Models
{
    
    public class Proveedores
    {
        UserDao userDao = new UserDao();
        public DataTable MostrarProveedores()
        {
            DataTable table = new DataTable();
            table = userDao.MostrarProveedores();
            return table;
        }
    }
}
