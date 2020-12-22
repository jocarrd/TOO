using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio;

namespace TOO
{
    class ClienteDato
    {
        private String dni;
        private String nombre;
        private long tfno;
        private String categoria;
        



        public ClienteDato(String dni , String nombre ,long tfno , Tipo_cliente categoria , Presupuesto presupuesto)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.tfno = tfno;
            this.categoria = categoria.ToString();
            
        }
    }
}
