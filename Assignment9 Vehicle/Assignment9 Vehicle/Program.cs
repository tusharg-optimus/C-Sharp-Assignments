using System;

namespace Assignment9_Vehicle
{
    class Program
    {
        
        static void Main(string[] args)
        {

             Car m = new Car("Wagonr",56289,"Maruti",2015,"bmw",87.6f);
             m.CarDetails();
            
            Console.WriteLine();
            Bike b = new Bike("HAYABUSA", 89711, "SUZUKI", 2021, "HTE", 299.9f);
            b.BikeDetails();

            Console.WriteLine();
            Bicycle by = new Bicycle("MOUNTAIN BIKE", 2, "HERO", 2019, "ABX", 50.6f);
            by.BicycleDetails();

            Console.WriteLine();
            Truck t = new Truck("TATA 400",746321,"TATA",2008,"TAE400",81.6F);
            t.TruckDetails();

        }
    }
}
