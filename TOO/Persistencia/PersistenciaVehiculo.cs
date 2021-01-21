using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class PersistenciaVehiculo
    {
        public static void Añadir(ModeloDominio.Vehiculo c)
        {
            BD.INSERTVehiculo(c);
        }

        public static ModeloDominio.Vehiculo Buscar(ModeloDominio.Vehiculo c)
        {
            if (BD.SELECTVehiculo(c) != null)
            {
                return BD.SELECTVehiculo(c);
            }
            else
            {
                return null;
            }

        }

        public static bool Eliminar(ModeloDominio.Vehiculo c)
        {
            return BD.DELETEVehiculo(c);
        }

        public static bool ModificarVehiculo(ModeloDominio.Vehiculo c)
        {
            return BD.UPDATEVehiculo(c);
        }

        public static List<ModeloDominio.Vehiculo> GetVehiculos()
        {
            return BD.Vehiculos.ToList();
        }

        public static bool existeVehiculo(String bas)
        {
            if (BD.Vehiculos.Contains(bas))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /*
        public static List<ModeloDominio.SegundaMano> GETVehiculosSegundaMano()
        {
            return BD.VehiculosSegundaMano.ToList();
        }
        public static List<ModeloDominio.Nuevo> GETVehiculosNuevo()
        {
            return BD.vehiculosNuevos.ToList();
        }*/


    }
}
