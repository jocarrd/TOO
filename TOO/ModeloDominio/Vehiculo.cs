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

        private Dictionary<string, double> extras;
        private double iva; 

        private string matricula;
        private DateTime fecha_matriculacion;
        
        public Vehiculo(string numBastidor){
            this.NumBastidor = numBastidor;
        }

        public Vehiculo(string numBastidor, string marca, string modelo, int potencia, double pvp, Dictionary<string,double> extrillas) 
        {
            this.NumBastidor = numBastidor;
            this.Marca = marca;
            this.Modelo = modelo;
            this.Potencia = potencia;
            this.Precio = pvp;
            this.Extras = extrillas;
            this.Iva = 10 / 100;
        }

        public Vehiculo(string numBastidor, string marca, string modelo, int potencia, double pvp, string matricula, DateTime fecha)
        {
            this.NumBastidor = numBastidor;
            this.Marca = marca;
            this.Modelo = modelo;
            this.Potencia = potencia;
            this.Precio = pvp;
            this.Extras = new Dictionary<string, double>();
            this.Matricula= matricula;
            this.Fecha_matriculacion = fecha;
            this.Iva = 21 / 100;
        }



        public string NumBastidor { get => numBastidor; set => numBastidor = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public int Potencia { get => potencia; set => potencia = value; }
        public double Precio { get => precio; set => precio = value; }
        public Dictionary<string, double> Extras { get => extras; set => extras = value; }
        public double Iva { get => iva; set => iva = value; }
        public string Matricula { get => matricula; set => matricula = value; }
        public DateTime Fecha_matriculacion { get => fecha_matriculacion; set => fecha_matriculacion = value; }

        public bool equals(Vehiculo c)
        {
            return NumBastidor.Equals(c.numBastidor);
        }
    }
}
