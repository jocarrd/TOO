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

namespace Presentación
{
    public partial class GestionClientes : Form
    {
        String tipoForm;

        public GestionClientes(String dni)
        {
            //ESTO ES ALTA CLIENTE
            InitializeComponent();
            this.tipoForm = "alta";
            this.dnitb.Text = dni;
            this.botonAceptar.Click += this.botonAceptarAlta_Click;
            this.botonAceptar.Focus();
        }

        public GestionClientes(String Dni, String nombre, long tfno, Tipo_cliente tipo_Cliente, String tipo)
        {
            //BUSQUEDA CLIENTES
            InitializeComponent();
            if (tipo.Equals("búsqueda"))
            {
                this.tipoForm = "búsqueda";
                this.dnitb.Text = Dni;
                this.nombretb.Text = nombre;
                this.nombretb.ReadOnly = true;
                this.telefonotb.Text = tfno.ToString();
                this.telefonotb.ReadOnly = true;
                this.botonCancelar.Visible = false;
                this.botonCancelar.Enabled = false;
                this.marcarTipoCliente(tipo_Cliente);
                this.botonA.Enabled = false;
                this.botonB.Enabled = false;
                this.botonC.Enabled = false;
                this.botonAceptar.Click += this.botonAceptarBusqueda_Click;
                this.botonAceptar.Focus();
            }
            else
            {
                this.tipoForm = "baja";
                this.dnitb.Text = Dni;
                this.nombretb.Text = nombre;
                this.nombretb.ReadOnly = true;
                this.telefonotb.Text = tfno.ToString();
                this.telefonotb.ReadOnly = true;
                this.marcarTipoCliente(tipo_Cliente);
                this.botonA.Enabled = false;
                this.botonB.Enabled = false;
                this.botonC.Enabled = false;
                this.botonAceptar.Click += this.botonAceptarBaja_Click;
                this.botonAceptar.Focus();
            }
        }

        private void botonAceptarAlta_Click(object sender, EventArgs e)
        {
            if (this.compruebaLosTextBox())
            {
                if (this.compruebaLosBotones())
                {
                    //AÑADIR A LA BASE DE DATOS
                }
                else
                {
                    MessageBox.Show("Seleccione al menos una categoría", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.flowLayoutPanel1.ForeColor = Color.Red;
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

        private void botonAceptarBaja_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Aviso", "Está seuro de que desea dar de baja este cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                //BORRAR EL CLIENTE DE LA BASE DE DATOS
                MessageBox.Show("Aviso", "Cliente eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
        }

        private void botonAceptarBusqueda_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool compruebaLosTextBox()
        {
            //Comprueba si los TextBox son vacíos o si tienen algun dato mal introducido

            //Comprobamos que no sean vacíos, sino dev falso
            if (!nombretb.Text.Equals("") || !telefonotb.Text.Equals("") || !dnitb.Text.Equals(""))
            {
                //Como los otros campos no pueden ser parseados por ser strings, comprobamos que el telf es in int
                if (!long.TryParse(telefonotb.Text, out long telf))
                {
                    return false;
                }
                else
                {
                    return true;
                }


            }
            else return false;
        }
        public bool compruebaLosBotones()
        {
            //Comprueba que al meno haya seleccionado una categoría
            if (!this.botonA.Checked && !this.botonB.Checked && !this.botonC.Checked) return false;
            else return true;
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
    }
}
