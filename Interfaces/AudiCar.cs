using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class AudiCar : Car
    {
        public bool IsQuattro { get; set; }

        public AudiCar(bool isQuattro, string model, int fuel, int maxFuelSize) : base(maxFuelSize)
        {
            IsQuattro = isQuattro;
            Model = model;
            Fuel = fuel;
        }

    }
}
