using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class VehiculoNuevo_extraBD : KeyedCollection<string, ModeloDominio.Nuevo>
    {
        protected override string GetKeyForItem(ModeloDominio.Nuevo item)
        {
            return item.getNumBastidor();
        }
    }
}
