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
            private int trainNo;
            private int pnrNo;
            private String passengerName;
            private int fare;

            /* public Railway(int t, int p, String pass, int f)
             {
                 train_no = t;
                 pnr_no = p;
                 passenger_name = pass;
                 fare = f;
             }*/

            public int Train
            {
                get { return trainNo; }
                set { trainNo = value; }
            }

            public int Pnr
            {
                get { return pnrNo; }
                set { pnrNo = value; }
            }

            public string Name
            {
                get { return passengerName; }
                set { passengerName = value; }
            }

            public int Far
            {
                get { return fare; }
                set { fare = value; }
            }
            public void Ticket()
            {
                Console.WriteLine("TICKET  DETAILS");
                Console.WriteLine("TRAIN NUMBER : " + trainNo);
                Console.WriteLine("PNR NUMBER : " + pnrNo);
                Console.WriteLine(" PASSENGER NAME : " + passengerName);
                Console.WriteLine(" TOTAL FARE : " + fare);

            }
            static void Main(string[] args)
            {
                Railway passenger1 = new Railway();
                passenger1.Train = 236;
                passenger1.Pnr = 8963547;
                passenger1.Name = "TUSHAR GUPTA";
                passenger1.Far = 850;
                passenger1.Ticket();

                Railway passenger2 = new Railway();
                passenger2.Train = 456;
                passenger2.Pnr = 8968947;
                passenger2.Name = "RAHUL GUPTA";
                passenger2.Far = 889;
                passenger2.Ticket();

                Railway passenger3 = new Railway();
                passenger3.Train = 365;
                passenger3.Pnr = 7968947;
                passenger3.Name = "SHREYA GOYAL";
                passenger3.Far = 2000;
                passenger3.Ticket();

                Railway passenger4 = new Railway();
                passenger4.Train = 89163;
                passenger4.Pnr = 1238947;
                passenger4.Name = "MEHUL GOYAL";
                passenger4.Far = 900;
                passenger4.Ticket();

            }
        }
    }
}
