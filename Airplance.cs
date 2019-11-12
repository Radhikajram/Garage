using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleGarage
{
    public class Airplane : Vehicle
    {
        public Airplane(string regNo, string color, int numberOfWheels, int numberOfEngine) : base(regNo, color, numberOfWheels)
        {
            NumberOfEngine = numberOfEngine;

        }
        public int NumberOfEngine { get; }
    }
}
