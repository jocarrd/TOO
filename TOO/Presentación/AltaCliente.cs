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



        public AltaCliente(String dni)
        {
            
            InitializeComponent();
            this.dnitb.Text = dni;
        }

        private void botonAceptar_Click(object sender, EventArgs e)
        {
            if (this.compruebaLosTextBox())
            {
                if (this.compruebaLosBotones())
                {

                }
                else {
                    MessageBox.Show("Seleccione al menos una categoría", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else {
                if (nombretb.Text.Equals("")) MessageBox.Show("Debes introducir uno nombre para el cliente ","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                else if (telefonotb.Text.Equals(""))  MessageBox.Show("Completa el campo Telefono", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
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
        public bool compruebaLosBotones() {
            //Comprueba que al meno haya seleccionado una categoría
            if (!this.botonA.Checked&& !this.botonB.Checked&& !this.botonC.Checked) return false;
            else return true;
        }

        private void AltaCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
