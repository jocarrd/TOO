using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModeloDominio;

namespace Persistencia
{
    public class PresupuestoBD : KeyedCollection<string, ModeloDominio.Presupuesto>
    {
        protected override string GetKeyForItem(ModeloDominio.Presupuesto item)
        {
            return item.Id_presupuesto;
        }

    }
}
