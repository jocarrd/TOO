using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace TOO
{
    public class Cliente : KeyedCollection<string, double>
    {
        protected override string GetKeyForItem(double item)
        {
            throw new NotImplementedException();
        }
    }
}
