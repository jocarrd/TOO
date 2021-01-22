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
        private NegocioAdmin neg;
        List<ModeloDominio.Cliente> lista = null;
        public ListadoClientes(NegocioAdmin neg)
        {
            InitializeComponent();
            lista = neg.listarClientes();
            List<Presupuesto> listaPresupuesto = null;


            foreach (Cliente c in lista)
            {
                this.dniListB.Items.Add(c.getDni());
                string[] nomApell = c.getNombre().Split(' ');
                if (nomApell.Length==2)
                {
                    this.nombreListB.Items.Add(nomApell[1] + "," + nomApell[0]);
                }
                else
                {
                    this.nombreListB.Items.Add(nomApell[0]);
                }

                listaPresupuesto = c.getPresupuesto();
                this.importeListB.Items.Add(listaPresupuesto[0]);
            }
        }
    }
}
