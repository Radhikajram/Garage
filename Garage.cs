using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace VehicleGarage
{
   
    public class Garage<T> : IEnumerable<T> where T : Vehicle
    {
        private int capacity;
        public Vehicle[] vehicles;

        public int Count { get; set; }
        public Garage(int capacity)
        {
            this.capacity = Math.Max(0, capacity);
            vehicles = new Vehicle[this.capacity];
            Count = 0;

            //list = new List<T>(capacity);
            
        }
        bool IsFull; 
        public  void Add(T item)
          {
             vehicles[Count] = item;
             Count++;
         //   if (IsFull) return false;
           
         //   return true;

        }

        public int CountOfArray()
        {
            return vehicles.Length;
        }
        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in vehicles)

            {
                 yield return item;

            }
        }
        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
        //IEnumerator IEnumerable.GetEnumerator()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
