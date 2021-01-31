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
    public partial class RecorridoCliente : Form
    {
        private List<ModeloDominio.Cliente> li;
        BindingSource b;

        public RecorridoCliente(List<ModeloDominio.Cliente> lista)
        {
            InitializeComponent();
            this.li = lista;
            b = new BindingSource();
            b.DataSource = lista;
            bindingNavigator1.BindingSource = b;
            ModeloDominio.Cliente c = b.Current as ModeloDominio.Cliente;

            dnitb.Text = c.Dni;
            string[] subs = c.Nombre.Split(' ');
            if (subs.Length>1)
            {
                this.nombretb.Text = subs[0];
                this.apellidostb.Text = subs[1];
            }
            else
            {
                this.nombretb.Text = subs[0];
            }
            if (c.PresupuestoList.Count>0)
            {
                this.importetb.Text = c.PresupuestoList[0].Cantidad.ToString()+"€";
            }
            
        }

        private void actualizar()
        {
            ModeloDominio.Cliente c = b.Current as ModeloDominio.Cliente;

            dnitb.Text = c.Dni;
            string[] subs = c.Nombre.Split(' ');
            if (subs.Length > 1)
            {
                this.nombretb.Text = subs[0];
                this.nombretb.Text = subs[1];
            }
            else
            {
                this.nombretb.Text = subs[0];
            }
            if (c.PresupuestoList.Count > 0)
            {
                this.importetb.Text = c.PresupuestoList[0].Cantidad.ToString() + "€";
            }
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
