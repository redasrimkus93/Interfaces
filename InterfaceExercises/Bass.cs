using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercises
{
    class Bass : IFish, IAnimal
    {
        public int Age { get; set; }

        public void Eat()
        {
            Console.WriteLine("Bass is eating");
        }

        public void Swim()
        {
            Console.WriteLine("Bass is swimming");
        }
    }
}
