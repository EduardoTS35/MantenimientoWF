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
    public partial class FrmCatalogoMaquinas : Form
    {
        Maquina maquina= new Maquina();
        public FrmCatalogoMaquinas()
        {
            InitializeComponent();
            dataGridView1.DataSource = maquina.MostrarMaquinaria();
            
        }
    }
}
