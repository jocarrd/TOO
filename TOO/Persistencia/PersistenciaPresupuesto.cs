using System;
using ModeloDominio;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
   public class PersistenciaPresupuesto
    {
        public static void Añadir(Presupuesto p)
        {
            BD.INSERTPresupuesto(p);
        }

        public static Presupuesto Buscar(Presupuesto p)
        {
            if (BD.SELECTPresupuesto(p) != null)
            {
                return BD.SELECTPresupuesto(p);
            }
            else
            {
                return null;
            }
        }

        public static bool Eliminar(Presupuesto c)
        {
            return BD.DELETEPresupuesto(c);
        }

        public static bool Modificar(Presupuesto c)
        {
            return BD.UPDATEPresupuesto(c);
        }

        public static bool Existe(String bas)
        {
            return BD.Presupuestos.Contains(bas);
        }

        public static List<Presupuesto> GETPresupuestos()
        {
            List<Presupuesto> lista = new List<Presupuesto>();
            foreach (Presupuesto c in BD.Presupuestos)
            {
                lista.Add(c);
            }
            return lista;
        }

        public static List<Presupuesto> GETPresupuestosCliente(Cliente c)
        {
            List<Presupuesto> resultado = new List<Presupuesto>();
            foreach (Presupuesto p in BD.Presupuestos)
            {
                Cliente cast = (Cliente)p.Cliente;
                if (cast.Dni.Equals(c.Dni))
                {
                    resultado.Add(p);
                }
            }
            return resultado;
        }

    }
}
