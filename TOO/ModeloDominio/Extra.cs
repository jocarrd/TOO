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
            this.nombre = nombre;
            this.precio = precio;
        }

        public void setNombre(String nombre)
        {
            this.nombre = nombre;
        }

        public String getNombre()
        {
            return this.nombre;
        }

        public void setPrecio(double precio)
        {
            this.precio = precio;
        }

        public double getPrecio()
        {
            return this.precio;
        }
    }
}
