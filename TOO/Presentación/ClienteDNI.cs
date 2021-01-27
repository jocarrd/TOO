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
using Persistencia;

namespace Presentación
{
    public partial class ClienteDNI : Form
    {
        private Cliente cliente;

        public ClienteDNI(Cliente c)
        {
            InitializeComponent();
            this.cliente = c;
        }

        private void botonAceptar_Click(object sender, EventArgs e)
        {
            this.cliente.Dni = this.dnitb.Text;
            this.Close();
        }

        public Cliente debCliente() { 
            return this.cliente;
        }


        private void botonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
