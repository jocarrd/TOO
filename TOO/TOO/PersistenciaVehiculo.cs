using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOO
{
    class PersistenciaVehiculo
    {
        public static void Añadir(Negocio.Vehiculo c)
        {
            BD.INSERTVehiculo(c);
        }

        public static Negocio.Vehiculo Buscar(Negocio.Vehiculo c)
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

        public static bool Eliminar(Negocio.Vehiculo c)
        {
            return BD.DELETEVehiculo(c);
        }

        public static bool ModificarVehiculo(Negocio.Vehiculo c)
        {
            return BD.UPDATEVehiculo(c);
        }




    }
}
