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
    public partial class ListadoClientes : Form
    {
        BindingList<Cliente> list = new BindingList<Cliente>();


        public ListadoClientes(List<Cliente> lista)
        {
            InitializeComponent();
            foreach(Cliente c in lista)
            {
                list.Add(c);
                
            }

            this.dniListB.DataSource = list;
            this.dniListB.DisplayMember = "Dni";

            this.nombreListB.DataSource = list;
            this.nombreListB.DisplayMember = "Nombre";

            

            this.importeListB.DataSource = list;
            this.importeListB.DisplayMember = "GetUnValorPresupuesto";

        }

        private void botonDNI_Click(object sender, EventArgs e)
        {
           IEnumerable<Cliente> n=list.OrderBy(f => f.Dni);
            BindingList<Cliente> lista = new BindingList<Cliente>();
            foreach (Cliente c in n.ToList())
            {
               lista.Add(c);

            }
            this.list = lista;


            this.RefrescarList();

        }

        private void botonNombre_Click(object sender, EventArgs e)
        {
            IEnumerable<Cliente> n = list.OrderBy(f => f.Nombre);
            BindingList<Cliente> lista = new BindingList<Cliente>();
            foreach (Cliente c in n.ToList())
            {
                lista.Add(c);

            }
            this.list = lista;


            this.RefrescarList();
        }

        private void RefrescarList()
        {
            this.dniListB.DataSource = null;
            this.dniListB.DataSource = list;
            this.dniListB.DisplayMember = "Dni";

            this.nombreListB.DataSource = null;
            this.nombreListB.DataSource = list;
            this.nombreListB.DisplayMember = "Nombre";


            this.importeListB.DataSource = null;
            this.importeListB.DataSource = list;
            this.importeListB.DisplayMember = "GetUnValorPresupuesto";





        }
    }
}
