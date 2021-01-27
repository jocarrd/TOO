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
        public static void Añadir(Cliente c)
        {           
            BD.INSERTCliente(c);
        }
       
        public static Cliente Buscar(Cliente c)
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

        public static bool Eliminar(Cliente c)
        {
            return BD.DELETECliente(c);
        }

        public static bool Modificar(Cliente c)
        {
            return BD.UPDATECliente(c);
        }

        public static bool Existe(String dni)
        {
            return BD.Clientes.Contains(dni);
        }

        public static List<Cliente> GETClientes()
        {
            List<ModeloDominio.Cliente> lista = new List<Cliente>();
            foreach (Cliente c in BD.Clientes)
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
