using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
   public class PersistenciaPresupuesto
    {
        public static void añadir(ModeloDominio.Presupuesto c)
        {
            BD.INSERTPresupuesto(c);
        }

        //PREGUNTAR QUE HACE ESTE MÉTODO
        public static ModeloDominio.Presupuesto buscar(ModeloDominio.Presupuesto c)
        {
            //UNA OPCION
            if (BD.SELECTPresupuesto(c) != null)
            {
                return BD.SELECTPresupuesto(c);
            }
            else
            {
                return null;
            }
        }

        public static bool eliminar(ModeloDominio.Presupuesto c)
        {
            return BD.DELETEPresupuesto(c);
        }

        public static bool modificarPresupuesto(ModeloDominio.Presupuesto c)
        {
            return BD.UPDATEPresupuesto(c);
        }

        public static bool existePresupuesto(String bas)
        {
            if (BD.Presupuestos.Contains(bas))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static List<ModeloDominio.Presupuesto> getPresupuestos()
        {
            return BD.Presupuestos.ToList();
        }

        public static List<ModeloDominio.Presupuesto> getPresupuestosCliente(ModeloDominio.Cliente c)
        {
            //UNA OPCION ES ASI
            
            List<ModeloDominio.Presupuesto> resultado = new List<ModeloDominio.Presupuesto>();
            foreach (ModeloDominio.Presupuesto p in BD.Presupuestos)
            {
                ModeloDominio.Cliente cast = (ModeloDominio.Cliente)p.getCliente();
                if (cast.getDni().Equals(c.getDni()))
                {
                    resultado.Add(p);
                }
            }
            return resultado;

            //OTRA OPCIÓN PUEDE SER APROBECHAR EL ATRIBUTO DE CLIENTE

            //return c.getPresupuesto();
        }

    }
}
