using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModeloDominio;

namespace Persistencia
{
    public class VehiculoBD : KeyedCollection<string, ModeloDominio.Vehiculo>
    {
        protected override string GetKeyForItem(ModeloDominio.Vehiculo item)
        {
            return item.NumBastidor;
        }

    }
}
