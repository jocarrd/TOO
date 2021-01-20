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
            bool existeCliente=false;
            if (this.existeCliente(this.dnitb.Text)!=null)
            {
                existeCliente = true;
            }
            switch (this.tipo)
            {
                case "alta":
                    if (!existeCliente)
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
                    if (!existeCliente)
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
                        GestionClientes baja = new GestionClientes(this.dnitb.Text, NOMBRE, TELEFONO, TIPOCLIENTE, this.tipo);
                        baja.Text = "Baja de un cliente";
                    }
                    break;

                case "búsqueda":
                    if (!existeCliente)
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
                        GestionClientes busqueda = new GestionClientes(this.dnitb.Text, NOMBRE, TELEFONO, TIPOCLIENTE, this.tipo);
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

        public ModeloDominio.Cliente existeCliente(String dni)
        {
            //HACER BUSQUEDA DEL CLIENTE
        }
    }
}
