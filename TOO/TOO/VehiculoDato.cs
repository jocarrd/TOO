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
        public double precio;
        public int potencia;
        public String categoria;
       

        public VehiculoDato(String marcaBastidor , String marca , String modelo , int potencia , double precio,String categoria)
        {
            this.marcaBastidor = marcaBastidor;
            this.marca = marca;
            this.modelo = modelo;
            this.potencia = potencia;
            this.precio = precio;
            this.categoria = categoria;

        }
    }
}
