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
        private BD() { }

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
            BD.clientes.Add(c);
            return true;
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
            BD.presupuestos.Add(p);
            return true;
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
    }
}