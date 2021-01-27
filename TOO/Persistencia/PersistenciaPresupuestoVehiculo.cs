using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class PersistenciaPresupuestoVehiculo
    {

        public static void Añadir(PresupuestoVehiculoDato a)
        {
            BD.INSERTPresupuestoVehiculo(a);
        }

        public static PresupuestoVehiculoDato Buscar(PresupuestoVehiculoDato a)
        {
            if (BD.SELECTPresupuestoVehiculo(a) != null)
            {
                return BD.SELECTPresupuestoVehiculo(a);
            }
            else
            {
                return null;
            }

        }

        public static bool Eliminar(PresupuestoVehiculoDato c)
        {
            return BD.DELETEPresupuestoVehiculo(c);
        }

        public static bool ModificarPresupuesto(PresupuestoVehiculoDato c)
        {
            return BD.UPDATEPresupuestoVehiculo(c);
        }

        public static bool Existe(Clave clave)
        {
            return BD.PresupuestosVehiculos.Contains(clave);
        }

        public static List<PresupuestoVehiculoDato> GETPresupuestosVehiculosDatos()
        {
            return BD.GETPresupuestosVehiculosDatos(); 
        }
        public static List<PresupuestoVehiculoDato> GETPresupuestosVehiculosDatos(ModeloDominio.Vehiculo v)
        {
            return BD.GETPresupuestosVehiculosDatos(v);
        }
    }
}
