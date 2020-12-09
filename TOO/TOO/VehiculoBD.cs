using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOO
{
    public class VehiculoBD : KeyedCollection<string, Negocio.Vehiculo>
    {
        protected override string GetKeyForItem(Negocio.Vehiculo item)
        {
            return item.MarcaBastidor;
        }

    }
}
