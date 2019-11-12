using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleGarage
{
    public class Vehicle
    {
        protected string regNo;
        protected string color;
        protected int numberOfWheels;
        private bool park;
       // private bool unpark;
        public Vehicle(string regNo,string color,int numberOfWheels)
        {
            this.regNo = regNo;
            this.color = color;
            this.numberOfWheels = numberOfWheels;
           // this.park = park;
        }


        //public virtual bool Park(bool value)
        //{
        //    park = value;
        //    return park;
        //}
        // public virtual bool Unpark()
        //{
        //    unpark = true;
        //    return unpark;
        //}
}
}
