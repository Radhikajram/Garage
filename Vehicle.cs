using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleGarage
{
    public class Vehicle
    {
       
        public Vehicle(string regNo,string color,int numberOfWheels)
        {
                Regno = regNo.ToLower();
                Color = color;
                NumberOfWheels = numberOfWheels;
        
        }

        public string Regno { get; set; }
        public string Color { get; set; }

        public int NumberOfWheels { get; set; }

        public override string ToString()

        {
            return $"RegNo: {Regno} Color: {Color} Number of Wheels {NumberOfWheels}";

        }

    }
}
