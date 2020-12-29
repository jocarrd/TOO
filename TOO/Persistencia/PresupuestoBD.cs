using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class PresupuestoBD : KeyedCollection<string,PresupuestoDato>
    {
        protected override string GetKeyForItem(PresupuestoDato item)
        {
            return item.id_presupuesto;
        }

    }
}
