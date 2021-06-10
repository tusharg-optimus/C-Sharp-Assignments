using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9_Vehicle
{
    
     class Car : Vehicle 
    {
        
        String carName;
        int chassisNo;

        public Car(string name,int ch,string m, int year, string mod, float speed1) : base(m, year, mod, speed1)
        {
            carName = name;
            chassisNo = ch;
        }

        public void CarDetails()
        {
            Console.WriteLine("CAR DETAILS");
            Console.WriteLine("MAKING OF : "+make);
            Console.WriteLine("CAR NAME : " + carName);
            Console.WriteLine("YEAR OF MANUFACTURE : " +yearOfManufacture);
            Console.WriteLine("MODEL NAME : "+model);
            Console.WriteLine("CHASSIS NUMBER : " +chassisNo);
            IsMoving();
            Accelerate();
            Deaccelerate();
            Stop();
            
        }
        public override void Accelerate()
        {
            Console.WriteLine("CAR IS ACCELERATING AT : " +speed);
        }
        public override void Deaccelerate()
        {
            base.Deaccelerate();
            
        }
        public override void Stop()
        {
            
            Console.WriteLine("CAR STOPPED");
        }

        public override bool IsMoving()
        {
            return base.IsMoving();
        }
    }
}
