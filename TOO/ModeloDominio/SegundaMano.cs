using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDominio
{
    class SegundaMano : Vehiculo
    {
        private string Matricula;
        private DateTime Fecha_matriculacion;
        private const double IVA = 21/100;

        public SegundaMano(string matricula, DateTime fecha_matriculacion,string marcaBastidor, string marca, string modelo, int potencia, double precio) : base(marcaBastidor, marca, modelo, potencia, precio)
        {
            
            Matricula1 = matricula;
            Fecha_matriculacion1 = fecha_matriculacion;
            precio = precio * IVA;
            base.Precio = precio;
        }

        public string Matricula1 { get => Matricula; set => Matricula = value; }
        public DateTime Fecha_matriculacion1 { get => Fecha_matriculacion; set => Fecha_matriculacion = value; }
    }
}
