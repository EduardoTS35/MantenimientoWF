using DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    internal class Refacciones
    {
        UserDao userDao = new UserDao();
        #region Atributos
        public int idRefaccion { get; set; }
        public string grupo { get; set; }
        public string unidad { get; set; }
        public string maquina { get; set; }
        public string precio { get; set; }
        public string proveedor { get; set; }
        #endregion
        #region Métodos
        public async Task<DataTable> MostrarRefaccionesAsync()
        {
            DataTable table = await Task.FromResult(userDao.MostrarRefacciones());
            return table;
        }
        public async Task<DataTable> MostrarGruposRefacciones()
        {
            DataTable table = await Task.FromResult(userDao.MostrarGruposRefacciones());
            return table;
        }
        public void AgregarRefaccion(string grupo, string descripcion,string unidad, string maquina, int precio, string proveedor)
        {
            userDao.AgregarRefaccion(grupo, descripcion, unidad, maquina, precio, proveedor);
        }
        public void EditarRefaccion(int idRefaccion, string grupo, string descripcion, string unidad, string maquina, int precio, string proveedor)
        {
            userDao.EditarRefaccion(idRefaccion, grupo, descripcion, unidad, maquina, precio, proveedor);
        }
        public void EliminarRefaccion(int idRefaccion)
        {
            userDao.EliminarRefaccion(idRefaccion);
        }
        #endregion
    }
}
