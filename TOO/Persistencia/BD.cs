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
        private static PresupuestoVehiculoBD presupuestosVehiculos;

        private BD() {}

        //Mirar porque el presupuesto ya tiene una clase interna que almacena cada coche que tiene ese presupuesto

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
            if (BD.presupuestosVehiculos.Contains(c))
            {
                return BD.presupuestosVehiculos.Remove(c);
            }
            return false;
        }


        //---
        public static bool UPDATEPresupuestoVehiculo(PresupuestoVehiculoDato c)
        {
            if (BD.DELETEPresupuestoVehiculo(c))
            {
                return BD.INSERTPresupuestoVehiculo(c);


            }
            return false;
        }

        //---

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
                if (c.GetSegunda().Equals(v.NumBastidor))
                {
                    resultado.Add(vd);
                }
            }
            return resultado;
        }
//------------------------------------------------------------------------------



        //-------------------------------------------------------------------------CLIENTE-------------------------------------------------------------------
        public static ClienteBD Clientes
        {
            get
            {
                if (clientes == null)
                    clientes = new Persistencia.ClienteBD();
                return clientes;
            }
        }
        public static bool INSERTCliente(ModeloDominio.Cliente c)
        {
            if (BD.Clientes.Contains(c))
            {
                return false;
            }
            else
            {
                BD.Clientes.Add(c);
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

        public static bool DELETECliente(ModeloDominio.Cliente c)
        {
            if (BD.Clientes.Contains(c))
            {
                return BD.Clientes.Remove(c);
            }return false;
        }


        //SEGURAMENTE SE PUEDA BORRAR ESTE MÉTODO, SOLO CONFUNDE
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
                    presupuestos = new Persistencia.PresupuestoBD();
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
            if (BD.presupuestos.Contains(p))
            {
                return BD.presupuestos.Remove(p);
            }return false;
        }


        //SEGURAMENTE SE PUEDA BORRAR ESTE MÉTODO, SOLO CONFUNDE
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
            if (BD.vehiculos.Contains(v))
            {
                return BD.vehiculos.Remove(v);
            }return false;
        }

        //SEGURAMENTE SE PUEDA BORRAR ESTE MÉTODO, SOLO CONFUNDE
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