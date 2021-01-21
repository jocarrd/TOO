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
            bool existe = neg.existe(this.dnitb.Text);
            switch (this.tipo)
            {
                case "alta":
                    if (!existe)
                    {
                        GestionClientes nuevo = new GestionClientes(this.dnitb.Text, this.neg);
                        nuevo.Text = "Alta de un cliente";
                        nuevo.Show();
                        this.Close();
                    }
                    else
                    {
                        if (MessageBox.Show("Ya existe un cliente con ese DNI", "¿Quieres introducir otro DNI?", MessageBoxButtons.YesNo) == DialogResult.Yes)
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
                        if (MessageBox.Show("No existe un cliente con ese DNI", "¿Quieres introducir otro DNI?", MessageBoxButtons.YesNo) == DialogResult.Yes)
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
                        if (MessageBox.Show("No existe un cliente con ese DNI", "¿Quieres introducir otro DNI?", MessageBoxButtons.YesNo) == DialogResult.Yes)
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

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
