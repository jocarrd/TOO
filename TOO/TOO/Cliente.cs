using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TOO
{
    public class Cliente : KeyedCollection<string, double>
    {
        protected override string GetKeyForItem(double item)
        {
            return Cliente.DNI;
        }
    }
}
