using DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class AlmacenRefacciones
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
        public async Task<DataTable> MostrarAlmacenRefacciones(int idStatus)
        {
            DataTable table = await Task.FromResult(userDao.MostrarAlmacenRefacciones(idStatus));
            return table;
        }
        public async Task<DataTable> MostrarAlmacenRefaccionesAsync(int idStatus, int revisado)
        {
            DataTable table = await Task.FromResult(userDao.MostrarAlmacenRefacciones(idStatus, revisado));
            return table;
        }
        public void AgregarMovimientoRefaccion(int idRefaccion, int idStatus, int cantidad, DateTime fechaMovimiento, string proveedor, int idSolicitud, string numFactura, double precio, int revision)
        {
            userDao.AgregarMovimientoRefaccion(idRefaccion, idStatus, cantidad, fechaMovimiento, proveedor, idSolicitud, numFactura,precio, revision);
        }
        public void EditarMovimientoRefaccion(int id, int idRefaccion, int idStatus, int cantidad, DateTime fechaMovimiento, int revisado)
        {
            userDao.EditarMovimientoRefaccion(id, idRefaccion, idStatus, cantidad, fechaMovimiento, revisado);
        }
        public void EliminarMovimientoRefaccion(int id)
        {
            userDao.EliminarMovimientoRefaccion(id);
        }
        #region Dashboard
        public DataTable MostrarHistorial(DateTime fechaInicio, DateTime fechaFin, int idStatus)
        {
            DataTable table = userDao.MostrarHistorial(fechaInicio, fechaFin,idStatus);
            return table;
        }
        #endregion
        #region Reporte Compras
        public DataTable MostrarMovimientosFecha(DateTime fechaInicio, DateTime fechaFin)
        {
            DataTable table = userDao.MostrarMovimientosFecha(fechaInicio, fechaFin);
            return table;
        }
        #endregion
        #endregion
    }
}
