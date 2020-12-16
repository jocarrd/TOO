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
        private const double IVA = 10/100;

        public Nuevo(Dictionary<string, double> extras, string marcaBastidor, string marca, string modelo, int potencia, double precio) : base(marcaBastidor, marca, modelo, potencia, precio)
        {
            this.extras = extras;
            actualizarPrecio();
        }

     
        public Nuevo(string marcaBastidor, string marca, string modelo, int potencia, double precio) : base(marcaBastidor, marca, modelo, potencia, precio)
        {
            this.extras = new Dictionary<string,double>();
        }   

        private double calcularCosteExtras()
        {
            double suma = 0;
            foreach (double a in extras.Values) {
                suma = suma + a;
            }
            return suma;
        }

        private void actualizarPrecio() {
            Precio = (Precio + calcularCosteExtras())*IVA;
        }

        private bool añadirExtra(string nom, double precio) {
            bool anadido = true;
            if (!extras.ContainsKey(nom))
            {
                extras.Add(nom, precio);
            }
            else {
                anadido = false;
            }
            actualizarPrecio();
            return anadido;
        }

        private bool quitarExtra(string nom)
        {
            bool funado = false;
            if (extras.ContainsKey(nom))
            {
                extras.Remove(nom);
                funado = true;
            }
            actualizarPrecio();
            return funado;
        }
    }
}
