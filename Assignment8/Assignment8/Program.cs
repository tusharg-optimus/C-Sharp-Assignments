using System;

namespace Assignment8
{
    class Program
    {
        //Assignment 8
        
        static void Main(string[] args)
        {  

            Random r = new Random();

            Student s1 = new Student(r.Next(),89506,"TUSHAR GUPTA",16);
            s1.StudentDetails();
            Console.WriteLine();
            Student s2 = new Student(r.Next(),875231,"RAHUL GUPTA",10);
            s2.StudentDetails();

            Console.WriteLine();
            Student s3 = new Student(r.Next(), 875231, "RAHUL GUPTA", 10);
            s3.Print();

            //Student s4 = new Student1();
           
        }
    }

    class Student1
    {
       

        public virtual void Print()
        {
            Console.WriteLine("SPECIFIC DETAILS OF STUDENTS " );
         

        }
    }

    class Student : Student1
    {
        enum Student3
        {

            studentId1 = 5647,
            age1 = 12,
            Muskaan,
        }

        int g =(int) Student3.studentId1;
        Student3 a = Student3.Muskaan;
        int b = (int) Student3.age1;


        private int studentId;
        private String studentName;
        private int enrollNumber;
        private int studentAge;

        public Student(int enroll, int id, String name, int age)
        {
            enrollNumber = enroll;
            studentId = id;
            studentName = name;
            studentAge = age;
        }
        public int Enrol
        {
            get { return enrollNumber; }
            set { enrollNumber = value; }
        }
        public int Id
        {
            get { return studentId; }
            set { studentId = value; }
        }

        public string Name
        {
            get { return studentName; }
            set { studentName = value; }
        }

        public int ag
        {
            get { return studentAge; }
            set { studentAge = value; }
        }

        public void StudentDetails()
        {
            Console.WriteLine("STUDENT DETAILS :");
            Console.WriteLine("STUDENT ENROLLMENT NUMBER : " + Enrol);
            Console.WriteLine("STUDENT ID : " + Id);
            Console.WriteLine("STUDENT NAME : " + Name);
            Console.WriteLine("STUDENT AGE : " + ag);
        }

        public override void Print()
        {
            
            Console.WriteLine("SPECIFIC DETAILS OF STUDENTS ");
            Console.WriteLine();
            Console.WriteLine("STUDENT ID : "+g );
            Console.WriteLine("STUDENT NAME : "+a );
            Console.WriteLine("STUDENT AGE : " + b);

        }
    }
}
