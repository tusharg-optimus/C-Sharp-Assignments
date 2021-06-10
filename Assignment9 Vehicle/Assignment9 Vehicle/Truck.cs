using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9_Vehicle
{
    class Truck : Vehicle
    {
        string truckName;
        int chassisNo;
        public Truck(string name,int chassis,string m,int year,string mod, float speed1):base(m,year,mod,speed1)
        {
            truckName = name;
            chassisNo = chassis;
        }

        public void TruckDetails()
        {
            Console.WriteLine("TRUCK DETAILS");
            Console.WriteLine("MAKING OF : " + make);
            Console.WriteLine("TRUCK NAME : " + truckName);
            Console.WriteLine("YEAR OF MANUFACTURE : " + yearOfManufacture);
            Console.WriteLine("MODEL NAME : " + model);
            Console.WriteLine("CHASSIS NUMBER : " + chassisNo);
            IsMoving();
            Accelerate();
            Deaccelerate();
            Stop();

        }

        public override void Accelerate()
        {
            Console.WriteLine("TRUCK IS ACCELERATING AT : " + speed);
        }
        public override void Deaccelerate()
        {
            base.Deaccelerate();
        }
        public override void Stop()
        {
            Console.WriteLine("TRUCK STOPEED");
        }
    }
}
