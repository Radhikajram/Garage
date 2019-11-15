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
            var vehicleNotNull = gar.Vehicles.Where(v => v != null);

            foreach (Vehicle item in vehicleNotNull)
            {
                Console.WriteLine(item.ToString());

            }

            if (vehicleNotNull.Count() == 0)
            {
                Console.WriteLine("Garage is empty !! ");
            }
            //gar.ListVehicles();
        }

        public void ListVehicleCount()
        {
            var vehicleNotNull = gar.Vehicles.Where(v => v != null);

            int countOfPlane = 0;
            int countOfBus = 0;
            int countOfBoat = 0;
            int countOfMotorcycle = 0;
            int countOfCar = 0;

            foreach (var item in vehicleNotNull)
            {

                switch (item)
                {
                    case Airplane a: countOfPlane += 1; break;
                    case Bus b: countOfBus += 1; break;
                    case Motorcycle m: countOfMotorcycle += 1; break;
                    case Car c: countOfCar += 1; break;
                    case Boat bt: countOfBoat += 1; break;
                }

            }

            Console.WriteLine($"Airplane : {countOfPlane} Bus : {countOfBus} Motorcycle : {countOfMotorcycle} Car : {countOfCar} Boat : {countOfBoat}");

            if (vehicleNotNull.Count() == 0)
            {
                Console.WriteLine("Garage is empty !! ");
            }
        }
        

        public void CreateGarage(int garageSize)
        {
            gar = new Garage<Vehicle>(garageSize);
            
        }
        
        public int GetCapacityOfArray()
        {
               return gar.GarageCapcity;
        }

        public void UnParkVehicles(string inpuRegno)
        {

           bool success =  gar.Remove(inpuRegno);
            if (success == true)
            {
                Console.WriteLine(" Vehicle sucessfully unparked ");
            }
            else Console.WriteLine("Vehicle Not found !! "); ;
        }

        public void ParkVehicleInGarage(Vehicle item)
        {
            bool success = gar.Add(item);
            if (success == true)
            {
                Console.WriteLine(" Vehicle sucessfully parked ");
            }
            else Console.WriteLine(" Not having enough space to Park ");

        }

        public void FindVehicleByRegNo(string inputRegno)
        {
            {
                try
                {

                    var vehicleByRegno = gar.Vehicles.Where(v => ((v != null) && (v.Regno.ToLower() == inputRegno.ToLower())));
                    int vehicleCount = vehicleByRegno.Count();

                    foreach (Vehicle item in vehicleByRegno)
                    {

                        Console.WriteLine(item.ToString());
                    }

                    if (vehicleCount == 0)
                    {
                        Console.WriteLine("Vehicle not found in garage");
                    }
                }
                catch (NullReferenceException e)
                {
                    Console.WriteLine("Null Exception from Search on RegNo.");
                }
            }
            //gar.FindByRegNo(inputRegno);
        }
        public void FindVehicleByPropertyr(string inputColor, int inputWheelcount)
        {
            try
            {
                var vehicleByColor =
                gar.Vehicles.Where(v => ((v != null) &&(v.Color.ToLower() == inputColor.ToLower()) && (v.NumberOfWheels == inputWheelcount)));
                foreach (Vehicle item in vehicleByColor)
                {
                    Console.WriteLine(item.ToString());
                }
                if (vehicleByColor.Count() == 0)
                {
                    Console.WriteLine("Vehicle not found !!");
                }
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("Null Exception from search on Vehicle By its Property");
            }
            // gar.FindVehicleByColor(inputColor, inputWheelcount);

        }

    }
}