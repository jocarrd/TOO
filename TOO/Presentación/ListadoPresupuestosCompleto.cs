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
        private NegocioAdmin neg;
        public ListadoPresupuestosCompleto(NegocioAdmin neg)
        {
            InitializeComponent();
            this.neg = neg;
            List<Presupuesto> lista = neg.obtenerTodosPresupuestos();
            int n;
            foreach (Presupuesto c in lista)
            {
                n = dataGridView1.Rows.Add();

                dataGridView1.Rows[n].Cells[0].Value = c.getId_presupuesto();
                dataGridView1.Rows[n].Cells[1].Value = c.getCantidad();
                dataGridView1.Rows[n].Cells[2].Value = c.getFecha_Realizacion().ToString();
                dataGridView1.Rows[n].Cells[3].Value = c.getEstado();
                dataGridView1.Rows[n].Cells[4].Value = c.getCliente().getDni();
            }
        }
    }
}
