using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOO
{
    public class BD
    {
        private static ClienteBD clientes;
        private static PresupuestoBD presupuestos;
        private static VehiculoBD vehiculos;
        private BD() { }
        public static ClienteBD Clientes
        {
            get
            {
                if (clientes == null)
                    clientes = new ClienteBD();
                return clientes;
            }
        }
        public static bool INSERTCliente(Negocio.Cliente c)
        {
            BD.clientes.Add(c);
            return true;
        }

        public static PresupuestoBD Presupuestos
        {
            get
            {
                if (presupuestos == null)
                    presupuestos = new PresupuestoBD();
                return presupuestos;
            }
        }
        public static bool INSERTPresupuesto(Negocio.Presupuesto p)
        {
            BD.presupuestos.Add(p);
            return true;
        }


        public static VehiculoBD Vehiculos
        {
            get
            {
                if (vehiculos == null)
                    vehiculos = new VehiculoBD();
                return vehiculos;
            }
        }
        public static bool INSERTVehiculo(Negocio.Vehiculo v)
        {
            BD.Vehiculos.Add(v);
            return true;
        }



        public static Negocio.Cliente SELECTCliente(Negocio.Cliente c)
        {
            IEnumerable<Negocio.Cliente> cliente = BD.clientes.Select(clientes => c);

            if (cliente == null)
            {
                return null;
            }
            else
            {
                return cliente.First();
            }
        }


        public static Negocio.Presupuesto SELECTPresupuesto(Negocio.Presupuesto p) {

            IEnumerable<Negocio.Presupuesto> presupuesto = BD.presupuestos.Select(presupuestos => p);

            if (presupuesto == null)
            {
                return null;
            }
            else
            {
                return presupuesto.First();
            }



        }

        public static Negocio.Vehiculo SELECTVehiculo(Negocio.Vehiculo v)
        {
            IEnumerable<Negocio.Vehiculo> vehiculo = BD.vehiculos.Select(vehiculos => v);
            if (vehiculo == null)
            {
                return null;
            }
            else
            {
                return vehiculo.First();
            }
        }



        public static bool DELETECliente(Negocio.Cliente c)
        {
           return  BD.clientes.Remove(c);
        }

        public static bool DELETEPresupuesto(Negocio.Presupuesto p)
        {
            return BD.presupuestos.Remove(p);
        }



        public static bool DELETEVehiculo(Negocio.Vehiculo v)
        {
            return BD.vehiculos.Remove(v);
        }



        public static bool UPDATECliente(Negocio.Cliente c)
        {
           if(BD.DELETECliente(c))
            {
                  return BD.INSERTCliente(c);
                

            }

            return false;


            
        }

        public static  bool UPDATEPresupuesto (Negocio.Presupuesto p)
        {

            if (BD.DELETEPresupuesto(p))
            {
                return BD.INSERTPresupuesto(p);
            }
            return false;

        }



        public static bool UPDATEVehiculo( Negocio.Vehiculo v)
        {
            if (BD.DELETEVehiculo(v))
            {
                return BD.INSERTVehiculo(v);
            }
            return false;
        }


    }

}
