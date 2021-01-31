using LogicaNegocio;
using Persistencia;
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
    public partial class GestionVehiculos : Form
    {
        Vehiculo vehiculo;

        public GestionVehiculos(String bastidor)
        {
            InitializeComponent();
      
            this.numBastb.Text = bastidor;
            this.vehiculo = new Vehiculo(this.numBastb.Text);
            this.matriculalb.Visible = false;
            this.matriculatb.Enabled = false;
            this.matriculatb.Visible = false;
            this.fechaMatriculatb.Visible = false;
            this.fechaMatriculatb.Enabled = false;
            this.fechaMatriculalb.Visible = false;
            this.botonAceptar.Focus();
        }

        public GestionVehiculos(Vehiculo v)
        {
            //BUSQUEDA CLIENTES
            InitializeComponent();
            this.vehiculo = v;
            this.numBastb.Text = v.NumBastidor;
            this.numBastb.ReadOnly = true;
            this.marcatb.Text = v.Marca;
            this.marcatb.ReadOnly = true;
            this.modelotb.Text = v.Modelo;
            this.modelotb.ReadOnly = true;
            this.potenciatb.Text = v.Potencia.ToString();
            this.potenciatb.ReadOnly = true;
            this.precioRectb.Text = v.Precio.ToString();
            this.precioRectb.ReadOnly = true;
            this.marcarTipoVehiculo(v);
            this.botonNuevo.Enabled = false;
            this.botonSegMano.Enabled = false;
            
            this.botonAceptar.Focus();
        }

        ///<summary>
        ///Coprueba que todo este completo y en orden, sino, marca los campos que fallan y sino cierra el formulario
        ///</summary>
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

                this.vehiculo.NumBastidor = this.numBastb.Text;
                this.vehiculo.Marca = this.marcatb.Text;
                this.vehiculo.Modelo = this.modelotb.Text;
                this.vehiculo.Potencia = int.Parse(this.potenciatb.Text);
                this.vehiculo.Precio = double.Parse(this.precioRectb.Text);
                if (this.botonSegMano.Checked)
                {
                    this.vehiculo.Matricula = this.matriculatb.Text;
                    //this.vehiculo.Fecha_matriculacion = this.fechaMatriculatb.Text;
                }
                
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
                        if (this.potenciatb.Text.Equals("") || !int.TryParse(potenciatb.Text, out int pot))
                        {
                            MessageBox.Show("Corrige el campo potencia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.potencialb.Font = new Font(potenciatb.Font, FontStyle.Bold);
                            this.potencialb.ForeColor = Color.Red;
                            this.potencialb.Focus();
                        }
                        else
                        {
                            if (this.precioRectb.Text.Equals("") || !double.TryParse(precioRectb.Text, out double prec))
                            {
                                MessageBox.Show("Completa el campo precio recomendado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                this.precioReclb.Font = new Font(precioRectb.Font, FontStyle.Bold);
                                this.precioReclb.ForeColor = Color.Red;
                                this.precioReclb.Focus();
                            }
                            else
                            {
                                if (!this.botonSegMano.Checked && !this.botonNuevo.Checked)
                                {
                                    MessageBox.Show("Marca el tipo del vehículo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    this.label6.Font = new Font(precioRectb.Font, FontStyle.Bold);
                                    this.label6.ForeColor = Color.Red;
                                    this.label6.Focus();
                                }
                                else
                                {
                                    if (this.botonSegMano.Checked)
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
            }
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            this.vehiculo.NumBastidor = "";
            this.Close();
        }

        public bool compruebaLosTextBox()
        {
            //Comprueba si los TextBox son vacíos o si tienen algun dato mal introducido
            //Comprobamos que no sean vacíos, sino dev falso
            if (this.botonSegMano.Checked)
            {
                if (!marcatb.Text.Equals("") && !modelolb.Text.Equals("") && !potenciatb.Text.Equals("") && !precioRectb.Text.Equals("") && !matriculatb.Text.Equals("") && !fechaMatriculatb.Text.Equals(""))
                {
                    //Como los otros campos no pueden ser parseados por ser strings, comprobamos que la pot es in int
                    if (int.TryParse(potenciatb.Text, out int pot) && double.TryParse(precioRectb.Text, out double prec))
                    {
                        return true;
                    }
                }
            }
            else
            {
                if (this.botonNuevo.Checked)
                {
                    if (!marcatb.Text.Equals("") && !modelolb.Text.Equals("") && !potenciatb.Text.Equals("") && !precioRectb.Text.Equals(""))
                    {
                        //Como los otros campos no pueden ser parseados por ser strings, comprobamos que la pot es in int
                        if (int.TryParse(potenciatb.Text, out int pot) && double.TryParse(precioRectb.Text, out double prec))
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }


        ///<summary>
        ///Marca los botones segun el Tipo Vehiculo
        ///</summary>
        public void marcarTipoVehiculo(Vehiculo v)
        {
            if (v.Matricula==null)
            {
                botonSegMano.Checked = false;
                botonNuevo.Checked = true;
            }
            else
            {
                botonSegMano.Checked = true;
                botonNuevo.Checked = false;
                this.matriculalb.Visible = true;
                this.matriculatb.Text = v.Matricula;
                this.matriculatb.Enabled = false;
                this.matriculatb.Visible = true;
                this.fechaMatriculatb.Text = v.Fecha_matriculacion.ToString();
                this.fechaMatriculatb.Visible = true;
                this.fechaMatriculatb.Enabled = false;
                this.fechaMatriculalb.Visible = true;
            }
        }

        ///<summary>
        ///Muestra los campos referentes a Segunda Mano
        ///</summary>
        private void botonSegMano_Click(object sender, EventArgs e)
        {
            this.matriculalb.Visible = true;
            this.matriculatb.Visible = true;
            this.matriculatb.Enabled = true;
            this.fechaMatriculatb.Visible = true;
            this.fechaMatriculatb.Enabled = true;
            this.fechaMatriculalb.Visible = true;
        }

        ///<summary>
        ///Oculta los campos referentes a Segunda Mano
        ///</summary>
        private void botonNuevo_CheckedChanged(object sender, EventArgs e)
        {
            this.matriculalb.Visible = false;
            this.matriculatb.Visible = false;
            this.matriculatb.Enabled = false;
            this.fechaMatriculatb.Visible = false;
            this.fechaMatriculatb.Enabled = false;
            this.fechaMatriculalb.Visible = false;
        }
        ///<summary>
        ///Devuelve el Vehiculo de esta clase
        ///</summary>
        public Vehiculo debVehiculo() {
            return this.vehiculo;
        }
    }
}