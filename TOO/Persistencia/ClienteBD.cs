using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModeloDominio;


namespace Persistencia
{
    public class ClienteBD : KeyedCollection<string, ModeloDominio.Cliente>
    {
        protected override string GetKeyForItem(ModeloDominio.Cliente item)
        {
            return item.getDni();
        }

    }
}