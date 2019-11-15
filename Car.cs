using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleGarage
{
  public class Car:Vehicle
    {
        public Car(string regNo, string color, int numberOfWheels, string fuelType) : base(regNo, color, numberOfWheels)
        {
            FuelType = fuelType;
        }
        public string FuelType { get; }
    }
}
