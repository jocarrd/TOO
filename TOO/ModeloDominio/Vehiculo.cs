using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDominio
{
    public class Vehiculo
    {
        private String marcaBastidor;
        private String marca;
        private String modelo;
        private int potencia;
        private double precio;

        public Vehiculo(string marcaBastidor, string marca, string modelo, int potencia, double pvp)
        {
            this.marcaBastidor = marcaBastidor;
            this.marca = marca;
            this.modelo = modelo;
            this.potencia = potencia;
            this.precio = pvp;
        }

        public string MarcaBastidor { get => marcaBastidor; set => marcaBastidor = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public int Potencia { get => potencia; set => potencia = value; }
        public double Precio { get => precio; set => precio = value; }
    }
}
