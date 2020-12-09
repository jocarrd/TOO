using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    class SegundaMano : Vehiculo
    {
        private string Matricula;
        private DateTime Fecha_matriculacion;

        public SegundaMano(string matricula, DateTime fecha_matriculacion,string marcaBastidor, string marca, string modelo, int potencia, double pvp) : base(marcaBastidor, marca, modelo, potencia, pvp)
        {
            
            Matricula1 = matricula;
            Fecha_matriculacion1 = fecha_matriculacion;

        }

        public string Matricula1 { get => Matricula; set => Matricula = value; }
        public DateTime Fecha_matriculacion1 { get => Fecha_matriculacion; set => Fecha_matriculacion = value; }
    }
}
