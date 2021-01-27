using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class PresupuestoVehiculoDato
    {
       public Clave clavePresupuestoVehiculo;
            
        public PresupuestoVehiculoDato(Clave c)
        {
            this.clavePresupuestoVehiculo = c;
        }

        public Clave GetClave()
        {
            return this.clavePresupuestoVehiculo;
        }
        
    }
}
