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
using Persistencia;
using ModeloDominio;

namespace Presentación
{
    public partial class MenuPrincipal : Form
    {
        NegocioAdmin Administrador;

        public MenuPrincipal(String nombreComercial, NegocioAdmin neg )
        {
            InitializeComponent();
            this.Text = nombreComercial+": Gestión de concesionario";
        }

        private void clientesToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e) {

            Cliente cliente = new Cliente("");

            if (e.ClickedItem.Text.Equals("Alta"))
            {
                ClienteDNI alta = new ClienteDNI(cliente);
                alta.ShowDialog();
                cliente=alta.clienteNuevo();
                if (Administrador.existeCliente(cliente.Dni)) {
                    if (MessageBox.Show("¿Quierres introducir otro?", "Existe un cliente con ese DNI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        this.altaToolStripMenuItem.PerformClick();
                    }
                }
                else {
                    GestionClientes datos = new GestionClientes(cliente.Dni);
                    datos.ShowDialog();
                    cliente = datos.debCliente();
                    Administrador.darAltaCliente(cliente); 
                }
                
            }

            if (e.ClickedItem.Text.Equals("Baja"))
            {
                ClienteDNI baja = new ClienteDNI(cliente);
                baja.ShowDialog();
                cliente = baja.clienteNuevo();
                if (!Administrador.existeCliente(cliente.Dni)) {
                    if (MessageBox.Show("¿Quierres introducir otro?", "No existe un cliente con ese DNI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                        this.bajaToolStripMenuItem.PerformClick();
                    }
                }
                else {
                    GestionClientes gestion = new GestionClientes(Administrador.seleccionarCliente(cliente));
                    gestion.ShowDialog();
                    if (MessageBox.Show("Está seguro que desea dar de baja a " + cliente.Nombre + " ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                        Administrador.darBajaCliente(cliente);
                        MessageBox.Show("Cliente " + cliente.Nombre + " eliminado", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    } 
                }
            }

            if (e.ClickedItem.Text.Equals("Búsqueda"))
            {
                ClienteDNI busqueda = new ClienteDNI(cliente);
                busqueda.ShowDialog();
                cliente = busqueda.clienteNuevo();
                if (!Administrador.existeCliente(cliente.Dni))
                {
                    if (MessageBox.Show("¿Quierres introducir otro?", "No existe un cliente con ese DNI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        this.bajaToolStripMenuItem.PerformClick();
                    }
                }
                else
                {
                    GestionClientes gestion = new GestionClientes(Administrador.seleccionarCliente(cliente));
                    gestion.ShowDialog();
                }
            }
        }

        private void vehiculosToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Vehiculo vehiculo = new Vehiculo("");

            if (e.ClickedItem.Text.Equals("Alta"))
             {
                VehiculoBastidor alta = new VehiculoBastidor();
                alta.ShowDialog();
                vehiculo = alta.vehiculoNuevo();
                Administrador.darAltaVehiculo(vehiculo);
            }

            if (e.ClickedItem.Text.Equals("Baja"))
            {
                VehiculoBastidor baja = new VehiculoBastidor(vehiculo);
                baja.ShowDialog();
                if (MessageBox.Show("Está seguro que desea dar de baja a " + vehiculo.NumBastidor +" ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Administrador.darBajaVehiculo(vehiculo);
                    MessageBox.Show("Cliente " + vehiculo.NumBastidor + " eliminado", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                }
            }

           if (e.ClickedItem.Text.Equals("Búsqueda"))
           {
                VehiculoBastidor busqueda = new VehiculoBastidor(vehiculo);
                busqueda.ShowDialog();
           }


        }
        private void presupuestosToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text.Equals("Crear nuevo"))
            {
                IdentificadorPresupuesto vehiculo = new IdentificadorPresupuesto();
                vehiculo.ShowDialog();
            }

            if (e.ClickedItem.Text.Equals("Búsqueda"))
            {
                IdentificadorPresupuesto vehiculo = new IdentificadorPresupuesto();
                vehiculo.ShowDialog();
            }
        }
        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListadoClientes lis = new ListadoClientes(Administrador.listarClientes());
            lis.ShowDialog();

        }

        private void listarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ListadoVehiculosCompleto l = new ListadoVehiculosCompleto(Administrador.listarVehiculos());
            l.ShowDialog();
        }

        private void listadoCompletoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ListadoPresupuestosCompleto lis = new ListadoPresupuestosCompleto(Administrador.obtenerTodosPresupuestos());
            lis.ShowDialog();
        }
    }
}
