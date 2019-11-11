using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleGarage
{
    internal static class UI
    {
        private static Garage<Vehicle> garage;


     internal static void  Run()
        {
            while (true)
            {
                Console.WriteLine(" Wlecome to Garage Management ");
                Console.WriteLine("1-Create a new garage with a specific size");
                Console.WriteLine("2-Add vehicle to Garage");
                Console.WriteLine("3-List all parked vehicles");
                Console.WriteLine("4-List all vehicle types currently parked in the garage and how many of each kind");
                Console.WriteLine("5-Park and unpark specific vehicles from the garage");
                Console.WriteLine("6-Set a maximum capacity of your garage");
                Console.WriteLine("7-Find vehicles");
                Console.WriteLine("8-Find vehicle by Regno");

                char input = Console.ReadLine()[0];

                switch(input)
                {
                    case '1': 
                        Console.WriteLine("Enter the size of the garage you want to create : " ) ;
                        int garageSize = int.Parse(Console.ReadLine());
                        CreateGarageSize(garageSize);
                        break;
                    case '2':
                        Console.WriteLine("Enter Type of Vehicle(Airplane/Motorcycle/Car/Bus/Boat) ");
                        String vehicleType = Console.ReadLine();
                        switch (vehicleType)
                        {
                            case 'Airplance':
                                Airplane airplane = new Airplane();
                                break;
                        }
                }

            }
            
        }

        private static void CreateGarageSize(int garageSize)
        {
            garage = new Garage<Vehicle>(garageSize);
            
        }

        private static void AddVehicleToGarage()
        {
            
        }
    }

}
