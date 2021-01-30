using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModeloDominio;

namespace Presentación
{
    public partial class BusquedaCliente : Form
    {
        List<Cliente> c;
        public BusquedaCliente(List<Cliente> c)
        {
            InitializeComponent();

            this.c = c;
            foreach (Cliente li in c)
            {
                dnicb.Items.Add(li.Dni);
            }
            
        }

        private void dnicb_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = dnicb.SelectedIndex;
            Cliente cli=c[indice];
            string[] nomApell = cli.Nombre.Split(' ');
            if (nomApell.Length == 2)
            {
                this.nombretb.Text = nomApell[0];
            }
            else
            {
                this.apellidostb.Text = nomApell[1];
            }
            this.nombretb.Text = cli.Nombre;

        }
    }
}
