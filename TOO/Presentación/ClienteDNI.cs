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
    public partial class ClienteDNI : Form
    {
        String tipo;
        private NegocioAdmin neg;

        public ClienteDNI(String a, NegocioAdmin neg)
        {
            InitializeComponent();
            this.neg = neg;
            this.tipo = a;
        }

        private void botonAceptar_Click(object sender, EventArgs e)
        {
            if (this.dnitb.Text.Length>=5)
            {
                bool existe = neg.existeCliente(this.dnitb.Text);
                switch (this.tipo)
                {
                    case "alta":
                        if (!existe)
                        {
                            GestionClientes nuevo = new GestionClientes(this.dnitb.Text, this.neg);
                            nuevo.Text = "Alta de un cliente";
                            nuevo.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            if (MessageBox.Show("¿Quieres introducir otro DNI?", "Ya existe un cliente con ese DNI", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                this.dnitb.Clear();
                                this.dnitb.Focus();
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
                            if (MessageBox.Show("¿Quieres introducir otro DNI?", "No existe un cliente con ese DNI", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                this.dnitb.Clear();
                                this.dnitb.Focus();
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
                            if (MessageBox.Show("¿Quieres introducir otro DNI?", "No existe un cliente con ese DNI", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                this.dnitb.Clear();
                                this.dnitb.Focus();
                            }
                            else
                            {
                                this.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Existe un cliente con ese DNI");
                            //busqueda.Text = "Datos del cliente";
                            //busqueda.Show();
                            this.Close();
                        }
                        break;
                }
            }
            else
            {
                MessageBox.Show("Error al introducir DNI", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dnitb.Focus();
            }
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
