using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Persistencia;
using ModeloDominio;
using LogicaNegocio;

namespace Presentación
{
    public partial class IdentificadorPresupuesto : Form
    {
        private Presupuesto presupuesto;

        public IdentificadorPresupuesto()
        {
            InitializeComponent();
            this.botonAceptar.Click += botonAceptarCrear_Click;
        }

        public IdentificadorPresupuesto(Presupuesto p)
        {
            InitializeComponent();
            this.presupuesto = p;

        }


        private void botonAceptar_Click(object sender, EventArgs e)
        {
            GestionPresupuestos nuevo = new GestionPresupuestos(this.IdePrestb.Text,this.presupuesto);
            nuevo.Text = "Alta presupuesto";
            nuevo.ShowDialog();
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
