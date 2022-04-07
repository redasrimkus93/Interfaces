using System;
using System.Collections.Generic;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<AudiCar> audiCars = new List<AudiCar>()
            {
                new AudiCar( false, "Audi A3", 55, 70),
                new AudiCar( true, "Audi Q7", 40, 80),
                new AudiCar( true, "Audi Q6", 30, 80),
                new AudiCar( true, "Audi A6", 10, 70)
            };

            var audiComparer = new AudiCarComparer();

            audiCars.Sort(audiComparer);

            foreach (var item in audiCars)
            {
                Console.WriteLine(item.Model + " " + item.Fuel);
            }









        }
    }
}
