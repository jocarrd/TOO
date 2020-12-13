using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TOO
{
    public class Persistencia
    {
        
        public static void Añadir(Negocio.Cliente c)
        {
            BD.INSERTCliente(c);
        }
       
        public static Negocio.Cliente Buscar(Negocio.Cliente)
        {
            if (BD.SELECTCliente()!=null)
            {
                return BD.SELECTCliente();
            }
            else
            {
                return null;
            }
                
        }





    }

}
