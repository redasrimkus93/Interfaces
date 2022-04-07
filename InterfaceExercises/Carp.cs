using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercises
{
    class Carp : IFish, IAnimal
    {
        public void Eat()
        {
            Console.WriteLine("Carp is eating");
        }

        public void Swim()
        {
            Console.WriteLine("Carp is swimming");
        }
    }
}
