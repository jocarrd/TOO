using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOO
{
    class PrepuestoVehiculoBD : KeyedCollection<string, PresupuestoVehiculoDato>
    {
        protected override string GetKeyForItem(PresupuestoVehiculoDato item)
        {
            return item.dni;
        }

    }
}
