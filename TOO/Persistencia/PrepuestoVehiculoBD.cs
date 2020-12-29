using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    class PrepuestoVehiculoBD : KeyedCollection<Clave, PresupuestoVehiculoDato>
    {
        protected override Clave GetKeyForItem(PresupuestoVehiculoDato item)
        {
            return item.clavePresupuestoVehiculo;

        }

    }
}
