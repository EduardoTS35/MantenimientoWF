﻿using DataAccess;
using System;
using System.Data;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class RegistroActividad
    {
        UserDao userDao = new UserDao();
        #region Atributos
        public int Id { get; set; }
        public string IdOrden { get; set; }
        public int IdActividad { get; set; }
        public int IdMaquina { get; set; }
        public int IdTrabajador { get; set; }
        public DateTime FechaProgramada { get; set; }
        public DateTime? FechaRealizacion { get; set; }
        public string Notas { get; set; }
        public int? IdTrabajadorSupervisor { get; set; }
        #endregion
        #region Métodos

        public async Task<DataTable> MostrarRegistroAsync()
        {
            DataTable table = await Task.FromResult(userDao.MostrarRegistroActividades());
            return table;
        }
        public DataTable MostrarRegistro()
        {
            _ = new DataTable();
            DataTable table = userDao.MostrarRegistroActividades();
            return table;
        }
        public void AgregarRegistro(string idOrden, int idActividad, int idMaquina, int idTrabajador,
            DateTime fechaProgramada, DateTime? fechaRealizacion, string notas, int idTrabajadorSupervisor)
        {
            userDao.AgregarRegistroActividad(idOrden, idActividad, idMaquina, idTrabajador,
                fechaProgramada, (DateTime)fechaRealizacion, notas, idTrabajadorSupervisor);
        }
        public void EditarRegistro(string idOrden, int idActividad, int idMaquina, int idTrabajador,
            DateTime fechaProgramada, DateTime fechaRealizacion, string notas, int idTrabajadorSupervisor)
        {
            userDao.EditarRegistroActividad(this.Id, idOrden, idActividad, idMaquina, idTrabajador,
                fechaProgramada, fechaRealizacion, notas, idTrabajadorSupervisor);
        }
        public void EliminarRegistro(int id)
        {
            userDao.EliminarRegistroActividad(id);
        }
        #region Indicadores
        public DataTable MostrarActividadesRealizadas(DateTime inicio, DateTime fin)
        {
            _ = new DataTable();
            DataTable table = userDao.MostrarActividadesRealizadas(inicio, fin);
            return table;
        }
        public DataTable RegistroPreventivoDashboard(DateTime inicio, DateTime fin)
        {
            _ = new DataTable();
            DataTable table = userDao.RegistroPreventivoDashboard(inicio, fin);
            return table;
        }
        #endregion
        #endregion
    }
}
