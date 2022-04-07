using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    abstract class Car : IVehicle
    {
        public string Model { get; set; }
        public int Fuel { get; set; }
        private readonly int _maxFuelSize;

        public Car(int maxFuelSize)
        {
            _maxFuelSize = maxFuelSize;
        }
        public void Drive()
        {
            if (Fuel > 0)
            {
                Console.WriteLine($"{Model} vaziuoja");
            }
            else
            {
                Console.WriteLine("Degalai pasibaige, vaziuoti negalima");
            }
        }

        public void Refuel(int litres)
        {
            if (litres < 0)
            {
                Console.WriteLine("Netinkamas degalu papildymo kiekis");
                return;
            }

            if (IsMaxFuelSizeReached(litres))
            {
                Console.WriteLine("Pasiektas bako limitas, pilkite maziau degalu");
                return;
            }
            Console.WriteLine($"Sekmingai pripilta {litres} litru degalu");
        }
        private bool IsMaxFuelSizeReached(int litres)
        {
            if (_maxFuelSize - Fuel - litres < 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
