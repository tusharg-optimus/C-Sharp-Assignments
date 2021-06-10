using System;

namespace Assignment3
{
    class Program
    {
        //Assignment 3
        enum WeekDays
        {
            MONDAY,
            TUESDAY,
            WEDNESDAY,
            THURSDAY,
            FRIDAY
        }
        static void Main(string[] args)
        {
            Console.WriteLine("TODAY IS " + WeekDays.MONDAY);
            Console.WriteLine("TODAY IS " + WeekDays.TUESDAY);
            Console.WriteLine("TODAY IS " + WeekDays.WEDNESDAY);
            Console.WriteLine("TODAY IS " + WeekDays.THURSDAY);
            Console.WriteLine("TODAY IS " + WeekDays.FRIDAY);
        }
    }
}
