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

        public static ModeloDominio.Vehiculo seleccionarVehiculo(String bas)
        {
            foreach (ModeloDominio.Vehiculo c in BD.Vehiculos)
            {
                if (c.getNumBastidor().Equals(bas))
                {
                    return c;
                }
            }
            return null;
        }

        public static bool Eliminar(ModeloDominio.Vehiculo c)
        {
            return BD.DELETEVehiculo(c);
        }

        public static bool ModificarVehiculo(ModeloDominio.Vehiculo c)
        {
            return BD.UPDATEVehiculo(c);
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

        public static List<ModeloDominio.Vehiculo> getVehiculos()
        {
            List<ModeloDominio.Vehiculo> lista = new List<ModeloDominio.Vehiculo>();
            foreach (ModeloDominio.Vehiculo c in BD.Vehiculos)
            {
                lista.Add(c);
            }
            return lista;
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
