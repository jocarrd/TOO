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
    public partial class RecorridoPresupuesto : Form
    {

        private List<ModeloDominio.Presupuesto> li;
        BindingSource b;

        public RecorridoPresupuesto(List<ModeloDominio.Presupuesto> lista)
        {
            InitializeComponent();
            this.li = lista;
            b = new BindingSource();
            b.DataSource = lista;
            bindingNavigator1.BindingSource = b;
            ModeloDominio.Presupuesto p = b.Current as ModeloDominio.Presupuesto;

            this.idPresupuestotb.Text = p.Id_presupuesto;
            this.cantidadtb.Text = p.Cantidad.ToString();
            this.fechaRealizaciontb.Text = p.Fecha_Realizacion.ToString();
            this.estadotb.Text = p.Estado.ToString();
            this.clientetb.Text = p.Cliente.Dni;
        }

        ///<summary>
        ///Actualiza el contendo de los TextBoxes con los datos del Presupuesto al que referencia
        ///</summary>
        private void actualizar()
        {
            ModeloDominio.Presupuesto p = b.Current as ModeloDominio.Presupuesto;

            this.idPresupuestotb.Text = p.Id_presupuesto;
            this.cantidadtb.Text = p.Cantidad.ToString();
            this.fechaRealizaciontb.Text = p.Fecha_Realizacion.ToString();
            this.estadotb.Text = p.Estado.ToString();
            this.clientetb.Text = p.Cliente.Dni;
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            this.actualizar();
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            this.actualizar();
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            this.actualizar();
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            this.actualizar();
        }
    }
}
