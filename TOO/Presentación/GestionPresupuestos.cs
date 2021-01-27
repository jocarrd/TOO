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

namespace Presentación
{
    public partial class GestionPresupuestos : Form
    {
        private List<ModeloDominio.Vehiculo> v;
        public GestionPresupuestos(String iden, String tipo, NegocioAdmin neg)
        {
            InitializeComponent();
            this.idePrestb.Text = iden;
            this.idePrestb.ReadOnly = true;
            if (this.tipo.Equals("crear"))
            {
                this.estadocb.Items.Add("Aceptado");
                this.estadocb.Items.Add("Pendiente");
                this.estadocb.Items.Add("Desestimado");
                v = new List<Vehiculo>();
            }
            else
            {
                Presupuesto pres = new Presupuesto(this.idePrestb.Text);
                this.cantidadtb.Text = pres.getCantidad().ToString();
                this.cantidadtb.ReadOnly = true;
                this.estadocb.Items.Add("pres.getEstado()");
                this.estadocb.Text = pres.getEstado().ToString();
                this.clientetb.Text = pres.getCliente().getDni();
                this.clientetb.ReadOnly = true;
                this.dateTimePicker1.Value = pres.getFecha_Realizacion();
                this.numbastb.Text = "";
                this.numbastb.Enabled = false;

                v = pres.getVehiculos();
                foreach (Vehiculo ve in v)
                {
                    this.listBox1.Items.Add(ve.getNumBastidor());
                }

                this.botonAñadir.Enabled = false;
                this.botonEliminar.Enabled = false;
            }

        }

        private void botonAceptar_Click(object sender, EventArgs e)
        {
            if (tipo.Equals("crear"))
            {
                if (this.compruebaLosTextBox() && neg.existeCliente(this.clientetb.Text))
                {
                    int indice = estadocb.SelectedIndex;
                    String estado = estadocb.Items[indice].ToString();

                    Cliente c = neg.seleccionarCliente(this.clientetb.Text);

                    neg.crearPresupuesto(this.idePrestb.Text, int.Parse(this.cantidadtb.Text), this.dateTimePicker1.Value.Date, this.estadoPesupuesto(estado), c, v);
                    this.Close();
                }
                else
                {
                    if (this.cantidadtb.Text.Equals(""))
                    {
                        MessageBox.Show("Debes introducir una cantidad para el presupuesto ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.cantidadtb.Font = new Font(cantidadtb.Font, FontStyle.Bold);
                        this.cantidadtb.ForeColor = Color.Red;
                        this.cantidadtb.Focus();
                    }
                    else
                    {
                        if (this.estadocb.Text.Equals(""))
                        {
                            MessageBox.Show("Completa el campo estado del presupuesto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.estadocb.Font = new Font(estadocb.Font, FontStyle.Bold);
                            this.estadocb.ForeColor = Color.Red;
                            this.estadocb.Focus();
                        }
                        else
                        {
                            if (this.clientetb.Text.Equals(""))
                            {
                                MessageBox.Show("Debes introducir un cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                this.clientetb.Font = new Font(estadocb.Font, FontStyle.Bold);
                                this.clientetb.ForeColor = Color.Red;
                                this.clientetb.Focus();
                            }
                            else
                            {
                                if (!neg.existeCliente(this.clientetb.Text))
                                {
                                    MessageBox.Show("El cliente no existe en la BD", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    this.clientetb.Font = new Font(estadocb.Font, FontStyle.Bold);
                                    this.clientetb.ForeColor = Color.Red;
                                    this.clientetb.Focus();
                                }
                            }
                        }
                    }
                }
            }
        }

        public bool compruebaLosTextBox()
        {
            //Comprueba si los TextBox son vacíos o si tienen algun dato mal introducido

            //Comprobamos que no sean vacíos, sino dev falso
            if (!cantidadtb.Text.Equals("") || !estadocb.Text.Equals("") || !clientetb.Text.Equals(""))
            {
                //Como los otros campos no pueden ser parseados por ser strings, comprobamos que el telf es un long
                if (int.TryParse(cantidadtb.Text, out int cant))
                {
                    return true;
                }
            }
            return false;
        }

        public EstadoPresupuesto estadoPesupuesto(String a)
        {
            if (a.Equals("Aceptado"))
            {
                return EstadoPresupuesto.Aceptado;
            }
            else
            {
                if (a.Equals("Desestimado"))
                {
                    return EstadoPresupuesto.Desestimado;
                }
                else
                {
                    return EstadoPresupuesto.Pendiente;
                }
            }
        }

        private void botonAñadir_Click(object sender, EventArgs e)
        {
            if (neg.existeVehiculo(this.numbastb.Text))
            {
                Vehiculo vehiculo = neg.seleccionarVehiculo(this.numbastb.Text);
                v.Add(vehiculo);
                this.listBox1.Items.Add(this.numbastb.Text);
            }
            else
            {
                MessageBox.Show("El vehículo no se encuenta en la BD", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void botonEliminar_Click(object sender, EventArgs e)
        {
            int indice = listBox1.SelectedIndex;
            if (indice != -1)
            {
                v.RemoveAt(indice);
                this.listBox1.Items.RemoveAt(indice);
            }
        }
    }
}
