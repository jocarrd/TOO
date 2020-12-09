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
        public static void INSERTCliente(Negocio.Cliente c)
        {
            BD.clientes.Add(c);
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
        public static void INSERTPresupuesto(Negocio.Presupuesto p)
        {
            BD.presupuestos.Add(p);
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
        public static void INSERTVehiculo(Negocio.Vehiculo v)
        {
            BD.Vehiculos.Add(v);
        }

    }
}
