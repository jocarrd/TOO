using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;
using ModeloDominio;

namespace LogicaNegocio
{
    public class NegocioAdmin
    { 
        //-------------------------------------------------------------------------------
        //Gestion de Clientes

        public void darAltaCliente(Cliente c)
        {
            PersistenciaCliente.Añadir(c);
        }

        public bool darBajaCliente(ModeloDominio.Cliente c)
        {
            return PersistenciaCliente.Eliminar(c);
        }

        public Cliente seleccionarCliente(Cliente c)
        {
            return PersistenciaCliente.Buscar(c);
        }

        public bool modificarCliente(Cliente c)
        {
            return PersistenciaCliente.Modificar(c);
        }

        public Boolean existeCliente(String dni)
        {
            return PersistenciaCliente.Existe(dni);
        }

        public List<Cliente> listarClientes()
        {
            return PersistenciaCliente.GETClientes();
        }

        public List<Presupuesto> obtenerPresupuestosPorCliente(Cliente c)
        {
            return PersistenciaCliente.GETPresupuestosCliente(c);
        }

        //------------------------------------------------------------------------------
        //Gestion de Vehiculos

        public void darAltaVehiculo(Vehiculo nuevoVehiculo)
        {
            PersistenciaVehiculo.Añadir(nuevoVehiculo);
        }

        public bool darBajaVehiculo(Vehiculo v)
        {
            return PersistenciaVehiculo.Eliminar(v);
        }

        public Boolean existeVehiculo(String bas)
        {
            return PersistenciaVehiculo.Existe(bas);
        }

        public Vehiculo seleccionarVehiculo(Vehiculo v)
        {
            return PersistenciaVehiculo.Buscar(v);
        }

        public List<Vehiculo> listarVehiculos()
        {
            return PersistenciaVehiculo.GETVehiculos();
        }

        //------------------------------------------------------------------------------
        //Gestion de Presupuestos

        public void crearPresupuesto(Presupuesto p, List<Vehiculo> vehiculos)
        {
            foreach(Vehiculo v in vehiculos)
            {
                p.CocheList.Add(v);
                PersistenciaPresupuestoVehiculo.Añadir(new PresupuestoVehiculoDato(new Clave(p.Id_presupuesto,v.NumBastidor)));
            }
            PersistenciaPresupuesto.Añadir(p);
        }

        public bool eliminarPresupuesto(Presupuesto p)
        {
            return PersistenciaPresupuesto.Eliminar(p);
        }

        public Presupuesto seleccionarPresupuesto(Presupuesto p)
        {
            return PersistenciaPresupuesto.Buscar(p);
        }

        public List<Presupuesto> obtenerTodosPresupuestos()
        {
            return PersistenciaPresupuesto.GETPresupuestos();
        }

        public Boolean existePresupuesto(String iden)
        {
            return PersistenciaPresupuesto.Existe(iden);
        }

        /*
        public void obtenerDatosClientePresupuesto(ModeloDominio.Presupuesto p)
        {
            obtenerInfoCliente(Persistencia.BD.SELECTPresupuesto(p).getCliente())
;       }
        
        public void obtenerDatosVehiculoPresupuesto(ModeloDominio.Presupuesto p)
        {
            foreach (ModeloDominio.Vehiculo v in Persistencia.BD.SELECTPresupuesto(p).getVehiculos()) { 
                obtenerInfoVehiculo(v);
            }
        }
       

        public void obtenerDatosPresupuesto(ModeloDominio.Presupuesto p)
        {
            System.Console.WriteLine("ID: " + p.getId_presupuesto());
            System.Console.WriteLine("Fecha Relizacion: " + p.getFecha_Realizacion());
            System.Console.WriteLine("Estado: " + p.getEstado());
            System.Console.WriteLine("Cliente: " + p.getCliente());
            System.Console.WriteLine("Vehiculos: " + p.getVehiculos());
        }


        //Seguramente de fallo
        public List<ModeloDominio.Presupuesto> obtenerTodosPresupuestosVehiculo(ModeloDominio.Vehiculo v) {
            System.Collections.IList list = Persistencia.BD.GETPresupuestosVehiculosDatos(v);
            List<ModeloDominio.Presupuesto> listaP = new List<ModeloDominio.Presupuesto>();
            for (int i = 0; i < list.Count; i++) {
                ModeloDominio.Presupuesto p = (ModeloDominio.Presupuesto)list[i];
                listaP.Add(p);
            }
            return listaP;
        }
        
        public void obtenerTodosPresupuestosPorEstado(bool estado)
        {
            foreach (ModeloDominio.Presupuesto p in Persistencia.BD.GETPresupuestosVehiculosDatos(estado))
            {
                obtenerDatosClientePresupuesto(Persistencia.BD.SELECTPresupuesto(p));
            }
        }*/
    }
}
