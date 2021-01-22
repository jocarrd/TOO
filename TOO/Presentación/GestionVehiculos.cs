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
            this.matriculalb.Visible = false;
            this.matriculatb.Enabled = false;
            this.matriculatb.Visible = false;
            this.fechaMatriculatb.Visible = false;
            this.fechaMatriculatb.Enabled = false;
            this.fechaMatriculalb.Visible = false;
            this.botonAceptar.Click += this.botonAceptarAlta_Click;
            this.botonAceptar.Focus();
        }

        public GestionVehiculos(String bastidor, String marca, String modelo, int potencia, double precio, String tipoVehiculo, String tipo, NegocioAdmin neg)
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
                this.matriculalb.Visible = false;
                this.matriculatb.Enabled = false;
                this.matriculatb.Visible = false;
                this.fechaMatriculatb.Visible = false;
                this.fechaMatriculatb.Enabled = false;
                this.fechaMatriculalb.Visible = false;
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
                this.matriculalb.Visible = false;
                this.matriculatb.Enabled = false;
                this.matriculatb.Visible = false;
                this.fechaMatriculatb.Visible = false;
                this.fechaMatriculatb.Enabled = false;
                this.fechaMatriculalb.Visible = false;
                this.botonAceptar.Click += this.botonAceptarBaja_Click;
                this.botonAceptar.Focus();
            }
        }

        private void botonAceptarAlta_Click(object sender, EventArgs e)
        {
            if (this.compruebaLosTextBox())
            {
                this.marcalb.Font = new Font(numBastb.Font, FontStyle.Regular);
                this.marcalb.ForeColor = numBastb.ForeColor;
                this.modelolb.Font = new Font(numBastb.Font, FontStyle.Regular);
                this.modelolb.ForeColor = numBastb.ForeColor;
                this.potencialb.Font = new Font(numBastb.Font, FontStyle.Regular);
                this.potencialb.ForeColor = numBastb.ForeColor;
                this.precioReclb.Font = new Font(numBastb.Font, FontStyle.Regular);
                this.precioReclb.ForeColor = numBastb.ForeColor;
                this.matriculalb.Font = new Font(numBastb.Font, FontStyle.Regular);
                this.matriculalb.ForeColor = numBastb.ForeColor;
                this.fechaMatriculalb.Font = new Font(numBastb.Font, FontStyle.Regular);
                this.fechaMatriculalb.ForeColor = numBastb.ForeColor;

                this.label6.Font = new Font(numBastb.Font, FontStyle.Regular);
                this.label6.ForeColor = numBastb.ForeColor;

                //AÑADIR A LA BASE DE DATOS
                ModeloDominio.Vehiculo nuevo;
                if (this.esVehiculoNuevo())
                {
                    nuevo = new ModeloDominio.Nuevo(this.numBastb.Text, this.marcatb.Text, this.modelotb.Text, int.Parse(potenciatb.Text), double.Parse(precioRectb.Text));
                }
                else
                {
                    nuevo = new ModeloDominio.SegundaMano(this.numBastb.Text, this.marcatb.Text, this.modelotb.Text, int.Parse(potenciatb.Text), double.Parse(precioRectb.Text), this.matriculatb.Text, DateTime.Parse(this.fechaMatriculatb.Text));
                }
                neg.darAltaVehiculo(nuevo);
                MessageBox.Show("Se ha añadido " + this.marcatb.Text + " " + this.modelotb.Text + " con numero de bastidor: " + this.numBastb.Text, "Añadido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                if (this.marcatb.Text.Equals(""))
                {
                    MessageBox.Show("Debes introducir una marca para el vehiculo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.marcalb.Font = new Font(marcatb.Font, FontStyle.Bold);
                    this.marcalb.ForeColor = Color.Red;
                    this.marcalb.Focus();
                }
                else
                {
                    if (this.modelotb.Text.Equals(""))
                    {
                        MessageBox.Show("Debes introducir un modelo para el vehiculo ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.modelolb.Font = new Font(modelotb.Font, FontStyle.Bold);
                        this.modelolb.ForeColor = Color.Red;
                        this.modelolb.Focus();
                    }
                    else
                    {
                        if (this.potenciatb.Text.Equals("")|| !int.TryParse(potencialb.Text, out int pot))
                        {
                            MessageBox.Show("Corrige el campo potenia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.potencialb.Font = new Font(potenciatb.Font, FontStyle.Bold);
                            this.potencialb.ForeColor = Color.Red;
                            this.potencialb.Focus();
                        }
                        else
                        {
                            if (this.precioRectb.Text.Equals("")||!double.TryParse(precioRectb.Text, out double prec))
                            {
                                MessageBox.Show("Completa el campo precio recomendado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                this.precioReclb.Font = new Font(precioRectb.Font, FontStyle.Bold);
                                this.precioReclb.ForeColor = Color.Red;
                                this.precioReclb.Focus();
                            }
                            else
                            {
                                if (this.matriculatb.Text.Equals(""))
                                {
                                    MessageBox.Show("Completa el campo matrícula", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    this.matriculalb.Font = new Font(precioRectb.Font, FontStyle.Bold);
                                    this.matriculalb.ForeColor = Color.Red;
                                    this.matriculalb.Focus();
                                }
                                else
                                {
                                    if (this.fechaMatriculatb.Text.Equals(""))
                                    {
                                        MessageBox.Show("Completa el campo fecha matriculacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        this.fechaMatriculalb.Font = new Font(precioRectb.Font, FontStyle.Bold);
                                        this.fechaMatriculalb.ForeColor = Color.Red;
                                        this.fechaMatriculalb.Focus();
                                    }
                                }
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
            if (this.botonNuevo.Checked) {
                if (!marcatb.Text.Equals("") || !modelolb.Text.Equals("") || !matriculatb.Text.Equals("") || !fechaMatriculatb.Text.Equals(""))
                {
                    //Como los otros campos no pueden ser parseados por ser strings, comprobamos que la pot es in int
                    if (int.TryParse(potencialb.Text, out int pot) || double.TryParse(precioRectb.Text, out double prec))
                    {
                        return true;
                    }
                }
            } else
            {
                if (!marcatb.Text.Equals("") || !modelolb.Text.Equals("")){
                    //Como los otros campos no pueden ser parseados por ser strings, comprobamos que la pot es in int
                    if (int.TryParse(potencialb.Text, out int pot) || double.TryParse(precioRectb.Text, out double prec))
                    {
                        return true;
                    }
                }  
            }
            return false;
        }

       

        public void marcarTipoVehiculo(String t)
        {
            if (t.Equals("nuevo"))
            {
                botonSegMano.Checked = false;
                botonNuevo.Checked = true;
            }
            else
            {
                botonSegMano.Checked = true;
                botonNuevo.Checked = false;
            }
        }

        public bool esVehiculoNuevo()
        {
            if (this.botonNuevo.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void botonSegMano_Click(object sender, EventArgs e)
        {
            this.matriculalb.Visible = true;
            this.matriculatb.Visible = true;
            this.matriculatb.Enabled = true;
            this.fechaMatriculatb.Visible = true;
            this.fechaMatriculatb.Enabled = true;
            this.fechaMatriculalb.Visible = true;
        }

        private void botonNuevo_CheckedChanged(object sender, EventArgs e)
        {
            this.matriculalb.Visible = false;
            this.matriculatb.Visible = false;
            this.matriculatb.Enabled = false;
            this.fechaMatriculatb.Visible = false;
            this.fechaMatriculatb.Enabled = false;
            this.fechaMatriculalb.Visible = false;
        }
    }
}