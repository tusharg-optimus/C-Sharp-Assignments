using System;
using System.Collections;

namespace Assignment12_Part1
{
    class VehicleCollection : IEnumerable,IComparable
    {
        public int vehicleNumber;
        public string vehicleModel;
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            return vehicleNumber + " " + vehicleModel;
        }

        int IComparable.CompareTo(object obj)
        {
            VehicleCollection other1 = (VehicleCollection)obj;
            if (this.vehicleNumber > other1.vehicleNumber)
                return 1;
            else if (this.vehicleNumber < other1.vehicleNumber)
                return -1;
            else
                return 0;
        }
    }

     class Vehicle : IComparable
    {
        public int vehicleId;
        public string vehicleName;

        public override string ToString()
        {
            return vehicleId + " " + vehicleName; 
        }

        public int CompareTo(object obj)
        {
            Vehicle other = (Vehicle)obj; //Type casting obj

            if (this.vehicleId > other.vehicleId)
                return 1;
            else if (this.vehicleId < other.vehicleId)
                return -1;
            else
                return 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList vehiclelist = new ArrayList();
            vehiclelist.Add(new Vehicle() { vehicleId = 2, vehicleName = "Maruti" });
            vehiclelist.Add(new Vehicle() { vehicleId = 1, vehicleName = "BMW" });


            //Cannot be able to sort two objects
            //To do sorting implement IComperable interface
            vehiclelist.Sort(); //Sort will internally call the ToCompare method for the objects

            foreach (Vehicle item in vehiclelist)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine( "----------------------------------------");
           
            Console.WriteLine( " " );
            //Accesing all elements of arraylist with the help of Enumerator
            //foreach loop has implicit implementation of enumerator, thats why we can able to access the elements with foreach loop
            IEnumerator en = vehiclelist.GetEnumerator();//Return objects

            foreach (Vehicle item in vehiclelist)
            {
                en.MoveNext();
                Vehicle v4 = (Vehicle)en.Current;
                Console.WriteLine(v4);
            }

            Console.WriteLine( "--------------------------");
            Console.WriteLine("USING IENUMERABLE INTERFACE");
            Console.WriteLine(" ");


            ArrayList list1 = new ArrayList();
            list1.Add(new VehicleCollection() { vehicleNumber = 56891, vehicleModel = "HTX" });
            list1.Add(new VehicleCollection() { vehicleNumber = 8931, vehicleModel = "HTE" });

            list1.Sort();//Internally call the ToCompare Method

            IEnumerator en1 = list1.GetEnumerator();

            foreach (VehicleCollection item in list1)
            {
                en1.MoveNext();
                VehicleCollection v5 = (VehicleCollection)en1.Current;
                Console.WriteLine(v5.ToString());
            }
        }
    }
}
