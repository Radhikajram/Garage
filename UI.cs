using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleGarage
{
    internal static class UI
    {
        //private static Garage<Vehicle> garage;

     
        internal static void  Mainmenu()
        {
            Console.WriteLine(" Wlecome to Garage Management ");
            Console.WriteLine("1-Create a new garage with Maximum size");
            Console.WriteLine("2-Park Vehicles to Garage");
            Console.WriteLine("3-List all parked vehicles");
            Console.WriteLine("4-List all vehicle types currently parked in the garage and how many of each kind");
            Console.WriteLine("5-Unpark specific vehicles from the garage");
            Console.WriteLine("7-Find vehicles by Color and Number of Wheels");
            Console.WriteLine("8-Find vehicle by Regno");
            Console.WriteLine("9-Quit");

        }

        internal static string AskForString(string prompt)

        {
            bool correct = true;

            string answer;
          do  { 
                Console.WriteLine(prompt);

                answer = Console.ReadLine();

                //If answer is not null or empty string

                if (!string.IsNullOrEmpty(answer))

                {

                    //Set bool correct to false to exit loop

                    correct = false;
                }

            } while (correct); //until we have get a correct value

            return answer; //return value

        }
        internal static int AskForInt(string prompt)

        {

            bool success;

            int answer; 

         do   {

                string input = AskForString(prompt);

                //Try to parse string to int returns bool

                //If true exit loop

                success = int.TryParse(input, out answer);

                //If we not successfully parsed string input to int answer

                if (!success)

                {

                    //Write errormessage
                      Console.WriteLine("Wrong format only numbers");
                }

            } while (!success);


            //Returns parsed string

            return answer;

        }

        internal static void Print(object sender, VehicleEventArgs e)
        {
            Console.WriteLine($"{ e.vehicle.Regno}, {e.Message}");
        }

        internal static int  GetGarageSize()
        {
            Console.WriteLine("Enter the size of the garage you want to create : ");
            int garageSize = int.Parse(Console.ReadLine());
            return garageSize;
        }
    }

}
