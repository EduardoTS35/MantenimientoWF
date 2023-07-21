using DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    internal class AlmacenRefacciones
    {
        UserDao userDao = new UserDao();
        #region Atributos
        public int id { get; set; }
        public int idRefaccion { get; set; }
        public int idStatus { get; set; }
        public int cantidad { get; set; }
        public DateTime fechaMovimiento { get; set; }
        #endregion
        #region Métodos
        public async Task<DataTable> MostrarAlmacenRefaccionesAsync()
        {
            DataTable table = await Task.FromResult(userDao.MostrarAlmacenRefacciones());
            return table;
        }
        public void AgregarMovimientoRefaccion(int idRefaccion, int idStatus, int cantidad, DateTime fechaMovimiento)
        {
            userDao.AgregarMovimientoRefaccion(idRefaccion, idStatus, cantidad, fechaMovimiento);
        }
        public void EditarMovimientoRefaccion(int id, int idRefaccion, int idStatus, int cantidad, DateTime fechaMovimiento)
        {
            userDao.EditarMovimientoRefaccion(id, idRefaccion, idStatus, cantidad, fechaMovimiento);
        }
        public void EliminarMovimientoRefaccion(int id)
        {
            userDao.EliminarMovimientoRefaccion(id);
        }
        #endregion
    }
}
