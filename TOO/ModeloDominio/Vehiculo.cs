using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDominio
{
    public class Vehiculo
    {
        private String numBastidor;
        private String marca;
        private String modelo;
        private int potencia;
        private double precio;

        public Vehiculo(string numBastidor, string marca, string modelo, int potencia, double pvp)
        {
            this.numBastidor = numBastidor;
            this.marca = marca;
            this.modelo = modelo;
            this.potencia = potencia;
            this.precio = pvp;
        }

        public void setNumBastidor(String numBastidor)
        {
            this.numBastidor = numBastidor;
        }

        public String getNumBastidor()
        {
            return this.numBastidor;
        }
        public void setMarca(String marca)
        {
            this.marca = marca;
        }

        public String getMarca()
        {
            return this.marca;
        }

        public void setModelo(String modelo)
        {
            this.modelo = modelo;
        }

        public String getModelo()
        {
            return this.modelo;
        }

        public void setPotencia(int potencia)
        {
            this.potencia = potencia;
        }

        public int getPotencia()
        {
            return this.potencia;
        }

        public void setPrecio(double precio)
        {
            this.precio = precio;
        }

        public double getPrecio()
        {
            return this.precio;
        }

        public bool equals(Vehiculo c)
        {
            return (numBastidor.Equals(c.getNumBastidor()));
        }
    }
}
