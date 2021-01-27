
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

        public VehiculoBastidor()
        {
            InitializeComponent();
            this.botonAceptar.Click += botonAceptarAlta_Click;
        }

        public VehiculoBastidor(Vehiculo v)
        {
            InitializeComponent();
            this.vehiculo = v;
            this.botonAceptar.Click += botonAceptarBajaBusqueda_Click;

        }

        private void botonAceptarAlta_Click(object sender, EventArgs e)
        {
            GestionVehiculos nuevo = new GestionVehiculos(this.numBastb.Text, this.vehiculo);
            nuevo.Text = "Alta de un vehiculo";
            nuevo.ShowDialog();
            if (PersistenciaVehiculo.Existe(this.vehiculo.NumBastidor))
            {
                if (MessageBox.Show("¿Quierres introducir otro?", "Ya existe un cliente con ese DNI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.numBastb.Clear();
                    this.numBastb.Focus();
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void botonAceptarBajaBusqueda_Click(object sender, EventArgs e)
        {
            if (!PersistenciaVehiculo.Existe(this.numBastb.Text))
            {
                if (MessageBox.Show("¿Quierres introducir otro?", "No existe un vwhiculo con ese bastidor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
                GestionVehiculos mostrar = new GestionVehiculos(PersistenciaVehiculo.Buscar(new Vehiculo(this.numBastb.Text)));
                mostrar.ShowDialog();
                this.Close();
            }
        }

        public Vehiculo vehiculoNuevo() {
            return this.vehiculo;
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
