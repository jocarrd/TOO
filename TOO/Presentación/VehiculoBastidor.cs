
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
using Persistencia;

namespace Presentación
{
    public partial class VehiculoBastidor : Form
    { 

        private Vehiculo vehiculo;

        public VehiculoBastidor(Vehiculo v)
        {
            InitializeComponent();
            this.vehiculo = v;
        }

        ///<summary>
        ///Asigna el contenido del textBox a la propiedad Numero Bastidor del Vehiculo
        ///</summary>
        private void botonAceptar_Click(object sender, EventArgs e)
        {
            this.vehiculo.NumBastidor = this.numBastb.Text;
            this.Close();
        }

        ///<summary>
        ///Devuelve el Vehiculo de esta clase
        ///</summary>
        public Vehiculo debVehiculo() {
            return this.vehiculo;
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            this.vehiculo.NumBastidor = "";
            this.Close();
        }
    }
}
