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
        private int indice;

        public RecorridoCliente(List<ModeloDominio.Cliente> li)
        {
            InitializeComponent();
            this.li = li;
            this.indice = 0;
            this.dnitb.Text = li[indice].Dni;

            string[] nomApell = li[indice].Nombre.Split(' ');
            if (nomApell.Length == 2)
            {
                this.nombretb.Text = nomApell[0];
            }
            
            
            
            this.importetb.Text = li[indice].PresupuestoList[0].Cantidad.ToString();
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }
    }
}
