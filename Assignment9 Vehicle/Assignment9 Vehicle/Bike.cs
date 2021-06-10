using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9_Vehicle
{
    class Bike : Vehicle
    {
        string bikeName;
        int chassisNo;
        public Bike(string nm,int ch,string m, int year, string mod, float speed1) : base(m, year, mod, speed1)
        {
            bikeName = nm;
            chassisNo = ch;
        }


        public void BikeDetails()
        {
            Console.WriteLine("BIKE DETAILS");
            Console.WriteLine("MAKING OF : " + make);
            Console.WriteLine("BIKE NAME : " + bikeName);
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
            Console.WriteLine("BIKE IS ACCELERATING AT : " + speed);
        }
        public override void Deaccelerate()
        {
            base.Deaccelerate();
        }
        public override void Stop()
        {
            Console.WriteLine("BIKE STOPEED");
        }


    }
}
