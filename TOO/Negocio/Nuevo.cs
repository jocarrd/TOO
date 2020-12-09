using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    class Nuevo : Vehiculo
    {
        private Dictionary<string, double> extras;

        public Nuevo(Dictionary<string, double> extras, string marcaBastidor, string marca, string modelo, int potencia, double pvp) : base(marcaBastidor, marca, modelo, potencia, pvp)
        {
            this.extras = extras;
        }

        public Nuevo(string marcaBastidor, string marca, string modelo, int potencia, double pvp) : base(marcaBastidor, marca, modelo, potencia, pvp)
        {
            this.extras = new Dictionary<string,double>();
        }
    }
}
