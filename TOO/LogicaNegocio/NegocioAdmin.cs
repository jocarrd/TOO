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

        public void darAltaCliente(string dni, string nombre, long tfno, ModeloDominio.Tipo_cliente categoria)
        {
            ModeloDominio.Cliente nuevoCliente = new ModeloDominio.Cliente(dni,nombre,tfno,categoria);
            PersistenciaCliente.Añadir(nuevoCliente);
        }

        public bool darBajaCliente(ModeloDominio.Cliente c)
        {
            return PersistenciaCliente.Eliminar(c);
        }

        public Cliente seleccionarCliente(String dni)
        {
            return PersistenciaCliente.seleccionarCliente(dni);
        }

        public Boolean existeCliente(String dni)
        {
            return PersistenciaCliente.existeCliente(dni);
        }

        public List<ModeloDominio.Cliente> listarClientes()
        {
            return PersistenciaCliente.getClientes();
        }

        public List<ModeloDominio.Presupuesto> obtenerPresupuestosCliente(ModeloDominio.Cliente c)
        {
            return PersistenciaCliente.GETPresupuestosCliente(c);
        }

        //------------------------------------------------------------------------------
        //Gestion de Vehiculos

        public void darAltaVehiculo(ModeloDominio.Vehiculo nuevoVehiculo)
        {
            PersistenciaVehiculo.Añadir(nuevoVehiculo);
        }

        public bool darBajaVehiculo(ModeloDominio.Vehiculo v)
        {
            return PersistenciaVehiculo.Eliminar(v);
        }

        public Boolean existeVehiculo(String bas)
        {
            return PersistenciaVehiculo.existeVehiculo(bas);
        }

        public void obtenerInfoVehiculo(ModeloDominio.Vehiculo v)
        {
            System.Console.WriteLine("Numero de Bastidor: " + v.getNumBastidor());
            System.Console.WriteLine("Marca: " + v.getMarca());
            System.Console.WriteLine("Modelo: " + v.getModelo());
            System.Console.WriteLine("Potencia: " + v.getPotencia());
            System.Console.WriteLine("Precio: " + v.getPrecio());
        }

        public List<ModeloDominio.Vehiculo> obtenerTodosVehiculos()
        {
            return PersistenciaVehiculo.GetVehiculos();
        }

        /*
        public List<ModeloDominio.SegundaMano> obtenerVehiculosSegundaMano()
        {
            return Persistencia.BD.GETVehiculosSegundaMano();
        }

        public List<ModeloDominio.Nuevo> obtenerVehiculosNuevos()
        {
            return Persistencia.BD.GETVehiculosNuevo();
        }
        */
        //------------------------------------------------------------------------------
        //Gestion de Presupuestos

        public void crearPresupuesto(string id_presupuesto, int cantidad, DateTime fecha_Realizacion, bool estado, ModeloDominio.Cliente c)
        {
            ModeloDominio.Presupuesto nuevoPresupuesto = new ModeloDominio.Presupuesto(id_presupuesto, cantidad,fecha_Realizacion, estado, c);
            PersistenciaPresupuesto.añadir(nuevoPresupuesto);
        }

        public bool eliminarPresupuesto(ModeloDominio.Presupuesto p)
        {
            return PersistenciaPresupuesto.eliminar(p);
        }

        public List<ModeloDominio.Presupuesto> obtenerTodosPresupuestos()
        {
            return PersistenciaPresupuesto.getPresupuestos();
        }

        public List<ModeloDominio.Presupuesto> getPresupuestosCliente(ModeloDominio.Cliente c)
        {
            return PersistenciaPresupuesto.getPresupuestosCliente(c);
        }

        public Boolean existePresupuesto(String iden)
        {
            return PersistenciaPresupuesto.existePresupuesto(iden);
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
