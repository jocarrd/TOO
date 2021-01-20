using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Persistencia
{
    public class BD
    {
        private static ClienteBD clientes;
        private static PresupuestoBD presupuestos;
        private static VehiculoBD vehiculos;
        private static VehiculoNuevo_extraBD vehiculosNuevos;
        private static VehiculoSegunda_manoBD vehiculosSegundaMano;
        private static PresupuestoVehiculoBD presupuestosVehiculos;

        private BD() { }

        //-------------------------------------------------------------------------PresupuestoVehiculo-------------------------------------------------------------------

        public static Persistencia.PresupuestoVehiculoBD PresupuestosVehiculos
        {
            get
            {
                if (presupuestosVehiculos == null)
                    presupuestosVehiculos = new Persistencia.PresupuestoVehiculoBD();
                return presupuestosVehiculos;
            }
        }

        public static bool INSERTPresupuestoVehiculo(PresupuestoVehiculoDato c)
        {
           

            if (BD.presupuestosVehiculos.Contains(c))
            {
                return false;

            }
            else
            {
                return true;
            }


        }

        public static PresupuestoVehiculoDato SELECTPresupuestoVehiculo(PresupuestoVehiculoDato c)
        {
            IEnumerable<PresupuestoVehiculoDato> PV = BD.presupuestosVehiculos.Select(presupuestosVehiculos => c);

            if (PV == null)
            {
                return null;
            }
            else
            {
                return PV.First();
            }
        }

        public static bool DELETEPresupuestoVehiculo(PresupuestoVehiculoDato c)
        {
            return BD.presupuestosVehiculos.Remove(c);
        }

        public static bool UPDATEPresupuestoVehiculo(PresupuestoVehiculoDato c)
        {
            if (BD.DELETEPresupuestoVehiculo(c))
            {
                return BD.INSERTPresupuestoVehiculo(c);


            }
            return false;
        }

        public static List<PresupuestoVehiculoDato> GETPresupuestosVehiculosDatos()
        {
            return BD.presupuestosVehiculos.ToList();
        }


        public static List<PresupuestoVehiculoDato> GETPresupuestosVehiculosDatos(ModeloDominio.Vehiculo v)
        {
            List<PresupuestoVehiculoDato> resultado = new List<PresupuestoVehiculoDato>();
            foreach (PresupuestoVehiculoDato vd  in BD.presupuestosVehiculos)
            {
                Clave c = (Clave)vd.GetClave();
                if (c.GetSegunda().Equals(v.getNumBastidor()))
                {
                    resultado.Add(vd);
                }
            }
            return resultado;
        }




        //-------------------------------------------------------------------------CLIENTE-------------------------------------------------------------------
        public static ClienteBD Clientes
        {
            get
            {
                if (clientes == null)
                    clientes = new ClienteBD();
                return clientes;
            }
        }
        public static bool INSERTCliente(ModeloDominio.Cliente c)
        {
            if (BD.clientes.Contains(c))
            {
                return false;
            }
            else
            {
                BD.clientes.Add(c);
                return true;
            }
        }
        public static ModeloDominio.Cliente SELECTCliente(ModeloDominio.Cliente c)
        {
            IEnumerable<ModeloDominio.Cliente> cliente = BD.clientes.Select(clientes => c);

            if (cliente == null)
            {
                return null;
            }
            else
            {
                return cliente.First();
            }
        }
        
        public static Boolean existe(String dni)
        {
            if (BD.clientes.Contains(dni))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool DELETECliente(ModeloDominio.Cliente c)
        {
            return BD.clientes.Remove(c);
        }
        public static bool UPDATECliente(ModeloDominio.Cliente c)
        {
            if (BD.DELETECliente(c))
            {
                return BD.INSERTCliente(c);
            }
            return false;
        }

        

        //--------------------------------------------------------------------------------------------------------------------------------------------        
        //-------------------------------------------------------------------------PRESUPUESTO--------------------------------------------------------
        public static PresupuestoBD Presupuestos
        {
            get
            {
                if (presupuestos == null)
                    presupuestos = new PresupuestoBD();
                return presupuestos;
            }
        }
        public static bool INSERTPresupuesto(ModeloDominio.Presupuesto p)
        {
            if (BD.presupuestos.Contains(p))
            {
                return false;
            }
            else
            {
                BD.presupuestos.Add(p);
                return true;
            }
           
        }

        public static ModeloDominio.Presupuesto SELECTPresupuesto(ModeloDominio.Presupuesto p)
        {

            IEnumerable<ModeloDominio.Presupuesto> presupuesto = BD.presupuestos.Select(presupuestos => p);

            if (presupuesto == null)
            {
                return null;
            }
            else
            {
                return presupuesto.First();
            }
        }

        public static bool DELETEPresupuesto(ModeloDominio.Presupuesto p)
        {
            return BD.presupuestos.Remove(p);
        }

        public static bool UPDATEPresupuesto(ModeloDominio.Presupuesto p)
        {

            if (BD.DELETEPresupuesto(p))
            {
                return BD.INSERTPresupuesto(p);
            }
            return false;

        }

        public static List<ModeloDominio.Presupuesto> GETPresupuestos()
        {
            return BD.presupuestos.ToList();
        }

        public static List<ModeloDominio.Presupuesto> GETPresupuestosCliente(ModeloDominio.Cliente c)
        {
            List<ModeloDominio.Presupuesto> resultado = new List<ModeloDominio.Presupuesto>();
            foreach(ModeloDominio.Presupuesto p in BD.presupuestos)
            {
                ModeloDominio.Cliente cast = (ModeloDominio.Cliente)p.getCliente();
                if (cast.getDni().Equals(c.getDni()))
                {
                    resultado.Add(p);
                }
            }
            return resultado;
        }


        //--------------------------------------------------------------------------------------------------------------------------------------------        
        //-------------------------------------------------------------------------VEHICULO-----------------------------------------------------------       
        public static VehiculoBD Vehiculos
        {
            get
            {
                if (vehiculos == null)
                    vehiculos = new VehiculoBD();
                return vehiculos;
            }
        }
        public static bool INSERTVehiculo(ModeloDominio.Vehiculo v)
        {
            BD.Vehiculos.Add(v);
            return true;
        }

        public static ModeloDominio.Vehiculo SELECTVehiculo(ModeloDominio.Vehiculo v)
        {
            IEnumerable<ModeloDominio.Vehiculo> vehiculo = BD.vehiculos.Select(vehiculos => v);
            if (vehiculo == null)
            {
                return null;
            }
            else
            {
                return vehiculo.First();
            }
        }

        public static bool DELETEVehiculo(ModeloDominio.Vehiculo v)
        {
            return BD.vehiculos.Remove(v);
        }

        public static bool UPDATEVehiculo(ModeloDominio.Vehiculo v)
        {
            if (BD.DELETEVehiculo(v))
            {
                return BD.INSERTVehiculo(v);
            }
            return false;
        }

        public static List<ModeloDominio.Vehiculo > GETVehiculos()
        {
            return BD.vehiculos.ToList();
        }

        public static List<ModeloDominio.SegundaMano> GETVehiculosSegundaMano()
        {
            return BD.vehiculosSegundaMano.ToList();
        }

        public static List<ModeloDominio.Nuevo> GETVehiculosNuevo()
        {
            return BD.vehiculosNuevos.ToList();
        }
    }
}