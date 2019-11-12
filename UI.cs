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
            Console.WriteLine("1-Create a new garage with a specific size");
            Console.WriteLine("2-Part Vehicles to Garage");
            Console.WriteLine("3-List all parked vehicles");
            Console.WriteLine("4-List all vehicle types currently parked in the garage and how many of each kind");
            Console.WriteLine("5-Park and unpark specific vehicles from the garage");
            Console.WriteLine("6-Set a maximum capacity of your garage");
            Console.WriteLine("7-Find vehicles");
            Console.WriteLine("8-Find vehicle by Regno");

        }

        //private static void CreateGarageSize(int garageSize)
        //{
        //    garage = new Garage<Vehicle>(garageSize);7
        //}



        internal static string AskForString(string prompt)

        {
            bool correct = true;

            string answer;
            { 
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

            {

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

        internal static int  GetGarageSize()
        {
            Console.WriteLine("Enter the size of the garage you want to create : ");
            int garageSize = int.Parse(Console.ReadLine());
            return garageSize;
        }
    }

}
