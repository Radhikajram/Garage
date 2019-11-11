using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleGarage
{
    public class Garage<T> : IEnumberable<T> where T : Vehicle
    {
        private int capacity;
        private List<T> list;

        public Garage(int capacity)
        {
            this.capacity = Math.Max(0, capacity);
            list = new List<T>(capacity);

        }
    }
}
