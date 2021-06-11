using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment14
{
    class Truck : Vehicle
    {
        public int TruckNumber { get; set; }
        public  string TruckName { get; set; }

        public override string ToString()
        {
            return ("VEHICLE ID : " + VehicleId + " TRUCK NUMBER : " + TruckNumber + " " + "TRUCK NAME : " + TruckName);
        }
    }
}
