using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleGarage
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle(string regNo, string color, int numberOfWheels, string cylinderVolume) : base(regNo, color, numberOfWheels)
        {
            CylinderVolume = cylinderVolume;
        }
        public string CylinderVolume { get; }

    }
}
