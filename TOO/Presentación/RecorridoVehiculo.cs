using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentación
{
    public partial class RecorridoVehiculo : Form
    {
        private List<ModeloDominio.Vehiculo> li;
        BindingSource b;

        public RecorridoVehiculo(List<ModeloDominio.Vehiculo> lista)
        {
            InitializeComponent();
            this.li = lista;
            b = new BindingSource();
            b.DataSource = lista;
            bindingNavigator1.BindingSource = b;
            ModeloDominio.Vehiculo v = b.Current as ModeloDominio.Vehiculo;

            this.numBastidortb.Text = v.NumBastidor;
            this.marcatb.Text = v.Marca;
            this.modelotb.Text = v.Modelo;
            this.potenciatb.Text = v.Potencia.ToString();
            this.preciotb.Text = v.Precio.ToString() + "€";
        }

        private void actualizar()
        {
            ModeloDominio.Vehiculo v = b.Current as ModeloDominio.Vehiculo;

            this.numBastidortb.Text = v.NumBastidor;
            this.marcatb.Text = v.Marca;
            this.modelotb.Text = v.Modelo;
            this.potenciatb.Text = v.Potencia.ToString();
            this.preciotb.Text = v.Precio.ToString() + "€";
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            this.actualizar();
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            this.actualizar();
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            this.actualizar();
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            this.actualizar();
        }
    }
}
