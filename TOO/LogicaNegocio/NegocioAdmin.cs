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

        public void darAltaCliente(String Dni, String name, long tfno, ModeloDominio.Tipo_cliente tipoCliente)
        {
            ModeloDominio.Cliente nuevoCliente = new ModeloDominio.Cliente(Dni,name,tfno,tipoCliente);
            Persistencia.BD.INSERTCliente(nuevoCliente);
        }

        public void darBajaCliente(ModeloDominio.Cliente c)
        {
            Persistencia.BD.DELETECliente(c);
        }

        public void obtenerPresupuestos(ModeloDominio.Cliente c)
        {
            Persistencia.BD.GETPresupuestos(Persistencia.BD.SELECTCliente(c));
        }

        public void obtenerInfoCliente(ModeloDominio.Cliente c)
        {
                System.Console.WriteLine("Cliente: "+ Persistencia.BD.SELECTCliente(c).getNombre());
                System.Console.WriteLine("Dni: " + Persistencia.BD.SELECTCliente(c).getDni());
                System.Console.WriteLine("Telefono: " + Persistencia.BD.SELECTCliente(c).getTfno());
                System.Console.WriteLine("Categoria: " + Persistencia.BD.SELECTCliente(c).getCategoria());
                System.Console.WriteLine("Presupuesto: " + Persistencia.BD.SELECTCliente(c).getPresupuesto());
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

        public void obtenerTodosVehiculos()
        {
            foreach (ModeloDominio.Vehiculo v in Persistencia.BD.GETVehiculos()) {
                obtenerInfoVehiculo(v);
            }
        }

        public void obtenerVehiculosSegundaMano()
        {
            foreach (ModeloDominio.Vehiculo v in Persistencia.BD.GETVehiculosSegMano())
            {
                obtenerInfoVehiculo(v);
            }
        }

        //------------------------------------------------------------------------------
        //Gestion de Presupuestos

        public void crearPresupuesto(string id_presupuesto, DateTime fecha_Realizacion, bool estado, ModeloDominio.Cliente c)
        {
            ModeloDominio.Presupuesto nuevoPresupuesto = new ModeloDominio.Presupuesto(id_presupuesto, fecha_Realizacion, estado, c);
            Persistencia.BD.INSERTPresupuesto(nuevoPresupuesto);
        }

        public void obtenerDatosClientePresupuesto(ModeloDominio.Presupuesto p)
        {
            obtenerInfoCliente(Persistencia.BD.SELECTPresupuesto(p).getCliente())
;        }

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

        public void obtenerTodosPresupuestosVehiculo(ModeloDominio.Vehiculo v) {
            foreach (ModeloDominio.Presupuesto p in Persistencia.BD.GETPresupuestoVehiculo(v)) {
                obtenerDatosClientePresupuesto(Persistencia.BD.SELECTPresupuesto(p));
            }
        }

        public void obtenerTodosPresupuestosPorEstado(bool stado)
        {
            foreach (ModeloDominio.Presupuesto p in Persistencia.BD.GETPresupuestoEstado(stado))
            {
                obtenerDatosClientePresupuesto(Persistencia.BD.SELECTPresupuesto(p));
            }
        }
    }
}
