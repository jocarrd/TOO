using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDominio
{
    public class Presupuesto
    {
        private String id_presupuesto;
        private int cantidad;
        private DateTime fecha_Realizacion;
        private EstadoPresupuesto estado;
        private Cliente cliente;
        private List<Vehiculo> cocheList;

        public Presupuesto(string id_presupuesto, int cantidad, DateTime fecha_Realizacion, EstadoPresupuesto estado, Cliente c)
        {
            this.Id_presupuesto = id_presupuesto;
            this.Cantidad = cantidad;
            this.Fecha_Realizacion = fecha_Realizacion;
            this.Estado = estado;
            this.Cliente = c;
            CocheList = new List<Vehiculo>();
        }

        public string Id_presupuesto { get => id_presupuesto; set => id_presupuesto = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public DateTime Fecha_Realizacion { get => fecha_Realizacion; set => fecha_Realizacion = value; }
        public EstadoPresupuesto Estado { get => estado; set => estado = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }
        public List<Vehiculo> CocheList { get => cocheList; set => cocheList = value; }

        public bool equals(Presupuesto c)
        {
            return this.Id_presupuesto.Equals(c.id_presupuesto);
        }
    }
}