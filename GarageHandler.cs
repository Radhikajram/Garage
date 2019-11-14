using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq;

namespace VehicleGarage
{
    internal  class GarageHandler
    {
    
        public Garage<Vehicle> gar;

        public void ListGarageVehicles()

        {

            var vehicleNotNull = gar.vehicles.Where(v => v!= null);

            foreach (Vehicle item in vehicleNotNull)
            {
                Console.WriteLine($"RegNo: {item.Regno} Color: {item.Color} Number of Wheels {item.NumberOfWheels} ");
            }

            //
            //var vehicleNull = gar.vehicles.Where(v => v == null);

            var index = Array.FindIndex(gar.vehicles, i => i == null );

            Console.WriteLine(index);


            //int vehicleCount = gar.vehicles.Count(s => s != null);

            //for (var i = 0; i < vehicleCount; i++)
            //{
            //    Console.WriteLine($"RegNo: {gar.vehicles[i].Regno} Color: {gar.vehicles[i].Color} Number of Wheels {gar.vehicles[i].NumberOfWheels} ");
            //}


            //gar.vehicles = gar.vehicles.Where(v => v != null));



        }

        public void CreateGarage(int garageSize)
        {
            gar = new Garage<Vehicle>(garageSize);
            
        }
        
        public int GetCapacityOfArray()
        {
            return gar.vehicles.Length;
        }

        //public void ParkVehicleInGarage(Vehicle vehicle)
        //{
        //    gar.Add(vehicle);
        //}

        public void Remove(string inpuRegno)
        {
            var indexToRemove = 0;
            try
            {
                indexToRemove = Array.FindIndex(gar.vehicles, row => (row.Regno == inpuRegno));
                gar.vehicles = gar.vehicles.Where((source, index) => index != indexToRemove).ToArray();
                Console.WriteLine(" Vehicle sucessfully unparked ");
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("Vehicle not found in the Garage");
            }
           
        }

        public void ParkVehicleInGarage(Vehicle item)
        {
            var index = Array.IndexOf(gar.vehicles, null);

            Console.WriteLine("insert at Index " + index);
            //var index = Array.FindIndex(gar.vehicles, i => i == null );

            gar.vehicles[index] = item;

           
        }

        public void FindByRegNo(string inputRegno)
        {
            //try
            //{
                var vehicleByRegno = gar.vehicles.Where(v => (v.Regno.ToLower() == inputRegno.ToLower()));
                foreach (Vehicle item in vehicleByRegno)
                {
                    Console.WriteLine($"RegNo: {item.Regno} Color: {item.Color} Number of Wheels {item.NumberOfWheels} ");
                }
            //}
            //catch (NullReferenceException e)
            //{
            //    Console.WriteLine("Vehicle not found in the Garage");
            //}
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