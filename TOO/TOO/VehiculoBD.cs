using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOO
{
    public class VehiculoBD : KeyedCollection<string, VehiculoDato>
    {
        protected override string GetKeyForItem(VehiculoDato item)
        {
            return item.marcaBastidor;
        }

    }
}
