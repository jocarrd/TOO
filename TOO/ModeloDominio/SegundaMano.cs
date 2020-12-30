using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDominio
{
    class SegundaMano : Vehiculo
    {
        private String matricula;
        private DateTime fecha_matriculacion;
        private const double IVA = 21/100;

        public SegundaMano(string matricula, DateTime fecha_matriculacion,string marcaBastidor, string marca, string modelo, int potencia, double precio) : base(marcaBastidor, marca, modelo, potencia, precio)
        {

            this.matricula = matricula;
            this.fecha_matriculacion1 = fecha_matriculacion;
            precio = precio * IVA;
            base.Precio = precio;
        }

        public void setMatricula(String matricula)
        {
            this.matricula = matricula;
        }

        public String getMatricula()
        {
            return this.matricula;
        }

        public void setFecha_matriculacion(DateTime fecha_matriculacion)
        {
            this.fecha_matriculacion = fecha_matriculacion;
        }

        public DateTime getFecha_matriculacion()
        {
            return this.fecha_matriculacion;
        }
    }
}
