using System;

namespace Assignment11
{
    //ASSIGNMENT11

    abstract class Student
    {
        public int rollNumber;
        public string studentName;
        public int studentAge;
        public float studentAttendance;

        public Student(int roll,string name,int age1, float attendance)
        {
            rollNumber = roll;
            studentName = name;
            studentAge = age1;
            studentAttendance = attendance;
        }

        public abstract void StudentDetails();


        public abstract void Attendance();


    }

    class SchoolStudents : Student
    {
        public int admissionId;
        public SchoolStudents(int adm,int roll,string name,int age1,float attendance) :base(roll,name,age1,attendance)
        {
            admissionId = adm;
        }

        public override void StudentDetails()
        {
           
            Console.WriteLine("SCHOOL STUDENT");
            Console.WriteLine("STUDENT ADMISSION ID : "+admissionId);
            Console.WriteLine("STUDENT ROLL NUMBER : "+rollNumber);
            Console.WriteLine("STUDENT NAME : "+studentName);
            Console.WriteLine("STUDENT AGE : "+studentAge);
            Console.WriteLine("STUDENT ATTENDANCE : "+studentAttendance);
        }

        public override void Attendance()
        {
            if(studentAttendance<50)
            {
                Console.WriteLine("CALL THE PARENTS IMMEDIATELY");
            }
            else
            {
                Console.WriteLine("DO NOT CALL THE PARENTS");
            }
        }


    }

    class CollegeStudent : Student
    {
        public int erollNumber;
        public CollegeStudent(int enroll,int roll,string name,int age1,float attendance) :base(roll,name,age1,attendance)
        {
            erollNumber = enroll;
        }
        public override void StudentDetails()
        {
            Console.WriteLine("COLLEGE STUDENT DETAILS");
            Console.WriteLine("STUDENT ENROLLMENT NUMBER : " + erollNumber);
            Console.WriteLine("STUDENT NAME : " + studentName);
            Console.WriteLine("STUDENT ROLL NUMBER : " + rollNumber);
            Console.WriteLine("STUDENT AGE : " + studentAge);
            Console.WriteLine("STUDENT ATTENDANCE : " + studentAttendance);
        }

        public override void Attendance()
        {
            if (studentAttendance < 60)
            {
                Console.WriteLine("RUSTICATED");
            }
            else
            {
                Console.WriteLine("DO NOT RUSTICATE");
            }
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            SchoolStudents s1 = new SchoolStudents(r.Next(0, 10000), 45, "TUSHAR", 15, 89);
            s1.StudentDetails();
            s1.Attendance();
            Console.WriteLine();
            SchoolStudents s2 = new SchoolStudents(r.Next(0, 10000), 35, "RAHUL", 13, 35);
            s2.StudentDetails();
            s2.Attendance();
            Console.WriteLine();

            CollegeStudent c1 = new CollegeStudent(r.Next(), 85, "SUPRIYA", 20, 65);
            c1.StudentDetails();
            c1.Attendance();
            Console.WriteLine();
            CollegeStudent c2 = new CollegeStudent(r.Next(), 25, "MANAV", 19, 50);
            c1.StudentDetails();
            c1.Attendance();

        }
    }

    
}
