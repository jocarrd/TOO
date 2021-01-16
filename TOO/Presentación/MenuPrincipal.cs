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

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClienteDNI cliente = new ClienteDNI("alta");
            cliente.Show();
        }
        
    }
}
