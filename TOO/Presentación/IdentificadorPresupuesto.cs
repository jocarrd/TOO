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

        public IdentificadorPresupuesto(Presupuesto p)
        {
            InitializeComponent();
            this.presupuesto = p;
        }

        ///<summary>
        ///Asigna el contenido del textBox a la propiedad IdPresupuesto del Presupuesto
        ///</summary>
        private void botonAceptar_Click(object sender, EventArgs e)
        {
            this.presupuesto.Id_presupuesto = this.IdePrestb.Text;
            this.Close();
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            this.presupuesto.Id_presupuesto = "";
            this.Close();
        }

        ///<summary>
        ///Devuelve el Presupuesto de esta clase
        ///</summary>
        public Presupuesto debPresupuesto() {
            return this.presupuesto;
        }
    }
}
