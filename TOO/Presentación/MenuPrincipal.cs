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
            this.Administrador = new NegocioAdmin();
            this.Text = nombreComercial+": Gestión de concesionario";
        }

        private void clientesToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e) {

            Cliente cliente = new Cliente("");

            if (e.ClickedItem.Text.Equals("Alta"))
            {
                ClienteDNI alta = new ClienteDNI(cliente);
                alta.ShowDialog();
                cliente=alta.debCliente();
                if (Administrador.existeCliente(cliente.Dni)) {
                    if (MessageBox.Show("¿Quieres introducir otro?", "Existe un cliente con ese DNI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        this.tsmiAltaCliente.PerformClick();
                    }
                }
                else {
                    if (!cliente.Dni.Equals(""))
                    {
                        GestionClientes datos = new GestionClientes(cliente.Dni);
                        datos.ShowDialog();
                        cliente = datos.debCliente();
                        Administrador.darAltaCliente(cliente);
                        if (!cliente.Dni.Equals(""))
                        {
                            MessageBox.Show("Se ha añadido a " + cliente.Nombre, "Añadido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                }
                
            }

            if (e.ClickedItem.Text.Equals("Baja"))
            {
                ClienteDNI baja = new ClienteDNI(cliente);
                baja.ShowDialog();
                cliente = baja.debCliente();
                if (!Administrador.existeCliente(cliente.Dni)) {
                    if (MessageBox.Show("¿Quieres introducir otro?", "No existe un cliente con ese DNI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                        this.tsmiBajaCliente.PerformClick();
                    }
                }
                else {
                    GestionClientes gestion = new GestionClientes(Administrador.seleccionarCliente(cliente));
                    gestion.ShowDialog();
                    if (MessageBox.Show("Está seguro que desea dar de baja a " + cliente.Nombre + " ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                        Administrador.darBajaCliente(cliente);
                        MessageBox.Show("Cliente " + cliente.Nombre + " eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    } 
                }
            }

            if (e.ClickedItem.Text.Equals("Búsqueda"))
            {
                ClienteDNI busqueda = new ClienteDNI(cliente);
                busqueda.ShowDialog();
                cliente = busqueda.debCliente();
                if (!Administrador.existeCliente(cliente.Dni))
                {
                    if (MessageBox.Show("¿Quieres introducir otro?", "No existe un cliente con ese DNI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        this.tsmiBusquedaCliente.PerformClick();
                    }
                }
                else
                {
                    GestionClientes gestion = new GestionClientes(Administrador.seleccionarCliente(cliente));
                    gestion.ShowDialog();

                }
            }

            if (e.ClickedItem.Text.Equals("Listar"))
            {
                ListadoClientes lis = new ListadoClientes(Administrador.listarClientes());
                lis.ShowDialog();
            }

            if (e.ClickedItem.Text.Equals("Listado Completo"))
            {
                
            }
        }

        private void vehiculosToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Vehiculo vehiculo = new Vehiculo("");

            if (e.ClickedItem.Text.Equals("Alta"))
            {
                VehiculoBastidor alta = new VehiculoBastidor(vehiculo);
                alta.ShowDialog();
                vehiculo = alta.debVehiculo();
                if (Administrador.existeVehiculo(vehiculo.NumBastidor))
                {
                    if (MessageBox.Show("¿Quieres introducir otro?", "Existe un vehiculo con ese Numero de Bastidor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        this.tsmiAltaVehiculo.PerformClick();
                    }
                }
                else
                {
                    if (!vehiculo.NumBastidor.Equals(""))
                    {
                        GestionVehiculos datos = new GestionVehiculos(vehiculo.NumBastidor);
                        datos.ShowDialog();
                        vehiculo = datos.debVehiculo();
                        Administrador.darAltaVehiculo(vehiculo);
                        if (!vehiculo.NumBastidor.Equals(""))
                        {
                            MessageBox.Show("Se ha añadido a " + vehiculo.NumBastidor, "Añadido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                }

            }

            if (e.ClickedItem.Text.Equals("Baja"))
            {
                VehiculoBastidor baja = new VehiculoBastidor(vehiculo);
                baja.ShowDialog();
                vehiculo = baja.debVehiculo();
                if (!Administrador.existeVehiculo(vehiculo.NumBastidor))
                {
                    if (MessageBox.Show("¿Quieres introducir otro?", "No existe un vehiculo con ese Numero de Bastidor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        this.tsmiAltaVehiculo.PerformClick();
                    }
                }
                else 
                {
                    GestionVehiculos datos = new GestionVehiculos(Administrador.seleccionarVehiculo(vehiculo));
                    datos.ShowDialog();
                    vehiculo = datos.debVehiculo();
                    if (MessageBox.Show("Está seguro que desea dar de baja a " + vehiculo.NumBastidor + " ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Administrador.darBajaVehiculo(vehiculo);
                        MessageBox.Show("Vehiculo " + vehiculo.NumBastidor + " eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                }
            }

           if (e.ClickedItem.Text.Equals("Búsqueda"))
           {
                VehiculoBastidor busqueda = new VehiculoBastidor(vehiculo);
                busqueda.ShowDialog();
                vehiculo = busqueda.debVehiculo();
                if (!Administrador.existeVehiculo(vehiculo.NumBastidor))
                {
                    if (MessageBox.Show("¿Quieres introducir otro?", "No existe un vehiculo con ese Numero de Bastidor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        this.tsmiAltaVehiculo.PerformClick();
                    }
                }
                else
                {
                    GestionVehiculos datos = new GestionVehiculos(Administrador.seleccionarVehiculo(vehiculo));
                    datos.ShowDialog();
                }
            }
            if (e.ClickedItem.Text.Equals("Listado Completo"))
            {
                ListadoVehiculosCompleto l = new ListadoVehiculosCompleto(Administrador.listarVehiculos());
                l.ShowDialog();
            }

        }
        private void presupuestosToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Presupuesto presupuesto = new Presupuesto("");

            if (e.ClickedItem.Text.Equals("Crear nuevo"))
            {
                IdentificadorPresupuesto crear = new IdentificadorPresupuesto(presupuesto);
                crear.ShowDialog();
                presupuesto = crear.debPresupuesto();
                if (Administrador.existePresupuesto(presupuesto.Id_presupuesto))
                {
                    if (MessageBox.Show("¿Quieres introducir otro?", "Existe un presupuesto con ese Id", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        this.tsmiCrearNuevo.PerformClick();
                    }
                }
                else 
                {
                    GestionPresupuestos datos = new GestionPresupuestos(presupuesto.Id_presupuesto);
                    datos.ShowDialog();
                    presupuesto = datos.devPresupuesto();
                    Administrador.crearPresupuesto(presupuesto,presupuesto.CocheList);
                }
            }
        }

        private void listadoCompletoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ListadoPresupuestosCompleto lis = new ListadoPresupuestosCompleto(Administrador.obtenerTodosPresupuestos());
            lis.ShowDialog();
        }
    }
}
