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
        public ListadoVehiculosCompleto(List<Vehiculo> vehiculos)
        {
            InitializeComponent();
            List<Vehiculo> lista = vehiculos;
            int n;
            foreach (Vehiculo c in lista)
            {
                n = dataGridView1.Rows.Add();

                dataGridView1.Rows[n].Cells[0].Value = c.NumBastidor;
                dataGridView1.Rows[n].Cells[1].Value = c.Marca;
                dataGridView1.Rows[n].Cells[2].Value = c.Modelo;
                dataGridView1.Rows[n].Cells[3].Value = c.Potencia.ToString();
                dataGridView1.Rows[n].Cells[4].Value = c.Precio.ToString();
                double pvp = c.Precio + (c.Precio * c.Iva);
                dataGridView1.Rows[n].Cells[5].Value = pvp.ToString();
            }
        }
    }
}
