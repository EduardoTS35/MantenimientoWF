using Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppMantenimiento
{
    public partial class FrmCatalogoMaquinaria : Form
    {
        Maquina maquina = new Maquina();
        bool seleccion=false;
        public FrmCatalogoMaquinaria()
        {
            InitializeComponent();
        }
        #region Métodos
        private void MostrarMaquinaria()
        {
            dtgMaquinaria.DataSource = maquina.MostrarMaquinariaAsync();
        }
        private void GuardarMaquinaria()
        {
            
        }
        #endregion
    }
}
