using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOO
{
    public class VehiculoDato
    {
        public String marcaBastidor;
        public String marca;
        public  String modelo;
        public int potencia;
        public double precio;

        public VehiculoDato(String marcaBastidor , String marca , String modelo , int potencia , double precio)
        {
            this.marcaBastidor = marcaBastidor;
            this.marca = marca;
            this.modelo = modelo;
            this.potencia = potencia;
            this.precio = precio;

        }
    }
}
