using DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class SolicitudRefaccion
    {
        UserDao userDao = new UserDao();
        #region Atributos
        int id {  get; set; }
        DateTime fecha { get; set; }
        int cantidad { get; set; }
        int idRefaccion { get; set; }
        int idMaquina { get; set; }
        string descUso { get; set; }
        int idTrabajadorSolicitante { get; set; }
        int idTrabajadorAutorizante { get; set; }
        string observaciones { get; set; }

        #endregion
        #region Métodos
        public async Task<DataTable> MostrarSolicitudesAsync()
        {
            DataTable table = await Task.FromResult(userDao.MostrarSolicitudesAsync());
            return table;
        }
        public async Task<DataTable> MostrarTop100Solicitudes()
        {
            DataTable table = await Task.FromResult(userDao.MostrarTop100Solicitudes());
            return table;
        }
        public DataTable StockRefaccion(int idRefaccion)
        {
            DataTable table = userDao.StockRefaccion(idRefaccion);
            return table;
        }
        public void AgregarSolicitud(DateTime fecha, int cantidad, int idRefaccion, int idMaquina, string descUso, int idTrabajadorSolicitante, int idTrabajadorAutorizante, string observaciones)
        {
            userDao.AgregarSolicitud(fecha, cantidad, idRefaccion, idMaquina, descUso, idTrabajadorSolicitante, idTrabajadorAutorizante, observaciones);
        }
        public void EditarSolicitud(int id,DateTime fecha, int cantidad, int idRefaccion, int idMaquina, string descUso, int idTrabajadorSolicitante, int idTrabajadorAutorizante, string observaciones)
        {
            userDao.EditarSolicitud(id, fecha, cantidad, idRefaccion, idMaquina, descUso, idTrabajadorSolicitante, idTrabajadorAutorizante, observaciones);
        }
        public void AprobarSolicitud(int id, int idTrabajadorAutorizante)
        {
            userDao.AprobarSolicitud(id, idTrabajadorAutorizante);
        }
        public void EliminarSolicitud(int id)
        {
            userDao.EliminarSolicitud(id);
        }
        #endregion
    }
}
