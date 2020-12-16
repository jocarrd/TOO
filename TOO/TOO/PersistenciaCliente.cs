using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TOO
{
    public class PersistenciaCliente
    {

       
        
        public static void Añadir(Negocio.Cliente c)
        {
            BD.INSERTCliente(c);
        }
       
        public static Negocio.Cliente Buscar(Negocio.Cliente c)
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

        public static bool Eliminar(Negocio.Cliente c)
        {
            return BD.DELETECliente(c);
        }

        public static bool ModificarCliente(Negocio.Cliente c)
        {
            return BD.UPDATECliente(c);
        }





    }

}
