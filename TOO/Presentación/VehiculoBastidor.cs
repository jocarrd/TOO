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
    public partial class VehiculoBastidor : Form
    {
        String tipo;
        private NegocioAdmin neg;

        public VehiculoBastidor(String a, NegocioAdmin neg)
        {
            InitializeComponent();
            this.neg = neg;
            this.tipo = a;
        }

        private void botonAceptar_Click(object sender, EventArgs e)
        {
            if (this.numBastb.Text.Length >= 5)
            {
                bool existe = neg.existeCliente(this.numBastb.Text);
                switch (this.tipo)
                {
                    case "alta":
                        if (!existe)
                        {
                            GestionVehiculos nuevo = new GestionVehiculos(this.numBastb.Text, this.neg);
                            nuevo.Text = "Alta de un vehiculo";
                            nuevo.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            if (MessageBox.Show("¿Quieres introducir otro Bastidor?", "Ya existe un vehiculo con ese Bastidor", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                this.numBastb.Clear();
                                this.numBastb.Focus();
                            }
                            else
                            {
                                this.Close();
                            }
                        }
                        break;

                    case "baja":
                        if (!existe)
                        {
                            if (MessageBox.Show("¿Quieres introducir otro Bastidor?", "No existe un vehiculo con ese Bastidor", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                this.numBastb.Clear();
                                this.numBastb.Focus();
                            }
                            else
                            {
                                this.Close();
                            }
                        }
                        else
                        {
                            //baja.Text = "Baja de un cliente";
                        }
                        break;

                    case "búsqueda":
                        if (!existe)
                        {
                            if (MessageBox.Show("¿Quieres introducir otro Bastidor?", "No existe un vehiculo con ese Bastidor", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                this.numBastb.Clear();
                                this.numBastb.Focus();
                            }
                            else
                            {
                                this.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Existe un vehiculo con ese Bastidor");
                            //busqueda.Text = "Datos del cliente";
                            //busqueda.Show();
                            this.Close();
                        }
                        break;
                }
            }
            else
            {
                MessageBox.Show("Error al introducir Bastidor", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numBastb.Focus();
            }

        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
