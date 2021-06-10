using System;
using System.Collections;

namespace Assignment12_Part2
{
    //ASSIGNMENT 12 PART2

    class Vehicle :IEnumerable, IComparable
    {
        public int vehicleNumber;
        public string vehicleBrand;
        public string vehicleName;

        public override string ToString()
        {
            return ("Vehicle number : " + vehicleNumber + " VEHICLE BRAND : " + vehicleBrand + " VEHICLE NAME : " + vehicleName);
        }

        int IComparable.CompareTo(object obj)
        {
            Vehicle ob = (Vehicle)obj;
            if (this.vehicleNumber > ob.vehicleNumber)
                return 1;
            else if (this.vehicleNumber < ob.vehicleNumber)
                return -1;
            else
                return 0;
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
            ArrayList VehicleList = new ArrayList();
            VehicleList.Add(new Vehicle() { vehicleNumber = 8523, vehicleBrand = "MARUTI", vehicleName = "WAGONR" });
            VehicleList.Add(new Vehicle() { vehicleNumber = 6541, vehicleBrand = "HYUNDAI", vehicleName = "CRETA" });
            VehicleList.Add(new Vehicle() { vehicleNumber = 6934, vehicleBrand = "RENAULT", vehicleName = "DUSTER" });
            //VehicleList.Add(25);
            //VehicleList.Add("TUSHAR");

            Console.WriteLine("MARUTI".GetHashCode()); 

            VehicleList.Sort(); //Internally calling ToCompare Method
            Console.WriteLine( "Accessing by Index" );
            Console.WriteLine(VehicleList[1].ToString());

            Console.WriteLine( "--------------------------------------" );

            foreach (var item in VehicleList)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine( " ");

            Console.WriteLine( "-------------------------------------" );
            Console.WriteLine( "Accessing through Enumerator" );
            IEnumerator en = VehicleList.GetEnumerator();

            foreach (Vehicle item in VehicleList)
            {
                en.MoveNext();
                Vehicle v5 = (Vehicle)en.Current;
                Console.WriteLine( v5.ToString() );
            }
        }
    }
}
