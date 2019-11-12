using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleGarage
{
    class GarageMethods : GarageHandler
    {
        //public readonly Garage<Vehicle> garage;
        public override void ListGarageVehicles()
        {
          garage.ForEach()
        }
    }
}
