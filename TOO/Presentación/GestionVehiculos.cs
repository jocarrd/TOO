using LogicaNegocio;
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
    public partial class GestionVehiculos : Form
    {
        String tipoForm;
        private NegocioAdmin neg;

        public GestionVehiculos(String bastidor, NegocioAdmin neg)
        {
            InitializeComponent();
            this.neg = neg;
            this.tipoForm = "alta";
            this.numBastb.Text = bastidor;
            this.botonAceptar.Click += this.botonAceptarAlta_Click;
            this.botonAceptar.Focus();
        }

        public GestionVehiculos(String bastidor, String marca, String modelo, int potencia, double precio, String tipoVehiculo,String tipo,NegocioAdmin neg)
        {
            //BUSQUEDA CLIENTES
            InitializeComponent();
            this.neg = neg;
            if (tipo.Equals("búsqueda"))
            {
                this.tipoForm = "búsqueda";
                this.numBastb.Text = bastidor;
                this.marcatb.Text = marca;
                this.marcatb.ReadOnly = true;
                this.modelotb.Text = modelo;
                this.modelotb.ReadOnly = true;
                this.potenciatb.Text = potencia.ToString();
                this.potenciatb.ReadOnly = true;
                this.precioRectb.Text = precio.ToString();
                this.precioRectb.ReadOnly = true;
                this.marcarTipoVehiculo(tipoVehiculo);
                this.botonNuevo.Enabled = false;
                this.botonSegMano.Enabled = false;
                this.botonCancelar.Visible = false;
                this.botonCancelar.Enabled = false;
                this.botonAceptar.Click += this.botonAceptarBusqueda_Click;
                this.botonAceptar.Focus();
            }
            else
            {
                this.tipoForm = "baja";
                this.numBastb.Text = bastidor;
                this.marcatb.Text = marca;
                this.marcatb.ReadOnly = true;
                this.modelotb.Text = modelo;
                this.modelotb.ReadOnly = true;
                this.potenciatb.Text = potencia.ToString();
                this.potenciatb.ReadOnly = true;
                this.precioRectb.Text = precio.ToString();
                this.precioRectb.ReadOnly = true;
                this.marcarTipoVehiculo(tipoVehiculo);
                this.botonNuevo.Enabled = false;
                this.botonSegMano.Enabled = false;
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
                    this.marcalb.Font = new Font(numBastb.Font, FontStyle.Regular);
                    this.marcalb.ForeColor = numBastb.ForeColor;
                    this.modelolb.Font = new Font(numBastb.Font, FontStyle.Regular);
                    this.modelolb.ForeColor = numBastb.ForeColor;
                    this.potencialb.Font = new Font(numBastb.Font, FontStyle.Regular);
                    this.potencialb.ForeColor = numBastb.ForeColor;
                    this.precioReclb.Font = new Font(numBastb.Font, FontStyle.Regular);
                    this.precioReclb.ForeColor = numBastb.ForeColor;
                    this.label6.Font = new Font(numBastb.Font, FontStyle.Regular);
                    this.label6.ForeColor = numBastb.ForeColor;

                    //AÑADIR A LA BASE DE DATOS
                    neg.darAltaVehiculo(this.numBastb.Text, this.marcatb.Text, this.modelotb.Text,int.Parse(potenciatb.Text), double.Parse(precioRectb.Text));
                    MessageBox.Show("Se ha añadido " + this.marcatb.Text + " "+ this.modelotb.Text + " con numero de bastidor: "+ this.numBastb.Text, "Añadido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Seleccione al menos una categoría de vehiculo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.label6.ForeColor = Color.Red;
                    this.label6.Font = new Font(label6.Font, FontStyle.Bold);
                }
            }
            else
            {
                if (this.marcatb.Text.Equals(""))
                {
                    MessageBox.Show("Debes introducir una marca para el vehiculo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.marcatb.Font = new Font(marcatb.Font, FontStyle.Bold);
                    this.marcatb.ForeColor = Color.Red;
                    this.marcatb.Focus();
                }
                else
                {
                    if (this.modelotb.Text.Equals(""))
                    {
                        MessageBox.Show("Debes introducir un modelo para el vehiculo ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.modelotb.Font = new Font(modelotb.Font, FontStyle.Bold);
                        this.modelotb.ForeColor = Color.Red;
                        this.modelotb.Focus();
                    }
                    else {
                        if (this.potenciatb.Text.Equals(""))
                        {
                            MessageBox.Show("Completa el campo potenia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.potenciatb.Font = new Font(potenciatb.Font, FontStyle.Bold);
                            this.potenciatb.ForeColor = Color.Red;
                            this.potenciatb.Focus();
                        }
                        else {
                            if (this.precioRectb.Text.Equals(""))
                            {
                                MessageBox.Show("Completa el campo precio recomendado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                this.precioRectb.Font = new Font(precioRectb.Font, FontStyle.Bold);
                                this.precioRectb.ForeColor = Color.Red;
                                this.precioRectb.Focus();
                            }
                        }
                    }
                }

            }
        }

        private void botonAceptarBaja_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está seuro de que desea dar de baja este vehiculo", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                //BORRAR EL Vehiculo DE LA BASE DE DATOS
                //this.neg.darBajaVehiculo(this.neg.obtenerInfoVehiculo(this.numBastb.Text));
                MessageBox.Show("Vehiculo eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (!marcatb.Text.Equals("") || !modelolb.Text.Equals(""))
            {
                //Como los otros campos no pueden ser parseados por ser strings, comprobamos que la pot es in int
                if (int.TryParse(potencialb.Text, out int pot) || double.TryParse(precioRectb.Text, out double prec))
                {
                    return true;
                }
            }
            return false;
        }

        public bool compruebaLosBotones()
        {
            //Comprueba que al meno haya seleccionado una categoría
            return this.botonNuevo.Checked && this.botonSegMano.Checked;
        }

        public void marcarTipoVehiculo(String t)
        {
            if (t.Equals("nuevo"))
            {
                botonSegMano.Checked = false;
                botonNuevo.Checked = true;
            }else{
                botonSegMano.Checked = true;
                botonNuevo.Checked = false;     
            }
        }
    }
}
