using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9_Vehicle
{
    abstract class Vehicle
    {
        public string make;
        public int yearOfManufacture;
        public string model;
        public float speed;

       public Vehicle( string m,int year,string mod,float speed1 )
        {
            this.make = m;
            this.yearOfManufacture = year;
            this.model = mod;
            this.speed = speed1;
        }


        public abstract void Accelerate();

        public virtual void Deaccelerate()
        {
            Console.WriteLine("APPLYING BRAKES");
        }


        public abstract void Stop();

        public virtual Boolean IsMoving()
        {
            if(speed !=0)
            {
                Console.WriteLine("IS MOVING");
                return true;
                
            }
            else
            {
                Console.WriteLine("STOPPED");
                return false;
                
            }
        }
    }

    
}
