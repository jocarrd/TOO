using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOO
{
    public  class PresupuestoDato
    {
        public String id_presupuesto;
        public  String fecha_Realizacion;
        public String estado;
        public String id_cliente;

        public PresupuestoDato(String id_presupuesto , String fechaRealizacion , String estado,String id_cliente)
        {
            this.id_presupuesto = id_presupuesto;
            this.fecha_Realizacion = fechaRealizacion;
            this.estado = estado;
            this.id_cliente = id_cliente;

        }

    }
}
