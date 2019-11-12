using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace VehicleGarage
{
    public class Garage<T> : IEnumerable<T>​  where T : Vehicle
    {
        private int capacity;
        private List<T> list;

        public Garage(int capacity)
        {
            this.capacity = Math.Max(0, capacity);
            list = new List<T>(capacity);

        }
        bool IsFull; 
        public virtual bool Add(T item)
        {
            if (IsFull) return false;

            list.Add(item);

            return true;

        }

        //internal void Add(Airplane airplane)
        //{
        //    throw new NotImplementedException();
        //}
    
        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in list)

            {

                yield return item;

            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
