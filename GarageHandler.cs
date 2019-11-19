using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace VehicleGarage
{
    internal  class GarageHandler
    {
    
        public Garage<Vehicle> gar;

        
        public void ListGarageVehicles()

        {
           if(gar.CountOfGarage == 0)
                Console.WriteLine("Garage is empty !! ");


            foreach (Vehicle item in gar)
            {
                Console.WriteLine(item.ToString());

            }
 
        }

        public void ListVehicleCount()
        {
            var result = gar.GroupBy(v => v.GetType().Name)
                            .Select(v => new
                            {
                                Name = v.Key,
                                Sum = v.Count()
                            }).ToList();

            result.ForEach(r => Console.WriteLine($"Type: {r.Name} ,NR: {r.Sum}"));


            //var vehicleNotNull = gar.Where(v => v != null);

            //int countOfPlane = 0;
            //int countOfBus = 0;
            //int countOfBoat = 0;
            //int countOfMotorcycle = 0;
            //int countOfCar = 0;

            //foreach (var item in vehicleNotNull)
            //{

            //    switch (item)
            //    {
            //        case Airplane a: countOfPlane += 1; break;
            //        case Bus b: countOfBus += 1; break;
            //        case Motorcycle m: countOfMotorcycle += 1; break;
            //        case Car c: countOfCar += 1; break;
            //        case Boat bt: countOfBoat += 1; break;
            //    }

            //}

            //Console.WriteLine($"Airplane : {countOfPlane} Bus : {countOfBus} Motorcycle : {countOfMotorcycle} Car : {countOfCar} Boat : {countOfBoat}");

            //if (vehicleNotNull.Count() == 0)
            //{
            //    Console.WriteLine("Garage is empty !! ");
            //}
        }


        public void CreateGarage(int garageSize)
        {
            gar = new Garage<Vehicle>(garageSize);
            gar.Send += UI.Print;
            
        }
        
        public int GetCapacityOfArray()
        {
               return gar.GarageCapcity;
        }

        public void UnParkVehicles(string inpuRegno)
        {

           bool success =  gar.Remove(inpuRegno);
            if (success == true)
            {
                Console.WriteLine(" Vehicle sucessfully unparked ");
            }
            else Console.WriteLine("Vehicle Not found !! "); ;
        }

        public void ParkVehicleInGarage(Vehicle item)
        {
            bool success = gar.Add(item);
            if (success == true)
            {
                Console.WriteLine(" Vehicle sucessfully parked ");
            }
          

        }

        public void FindVehicleByRegNo(string inputRegno)
        {
            {
                try
                {

                    var vehicleByRegno = gar.Where(v => ((v != null) && (v.Regno.ToLower() == inputRegno.ToLower())));
                    int vehicleCount = vehicleByRegno.Count();

                    foreach (Vehicle item in vehicleByRegno)
                    {

                        Console.WriteLine(item.ToString());
                    }

                    if (vehicleCount == 0)
                    {
                        Console.WriteLine("Vehicle not found in garage");
                    }
                }
                catch (NullReferenceException e)
                {
                    Console.WriteLine("Null Exception from Search on RegNo.");
                }
            }
           
        }
        public void FindVehicleByPropertyr(string inputColor, int inputWheelcount)
        {
            try
            {
                var vehicleByColor =
                gar.Where(v => ((v != null) &&(v.Color.ToLower() == inputColor.ToLower()) && (v.NumberOfWheels == inputWheelcount)));
                foreach (Vehicle item in vehicleByColor)
                {
                    Console.WriteLine(item.ToString());
                }
                if (vehicleByColor.Count() == 0)
                {
                    Console.WriteLine("Vehicle not found !!");
                }
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("Null Exception from search on Vehicle By its Property");
            }
            

        }

    }
}