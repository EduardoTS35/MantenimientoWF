using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ConnectionToSql
    {
        private readonly string connectionString;
        public ConnectionToSql()
        {
            connectionString = "Data Source=SQL8003.site4now.net;Initial Catalog=db_a92aca_mantenimiento;User Id=db_a92aca_mantenimiento_admin;Password=Arzafil01";
            ;
        }
        //"Data Source = (local); Initial Catalog = AlmacenesArzafil; Integrated Security = True"
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
