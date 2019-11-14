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
        public Vehicle[] vehicles;

        public int Count { get; set; }
        public Garage(int capacity)
        {
            this.capacity = Math.Max(0, capacity);
            vehicles = new Vehicle[this.capacity];

            //for (int i = 0; i < vehicles.Length; i++)
            //{
            //    vehicles[i] = null;
            //}
            Count = 0;
  
        }
  
        //public  void Add(T item)
        //  {

        //    var index = Array.FindIndex(gar.vehicles, i => i == null);

        //    //try
        //    //{

        //    //    vehicles[Count] = item;
        //    //    Count++;
        //    //}
        //    //catch (System.IndexOutOfRangeException e)  // CS0168
        //    //{
        //    //    System.Console.WriteLine(e.Message);
        //    //    Console.WriteLine("Garage not having enough space to park vehicles");

        //    //}

        //}

      
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
