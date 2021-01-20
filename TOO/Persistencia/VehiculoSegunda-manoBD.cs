using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class VehiculoSegunda_manoBD : KeyedCollection<string, ModeloDominio.SegundaMano>
    {

        protected override string GetKeyForItem(ModeloDominio.SegundaMano item)
        {
            return item.getNumBastidor();
        }
    }
}
