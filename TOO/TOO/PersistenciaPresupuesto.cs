using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOO
{
    class PersistenciaPresupuesto
    {
        public static void Añadir(Negocio.Presupuesto c)
        {
            BD.INSERTPresupuesto(c);
        }

        public static Negocio.Presupuesto Buscar(Negocio.Presupuesto c)
        {
            if (BD.SELECTPresupuesto(c) != null)
            {
                return BD.SELECTPresupuesto(c);
            }
            else
            {
                return null;
            }

        }

        public static bool Eliminar(Negocio.Presupuesto c)
        {
            return BD.DELETEPresupuesto(c);
        }

        public static bool ModificarPresupuesto(Negocio.Presupuesto c)
        {
            return BD.UPDATEPresupuesto(c);
        }

    }
}
