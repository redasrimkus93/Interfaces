using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercises
{
    class DogComparer : IComparer<Dog>
    {
        public int Compare(Dog x, Dog y)
        {
            return x.Age - y.Age;
        }
    }
}
