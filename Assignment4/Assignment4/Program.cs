using System;

namespace Assignment4
{
    class Program
    {
        //Assignment 4
        static void Main(string[] args)
        {
            String hello = "Hello tushar gupta";

            String hello1 = "how are you";

            String g = string.Concat(hello, hello1);

            Console.WriteLine(g);

            Console.WriteLine("LENGTH of the given string is " + hello.Length);

            Console.WriteLine("UPPER CASE of the given string is " + hello.ToUpper());

            Console.WriteLine("LOWER CASE of the given string is " + hello.ToLower());

            Console.WriteLine("Charcter at index 9 of the given string is " + hello[9]);

            Console.WriteLine("INDEX of the given string is " + hello.IndexOf("tushar"));

            Console.WriteLine("INDEX of the given string is " + hello.Substring(6));

            Console.WriteLine($"INTERPOLATION of the given string is \n {hello} {hello1}");
        }
    }
}
