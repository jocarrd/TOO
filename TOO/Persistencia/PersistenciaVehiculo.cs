using System;
using ModeloDominio;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Persistencia
{
    public class PersistenciaVehiculo
    {
        public static void Añadir(Vehiculo v)
        {
            BD.INSERTVehiculo(v);
        }

        public static Vehiculo Buscar(Vehiculo v)
        {
            if (BD.SELECTVehiculo(v) != null)
            {
                return BD.SELECTVehiculo(v);
            }
            else
            {
                return null;
            }
        }

        public static bool Eliminar(Vehiculo c)
        {
            return BD.DELETEVehiculo(c);
        }

        public static bool ModificarVehiculo(Vehiculo c)
        {
            return BD.UPDATEVehiculo(c);
        }

        public static bool Existe(String bas)
        {
            return BD.Vehiculos.Contains(bas);
        }

        public static List<Vehiculo> GETVehiculos()
        {
            List<Vehiculo> lista = new List<Vehiculo>();
            foreach (Vehiculo c in BD.Vehiculos)
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
