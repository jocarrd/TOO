using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class ExtrasBD : KeyedCollection<string, ModeloDominio.Extra>
    {
        protected override string GetKeyForItem(ModeloDominio.Extra item)
        {
            return item.getNombre();
        }
    }
}
