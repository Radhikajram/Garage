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
           NavigateGarageOptions();

        }

     
        internal static void NavigateGarageOptions()
        {
         GarageHandler garagemethod = new GarageHandler();


            string regno;
            string color;
            int numberOfWheels;
            bool continueFlag = true;
            int gargeSize = 0;


            while (continueFlag)
            {
                try
                {
                Console.WriteLine("Enter your choice ");
                char input = Console.ReadLine()[0];

                switch (input)
                {
                    case '1':
                        gargeSize = UI.GetGarageSize();
                        garagemethod.CreateGarage(gargeSize);
                        Console.WriteLine($"Created garage with capacity : {garagemethod.GetCapacityOfArray()}");
                         break;
                    case '2':
                        if (gargeSize > 0)
                        {
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
                                default: Console.WriteLine("Enter valid option"); break;

                            }
                        }
                        else
                            Console.WriteLine("Set the Size of Garage ");
                            break;
                    case '3':
                        if (gargeSize > 0)
                            garagemethod.ListGarageVehicles();
                        else
                            Console.WriteLine("Set the size of Garage.!!  ");
                        break;
                    case '4':
                        if (gargeSize > 0)
                            garagemethod.ListVehicleCount();
                        else
                            Console.WriteLine("Set the size of Garage.!! ");
                        break;
                    case '5':
                        if (gargeSize > 0)
                        {
                            var inputRegno = UI.AskForString("Enter Regno of the Vehicle to be Unparked :");
                            garagemethod.UnParkVehicles(inputRegno);
                        }
                        else
                            Console.WriteLine("Set the Size of Garage ");
                        break;
                    case '7':
                        if (gargeSize > 0)
                        {
                            var vehicleColor = UI.AskForString(" Enter the Color of Vehicle of your choice To search  : ");
                            var vehicleWheels = UI.AskForInt(" Enter the No.Of Wheels of Vehicle of your choice  To search: ");
                            garagemethod.FindVehicleByPropertyr(vehicleColor, vehicleWheels);
                        }
                        else
                            Console.WriteLine("Set the Size of Garage ");
                        break;
                    case '8':
                        var iRegno = UI.AskForString(" Enter Regno you want to search : ");
                        garagemethod.FindVehicleByRegNo(iRegno); break;
                    case '9': continueFlag = false;break;
                    
                    default: Console.WriteLine("Enter valid option"); break;



                }
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Enter valid option from main menu " );   
             }

            }

        }
      
    }
}
       