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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal(String nombreComercial)
        {
            InitializeComponent();
            this.Text = nombreComercial+": Gestión de concesionario";
        }

        private void clientesToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e) {
            if (e.ClickedItem.Text.Equals("Alta"))
            {
                ClienteDNI cliente = new ClienteDNI("alta");
                cliente.ShowDialog();
            }

            if (e.ClickedItem.Text.Equals("Baja"))
            {
                ClienteDNI cliente = new ClienteDNI("baja");
                cliente.ShowDialog();
            }

            if (e.ClickedItem.Text.Equals("Búsqueda"))
            {
                ClienteDNI cliente = new ClienteDNI("búsqueda");
                cliente.ShowDialog();
            }
        }
    }
}
