using System;
using System.Collections.Generic;

namespace VehicleGarage
{
    class Program
    {

        static void Main(string[] args)
        {
           
            // Call Welcome screen.
            UI.Mainmenu();
            WelcomeGarageOptions();

        }

        private static void ListAllParkedVehicles()
        {
            throw new NotImplementedException();
        }

        internal static void WelcomeGarageOptions()
        {
         GarageHandler garagemethod = new GarageHandler();


            string regno;
            string color;
            int numberOfWheels;
            bool continueFlag = true;
           
            while (continueFlag)
            {
                Console.WriteLine("Enter your choice ");
                char input = Console.ReadLine()[0];

                switch (input)
                {
                    case '1':
                        int gargeSize = UI.GetGarageSize();
                        garagemethod.CreateGarage(gargeSize);
                        Console.WriteLine($"Created garage with capacity : {garagemethod.GetCapacityOfArray()}");
                        
                         break;
                    case '2':
                        regno = UI.AskForString("Regno: ");
                        color = UI.AskForString("Color: ");
                        numberOfWheels = UI.AskForInt("Number-Of-Wheels:");
                        string vehicleType = UI.AskForString("Enter the Type of Vehicle you want to park : 1. Aeroplane 2. Motorcycle 3.Car 4. Bus 5. Boat ");
                       
                        switch (vehicleType)
                        {
                            case "1":
                                 var numberOfEngine = UI.AskForInt("Enter Number of Engines: ");
                                 garagemethod.ParkVehicleInGarage(new Airplane(regno, color, numberOfWheels, numberOfEngine));
                                 break;
                            case "2":
                                var cylinderVolume = UI.AskForString("Enter Bike Cylinder Volume:");
                                garagemethod.ParkVehicleInGarage(new Motorcycle(regno, color, numberOfWheels, cylinderVolume));
                                break;
                            case "3":
                                var fuelType = UI.AskForString("Enter Car Fuel Type: ");
                                garagemethod.ParkVehicleInGarage(new Car(regno, color, numberOfWheels, fuelType));
                                 break;
                            case "4":
                                var numberOfSeats = UI.AskForInt("Enter Bus Number of Seats: ");
                                garagemethod.ParkVehicleInGarage(new Bus(regno, color, numberOfWheels, numberOfSeats));
                                 break;
                            case "5":
                                var length = UI.AskForInt("Enter Boat Length: ");
                                garagemethod.ParkVehicleInGarage(new Boat(regno, color, numberOfWheels, length));
                                break;

                        }
                        break;
                    case '3': garagemethod.ListGarageVehicles(); break;

                    case '7': var vehicleColor = UI.AskForString(" Enter the Color of Vehicle of your choice To search  : ");
                              var vehicleWheels = UI.AskForInt(" Enter the No.Of Wheels of Vehicle of your choice  To search: ");
                              garagemethod.FindVehicleByColor(vehicleColor, vehicleWheels); break;

                    case '9': continueFlag = false;break;
                     



                }
            }

        }
        
        
       

    }
}
       