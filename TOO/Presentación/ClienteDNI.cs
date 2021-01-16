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
    public partial class ClienteDNI : Form
    {
        String tipo;
        public ClienteDNI(String a)
        {
            this.tipo = a;
            InitializeComponent();
        }

        private void botonAceptar_Click(object sender, EventArgs e)
        {
            if (tipo.Equals("alta"))
            {
                


                AltaCliente nuevo = new AltaCliente(this.dnitb.Text);
                nuevo.Show();
                this.Close();
            }

        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void ClienteDNI_Load(object sender, EventArgs e)
        {

        }
    }
}
