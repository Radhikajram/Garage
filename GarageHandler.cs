using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VehicleGarage
{
    internal  class GarageHandler
    {
        // public  Vehicle[] garage;
        public Garage<Vehicle> gar;

        public void ListGarageVehicles()
        {
            foreach (Vehicle item in gar.vehicles)
            {
                
                Console.WriteLine($"RegNo: {item.Regno} Color: {item.Color} Number of Wheels {item.NumberOfWheels} ");
            }
        }

        public void CreateGarage(int garageSize)
        {
            // garage = new Garage[Vehicle](garageSize);

                gar = new Garage<Vehicle>(garageSize);
            
        }
        
        public int GetCapacityOfArray()
        {
            return gar.CountOfArray();
        }
        public void ParkVehicleInGarage(Vehicle vehicle)
        {

            gar.Add(vehicle);
            
           // garage.Add(vehicle);
           
        }

        public void FindVehicleByColor(string inputColor, int inputWheelcount)
        {
            var vehicleByColor = gar.Where(v => ((v.Color == inputColor) && (v.NumberOfWheels == inputWheelcount)));

            int vehicleCount = vehicleByColor.Count();

            if (vehicleCount == 0)
            {
                Console.WriteLine("Could not find any vehicle");
            }
            else
                foreach (Vehicle item in vehicleByColor)
                {
                    Console.WriteLine($"RegNo: {item.Regno} Color: {item.Color} Number of Wheels {item.NumberOfWheels} ");
                }
            

        }

    }
}