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
            
            Matricula = matricula;
            Fecha_matriculacion = fecha_matriculacion;

        }
    }
}
