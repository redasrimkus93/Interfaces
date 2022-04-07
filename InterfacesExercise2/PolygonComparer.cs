using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExercise2
{
    class PolygonComparer : IComparer<IPolygon>
    {
        public int Compare(IPolygon x, IPolygon y)
        {
            return Convert.ToInt32(x.GetArea() - y.GetArea());
        }
    }
}
