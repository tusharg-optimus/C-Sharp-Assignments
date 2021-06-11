using System;

namespace Assignment6
{
    class Program
    {
        //Encapsulation Assignment 6
        //By using get and set Property
        // Otherwise for this we can use constructors also by making them public 
        class Railway
        {
            public int Train { get; set; }
            public int Pnr { set; get; }
            public string Name { set; get; }
            public int Far { set; get; }
            public void Ticket()
            {
                Console.WriteLine("TICKET  DETAILS");
                Console.WriteLine("TRAIN NUMBER : " + Train);
                Console.WriteLine("PNR NUMBER : " + Pnr);
                Console.WriteLine(" PASSENGER NAME : " +Name);
                Console.WriteLine(" TOTAL FARE : " + Far);

            }
            static void Main(string[] args)
            {
                Random r = new Random();

                Railway passenger1 = new Railway();
                passenger1.Train = r.Next(0,10000);
                passenger1.Pnr = r.Next();
                passenger1.Name = "TUSHAR GUPTA";
                passenger1.Far = 850;
                passenger1.Ticket();

                Railway passenger2 = new Railway();
                passenger2.Train = r.Next(0,10000);
                passenger2.Pnr = r.Next();
                passenger2.Name = "RAHUL GUPTA";
                passenger2.Far = 889;
                passenger2.Ticket();

                Railway passenger3 = new Railway();
                passenger3.Train = r.Next(0,10000);
                passenger3.Pnr = r.Next();
                passenger3.Name = "SHREYA GOYAL";
                passenger3.Far = 2000;
                passenger3.Ticket();

                Railway passenger4 = new Railway();
                passenger4.Train = r.Next(0,10000);
                passenger4.Pnr = r.Next();
                passenger4.Name = "MEHUL GOYAL";
                passenger4.Far = 900;
                passenger4.Ticket();

            }
        }
    }
}
