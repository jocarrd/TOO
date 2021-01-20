using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class NegocioAdmin
    { 
        //-------------------------------------------------------------------------------
        //Gestion de Clientes

        public static void darAltaCliente(ModeloDominio.Cliente nuevoCliente)
        {
            Persistencia.BD.INSERTCliente(nuevoCliente);
        }

        public static void darBajaCliente(ModeloDominio.Cliente c)
        {
            Persistencia.BD.DELETECliente(c);
        }

        public static void obtenerPresupuestosCliente(ModeloDominio.Cliente c)
        {
            Persistencia.BD.GETPresupuestosCliente(Persistencia.BD.SELECTCliente(c));
        }

        public static ModeloDominio.Cliente obtenerCliente(String dni)
        {
            ModeloDominio.Cliente vacio = new ModeloDominio.Cliente(dni,"",0,ModeloDominio.Tipo_cliente.Media);
            return Persistencia.BD.SELECTCliente(vacio);
        }

        //------------------------------------------------------------------------------
        //Gestion de Vehiculos

        public void darAltaVehiculo(string numBastidor, string marca, string modelo, int potencia, double pvp)
        {
            ModeloDominio.Vehiculo nuevoVehiculo = new ModeloDominio.Vehiculo(numBastidor,marca,modelo,potencia,pvp);
            Persistencia.BD.INSERTVehiculo(nuevoVehiculo);
        }

        public void darBajaVehiculo(ModeloDominio.Vehiculo v)
        {
            Persistencia.BD.DELETEVehiculo(v);
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
            return Persistencia.BD.GETVehiculos();
        }

        public List<ModeloDominio.SegundaMano> obtenerVehiculosSegundaMano()
        {
            return Persistencia.BD.GETVehiculosSegundaMano();
        }

        public List<ModeloDominio.Nuevo> obtenerVehiculosNuevos()
        {
            return Persistencia.BD.GETVehiculosNuevo();
        }

        //------------------------------------------------------------------------------
        //Gestion de Presupuestos

        public void crearPresupuesto(string id_presupuesto, DateTime fecha_Realizacion, bool estado, ModeloDominio.Cliente c)
        {
            ModeloDominio.Presupuesto nuevoPresupuesto = new ModeloDominio.Presupuesto(id_presupuesto, fecha_Realizacion, estado, c);
            Persistencia.BD.INSERTPresupuesto(nuevoPresupuesto);
        }

        /*
        public void obtenerDatosClientePresupuesto(ModeloDominio.Presupuesto p)
        {
            obtenerInfoCliente(Persistencia.BD.SELECTPresupuesto(p).getCliente())
;       }
        */
        public void obtenerDatosVehiculoPresupuesto(ModeloDominio.Presupuesto p)
        {
            foreach (ModeloDominio.Vehiculo v in Persistencia.BD.SELECTPresupuesto(p).getVehiculos()) { 
                obtenerInfoVehiculo(v);
            }
        }

        public bool obtenerConfirmacionPresupuesto(ModeloDominio.Presupuesto p)
        {
            return obtenerEstadoPresupueto(p);
        }

        public bool obtenerEstadoPresupueto(ModeloDominio.Presupuesto p)
        {
            return Persistencia.BD.SELECTPresupuesto(p).getEstado();
        }

        public void eliminarPresupuesto(ModeloDominio.Presupuesto p)
        {
            Persistencia.BD.DELETEPresupuesto(p);
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
        /*
        public void obtenerTodosPresupuestosPorEstado(bool estado)
        {
            foreach (ModeloDominio.Presupuesto p in Persistencia.BD.GETPresupuestosVehiculosDatos(estado))
            {
                obtenerDatosClientePresupuesto(Persistencia.BD.SELECTPresupuesto(p));
            }
        }*/
    }
}
