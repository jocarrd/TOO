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
    public partial class ClienteDNI : Form
    {
        String tipo;

        public ClienteDNI(String a)
        {
            InitializeComponent();
            this.tipo = a;
        }

        private void botonAceptar_Click(object sender, EventArgs e)
        {
            ModeloDominio.Cliente cliente = new ModeloDominio.Cliente(this.dnitb.Text,"",0,ModeloDominio.Tipo_cliente.Baja);
            bool existe = false;
            switch (this.tipo)
            {
                case "alta":
                    if (!existe)
                    {
                        GestionClientes nuevo = new GestionClientes(this.dnitb.Text);
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
                        GestionClientes baja = new GestionClientes(this.dnitb.Text, cliente.getNombre(), cliente.getTfno(), cliente.getCategoria(), this.tipo);
                        baja.Text = "Baja de un cliente";
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
                        GestionClientes busqueda = new GestionClientes(this.dnitb.Text, cliente.getNombre(), cliente.getTfno(), cliente.getCategoria(), this.tipo);
                        busqueda.Text = "Datos del cliente";
                        busqueda.Show();
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
