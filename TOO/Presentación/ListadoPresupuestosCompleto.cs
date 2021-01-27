using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaNegocio;
using ModeloDominio;

namespace Presentación
{
    public partial class ListadoPresupuestosCompleto : Form
    {
        public ListadoPresupuestosCompleto(List<Presupuesto> presupuestos)
        {
            InitializeComponent();
            List<Presupuesto> lista = presupuestos;
            int n;
            foreach (Presupuesto c in lista)
            {
                n = dataGridView1.Rows.Add();

                dataGridView1.Rows[n].Cells[0].Value = c.Id_presupuesto;
                dataGridView1.Rows[n].Cells[1].Value = c.Cantidad;
                dataGridView1.Rows[n].Cells[2].Value = c.Fecha_Realizacion.ToString();
                dataGridView1.Rows[n].Cells[3].Value = c.Estado;
                dataGridView1.Rows[n].Cells[4].Value = c.Cliente.Dni;
            }
        }
    }
}
