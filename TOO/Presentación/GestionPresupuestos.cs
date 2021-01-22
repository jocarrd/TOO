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
    public partial class GestionPresupuestos : Form
    {
        private NegocioAdmin neg;
        private String tipo;
        public GestionPresupuestos(String iden, String tipo, NegocioAdmin neg)
        {
            InitializeComponent();
            this.neg = neg;
            this.tipo = tipo;
            this.idePrestb.Text = iden;
            this.idePrestb.ReadOnly=true;
        }
    }
}
