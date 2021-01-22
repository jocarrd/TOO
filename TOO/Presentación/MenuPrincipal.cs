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
    public partial class MenuPrincipal : Form
    {
        private NegocioAdmin neg;

        public MenuPrincipal(String nombreComercial, NegocioAdmin neg )
        {
            InitializeComponent();
            this.Text = nombreComercial+": Gestión de concesionario";
            this.neg = neg;
        }

        private void clientesToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e) {
            if (e.ClickedItem.Text.Equals("Alta"))
            {
                ClienteDNI cliente = new ClienteDNI("alta",neg);
                cliente.ShowDialog();
            }

            if (e.ClickedItem.Text.Equals("Baja"))
            {
                ClienteDNI cliente = new ClienteDNI("baja",neg);
                cliente.ShowDialog();
            }

            if (e.ClickedItem.Text.Equals("Búsqueda"))
            {
                ClienteDNI cliente = new ClienteDNI("búsqueda",neg);
                cliente.ShowDialog();
            }
        }

        private void vehiculosToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
           
            if (e.ClickedItem.Text.Equals("Alta"))
             {
                 VehiculoBastidor vehiculo = new VehiculoBastidor("alta", neg);
                 vehiculo.ShowDialog();
             }

            if (e.ClickedItem.Text.Equals("Baja"))
            {
                VehiculoBastidor vehiculo = new VehiculoBastidor("baja", neg);
                vehiculo.ShowDialog();
            }

           if (e.ClickedItem.Text.Equals("Búsqueda"))
           {
                VehiculoBastidor vehiculo = new VehiculoBastidor("búsqueda", neg);
                vehiculo.ShowDialog();
           }
        }
        private void presupuestosToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text.Equals("Crear nuevo"))
            {
                IdentificadorPresupuesto vehiculo = new IdentificadorPresupuesto("crear", neg);
                vehiculo.ShowDialog();
            }

            if (e.ClickedItem.Text.Equals("Búsqueda"))
            {
                VehiculoBastidor vehiculo = new VehiculoBastidor("búsqueda", neg);
                vehiculo.ShowDialog();
            }
        }
        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListadoClientes lis = new ListadoClientes(neg);
            lis.ShowDialog();

        }

        
    }
}
