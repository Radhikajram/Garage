using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleGarage
{
    internal abstract class GarageHandler
    {
         public  Garage<Vehicle> garage;

        public abstract void ListGarageVehicles();

        public void CreateGarage(int garageSize)
        {
            garage = new Garage<Vehicle>(garageSize);
        }
        
        public void ParkVehicleInGarage(Vehicle vehicle)
        {
            garage.Add(vehicle);
        }
      

    }
}