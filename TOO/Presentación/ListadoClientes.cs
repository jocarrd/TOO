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
        List<Cliente> lista = null;
        
        public ListadoClientes(List<Cliente> list)
        {
            InitializeComponent();
            this.lista = list;
            List<Presupuesto> listaPresupuesto = null;

            foreach (Cliente c in lista)
            {
                this.dniListB.Items.Add(c.Dni);
                string[] nomApell = c.Nombre.Split(' ');
                if (nomApell.Length == 2)
                {
                    this.nombreListB.Items.Add(nomApell[1] + "," + nomApell[0]);
                }
                else
                {
                    this.nombreListB.Items.Add(nomApell[0]);
                }

                listaPresupuesto = c.PresupuestoList;
                this.importeListB.Items.Add(listaPresupuesto[0]);
            }
        }
    }
}
