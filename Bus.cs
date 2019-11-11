using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleGarage
{
    class Bus:Vehicle
    {
        public Bus(string regNo, string color, int numberOfWheels, int numberOfSeats) : base(regNo, color, numberOfWheels)
        {
            NumberOfSeats = numberOfSeats;
        }

    
        public int NumberOfSeats { get; }
    }
}
