using System;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER LANGUAGE");
            String lang = Console.ReadLine();

            if (lang == "VB")
            {
                Console.WriteLine("VB .NET: OOP, multithreading and more!");
            }
            else if (lang == "C#")
            {
                Console.WriteLine("Good choice, C# is a fine language");
            }
            else
            {
                Console.WriteLine("Well... good luck with that");
            }
        }
    }
}
