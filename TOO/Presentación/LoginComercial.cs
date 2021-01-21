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

namespace Presentación
{
    public partial class LoginComercial : Form
    {
        private NegocioAdmin neg;
        public LoginComercial()
        {
            InitializeComponent();
            neg = new NegocioAdmin();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.nombretb.Text.Equals("") && this.contraseñatb.Text.Equals("")) 
            {
                MessageBox.Show("Seleccione al menos una categoría", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //acordarse al final de cambiarlo en loginComercial
                MenuPrincipal mp = new MenuPrincipal(this.nombretb.Text, neg);
                mp.Show();
            }
        }
    }
}
