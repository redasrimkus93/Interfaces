using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Truck : IVehicle
    {
        public string Model { get; set; }
        public void Drive()
        {
            Console.WriteLine($"{Model} vaziuoja");
        }

        public void Refuel(int litres)
        {
            throw new NotImplementedException();
        }
    }
}
