﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class BmwCar : Car
    {
        public bool IsXDrive { get; set; }
        public BmwCar(bool isXDrive, string model, int fuel, int maxFuelSize) : base(maxFuelSize)
        {
            IsXDrive = isXDrive;
            Model = model;
            Fuel = fuel;
        }
    }
}
