using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class BmwCarComparer : IComparer<BmwCar>
    {
        public int Compare(BmwCar x, BmwCar y)
        {
            var result = string.Compare(x.Model, y.Model);
            return result != 0 ? result : x.Fuel - y.Fuel;
        }
    }
}
