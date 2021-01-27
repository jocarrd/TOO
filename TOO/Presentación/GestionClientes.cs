using ModeloDominio;
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
    public partial class GestionClientes : Form
    {
        Cliente cliente;

        public GestionClientes(String dni)
        {
            //ESTO ES ALTA CLIENTE
            InitializeComponent();
            this.dnitb.Text = dni;
            this.cliente = new Cliente(this.dnitb.Text);
            this.botonAceptar.Focus();
        }

        public GestionClientes(Cliente c)
        {
            //BAJA/BUSQUEDA CLIENTES
            InitializeComponent();
            this.cliente = c;
            this.dnitb.Text = c.Dni;
            this.nombretb.Text = c.Nombre;
            this.nombretb.ReadOnly = true;
            this.telefonotb.Text = c.Tfno.ToString();
            this.telefonotb.ReadOnly = true;
            this.botonCancelar.Visible = false;
            this.botonCancelar.Enabled = false;
            this.marcarTipoCliente(c.Categoria);
            this.botonA.Enabled = false;
            this.botonB.Enabled = false;
            this.botonC.Enabled = false;
            this.botonAceptar.Focus();
        }


        private void botonAceptar_Click(object sender, EventArgs e)
        {
            if (this.compruebaLosTextBox())
            {
                if (this.compruebaLosBotones())
                {
                    this.nombrelb.Font = new Font(dnilb.Font, FontStyle.Regular);
                    this.nombrelb.ForeColor = dnilb.ForeColor;
                    this.telefonolb.Font = new Font(dnilb.Font, FontStyle.Regular);
                    this.telefonolb.ForeColor = dnilb.ForeColor;
                    this.categorialbl.Font = new Font(dnilb.Font, FontStyle.Regular);
                    this.categorialbl.ForeColor = dnilb.ForeColor;

                    this.cliente.Dni = this.dnitb.Text;
                    this.cliente.Nombre = this.nombretb.Text;
                    this.cliente.Tfno = long.Parse(this.telefonotb.Text);
                    this.cliente.Categoria = this.GetTipo_Cliente();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Seleccione al menos una categoría", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.categorialbl.ForeColor = Color.Red;
                    this.categorialbl.Font = new Font(categorialbl.Font, FontStyle.Bold);
                }
            }
            else
            {
                if (this.nombretb.Text.Equals(""))
                {
                    MessageBox.Show("Debes introducir uno nombre para el cliente ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.nombrelb.Font = new Font(nombrelb.Font, FontStyle.Bold);
                    this.nombrelb.ForeColor = Color.Red;
                    this.nombretb.Focus();
                }
                else
                {
                    if (this.telefonotb.Text.Equals(""))
                    {
                        MessageBox.Show("Completa el campo Telefono", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.telefonolb.Font = new Font(nombrelb.Font, FontStyle.Bold);
                        this.telefonolb.ForeColor = Color.Red;
                        this.telefonotb.Focus();
                    }
                }

            }
        }

        public bool compruebaLosTextBox()
        {
            //Comprueba si los TextBox son vacíos o si tienen algun dato mal introducido

            //Comprobamos que no sean vacíos, sino dev falso
            if (!nombretb.Text.Equals("") || !telefonotb.Text.Equals(""))
            {
                //Como los otros campos no pueden ser parseados por ser strings, comprobamos que el telf es un long
                if (long.TryParse(telefonotb.Text, out long telf))
                {
                    return true;
                }
            }
            return false;
        }
        public bool compruebaLosBotones()
        {
            //Comprueba que al meno haya seleccionado una categoría
            return this.botonA.Checked || this.botonB.Checked || this.botonC.Checked;
        }

        public void marcarTipoCliente(Tipo_cliente t)
        {
            switch (t)
            {
                case Tipo_cliente.Baja:
                    botonA.Checked = false;
                    botonB.Checked = false;
                    botonC.Checked = true;
                    break;
                case Tipo_cliente.Media:
                    botonA.Checked = false;
                    botonB.Checked = true;
                    botonC.Checked = false;
                    break;
                case Tipo_cliente.Alta:
                    botonA.Checked = true;
                    botonB.Checked = false;
                    botonC.Checked = false;
                    break;
            }
        }

        public Tipo_cliente GetTipo_Cliente() {
            if (botonA.Checked) {
                return Tipo_cliente.Alta;
            } else {
                if (botonB.Checked) {
                    return Tipo_cliente.Media;
                } else {
                    return Tipo_cliente.Baja;
                } 
            }
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
