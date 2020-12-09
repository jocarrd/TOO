using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TOO
{
    public class ClienteBD : KeyedCollection<string, Negocio.Cliente>
    {
        protected override string GetKeyForItem(Negocio.Cliente item)
        {
            return item.Dni;
        }

    }
}