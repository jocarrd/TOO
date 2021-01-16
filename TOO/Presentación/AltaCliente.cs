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
    public partial class AltaCliente : Form
    {
        public AltaCliente()
        {
            InitializeComponent();
        }

        private void botonAceptar_Click(object sender, EventArgs e)
        {
            if (!nombretb.Text.Equals("") || !telefonotb.Text.Equals("") || !dnitb.Text.Equals(""))
            {

            }
            else {
                if (nombretb.Text.Equals("")) MessageBox.Show("Completa el campo Nombre");
                else if (telefonotb.Text.Equals("")) MessageBox.Show("Completa el campo Telefono");
                else MessageBox.Show("Completa el campo DNI");
            }
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool compruebaLosTextBox() {
            //Comprueba si los TextBox son vacíos o si tienen algun dato mal introducido

            //Comprobamos que no sean vacíos, sino dev falso
            if (!nombretb.Text.Equals("") || !telefonotb.Text.Equals("") || !dnitb.Text.Equals(""))
            {
                //Como los otros campos no pueden ser parseados por ser strings, comprobamos que el telf es in int
                if (!long.TryParse(telefonotb.Text, out long telf))
                {
                    return false;
                }
                else { 
                    return true;
                }


            }else return false;
        }
    }
}
