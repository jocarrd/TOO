using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOO
{
    public class PresupuestoBD : KeyedCollection<string, Negocio.Presupuesto>
    {
        protected override string GetKeyForItem(Negocio.Presupuesto item)
        {
            return item.Id_presupuesto;
        }

    }
}
