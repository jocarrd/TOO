using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModeloDominio;

namespace Persistencia
{
    public class PersistenciaCliente
    { 
        public static void Añadir(ModeloDominio.Cliente c)
        {           
            BD.INSERTCliente(c);
        }
       
        public static ModeloDominio.Cliente Buscar(ModeloDominio.Cliente c)
        {
            if (BD.SELECTCliente(c)!=null)
            {
                return BD.SELECTCliente(c);
            }
            else
            {
                return null;
            }                
        }

        public static Cliente seleccionarCliente(String dni)
        {
            foreach (Cliente c in BD.Clientes)
            {
                if (c.getDni().Equals(dni))
                {
                    return c;
                }
            }
            return null;
        }

        public static bool Eliminar(ModeloDominio.Cliente c)
        {
            return BD.DELETECliente(c);
        }

        public static bool ModificarCliente(ModeloDominio.Cliente c)
        {
            return BD.UPDATECliente(c);
        }

        public static bool existeCliente(String dni)
        {
            return BD.Clientes.Contains(dni);
        }

        public static List<ModeloDominio.Presupuesto> GETPresupuestosCliente(ModeloDominio.Cliente c)
        {
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
        }
    }

}
