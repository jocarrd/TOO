using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Cliente
    {
        private String dni;
        private String nombre;
        private long tfno;
        private Tipo_cliente categoria;

        public Cliente(string dni, string nombre, long tfno, Tipo_cliente categoria)
        {
            this.Dni = dni;
            this.Nombre = nombre;
            this.Tfno = tfno;
            this.Categoria = categoria;
        }

        public string Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public long Tfno { get => tfno; set => tfno = value; }
        public Tipo_cliente Categoria { get => categoria; set => categoria = value; }
    }
}
