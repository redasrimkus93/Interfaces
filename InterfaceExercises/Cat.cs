using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercises
{
    class Cat : IAnimal, IMammal
    {
        public int Age { get; set; }
        public void Eat()
        {
            Console.WriteLine("Cat is eating");
        }

        public void GiveBirth()
        {
            Console.WriteLine("Cat is giving a birth");
        }
    }
}
