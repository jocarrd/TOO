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
        ///<summary>
        ///Vvariable objeto de tipo NegocioAdmin del proyecto LogicaNegocio
        ///</summary>
        NegocioAdmin Administrador;

        ///<summary>
        ///Constructor del Form "Menu Principal"
        ///</summary>
        public MenuPrincipal(String nombreComercial, NegocioAdmin neg )
        {
            InitializeComponent();
            this.Administrador = new NegocioAdmin();
            this.Text = nombreComercial+": Gestión de concesionario";
        }

        ///<summary>
        ///Se referencia al pulsar cualquiera de las opciones de Cliente en el menuStrip dando lugar a distintas acciones
        ///</summary>
        private void clientesToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e) {

            Cliente cliente = new Cliente("");

            //Al dar en el botón "Alta" se le debe de pasar un DNI primero, y a partir de ahí, introcducir los demás datos del cliente
            if (e.ClickedItem.Text.Equals("Alta"))
            {
                ClienteDNI alta = new ClienteDNI(cliente);
                alta.ShowDialog();
                cliente=alta.debCliente();

                //Comprueba si existe un cliente con ese Dni en la base de datos
                if (Administrador.existeCliente(cliente.Dni)) {
                    if (MessageBox.Show("¿Quieres introducir otro?", "Existe un cliente con ese DNI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        this.tsmiAltaCliente.PerformClick();
                    }
                }
                else {
                    //Comprueba si se ha dado a cancelar en el formulario en el que se debe introducir el Dni
                    if (!cliente.Dni.Equals(""))
                    {
                        GestionClientes datos = new GestionClientes(cliente.Dni);
                        datos.ShowDialog();
                        cliente = datos.debCliente();


                        // Comprueba si se ha dado a cancelar en el formulario en el que se debe introducir los demás datos del cliente
                        if (!cliente.Dni.Equals(""))
                        {
                            Administrador.darAltaCliente(cliente);
                            MessageBox.Show("Se ha añadido a " + cliente.Nombre, "Añadido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                }
                
            }

            //Al dar en el botón "Baja" se le debe de pasar un DNI primero, y a partir de ahí, introcducir los demás datos del cliente
            if (e.ClickedItem.Text.Equals("Baja"))
            {
                ClienteDNI baja = new ClienteDNI(cliente);
                baja.ShowDialog();
                cliente = baja.debCliente();

                //Comprueba si ya existe un cliente con ese Dni en la base de datos
                if (!Administrador.existeCliente(cliente.Dni)) {
                    if (MessageBox.Show("¿Quieres introducir otro?", "No existe un cliente con ese DNI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                        this.tsmiBajaCliente.PerformClick();
                    }
                }
                else {
                    GestionClientes gestion = new GestionClientes(Administrador.seleccionarCliente(cliente));
                    gestion.ShowDialog();
                    cliente = gestion.debCliente();
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

            if (e.ClickedItem.Text.Equals("Búsqueda2"))
            {            
                BusquedaCliente gestion = new BusquedaCliente(Administrador.listarClientes());
                gestion.ShowDialog();       
            }

            if (e.ClickedItem.Text.Equals("Listar"))
            {
                ListadoClientes lis = new ListadoClientes(Administrador.listarClientes());
                lis.ShowDialog();
            }

            if (e.ClickedItem.Text.Equals("Recorrido uno a uno"))
            {
                RecorridoCliente gestion = new RecorridoCliente(Administrador.listarClientes());
                gestion.ShowDialog();
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
                        
                        if (!vehiculo.NumBastidor.Equals(""))
                        {
                            Administrador.darAltaVehiculo(vehiculo);
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

            if (e.ClickedItem.Text.Equals("Recorrido uno a uno"))
            {
                RecorridoVehiculo gestion = new RecorridoVehiculo(Administrador.listarVehiculos());
                gestion.ShowDialog();
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
                    if (!presupuesto.Id_presupuesto.Equals(""))
                    {
                        Boolean salir = false;
                        while (!salir && !presupuesto.Id_presupuesto.Equals("")) {
                            GestionPresupuestos datos = new GestionPresupuestos(presupuesto.Id_presupuesto);
                            datos.ShowDialog();
                            presupuesto = datos.devPresupuesto();

                            if (presupuesto.Id_presupuesto.Equals(""))
                            {
                                salir = true;
                            }
                            else
                            {
                                if (Administrador.existeCliente(presupuesto.Cliente.Dni))
                                {
                                    Cliente c = Administrador.seleccionarCliente(presupuesto.Cliente);  
                                    presupuesto.Cliente = c;
                                    c.añadirPresupuesto(presupuesto);
                                    Administrador.modificarCliente(c);
                                    salir = true;
                                }
                                else
                                {
                                    MessageBox.Show("No se ha encontrado al cliente especificado en la BD", "Añadido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }                           
                        }

                        if (!presupuesto.Id_presupuesto.Equals(""))
                        {                            
                            Administrador.crearPresupuesto(presupuesto, presupuesto.CocheList);
                            MessageBox.Show("Se ha añadido a " + presupuesto.Id_presupuesto, "Añadido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }

            if (e.ClickedItem.Text.Equals("Búsqueda"))
            {
                IdentificadorPresupuesto busqueda = new IdentificadorPresupuesto(presupuesto);
                busqueda.ShowDialog();
                presupuesto = busqueda.debPresupuesto();
                if (!Administrador.existePresupuesto(presupuesto.Id_presupuesto))
                {
                    if (MessageBox.Show("¿Quieres introducir otro?", "No existe un presupuesto con ese Id", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        this.tsmiAltaVehiculo.PerformClick();
                    }
                }
                else
                {
                    GestionPresupuestos datos = new GestionPresupuestos(Administrador.seleccionarPresupuesto(presupuesto));
                    datos.ShowDialog();
                }
            }

            if (e.ClickedItem.Text.Equals("Información Cliente"))
            {
                IdentificadorPresupuesto busqueda = new IdentificadorPresupuesto(presupuesto);
                busqueda.ShowDialog();
                presupuesto = busqueda.debPresupuesto();
                if (!Administrador.existePresupuesto(presupuesto.Id_presupuesto))
                {
                    if (MessageBox.Show("¿Quieres introducir otro?", "No existe un presupuesto con ese Id", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        this.tsmiAltaVehiculo.PerformClick();
                    }
                }
                else
                {
                    Presupuesto p=Administrador.seleccionarPresupuesto(presupuesto);
                    GestionClientes gestion = new GestionClientes(Administrador.seleccionarCliente(p.Cliente));
                    gestion.ShowDialog();
                }
            }

            if (e.ClickedItem.Text.Equals("Listado Completo"))
            {
                ListadoPresupuestosCompleto lis = new ListadoPresupuestosCompleto(Administrador.listarPresupuestos());
                lis.ShowDialog();
            }

            if (e.ClickedItem.Text.Equals("Recorrido uno a uno"))
            {
                RecorridoPresupuesto gestion = new RecorridoPresupuesto(Administrador.listarPresupuestos());
                gestion.ShowDialog();
            }
        }
    }
}
