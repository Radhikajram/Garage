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

        public EventHandler<VehicleEventArgs> Send;


        public bool IsAdded;
        public bool IsRemoved;
        public Garage(int capacity)
        {
            this.capacity = Math.Max(0, capacity);
            vehicles = new Vehicle[this.capacity];
      
  
        }
        

        public bool Add(Vehicle item)
        {
            try
            {
                    
                    var vehicleByRegno = vehicles.Where(v => v.Regno == item.Regno.ToLower());

                    if ((CountOfGarage > 0) && (vehicleByRegno != null)) 
                    {
                        Send?.Invoke(this, new VehicleEventArgs { vehicle = item });
                        Console.WriteLine($"Vehicle with regno : {item.Regno} already parked ");
                        return IsAdded = false;
                    }
             
                else
                {
                    var index = Array.IndexOf(vehicles, null);

                    vehicles[index] = item;

                    return IsAdded = true;
                }
            }
            catch(IndexOutOfRangeException e)
            {
                Send?.Invoke(this, new VehicleEventArgs { vehicle = item, Message = " Not having enough space to Park " });
               
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

        public int CountOfGarage => vehicles.Where(v => v != null).Count();
   

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
                if(item != null)
                 yield return item;

            }
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
     
    }
}
