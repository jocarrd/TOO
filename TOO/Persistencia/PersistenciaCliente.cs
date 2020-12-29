using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Persistencia
{
    public class PersistenciaCliente
    {

       
        
        public static void Añadir(ClienteDato c)
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

        public static bool Eliminar(ModeloDominio.Cliente c)
        {
            return BD.DELETECliente(c);
        }

        public static bool ModificarCliente(ModeloDominio.Cliente c)
        {
            return BD.UPDATECliente(c);
        }





    }

}
