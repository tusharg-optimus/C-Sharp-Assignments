using System;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Assignment2

            Console.WriteLine("ENTER LANGUAGE");
            String lang1 = Console.ReadLine();

            switch (lang1)
            {
                case "VB":
                    Console.WriteLine("VB .NET: OOP, multithreading and more!");
                    break;
                case "C#":
                    Console.WriteLine("Good choice, C# is a fine language");
                    break;
                default:
                    Console.WriteLine("Well... good luck with that");
                    break;
            }
        }
    }
}
