using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercises
{
    class Dog : IMammal, IAnimal
    {
        public int Age { get; set; }
        public void Eat()
        {
            Console.WriteLine("Dog is eating");
        }

        public void GiveBirth()
        {
            Console.WriteLine("Dog is giving a birth");
        }
    }
}
