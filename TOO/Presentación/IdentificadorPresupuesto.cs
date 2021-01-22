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
    public partial class IdentificadorPresupuesto : Form
    {
        private NegocioAdmin neg;
        private String tipo;
        public IdentificadorPresupuesto(String tipo, NegocioAdmin neg)
        {
            InitializeComponent();
            this.neg = neg;
            this.tipo = tipo;
        }

        private void botonAceptar_Click(object sender, EventArgs e)
        {
            if (this.IdePrestb.Text.Length >= 2)
            {
                bool existe = neg.existePresupuesto(this.IdePrestb.Text);
                switch (this.tipo)
                {
                    case "crear":
                        if (!existe)
                        {
                            GestionPresupuestos nuevo = new GestionPresupuestos(this.IdePrestb.Text, this.tipo, this.neg);
                            nuevo.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            if (MessageBox.Show("¿Quieres introducir otro presupuesto?", "Ya existe un presupuesto con ese identificador", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                this.IdePrestb.Clear();
                                this.IdePrestb.Focus();
                            }
                            else
                            {
                                this.Close();
                            }
                        }
                        break;

                    case "búsqueda":
                        if (!existe)
                        {
                            if (MessageBox.Show("¿Quieres introducir otro presupuesto?", "No existe un presupuesto con ese identificador", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                this.IdePrestb.Clear();
                                this.IdePrestb.Focus();
                            }
                            else
                            {
                                this.Close();
                            }
                        }
                        else
                        {
                            GestionPresupuestos nuevo = new GestionPresupuestos(this.IdePrestb.Text, this.tipo, this.neg);
                            nuevo.ShowDialog();
                            this.Close();
                        }
                        break;
                }
            }
            else
            {
                MessageBox.Show("Error al introducir el identificador", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.IdePrestb.Focus();
            }
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
