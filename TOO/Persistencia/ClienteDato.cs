using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModeloDominio;

namespace Persistencia
{
   public class ClienteDato
    {
       public  String dni;
       public  String nombre;
       public long tfno;
       public String categoria;
        

        public ClienteDato(String dni , String nombre ,long tfno , ModeloDominio.Tipo_cliente categoria , ModeloDominio.Presupuesto presupuesto)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.tfno = tfno;
            this.categoria = categoria.ToString();
            
        }
    }
}
