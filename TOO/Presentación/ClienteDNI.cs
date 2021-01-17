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
            switch (this.tipo) {
                case "alta":
                    if ( LogicaNegocio.NegocioAdmin. this.dnitb.Text /* NO EXISTE EN LA BD*/){ 
                        AltaCliente nuevo = new AltaCliente(this.dnitb.Text);
                        nuevo.Show();
                        this.Close();
                    }else {
                        if (MessageBox.Show("Ya existe un cliente con ese DNI", "¿Quieres introducir otro DNI?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            this.dnitb.Clear();
                        }
                        else { 
                            this.Close(); 
                        }
                    }
                    break;

                case "baja":
                    
                    this.Close();
                    break;

                case "búsqueda":
                    
                    this.Close();
                    break;
            }
        
            
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
