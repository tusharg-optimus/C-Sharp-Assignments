using System;

namespace Assignment5
{
    class Program
    {
        static String GetArray()
        {
            string[] names = { "TUSHAR", "RAHUL", "JAI" };

            foreach (string i in names)
            {
                Console.WriteLine(i);
            }

            return Convert.ToString(names);
        }

        static void Main(string[] args)
        {
            GetArray();
        }
    }
}
