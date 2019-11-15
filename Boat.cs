using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleGarage
{
    public class Boat : Vehicle

    {
        public Boat(string regNo, string color, int numberOfWheels, int length) : base(regNo, color, numberOfWheels)
        {
            Length = length;

        }
        public int Length { get; }
    }
}
