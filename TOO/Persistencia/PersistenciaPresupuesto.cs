using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
   public class PersistenciaPresupuesto
    {
        public static void Añadir(ModeloDominio.Presupuesto c)
        {
            BD.INSERTPresupuesto(c);
        }

        public static ModeloDominio.Presupuesto Buscar(ModeloDominio.Presupuesto c)
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

        public static bool Eliminar(ModeloDominio.Presupuesto c)
        {
            return BD.DELETEPresupuesto(c);
        }

        public static bool ModificarPresupuesto(ModeloDominio.Presupuesto c)
        {
            return BD.UPDATEPresupuesto(c);
        }

        public static List<ModeloDominio.Presupuesto> GETPresupuestos()
        {
            return BD.GETPresupuestos();
        }

        public static List<ModeloDominio.Presupuesto> GETPresupuestos(ModeloDominio.Cliente c)
        {
            return BD.GETPresupuestos(c);
        }

    }
}
