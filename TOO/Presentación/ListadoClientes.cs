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
        ///<summary>
        ///Ordena los textbox por dni
        ///</summary>
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

        ///<summary>
        ///Ordena los textbox por nombre
        ///</summary>

        private void botonNombre_Click(object sender, EventArgs e)
        {
            IEnumerable<Cliente> n = list.OrderBy(f => f.Nombre);
            BindingList<Cliente> lista = new BindingList<Cliente>();
            foreach (Cliente c in n.ToList())
            {
                lista.Add(c);

            }
            this.list = lista;

            this.dniListB.DataSource = null;
            this.dniListB.DataSource = list;
            this.dniListB.DisplayMember = "Dni";
           
            
        }


        ///<summary>
        ///Refresca los data source para que los cambios fruto de una ordenacion sean visibles
        ///</summary>
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
        ///<summary>
        ///Ordena los textbox por importe
        ///</summary>
        private void botonImporte_Click(object sender, EventArgs e)
        {
            IEnumerable<Cliente> n = list.OrderBy(f => f.GetUnValorPresupuesto);
            BindingList<Cliente> lista = new BindingList<Cliente>();
            foreach (Cliente c in n.ToList())
            {
                lista.Add(c);

            }
            this.list = lista;


            this.RefrescarList();
        }

        private void botonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
