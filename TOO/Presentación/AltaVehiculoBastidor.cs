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
    public partial class AltaVehiculoBastidor : Form
    {
        public AltaVehiculoBastidor()
        {
            InitializeComponent();
        }

        private void botonAceptar_Click(object sender, EventArgs e)
        {
            if (this.bastidortb.Text.Equals("")) 
            {
                MessageBox.Show("Introduce el número de bastidor");
            }
            else
            {

            }
            
        }
    }
}
