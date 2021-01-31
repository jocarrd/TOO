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

        public RecorridoCliente(List<ModeloDominio.Cliente> li)
        {
            InitializeComponent();
            this.li = li;
            b = new BindingSource();
            b.DataSource = li;
            bindingNavigator1.BindingSource = b;
            ModeloDominio.Cliente c = b.Current as ModeloDominio.Cliente;

            dnitb.Text = c.Dni;
            String s = c.Nombre;
            string[] subs = s.Split(' ');
            if (subs.Length>1)
            {
                this.nombretb.Text = subs[0];
                this.nombretb.Text = subs[1];
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

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            ModeloDominio.Cliente c = b.Current as ModeloDominio.Cliente;

            dnitb.Text = c.Dni;
            String s = c.Nombre;
            string[] subs = s.Split(' ');
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
    }
}
