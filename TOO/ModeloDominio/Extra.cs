using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDominio
{
    public class Extra
    {
        private String nombre;
        private double precio;

        public Extra(String nombre, double precio)
        {
            this.Nombre = nombre;
            this.Precio = precio;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public double Precio { get => precio; set => precio = value; }

        public bool equals(Extra c)
        {
            return this.Nombre.Equals(c.nombre);
        }
    }
}
