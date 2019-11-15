using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Linq;

namespace VehicleGarage
{
   
    public class Garage<T> : IEnumerable<T> where T : Vehicle
    {
        private int capacity;
        private Vehicle[] vehicles;

      //  public int Count { get; set; }
        public Vehicle[] Vehicles
        {
            get
            {
                return vehicles;
            }
        }

        public bool IsAdded;
        public bool IsRemoved;
        public Garage(int capacity)
        {
            this.capacity = Math.Max(0, capacity);
            vehicles = new Vehicle[this.capacity];
         //   Count = 0;
  
        }
        

        public bool Add(Vehicle item)
        {
            try
            {
                var index = Array.IndexOf(vehicles, null);

                vehicles[index] = item;

                return IsAdded = true;
            }
            catch(IndexOutOfRangeException e)
            {
                
                return IsAdded = false;
            }

        }
        public int GarageCapcity 
        { 
            get
            {
                return this.capacity;
            }
        }

        public bool Remove(string inpuRegno)
        {
            var indexToRemove = 0;
            try
            {
                indexToRemove = Array.FindIndex(vehicles, row => (row.Regno == inpuRegno));
                vehicles[indexToRemove] = null;
                return IsRemoved = true;
            }
            catch (NullReferenceException e)
            {
                return IsRemoved = false;
            }
            catch (IndexOutOfRangeException e)
            {
                return IsRemoved = false;
            }

        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in vehicles)

            {
                 yield return item;

            }
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
     
    }
}
