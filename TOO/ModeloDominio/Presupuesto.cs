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
        private DateTime fecha_Realizacion;
        private bool estado;
        private Cliente cliente;
        private List<Vehiculo> cocheList;

        public Presupuesto(string id_presupuesto, DateTime fecha_Realizacion, bool estado, Cliente c)
        {
            this.id_presupuesto = id_presupuesto;
            this.fecha_Realizacion = fecha_Realizacion;
            this.estado = estado;
            this.cliente = c;
            cocheList = new List<Vehiculo>();
        }

        public void setId_presupuesto(String id_presupuesto)
        {
            this.id_presupuesto = id_presupuesto;
        }

        public String getId_presupuesto()
        {
            return this.id_presupuesto;
        }

        public void setFecha_Realizacion(DateTime fecha_Realizacion)
        {
            this.fecha_Realizacion = fecha_Realizacion;
        }

        public DateTime getFecha_Realizacion()
        {
            return this.fecha_Realizacion;
        }

        public void setEstado(bool estado)
        {
            this.estado = estado;
        }

        public bool getEstado()
        {
            return this.estado;
        }

        public void setCliente(Cliente cliente)
        {
            this.cliente = cliente;
        }

        public Cliente getCliente()
        {
            return this.cliente;
        }

        public void anadirVehiculo(Vehiculo vehiculo)
        {
            this.cocheList.Add(vehiculo);
        }

        public List<Vehiculo> getVehiculos()
        {
            return cocheList;
        }

        public bool equals(Presupuesto c)
        {
            return (this.id_presupuesto.Equals(c.getId_presupuesto());
        }
    }
}