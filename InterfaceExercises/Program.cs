using System;
using System.Collections.Generic;

namespace InterfaceExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IAnimal> animals = new List<IAnimal>();
            var dog1 = new Dog() { Age = 10 };
            Bass bass = new Bass();
            var cat = new Cat();
            var carp = new Carp();
            animals.Add(dog1);
            animals.Add(bass);
            animals.Add(cat);
            animals.Add(carp);

            Console.WriteLine("Animals:");
            foreach (var item in animals)
            {
                item.Eat();
            }

            Console.WriteLine("Mammals:");
            List<IMammal> mammals = new List<IMammal>() { cat, dog1 };
            foreach (var item in mammals)
            {
                item.GiveBirth();
            }
            Console.WriteLine("Fishes:");
            List<IFish> fishes = new List<IFish>() { bass, carp };
            foreach (var item in fishes)
            {
                item.Swim();
            }

            List<Dog> dogs = new List<Dog>()
            {
                dog1,
                new Dog(){ Age = 5},
                new Dog() { Age = 10},
                new Dog() {Age = 2},
                new Dog() { Age = 7}
            };

            dogs.Sort(new DogComparer());


            Console.WriteLine("Dogs");
            foreach (var item in dogs)
            {
                Console.WriteLine(item.Age);
            }




        }
    }
}
