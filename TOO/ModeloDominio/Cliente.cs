using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDominio
{
    public class Cliente
    {
        private String dni;
        private String nombre;
        private long tfno;
        private Tipo_cliente categoria;
        private List<Presupuesto> presupuestoList;
        
        public Cliente(string dni) {
            this.Dni = dni;
        }

        public Cliente(string dni, string nombre, long tfno, Tipo_cliente categoria)
        {
            this.Dni = dni;
            this.Nombre = nombre;
            this.Tfno = tfno;
            this.Categoria = categoria;
            PresupuestoList = new List<Presupuesto>();
        }

        public string Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public long Tfno { get => tfno; set => tfno = value; }
        public Tipo_cliente Categoria { get => categoria; set => categoria = value; }
        public List<Presupuesto> PresupuestoList { get => presupuestoList; set => presupuestoList = value; }

        public bool equals(Cliente c)
        {
            return (this.Dni.Equals(c.dni));
        }
    }
}
