using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9_Vehicle
{
    class Bicycle : Vehicle
    {
        string bicycleName;
        int numberOfTyres;
        public Bicycle(string name,int tyre,string m,int year,string mod,float speed1):base(m,year,mod,speed1)
        {
            bicycleName = name;
            numberOfTyres = tyre;
        }

        public void BicycleDetails()
        {
            Console.WriteLine("BICYCLE DETAILS");
            Console.WriteLine("MAKING OF : " + make);
            Console.WriteLine("BICYCLE NAME : " + bicycleName);
            Console.WriteLine("YEAR OF MANUFACTURE : " + yearOfManufacture);
            Console.WriteLine("MODEL NAME : " + model);
            Console.WriteLine("NUMBER OF TYRES : "+numberOfTyres);
            IsMoving();
            Accelerate();
            Deaccelerate();
            Stop();

        }

        public override void Accelerate()
        {
            Console.WriteLine("BICYCLE IS ACCELERATING AT : " + speed);
        }

        public override void Deaccelerate()
        {
            base.Deaccelerate();
        }

        public override void Stop()
        {
            Console.WriteLine("BICYCLE STOPEED");
        }
    }
}
