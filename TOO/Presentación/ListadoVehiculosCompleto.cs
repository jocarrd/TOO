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
    public partial class ListadoVehiculosCompleto : Form
    {
        private NegocioAdmin neg;
        public ListadoVehiculosCompleto(NegocioAdmin neg)
        {
            InitializeComponent();
            this.neg = neg;
            List<Vehiculo> lista = neg.listarVehiculos();
            int n;
            foreach (Vehiculo c in lista)
            {
                n = dataGridView1.Rows.Add();

                dataGridView1.Rows[n].Cells[0].Value = c.getNumBastidor();
                dataGridView1.Rows[n].Cells[1].Value = c.getMarca();
                dataGridView1.Rows[n].Cells[2].Value = c.getModelo();
                dataGridView1.Rows[n].Cells[3].Value = c.getPotencia().ToString();
                dataGridView1.Rows[n].Cells[4].Value = c.getPrecio().ToString();
                dataGridView1.Rows[n].Cells[5].Value = "";
            }
        }
    }
}
