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

        public Presupuesto(string id_presupuesto, DateTime fecha_Realizacion, bool estado)
        {
            this.Id_presupuesto = id_presupuesto;
            this.Fecha_Realizacion = fecha_Realizacion;
            this.Estado = estado;
        }

        public string Id_presupuesto { get => id_presupuesto; set => id_presupuesto = value; }
        public DateTime Fecha_Realizacion { get => fecha_Realizacion; set => fecha_Realizacion = value; }
        public bool Estado { get => estado; set => estado = value; }
    }
}