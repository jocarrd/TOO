using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Presupuesto
    {
        private String id_presupuesto;
        private DateTime fecha_Realizacion;
        private bool estado;
        private Cliente cliente;
        private List<Vehiculo> coches;

        public Presupuesto(string id_presupuesto, DateTime fecha_Realizacion, bool estado, Cliente c, List<Vehiculo> cochs)
        {
            this.Id_presupuesto = id_presupuesto;
            this.Fecha_Realizacion = fecha_Realizacion;
            this.Estado = estado;
            this.Cliente = c;
            this.Coches = cochs;
            
        }

        public string Id_presupuesto { get => id_presupuesto; set => id_presupuesto = value; }
        public DateTime Fecha_Realizacion { get => fecha_Realizacion; set => fecha_Realizacion = value; }
        public bool Estado { get => estado; set => estado = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }
        public List<Vehiculo> Coches { get => coches; set => coches = value; }
    }
}