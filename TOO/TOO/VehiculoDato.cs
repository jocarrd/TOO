using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOO
{
    class VehiculoDato
    {
        private String marcaBastidor;
        private String marca;
        private String modelo;
        private int potencia;
        private double precio;

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
