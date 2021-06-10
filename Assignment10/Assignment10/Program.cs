using System;
using System.IO;

namespace Assignment10
{
    /*Assignment 10
    Problem 1
    No the code will not run successfully*/

    ////PROBLEM 2 
    //THE CODE WILL RUN SUCCESSFULLY beacuse of the protected internal access modifier
   class Student
    {
        protected int age  = 22; 
    }
    
    class St : Student
    {
        public void tu()
        {
            int g = base.age;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
               Student g = new Student();

               Console.WriteLine(age);

            /*string make = "HELLO";
             string path = @"E:\";
             File.WriteAllText(path, make);
             string g = File.ReadAllText(path);
             Console.WriteLine(g);
            */

          
            

        }

       
    }
}
