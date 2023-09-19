using DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Refacciones
    {
        UserDao userDao = new UserDao();
        #region Atributos
        public int idRefaccion { get; set; }
        public string descripcion { get; set; } 
        public string grupo { get; set; }
        public string unidad { get; set; }
        public string maquina { get; set; }
        public string precio { get; set; }
        public string proveedor { get; set; }
        public int max { get; set; }
        public int min { get; set; }
        #endregion
        #region Métodos
        public async Task<DataTable> MostrarRefaccionesAsync()
        {
            DataTable table = await Task.FromResult(userDao.MostrarRefacciones());
            return table;
        }
        public async Task<DataTable> MostrarTop100Refacciones()
        {
            DataTable table = await Task.FromResult(userDao.MostrarRefaccionesTop100());
            return table;
        }
        public async Task<DataTable> MostrarGruposRefacciones()
        {
            DataTable table = await Task.FromResult(userDao.MostrarGruposRefacciones());
            return table;
        }
        public void AgregarRefaccion(string grupo, string descripcion,string unidad, string maquina, double precio, string proveedor, int max, int min, string moneda)
        {
            userDao.AgregarRefaccion(grupo, descripcion, unidad, maquina, precio, proveedor, max, min, moneda);
        }
        public void EditarRefaccion(int idRefaccion, string grupo, string descripcion, string unidad, string maquina, double precio, string proveedor, int max, int min, string moneda)
        {
            userDao.EditarRefaccion(idRefaccion, grupo, descripcion, unidad, maquina, precio, proveedor, max, min, moneda);
        }
        public void EliminarRefaccion(int idRefaccion)
        {
            userDao.EliminarRefaccion(idRefaccion);
        }
        #endregion
    }
}
