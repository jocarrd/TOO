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
        private List<Vehiculo> v;
        private Presupuesto presupuesto;

        public GestionPresupuestos(String iden)
        {
            InitializeComponent();
            this.idePrestb.Text = iden;
            this.idePrestb.ReadOnly = true;
            this.estadocb.Items.Add("Aceptado");
            this.estadocb.Items.Add("Pendiente");
            this.estadocb.Items.Add("Desestimado");
            v = new List<Vehiculo>();
        }

         public GestionPresupuestos(Presupuesto p){
            this.presupuesto = p;
            this.cantidadtb.Text = this.presupuesto.Cantidad.ToString();
            this.cantidadtb.ReadOnly = true;
            this.estadocb.Items.Add(this.presupuesto.Estado);
            this.estadocb.Text = this.presupuesto.Estado.ToString();
            this.clientetb.Text = this.presupuesto.Cliente.Dni;
            this.clientetb.ReadOnly = true;
            this.dateTimePicker1.Value = this.presupuesto.Fecha_Realizacion;
            this.numbastb.Text = "";
            this.numbastb.Enabled = false;
            v = this.presupuesto.CocheList;
                foreach (Vehiculo ve in v)
                {
                    this.listBox1.Items.Add(ve.NumBastidor);
                }

            this.botonAñadir.Enabled = false;
            this.botonEliminar.Enabled = false;
         }

        private void botonAceptar_Click(object sender, EventArgs e)
        {

            if (this.compruebaLosTextBox())
            {
                int indice = estadocb.SelectedIndex;
                String estado = estadocb.Items[indice].ToString();
                presupuesto.Cantidad = int.Parse(this.cantidadtb.Text);
                presupuesto.Cliente = new Cliente(this.clientetb.Text);
                presupuesto.Estado =this.estadoPesupuesto(estado);
                presupuesto.Fecha_Realizacion = this.dateTimePicker1.Value;
                presupuesto.CocheList = this.v;
                this.Close();
            }
            else
            {
                if (this.cantidadtb.Text.Equals(""))
                {
                    MessageBox.Show("Debes introducir una cantidad para el presupuesto ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.cantidadlb.Font = new Font(cantidadlb.Font, FontStyle.Bold);
                    this.cantidadlb.ForeColor = Color.Red;
                    this.cantidadlb.Focus();
                }
                else
                {
                    if (this.estadocb.Text.Equals(""))
                    {
                        MessageBox.Show("Completa el campo estado del presupuesto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.label3.Font = new Font(estadocb.Font, FontStyle.Bold);
                        this.label3.ForeColor = Color.Red;
                        this.estadocb.Focus();
                    }
                    else
                    {
                        if (this.clientetb.Text.Equals(""))
                        {
                            MessageBox.Show("Debes introducir un cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.label1.Font = new Font(estadocb.Font, FontStyle.Bold);
                            this.label1.ForeColor = Color.Red;
                            this.clientetb.Focus();
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
            this.listBox1.Items.Add(this.numbastb.Text);
        }

        private void botonEliminar_Click(object sender, EventArgs e)
        {
            int indice = listBox1.SelectedIndex;
            if (indice != -1)
            {
                this.listBox1.Items.RemoveAt(indice);
            }
        }

        public Presupuesto devPresupuesto()
        {
            return this.presupuesto;
        }

        public List<Vehiculo> devVehiculos()
        {
            return this.v;
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
