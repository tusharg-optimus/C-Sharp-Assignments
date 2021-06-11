using System;
using System.Collections;
using System.Collections.Generic;

namespace Assignment14
{

    //ASSIGNMENT 14
    class Vehicle :IEnumerable<Vehicle>, IComparable<Vehicle>
    {
        public int VehicleId { get; set; }
        public string  VehicleName { get; set; }

        int IComparable<Vehicle>.CompareTo(Vehicle other) //Comparing current Vehicle Id with pass arguementt
        {
            return this.VehicleId.CompareTo(other.VehicleId);
        }

        IEnumerator<Vehicle> IEnumerable<Vehicle>.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            Car c1 = new Car()
            {
                VehicleId = r.Next(100,1000),
                CarNumber = r.Next(1000, 10000),
                CarName = "BMW"
            };

            Car c2 = new Car()
            {
                VehicleId = r.Next(100,1000),
                CarNumber = r.Next(1000, 10000),
                CarName = "CRETA"
            };

            Truck t1 = new Truck()
            {
                VehicleId = r.Next(100,1000),
                TruckNumber = r.Next(1000,10000),
                TruckName = "ASHOK LEYLEND"
            };
            Truck t2 = new Truck()
            {
                VehicleId = r.Next(100,1000),
                TruckNumber = r.Next(1000,10000),
                TruckName = "TATA"
            };

            List<Vehicle> list1 = new List<Vehicle>();
           // list1.Add(new Car() { VechicleId = r.Next(),CarNumber = r.Next(),CarName = "MBV"});
            list1.Add(c1);
            list1.Add(c2);
            list1.Add(t1);
            list1.Add(t2);


            IEnumerator en = list1.GetEnumerator(); //Getting Enumerator object to iterate

            foreach (Vehicle item in list1)
            {
                en.MoveNext();
                Vehicle v = (Vehicle)en.Current;
                Console.WriteLine(v.ToString()); //Caaling toString from car and truck class

                // Console.WriteLine(item.ToString());
            }

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("SORTED LIST");
            Console.WriteLine(" ");

            list1.Sort(); //internally calling ToCompare Method

           

            foreach (Vehicle item in list1)
            {

               Console.WriteLine(item.ToString());
            }
        }
    }
}
