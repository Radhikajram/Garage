using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleGarage
{
    public class Vehicle
    {
        //protected string regNo;
        //protected string color;
        //protected int numberOfWheels;
        //private bool park;
       // private bool unpark;
        public Vehicle(string regNo,string color,int numberOfWheels)
        {
                Regno = regNo;
                Color = color;
                NumberOfWheels = numberOfWheels;
           // this.park = park;
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
