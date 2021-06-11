using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment14
{
    class Car : Vehicle 
    {
        public int CarNumber { get; set; }
        public string CarName { get; set; }

        public override string ToString()
        {
            return ("VEHICLE ID : "+VehicleId+ " CAR NUMBER : " + CarNumber + " " + "CAR NAME : "+CarName);
        }
        
    }
}
