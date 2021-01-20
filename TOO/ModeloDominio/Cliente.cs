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

        public Cliente(string dni, string nombre, long tfno, Tipo_cliente categoria)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.tfno = tfno;
            this.categoria = categoria;
            presupuestoList = new List<Presupuesto>();
        }
        public void setDni(String dni)
        {
            this.dni = dni;
        }

        public String getDni()
        {
            return this.dni;
        }

        public void setNombre(String nombre)
        {
            this.nombre = nombre;
        }

        public String getNombre()
        {
            return this.nombre;
        }

        public void setTfno(long tfno)
        {
            this.tfno = tfno;
        }

        public long getTfno()
        {
            return this.tfno;
        }

        public void setCategoria(Tipo_cliente categoria)
        {
            this.categoria = categoria;
        }

        public Tipo_cliente getCategoria()
        {
            return this.categoria;
        }

        public void anadirPresupuesto(Presupuesto presupuesto)
        {
            this.presupuestoList.Add(presupuesto);
        }

        public List<Presupuesto> getPresupuesto()
        {
            return presupuestoList;
        }

        public bool equals(Cliente c)
        {
            return (this.dni.Equals(c.getDni());
        }
    }
}
